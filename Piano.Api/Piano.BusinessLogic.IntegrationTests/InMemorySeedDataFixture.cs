using Microsoft.EntityFrameworkCore;
using Piano.Database;
using System;
using System.Threading.Tasks;
using Piano.Entities;
using Piano.Entities.User;

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

        public async Task<User?> GetUser(string username, string password)
        {
            return default;
        }

        public void AddUser(string email, string username, Guid userId, string password)
        {
            //_pianoContext.Users.Add(new User { Email = email, Username = username, Id = userId, Password = password });
            _pianoContext.SaveChanges();
        }

        public void Dispose()
        {
            _pianoContext.Dispose();
        }
    }
}
