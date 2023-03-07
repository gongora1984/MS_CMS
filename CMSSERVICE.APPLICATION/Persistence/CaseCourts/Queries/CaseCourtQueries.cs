using CMSSERVICE.DOMAIN.Contracts.Responses.Common;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCourts.Queries;

public record GetAllCaseCourtQuery : IQuery<AllCaseCourtResponse>;
public record GetCaseCourtByIdQuery(int courtId) : IQuery<CaseCourtResponse>;
public record GetAllCaseCourtByCountyQuery(int countyId) : IQuery<AllCaseCourtResponse>;
public record GetAllCaseCourtByDistrictQuery(int districtId) : IQuery<AllCaseCourtResponse>;
public record GetAllCaseCourtByNameQuery(string courtName) : IQuery<AllCaseCourtResponse>;
public record GetAllCaseCourtByTypeQuery(int courtTypeLid) : IQuery<AllCaseCourtResponse>;
