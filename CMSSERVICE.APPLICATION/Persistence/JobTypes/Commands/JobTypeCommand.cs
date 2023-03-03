using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

namespace CMSSERVICE.APPLICATION.Persistence.JobTypes.Commands;

public record RegisterJobTypeCommand(JobTypeRequest jt) : ICommand<JobTypeResponse>;
