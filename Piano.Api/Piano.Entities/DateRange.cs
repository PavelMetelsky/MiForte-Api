namespace Piano.Entities;

public struct Range<T>
{
    public Range(T start, T end)
    {
        End = end;
        Start = start;
    }

    public T Start { get; set; }
    public T End { get; set; }
}

public static class RangeExtensions
{
    public static bool Contains<T>(this Range<T> range, T value) where T : IComparable<T>
    {
        return range.Start.CompareTo(value) < 0 && range.End.CompareTo(value) > 0;
    }
}