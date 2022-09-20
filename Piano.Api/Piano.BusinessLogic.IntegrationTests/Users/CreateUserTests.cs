using System;
using System.Threading;
using System.Threading.Tasks;
using Piano.BusinessLogic.Commands.Users.CreateUser;
using Piano.Entities;
using Xunit;

namespace Piano.BusinessLogic.IntegrationTests;

public class CreateUserTests : IClassFixture<InMemorySeedDataFixture>
{
    private readonly InMemorySeedDataFixture _fixture;

    public CreateUserTests(InMemorySeedDataFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async void CreateUserCommand_CreatesUser()
    {
        var createUserCommand = GenerateCreateUserCommand();
        var (user, userId) = await SendCreateUserCommand(createUserCommand);
        Assert.True(UserMatchesRequest(user, createUserCommand, userId));
    }

    private async Task<(User, Guid)> SendCreateUserCommand(CreateUserCommand createUserCommand)
    {
        var handler = new CreateUserHandler(_fixture._pianoContext);
        var result = await handler.Handle(createUserCommand, CancellationToken.None);
        var user = await _fixture.GetUser(createUserCommand.Username, createUserCommand.Password);
        Assert.NotNull(result.Flag);
        Assert.NotNull(user);
        return (user!, result.Flag!.Value);
    }

    private CreateUserCommand GenerateCreateUserCommand()
    {
        return new CreateUserCommand()
        { Role = 1,
          City = "Brest",
          Country = "Belarus",
          Email = "email",
          Password = "pswd",
          Username = "username",
          Telephone = "tlph" };
    }

    private bool UserMatchesRequest(User user, CreateUserCommand command, Guid userId)
    {
        return user.UserId == userId &&
               user.Username == command.Username &&
               user.Password == command.Password &&
               user.Email == command.Email &&
               user.Role == command.Role &&
               user.Country == command.Country &&
               user.City == command.City &&
               user.Telephone == command.Telephone;
    }
}