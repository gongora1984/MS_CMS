namespace CMSSERVICE.DOMAIN.Contracts.Responses.Common;

public class AllCaseJudgeResponse
{
    public AllCaseJudgeResponse()
    {
    }

    public AllCaseJudgeResponse(IEnumerable<CaseJudgeResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<CaseJudgeResponse>? Items { get; set; }
}
