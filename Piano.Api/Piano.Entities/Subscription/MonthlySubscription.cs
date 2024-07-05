namespace Piano.Entities.Subscription;

public class MonthlySubscription : Subscription
{
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public int NumberOfSessions { get; set; }
    public override Range<DateOnly> SubscriptionPeriod => new(start: StartDate, end: EndDate);

    public override bool CanAddSession(Session.Session session)
    {
        return Status == SubscriptionStatus.Active &&
               Sessions.Count < NumberOfSessions &&
               SubscriptionPeriod.Contains(DateOnly.FromDateTime(session.PlannedDate));
    }
}