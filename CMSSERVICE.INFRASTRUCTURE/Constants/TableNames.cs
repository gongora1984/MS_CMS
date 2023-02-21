using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.INFRASTRUCTURE.Constants;

internal static class TableNames
{
    internal const string BkrCaseSummary = nameof(BkrcaseSummary);

    internal const string BkrConditionalOrder = nameof(BkrconditionalOrder);

    internal const string BkrDistrict = nameof(Bkrdistrict);

    internal const string BkrFinancial = nameof(Bkrfinancial);

    internal const string BkrFinInstallment = nameof(BkrfinInstallment);

    internal const string BkrFinInterestRate = nameof(BkrfinInterestRate);

    internal const string BkrFinMissedPayment = nameof(BkrfinMissedPayment);

    internal const string BkrFinOtherCost = nameof(BkrfinOtherCost);

    internal const string BkrJournal = nameof(Bkrjournal);

    internal const string BkrLoanModification = nameof(BkrloanModification);

    internal const string BkrMfr = nameof(Bkrmfr);

    internal const string BkrPaymentChange = nameof(BkrpaymentChange);

    internal const string BkrProperty = nameof(Bkrproperty);

    internal const string CaseAuto = nameof(CaseAuto);

    internal const string CaseAutoBuyerInfo = nameof(CaseAutoBuyerInfo);

    internal const string CaseBkr = nameof(CaseBkr);

    internal const string CaseCol = nameof(CaseCol);

    internal const string CaseColDefendantBankInfo = nameof(CaseColdefendantBankInfo);

    internal const string CaseColDefendantCardInfo = nameof(CaseColdefendantCardInfo);

    internal const string CaseColTransaction = nameof(CaseColtransaction);

    internal const string CaseComment = nameof(CaseComment);

    internal const string CaseCommentWhiteboard = nameof(CaseCommentWhiteboard);

    internal const string CaseCounty = nameof(CaseCounty);

    internal const string CaseCourt = nameof(CaseCourt);

    internal const string CaseDistrict = nameof(CaseDistrict);

    internal const string CaseEviction = nameof(CaseEviction);

    internal const string CaseEvictionJournal = nameof(CaseEvictionJournal);

    internal const string CaseFcl = nameof(CaseFcl);

    internal const string CaseJobDefendant = nameof(CaseJobDefendant);

    internal const string CaseJobDefendantAdditionalAddress = nameof(CaseJobDefendantAdditionalAddress);

    internal const string CaseJobDefendantAtty = nameof(CaseJobDefendantAtty);

    internal const string CaseJobDefendantByVirtueOf = nameof(CaseJobDefendantByVirtueOf);

    internal const string CaseJobDefendantSearchHistory = nameof(CaseJobDefendantSearchHistory);

    internal const string CaseJobDefendantService = nameof(CaseJobDefendantService);

    internal const string CaseJudge = nameof(CaseJudge);

    internal const string CaseMaster = nameof(CaseMaster);

    internal const string CaseReplevin = nameof(CaseReplevin);

    internal const string CaseSale = nameof(CaseSale);

    internal const string CaseSalePubCost = nameof(CaseSalePubCost);

    internal const string CaseSalePubDate = nameof(CaseSalePubDate);

    internal const string CaseState = nameof(CaseState);

    internal const string CaseSubpoena = nameof(CaseSubpoena);

    internal const string CaseSubpoenaOrderInfo = nameof(CaseSubpoenaOrderInfo);

    internal const string CaseTitle = nameof(CaseTitle);

    internal const string CaseTitleAssignment = nameof(CaseTitleAssignment);

    internal const string CaseTitleAssignmentItem = nameof(CaseTitleAssignmentItem);

    internal const string CaseTitleDlinqTax = nameof(CaseTitleDlinqTax);

    internal const string CaseTitleFileAssign = nameof(CaseTitleFileAssign);

    internal const string CaseTitleIrstaxLien = nameof(CaseTitleIrstaxLien);

    internal const string CaseTitleJudgmentLien = nameof(CaseTitleJudgmentLien);

    internal const string CaseTitleModParagraph = nameof(CaseTitleModParagraph);

    internal const string CaseTitleMortgTaxLien = nameof(CaseTitleMortgTaxLien);

    internal const string CaseTitleMortgWithAssignment = nameof(CaseTitleMortgWithAssignment);

    internal const string CaseTitleReRecorded = nameof(CaseTitleReRecorded);

    internal const string CaseTitleSpecialCount = nameof(CaseTitleSpecialCount);

