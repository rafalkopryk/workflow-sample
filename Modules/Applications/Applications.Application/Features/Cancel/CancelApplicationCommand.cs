using Common.Application.Cqrs.Results;

namespace Applications.Application.Features.CancelApplication;

public record CancelApplicationCommand(string ApplicationId);

public union CancelApplicationCommandResponse(OK, ResourceNotFound);
