using Microsoft.EntityFrameworkCore;
using Piano.Database;
using System;

namespace Piano.BusinessLogic.IntegrationTests
{
    public class InMemorySeedDataFixture : IDisposable
    {
        public PianoContext _pianoContext { get; private set; }

        public InMemorySeedDataFixture()
        {
            var options = new DbContextOptionsBuilder<PianoContext>()
                .UseInMemoryDatabase(databaseName: "Test")
                .Options;

            _pianoContext = new PianoContext(options);
        }

        public void AddUser(string email, string username, Guid userId, string password)
        {
            _pianoContext.Users.Add(new Entities.User { Email = email, Username = username, UserId = userId, Password = password });
            _pianoContext.SaveChanges();
        }

        public void Dispose()
        {
            _pianoContext.Dispose();
        }
    }
}
