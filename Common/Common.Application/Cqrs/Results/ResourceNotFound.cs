namespace Common.Application.Cqrs.Results;

public sealed record ResourceNotFound
{
    public static readonly ResourceNotFound Result = new();
}
