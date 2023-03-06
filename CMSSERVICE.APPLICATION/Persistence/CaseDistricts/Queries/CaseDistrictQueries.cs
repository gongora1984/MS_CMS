using CMSSERVICE.DOMAIN.Contracts.Responses.CaseDistricts;

namespace CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Queries;

public record GetCaseDistrictByIdQuery(int id) : IQuery<CaseDistrictResponse>;

public record GetAllCaseDistrictQuery : IQuery<AllCaseDistrictResponse>;

public record GetAllCaseDistrictInStateQuery(int stateId) : IQuery<AllCaseDistrictResponse>;

public record GetAllCaseDistrictByNameQuery(string name) : IQuery<AllCaseDistrictResponse>;

public record GetCaseDistrictByNameInStateQuery(string name, int stateId) : IQuery<CaseDistrictResponse>;