    internal const string CaseTitleSpecialCountTemplate = nameof(CaseTitleSpecialCountTemplate);

    internal const string CaseTitleUnderWriter = nameof(CaseTitleUnderWriter);

    internal const string CaseWrit = nameof(CaseWrit);

    internal const string CaseWritFinancial = nameof(CaseWritFinancial);

    internal const string CientJobLog = nameof(CientJobLog);

    internal const string Client = nameof(Client);

    internal const string ClientAssignment = nameof(ClientAssignment);

    internal const string ClientAssignmentCheckListCr = nameof(ClientAssignmentCheckListCr);

    internal const string ClientAssignmentCheckListVr = nameof(ClientAssignmentCheckListVr);

    internal const string ClientAssignmentHold = nameof(ClientAssignmentHold);

    internal const string ClientAssignmentJournal = nameof(ClientAssignmentJournal);

    internal const string ClientAssignmentReProHistory = nameof(ClientAssignmentReProHistory);

    internal const string ClientAssignmentScheduled = nameof(ClientAssignmentScheduled);

    internal const string ClientAssignmentTask = nameof(ClientAssignmentTask);

    internal const string ClientAssignmentTaskCheckList = nameof(ClientAssignmentTaskCheckList);

    internal const string ClientAssignmentTaskCheckListCr = nameof(ClientAssignmentTaskCheckListCr);

    internal const string ClientAssignmentTaskCheckListVr = nameof(ClientAssignmentTaskCheckListVr);

    internal const string ClientAssignmentTaskRecurrence = nameof(ClientAssignmentTaskRecurrence);

    internal const string ClientAssignmentTaskRule = nameof(ClientAssignmentTaskRule);

    internal const string ClientAssignmentTaskScheduled = nameof(ClientAssignmentTaskScheduled);

    internal const string ClientDepartment = nameof(ClientDepartment);

    internal const string ClientFacility = nameof(ClientFacility);

    internal const string ClientJob = nameof(ClientJob);

    internal const string ClientJobActivity = nameof(ClientJobActivity);

    internal const string ClientJobLegal = nameof(ClientJobLegal);

    internal const string ClientJobListing = nameof(ClientJobListing);

    internal const string ClientLawPractice = nameof(ClientLawPractice);

    internal const string ClientLawPracticeJobType = nameof(ClientLawPracticeJobType);

    internal const string ClientStateLocation = nameof(ClientStateLocation);

    internal const string DefendantAddress = nameof(DefendantAddress);

    internal const string DocumentMailOutHistory = nameof(DocumentMailOutHistory);

    internal const string DocumentNote = nameof(DocumentNote);

    internal const string DocumentRepository = nameof(DocumentRepository);

    internal const string DocumentType = nameof(DocumentType);

    internal const string Garnishee = nameof(Garnishee);

    internal const string JobType = nameof(JobType);

    internal const string LawPractice = nameof(LawPractice);

    internal const string LawPracticeJob = nameof(LawPracticeJob);

    internal const string LawPracticeUser = nameof(LawPracticeUser);

    internal const string ListItem = nameof(ListItem);

    internal const string LocalCounsel = nameof(LocalCounsel);

    internal const string LoginDetail = nameof(LoginDetail);

    internal const string LoginDetailJobListing = nameof(LoginDetailJobListing);

    internal const string LoginDetailsAccessRole = nameof(LoginDetailsAccessRole);

    internal const string LogonDetailsAssignmentPool = nameof(LogonDetailsAssignmentPool);

    internal const string LogonDetailsAssignmentPoolTask = nameof(LogonDetailsAssignmentPoolTask);

    internal const string LogonDetailSubordinate = nameof(LogonDetailSubordinate);

    internal const string MergeDocument = nameof(MergeDocument);

    internal const string MergeDocumentCustom = nameof(MergeDocumentCustom);

    internal const string MergeDocumentToken = nameof(MergeDocumentToken);

    internal const string MergeField = nameof(MergeField);

    internal const string Report = nameof(Report);

    internal const string ReportJob = nameof(ReportJob);

    internal const string ReportJobParameter = nameof(ReportJobParameter);

    internal const string ReportJobSchedule = nameof(ReportJobSchedule);

    internal const string ReportMapping = nameof(ReportMapping);

    internal const string ReportParameter = nameof(ReportParameter);

    internal const string ThirdPartyConvertion = nameof(ThirdPartyConvertion);

    internal const string ZipCodeDictionary = nameof(ZipCodeDictionary);
}
