using Common.Application.Cqrs.Results;

namespace Applications.Application.Features.SignContract;

public record SignContractCommand(string ApplicationId);

public union SignContractCommandResponse(OK, ResourceNotFound);
