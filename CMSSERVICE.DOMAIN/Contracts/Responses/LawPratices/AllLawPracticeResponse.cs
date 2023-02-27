namespace CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;

public class AllLawPracticeResponse
{
    public AllLawPracticeResponse()
    {
    }

    public AllLawPracticeResponse(IEnumerable<LawPracticeResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<LawPracticeResponse>? Items { get; set; }
}
