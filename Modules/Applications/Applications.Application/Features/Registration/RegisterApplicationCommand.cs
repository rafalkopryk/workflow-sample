using Applications.Application.Features.RegisterApplication.Dto;
using Common.Application.Cqrs.Results;

namespace Applications.Application.Features.RegisterApplication;

public record RegisterApplicationCommand
{
    public string ApplicationId { get; init; } 
    public RegisterApplicationCommandCreditApplicationDto CreditApplication { get; init; }
    public string ProcessCode { get; init; }
}

public union RegisterApplicationCommandResponse(OK, ResourceExists);
