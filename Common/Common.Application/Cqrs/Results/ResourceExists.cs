namespace Common.Application.Cqrs.Results;

public sealed record ResourceExists
{
    public static readonly ResourceExists Result = new();
}
