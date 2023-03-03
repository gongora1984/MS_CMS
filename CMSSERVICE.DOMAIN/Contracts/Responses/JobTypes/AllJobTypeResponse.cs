namespace CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

public class AllJobTypeResponse
{
    public AllJobTypeResponse()
    {
    }

    public AllJobTypeResponse(IEnumerable<JobTypeResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<JobTypeResponse>? Items { get; set; }
}
