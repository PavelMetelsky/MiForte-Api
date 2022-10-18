using Microsoft.EntityFrameworkCore;
using Piano.Database;
using System;
using Piano.Entities.Subscriptions;

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
            return await _pianoContext.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        public void AddUser(string email, string username, Guid userId, string password)
        {
            _pianoContext.Users.Add(new Entities.User { Email = email, Username = username, UserId = userId, Password = password });
            _pianoContext.SaveChanges();
        }

        public void AddSubscriptionCard(SubscriptionCard card)
        {
            _pianoContext.Add(card);
            _pianoContext.SaveChanges();
        }

        public void DeleteSubscriptionCard(SubscriptionCard card)
        {
            _pianoContext.Remove(card);
            _pianoContext.SaveChanges();
        }

        public SubscriptionCard? GetSubscriptionCard(Guid id)
        {
            return _pianoContext.SubscriptionCards.Find(id);
        }

        public void Dispose()
        {
            _pianoContext.Dispose();
        }
    }
}
