using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.JobTypes;

public class JobTypeMapperProfile : Profile
{
    public JobTypeMapperProfile()
    {
        CreateMap<JobType, JobTypeResponse>().ReverseMap();

        CreateMap<JobType, JobTypeRequest>().ReverseMap();

        CreateMap<JobType, AllJobTypeResponse>().ReverseMap();

        CreateMap<List<JobType>, AllJobTypeResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new JobTypeResponse()
                    {
                        Id = t.Id,
                        JobName = t.JobName,
                        JobDepartmentId = t.JobDepartmentId,
                        JobIconLocation = t.JobIconLocation,
                        JobState = t.JobState,
                        JobDataTable = t.JobDataTable,
                        JobPkfield = t.JobPkfield,
                        JobClientRefField = t.JobClientRefField,
                        JobSysCode = t.JobSysCode,
                        IsMasterJob = t.IsMasterJob,
                        JobTemplateLocation = t.JobTemplateLocation,
                        IsClientStart = t.IsClientStart,
                        IsLawPracticeStart = t.IsLawPracticeStart,
                        IsLocalCounselStart = t.IsLocalCounselStart,
                        CanHaveMultiple = t.CanHaveMultiple,
                        CanCreateNewCase = t.CanCreateNewCase
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
