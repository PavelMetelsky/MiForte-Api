using Piano.BusinessLogic.Commands.SubscriptionCards.CreateSubscriptionCard;

namespace Piano.BusinessLogic.Models.Cards;

public static class Converter
{
    public static Piano.Entities.Subscriptions.Session ToEntitiesSession(this Session s)
    {
        return new Entities.Subscriptions.Session
        { 
        Id = s.Id,
        SessionDate = s.SessionDate,
        State = (Entities.Subscriptions.Session.SessionState) s.State,
        Duration = s.Duration,
        OwnerId = s.OwnerId 
        };
    }

    public static Session ToModelSession(this Entities.Subscriptions.Session session)
    {
        return new Session
        { 
            Id = session.Id,
            SessionDate = session.SessionDate,
            State = (int) session.State,
            Duration = session.Duration,
            OwnerId = session.OwnerId 
        };
    }
    public static Entities.Subscriptions.SubscriptionCard ToEntitiesSubscriptionCard(this SubscriptionCard card)
    {
        return new Entities.Subscriptions.SubscriptionCard
        { 
            Id = card.Id,
            Sessions = card.Sessions.ToEntitiesSessionList(),
            BuyingDate = card.BuyingDate,
            ActiveMonth = card.ActiveMonth,
            OwnerId = card.OwnerId,
            MentorId = card.MentorId, 
        };
    }

    public static SubscriptionCard ToModelSubscriptionCard(this Entities.Subscriptions.SubscriptionCard card)
    {
        return new SubscriptionCard
        { 
            Id = card.Id,
            Sessions = card.Sessions.ToModelSessionList(),
            BuyingDate = card.BuyingDate,
            ActiveMonth = card.ActiveMonth,
            OwnerId = card.OwnerId,
            MentorId = card.MentorId 
        };
    }
    public static List<Entities.Subscriptions.Session> ToEntitiesSessionList(
        this IEnumerable<Session> sessions)
    {
        return sessions.Select(s => s.ToEntitiesSession()).ToList();
    }

    public static List<Session> ToModelSessionList(
        this IEnumerable<Entities.Subscriptions.Session> sessions)
    {
        return sessions.Select(ToModelSession).ToList();
    }

    public static Session ToModelSession(this RequestSession session)
    {
        return new Session
        {
            Id = Guid.NewGuid(),
            SessionDate = session.SessionDate,
            Duration = session.Duration,
            OwnerId = session.OwnerId,
            State = session.State,
        };
    }

    public static List<Session> ToModelSessionList(this IEnumerable<RequestSession> l)
    {
        return l.Select(s => s.ToModelSession()).ToList();
    }

    public static List<Entities.Subscriptions.Session> ToEntitiesSessionList(this IEnumerable<RequestSession> l, Guid cardId)
    {
        return l.Select(session => new Entities.Subscriptions.Session
        { Id = Guid.NewGuid(),
          SessionDate = session.SessionDate,
          Duration = session.Duration,
          OwnerId = session.OwnerId,
          State = (Entities.Subscriptions.Session.SessionState)session.State,
          SubscriptionCardId = cardId
        }).ToList();
    }
}