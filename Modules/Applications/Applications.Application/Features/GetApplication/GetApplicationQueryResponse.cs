using Applications.Application.Features.GetApplication.Dto;
using Common.Application.Cqrs.Results;

namespace Applications.Application.Features.GetApplication;

public union GetApplicationQueryResponse(GetApplicationQueryCreditApplicationDto, ResourceNotFound);
