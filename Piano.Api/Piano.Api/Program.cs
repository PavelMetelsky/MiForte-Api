using Microsoft.EntityFrameworkCore;
using Piano.Database;
using MediatR;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Piano.BusinessLogic.Converters;

var MyAllowSpecificOrigins = "MyPolicy";

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost:4200", "https://miforte.com")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    options.SerializerOptions.Converters.Add(new TimeSpanJsonConverter());
});

builder.Services.AddSwaggerGen(options =>
    {
        options.MapType<DateOnly>(() => new OpenApiSchema
        { 
          Type = "string",
          Format = "date",
          Example = new OpenApiString("2022-01-01") 
        });
        options.MapType<TimeSpan>(() => new OpenApiSchema
        {
            Type = "string",
            Example = new OpenApiString("00:00"),
         });
    }
);

// Add services to the container.
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

{
    var services = builder.Services;
    
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddDbContext<PianoContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
    services.AddMediatR(typeof(Piano.BusinessLogic.Models.User));
}

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

//app.UseAuthentication();
//app.UseAuthorization();

app.MapControllers();

//app.Run(url);
app.Run();