namespace Common.Application.Cqrs.Results;

public sealed record OK
{
    public static readonly OK Result = new();
}
