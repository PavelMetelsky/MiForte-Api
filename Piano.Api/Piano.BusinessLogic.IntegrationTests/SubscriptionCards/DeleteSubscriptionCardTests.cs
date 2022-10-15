using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Piano.BusinessLogic.Models;
using Piano.Entities.Subscriptions;
using Xunit;

namespace Piano.BusinessLogic.IntegrationTests.SubscriptionCards
{
    public class DeleteSubscriptionCardTests : IClassFixture<InMemorySeedDataFixture>
    {
        private readonly InMemorySeedDataFixture _fixture;

        public DeleteSubscriptionCardTests(InMemorySeedDataFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task DeleteSubscription_DeletesSubscription()
        {
            var user = new User
            {
                City = string.Empty,
                Country = string.Empty,
                Email = string.Empty,
                Password = string.Empty,
                Role = 0,
                SocialLinks = new List<string>(),
                Telephone = string.Empty,
                UserId = Guid.NewGuid(),
                Username = "User!"
             };
            var session = new Session
            { 
              Duration = new TimeSpan(1, 30, 0),
              Id = Guid.NewGuid(),
              SessionDate = new DateOnly(2022, 12, 15),
              OwnerId = user.UserId,
              State = 0 
            };
            var list = new List<Session>();
            list.Add(session);
            var card = new SubscriptionCard
            { 
              ActiveMonth = new DateOnly(2022, 12, 2),
              BuyingDate = new DateOnly(2022, 12, 15),
              Id = new Guid(),
              MentorId = user.UserId,
              OwnerId = user.UserId,
              Sessions = list 
            };
            _fixture.AddSubscriptionCard(card);
            _fixture.DeleteSubscriptionCard(card);
            Assert.Null(_fixture.GetSubscriptionCard(card.Id));
        }
    }
}