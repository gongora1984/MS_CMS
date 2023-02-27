using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppPermission",
                columns: table => new
                {
                    AppPermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKAppPermission", x => x.AppPermissionId);
                });

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    AppRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKAppRole", x => x.AppRoleId);
                });

            migrationBuilder.CreateTable(
                name: "BkrDistrict",
                columns: table => new
                {
                    BkrDistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DistrictName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ClientBKCourtJurisdiction = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrDistrict", x => x.BkrDistrictId);
                });

            migrationBuilder.CreateTable(
                name: "CaseJobDefendantAtty",
                columns: table => new
                {
                    CaseJobDefendantAttyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttorneyName = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    LawPracticeName = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    AttyBarNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BusPhoneNum = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    EmailAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LoginDetailsID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJobDefendantAtty", x => x.CaseJobDefendantAttyId);
                });

            migrationBuilder.CreateTable(
                name: "CaseState",
                columns: table => new
                {
                    CaseStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateAbbrev = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    StateName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseState", x => x.CaseStateId);
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleUnderWriter",
                columns: table => new
                {
                    CaseTitleUnderWriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnderWriterName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    UnderWriterSendVIA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    UnderWriterAttentionTo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UnderWriterAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    UnderWriterAddress2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UnderWriterCity = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    UnderWriterState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    UnderWriterZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SendEmail = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SendMail = table.Column<bool>(type: "bit", nullable: false),
                    SendUPS = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleUnderWriter", x => x.CaseTitleUnderWriterId);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ClientAddress1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ClientAddress2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ClientCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ClientState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ClientZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ClientBillAddress1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ClientBillAddress2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ClientBillCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ClientBillState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ClientBillZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ClientMainContact = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ClientMailAlertLogEmail = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ClientLogoLocation = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ProvestClientCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientFax = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ClientPhone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    useNativeTasksOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsReverseClient = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GlobeClientCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClient", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTaskCheckListCr",
                columns: table => new
                {
                    ClientAssignmentTaskCheckListCrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SelectValueSql = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IsSql = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsTextBox = table.Column<bool>(type: "bit", nullable: false),
                    IsDropDown = table.Column<bool>(type: "bit", nullable: false),
                    DropDownSql = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    CompareType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('==')"),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTaskCheckListCr", x => x.ClientAssignmentTaskCheckListCrId);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    JobTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    JobDepartmentId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    JobIconLocation = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    JobTemplateId = table.Column<int>(type: "int", nullable: false),
                    JobState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    JobDataTable = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    JobPKField = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    JobClientRefField = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('PKID')"),
                    JobSysCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('sysfcl')"),
                    isMasterJob = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    JobTemplateLocation = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false, defaultValueSql: "(' ')"),
                    isCLientStart = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isLawPracticeStart = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isLocalCounselStart = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CanHaveMultiple = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    canCreateNewCase = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKJobType", x => x.JobTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LocalCounsel",
                columns: table => new
                {
                    LocalCounselId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LCName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LCCompanyName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LCPhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LCEmailAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LCAddress1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LCAddress2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LCCity = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    LCState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    LCZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LCCountyId = table.Column<int>(type: "int", nullable: true),
                    IsLCActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    LCBarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LCModuleType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LCFaxNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LogoLocation = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LCTrackingNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLocalCounsel", x => x.LocalCounselId);
                });

            migrationBuilder.CreateTable(
                name: "MergeDocument",
                columns: table => new
                {
                    MergeDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobTypeId = table.Column<int>(type: "int", nullable: true),
                    Category1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Category2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CommonName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MergeDocumentName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    TemplateLocation = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    CodePageLocation = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    OutDocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    OutFormat = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('docx')"),
                    MakeForEachDendant = table.Column<bool>(type: "bit", nullable: false),
                    BlankDataValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BitNoValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BitYesValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MergeThesePartyTypes = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    IncludeCurrentOccupent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKMergeDocument", x => x.MergeDocumentId);
                });

            migrationBuilder.CreateTable(
                name: "MergeDocumentToken",
                columns: table => new
                {
                    MergeDocumentTokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MergeToken = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MergeDocumentPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SelectValueSql = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IsSql = table.Column<bool>(type: "bit", nullable: true),
                    IsSqlFunction = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKMergeDocumentToken", x => x.MergeDocumentTokenId);
                });

            migrationBuilder.CreateTable(
                name: "MergeField",
                columns: table => new
                {
                    MergeFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MergeFieldName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MergeToken = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    MissingValueQuestion = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    UpdateValueSQL = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKMergeField", x => x.MergeFieldId);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyConvertion",
                columns: table => new
                {
                    ThirdPartyConvertionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LawPracticeId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ThirdPartyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ConvertionTag = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ConvertionKey = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    ConvertionValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ConvertionValue2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ConvertionValue3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    HasMultiValues = table.Column<bool>(type: "bit", nullable: false),
                    ContainsKey = table.Column<bool>(type: "bit", nullable: false),
                    CaseSensitive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKThirdPartyConvertion", x => x.ThirdPartyConvertionId);
                });

            migrationBuilder.CreateTable(
                name: "ZipCodeDictionary",
                columns: table => new
                {
                    ZipCodeDictionaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    primary_city = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    state = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    county = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKZipCodeDictionary", x => x.ZipCodeDictionaryId);
                });

            migrationBuilder.CreateTable(
                name: "AppRolePermission",
                columns: table => new
                {
                    AppRolePermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppPermissionId = table.Column<int>(type: "int", nullable: false),
                    AppRoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKAppRolePermission", x => x.AppRolePermissionId);
                    table.ForeignKey(
                        name: "FKAppPermissionAppRolePermission",
                        column: x => x.AppPermissionId,
                        principalTable: "AppPermission",
                        principalColumn: "AppPermissionId");
                    table.ForeignKey(
                        name: "FKAppRoleAppRolePermission",
                        column: x => x.AppRoleId,
                        principalTable: "AppRole",
                        principalColumn: "AppRoleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseCounty",
                columns: table => new
                {
                    CaseCountyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    County = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    CaseStateId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseCounty", x => x.CaseCountyId);
                    table.ForeignKey(
                        name: "FKCaseCountyCaseStateId",
                        column: x => x.CaseStateId,
                        principalTable: "CaseState",
                        principalColumn: "CaseStateId");
                });

            migrationBuilder.CreateTable(
                name: "CaseDistrict",
                columns: table => new
                {
                    CaseDistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    CaseStateId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseDistrict", x => x.CaseDistrictId);
                    table.ForeignKey(
                        name: "FKCaseDistrictCaseStateId",
                        column: x => x.CaseStateId,
                        principalTable: "CaseState",
                        principalColumn: "CaseStateId");
                });

            migrationBuilder.CreateTable(
                name: "ClientDepartment",
                columns: table => new
                {
                    ClientDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sysCode = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientDepartment", x => x.ClientDepartmentId);
                    table.ForeignKey(
                        name: "FKClientDepartmentClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "ClientStateLocation",
                columns: table => new
                {
                    ClientStateLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    EntityName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DivisionName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    WitnessName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    zip = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    WitnessBar = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    phone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    fax = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    PaymentName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PaymentAdd1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    PaymentAdd2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    PaymentCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PaymentState = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PaymentZip = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PaymentEmail = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    PaymentPhone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PaymentFax = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientStateLocation", x => x.ClientStateLocationId);
                    table.ForeignKey(
                        name: "FKClientStateLocationClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "Garnishee",
                columns: table => new
                {
                    GarnisheeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GarnisheeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    GarnisheeAddress1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    GarnisheeAddress2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    GarnisheeCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    GarnisheeState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    GarnisheeZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    GarnisheePhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GarnisheeFax = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKGarnishee", x => x.GarnisheeId);
                    table.ForeignKey(
                        name: "FKGarnisheeClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "ListItem",
                columns: table => new
                {
                    ListItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    SystemCategory = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('System')"),
                    SystemTag = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DisplayText = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Value1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Value2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ListOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    DefValue1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefValue2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefValue3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefValue4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefValue5 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefValue6 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefaultDateDays = table.Column<int>(type: "int", nullable: true),
                    MergeText = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    MergeValue = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    InvokeAssignment = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKListItem", x => x.ListItemId);
                    table.ForeignKey(
                        name: "FK_ListItem_Client",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MasterSQL = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    OutputFormat = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('xlsx')"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKReport", x => x.ReportId);
                    table.ForeignKey(
                        name: "FKReportClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "ClientJobListing",
                columns: table => new
                {
                    ClientJobListingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartAssignmentsOnReferral = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientJobListing", x => x.ClientJobListingId);
                    table.ForeignKey(
                        name: "FKClientJobListingClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKClientJobListingJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                });

            migrationBuilder.CreateTable(
                name: "ClientLawPracticeJobType",
                columns: table => new
                {
                    ClientLawPracticeJobTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferralPercent = table.Column<int>(type: "int", nullable: false),
                    AlertReferralAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TotalOpenCases = table.Column<int>(type: "int", nullable: false),
                    TotalHeldCases = table.Column<int>(type: "int", nullable: false),
                    AverageDaysToClose = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CustomTemplateId = table.Column<int>(type: "int", nullable: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientLawPracticeJobType", x => x.ClientLawPracticeJobTypeId);
                    table.ForeignKey(
                        name: "FKClientLawPracticeJobTypeJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                });

            migrationBuilder.CreateTable(
                name: "MergeDocumentCustom",
                columns: table => new
                {
                    MergeDocumentCustomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    CountyId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    TemplateLocation = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    CodePageLocation = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    BlankDataValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BitYesValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BitNoValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MergeDocumentId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKMergeDocumentCustom", x => x.MergeDocumentCustomId);
                    table.ForeignKey(
                        name: "FKMergeDocumentCustomMergeDocumentId",
                        column: x => x.MergeDocumentId,
                        principalTable: "MergeDocument",
                        principalColumn: "MergeDocumentId");
                });

            migrationBuilder.CreateTable(
                name: "CaseMaster",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseReferance = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    ClientReferance = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ClientInternalRef = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    JobRecipientName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RecipientAdd1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    RecipientAdd2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    RecipientCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    RecipientState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RecipientZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CaseCountyId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseMaster", x => x.CaseId);
                    table.ForeignKey(
                        name: "FKCaseClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKCaseMasterCaseCountyId",
                        column: x => x.CaseCountyId,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                });

            migrationBuilder.CreateTable(
                name: "CaseCourt",
                columns: table => new
                {
                    CaseCourtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourtName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    CountOfficalName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Fax = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ClerkContact = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CourtCurcit = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PSTCurcitCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CourtNotes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Website = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CaseCountyId = table.Column<int>(type: "int", nullable: false),
                    CaseDistrictId = table.Column<int>(type: "int", nullable: true),
                    CourtTypeLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseCourt", x => x.CaseCourtId);
                    table.ForeignKey(
                        name: "FKCaseCourtCaseCountyId",
                        column: x => x.CaseCountyId,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                    table.ForeignKey(
                        name: "FKCaseCourtCaseDistrictId",
                        column: x => x.CaseDistrictId,
                        principalTable: "CaseDistrict",
                        principalColumn: "CaseDistrictId");
                    table.ForeignKey(
                        name: "FKCaseCourtCourtType",
                        column: x => x.CourtTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleSpecialCountTemplate",
                columns: table => new
                {
                    CaseTitleSpecialCountTemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSpecialCountTemplateName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TitleSpecialCountTemplateTitle = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    TitleSpecialCountTemplateText = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    TitleSCTMergeParagraphMSJ = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    TitleSCTMergeParagraphFJ = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Other = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    StateId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CountTypeLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleSpecialCountTemplate", x => x.CaseTitleSpecialCountTemplateId);
                    table.ForeignKey(
                        name: "FKCaseTitleSpecialCountTemplateCountTypeLid",
                        column: x => x.CountTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "ClientFacility",
                columns: table => new
                {
                    ClientFacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Fax = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FacilityState = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FacilityTypeLid = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientFacility", x => x.ClientFacilityId);
                    table.ForeignKey(
                        name: "FKClientFacilityClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKClientFacilityFacilityTypeLid",
                        column: x => x.FacilityTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentFileBase = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DocumentTitle = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    isSecureDocument = table.Column<bool>(type: "bit", nullable: false),
                    isMergeDocument = table.Column<bool>(type: "bit", nullable: false),
                    hasVersioning = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    EnvokesFileAssignment = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RegisterAsAction = table.Column<bool>(type: "bit", nullable: false),
                    ProvestDocumentCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    canSendForService = table.Column<bool>(type: "bit", nullable: false),
                    sysDocumentCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SendCertified = table.Column<bool>(type: "bit", nullable: true),
                    SendFirstClass = table.Column<bool>(type: "bit", nullable: true),
                    IsClientView = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsLawPracticeView = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsLocalCounselView = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    AllowViewAll = table.Column<bool>(type: "bit", nullable: false),
                    AllowDuplicate = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DocumentCategoryLid = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKDocumentType", x => x.DocumentTypeId);
                    table.ForeignKey(
                        name: "FKDocumentTypeClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKDocumentTypeDocumentCategoryLid",
                        column: x => x.DocumentCategoryLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKDocumentTypeJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                });

            migrationBuilder.CreateTable(
                name: "LawPractice",
                columns: table => new
                {
                    LawPracticeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PracticeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    PracticeContact = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Address1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Address2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    State = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Zip = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    ContactBarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PracticeLogoLocation = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    CurrentCMSSystem = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    HasDevelopmentStaff = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    HasEFileAbility = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NumberOfAttorneys = table.Column<int>(type: "int", nullable: true),
                    PaymentType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CardExpirationDate = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CardName = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    CardDisplayNumber = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ServiceEventsURL = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    ServiceEventsLogon = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ServiceEventsPass = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ReferralCompanyCode = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    FirmStateCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    FaxNumber = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    PracticeTypeLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLawPractice", x => x.LawPracticeId);
                    table.ForeignKey(
                        name: "FKLawPracticeClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKPracticeTypeLid",
                        column: x => x.PracticeTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "ReportJob",
                columns: table => new
                {
                    ReportJobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DatabaseName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    UserName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Password = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SheduleDays = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SheduleTimeOnly = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SheduleEveryMinutes = table.Column<int>(type: "int", nullable: true),
                    SheduleBetweenHoursST = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SheduleBetweenHoursEN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    LastRun = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastResult = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    NextRun = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "(getdate())"),
                    inProgress = table.Column<bool>(type: "bit", nullable: false),
                    Action = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('email')"),
                    Destination = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKReportJob", x => x.ReportJobId);
                    table.ForeignKey(
                        name: "FKReportJobReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId");
                });

            migrationBuilder.CreateTable(
                name: "ReportJobSchedule",
                columns: table => new
                {
                    ReportJobScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ProcessStart = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    ProcessEnd = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Message = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKReportJobSchedule", x => x.ReportJobScheduleId);
                    table.ForeignKey(
                        name: "FKReportJobScheduleReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId");
                });

            migrationBuilder.CreateTable(
                name: "ReportParameter",
                columns: table => new
                {
                    ReportParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Token = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ValueType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('string')"),
                    DefaultValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKReportParameter", x => x.ReportParameterId);
                    table.ForeignKey(
                        name: "FKReportParameterReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId");
                });

            migrationBuilder.CreateTable(
                name: "CaseJudge",
                columns: table => new
                {
                    CaseJudgeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JudgeName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    JudgeCourtName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Room = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Fax = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    SpeacialInstructions1 = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    CaseCourtId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJudge", x => x.CaseJudgeId);
                    table.ForeignKey(
                        name: "FKCaseJudgeCaseCourtId",
                        column: x => x.CaseCourtId,
                        principalTable: "CaseCourt",
                        principalColumn: "CaseCourtId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTask",
                columns: table => new
                {
                    ClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentTaskId = table.Column<int>(type: "int", nullable: false),
                    ClientDepartmentId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CatListOrder = table.Column<int>(type: "int", nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    LawActionType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    isStartupTask = table.Column<bool>(type: "bit", nullable: false),
                    AssignmentName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    AssignmentCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssignmentDuration = table.Column<int>(type: "int", nullable: false),
                    StopAllWorkUntilDone = table.Column<bool>(type: "bit", nullable: false),
                    HoldWorkOnDepts = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RequiresAttyApproval = table.Column<bool>(type: "bit", nullable: false),
                    AlertAssigneeWhenComplete = table.Column<bool>(type: "bit", nullable: false),
                    AlertAttyWhenComplete = table.Column<bool>(type: "bit", nullable: false),
                    AlertEmailAddressWhenComplete = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AutoAssignTheseWhenComplete = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IntegrationCode1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IntegrationCode2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AcctFeeActivityCodeId = table.Column<int>(type: "int", nullable: true),
                    BillOnCompletion = table.Column<bool>(type: "bit", nullable: true),
                    DefaultSecUserId = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DefaultAssignmentText = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    DefaultPriority = table.Column<int>(type: "int", nullable: true),
                    StartAtReferral = table.Column<bool>(type: "bit", nullable: false),
                    CompleteActionDateName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AssignActionDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompleteCommand = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreateCommand = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    hasCheckList = table.Column<bool>(type: "bit", nullable: false),
                    runCreateCmdOnTargetDate = table.Column<bool>(type: "bit", nullable: false),
                    RequiresComplettion = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsQueueTask = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    MaxReprojectionDays = table.Column<int>(type: "int", nullable: false),
                    MaxReprojections = table.Column<int>(type: "int", nullable: false),
                    AlertAttyOnReportject = table.Column<bool>(type: "bit", nullable: false),
                    AlertAllOnReproject = table.Column<bool>(type: "bit", nullable: false),
                    AlertOthersOnReproject = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OptionalCompletionAssignments = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SetHearingAppId = table.Column<int>(type: "int", nullable: true),
                    AcctFeeReasonId = table.Column<int>(type: "int", nullable: true),
                    HoldWorkOfAssignments = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AssignmentCompletesChain = table.Column<bool>(type: "bit", nullable: false),
                    AcctFeeApprovalCOAItemId = table.Column<int>(type: "int", nullable: true),
                    RequireCOAApproval = table.Column<bool>(type: "bit", nullable: false),
                    AllowDuplicate = table.Column<bool>(type: "bit", nullable: false),
                    CloseDepartmentCase = table.Column<bool>(type: "bit", nullable: false),
                    ShowWhenDueInDays = table.Column<int>(type: "int", nullable: false),
                    ShowWhenEventInDays = table.Column<int>(type: "int", nullable: false),
                    isATTYReview = table.Column<bool>(type: "bit", nullable: true),
                    isHearingEvent = table.Column<bool>(type: "bit", nullable: true),
                    CalendarColor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    ClientSystemDefualtCode = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ClientSystemCommand = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RequireChecklistForCompletion = table.Column<bool>(type: "bit", nullable: true),
                    AssignByFileLocation = table.Column<bool>(type: "bit", nullable: true),
                    ABLBiDirectional = table.Column<bool>(type: "bit", nullable: true),
                    PrimaryTask = table.Column<bool>(type: "bit", nullable: true),
                    AllowAnyToComplete = table.Column<bool>(type: "bit", nullable: true),
                    StartOnChainCompletion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CompleteOnChainCompletion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    WebPortalTool = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CanBeAssignedToVender = table.Column<bool>(type: "bit", nullable: true),
                    ShowChecklistByDefult = table.Column<bool>(type: "bit", nullable: true),
                    CloseFileReasonId = table.Column<int>(type: "int", nullable: true),
                    VoidOnComplete = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DeleteOnComplete = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    isConsoleCompleteJob = table.Column<bool>(type: "bit", nullable: true),
                    AutoAssignPara = table.Column<bool>(type: "bit", nullable: true),
                    AutoAssignAtty = table.Column<bool>(type: "bit", nullable: true),
                    RetainAssignee = table.Column<bool>(type: "bit", nullable: true),
                    RequireEventDateOnComplete = table.Column<bool>(type: "bit", nullable: true),
                    CheckDupsIfChainComplete = table.Column<bool>(type: "bit", nullable: true),
                    IntegrationTaskCode = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    isDocumentApprovalTask = table.Column<bool>(type: "bit", nullable: true),
                    MergeDocumentOnStart = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MergeDocumentOnComplete = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ReturnDocument = table.Column<bool>(type: "bit", nullable: true),
                    ClaimState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    PriorMileStone = table.Column<int>(type: "int", nullable: true),
                    UseForTagetTaskId = table.Column<int>(type: "int", nullable: true),
                    UseCalendarDaysForTarget = table.Column<bool>(type: "bit", nullable: true),
                    ShowDocumentAttachmentArea = table.Column<bool>(type: "bit", nullable: true),
                    MaxTimeOutOpen = table.Column<int>(type: "int", nullable: true),
                    isClientTask = table.Column<bool>(type: "bit", nullable: true),
                    isLawPracticeTask = table.Column<bool>(type: "bit", nullable: true),
                    isLocalCounselTask = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    isClientCompleteTask = table.Column<bool>(type: "bit", nullable: true),
                    isLawPracticeCompleteTask = table.Column<bool>(type: "bit", nullable: true),
                    isLocalCounselCompleteTask = table.Column<bool>(type: "bit", nullable: true),
                    GroupCategory1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    GroupCategory2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    GroupCategory3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    GroupCategory4 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    GroupCategory5 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    GroupCategory6 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    GroupCategory7 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    AllowParallel = table.Column<bool>(type: "bit", nullable: true),
                    AutoCompleteTaskIfExists = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IgnorHoldsFromTaskIds = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    RequiresDocumentId = table.Column<int>(type: "int", nullable: true),
                    AssocMergePackageId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTask", x => x.ClientAssignmentTaskId);
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskAssocMergePackageId",
                        column: x => x.AssocMergePackageId,
                        principalTable: "MergeDocument",
                        principalColumn: "MergeDocumentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskRequiresDocumentId",
                        column: x => x.RequiresDocumentId,
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId");
                    table.ForeignKey(
                        name: "RefClientAssignmentTask213",
                        column: x => x.ParentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                });

            migrationBuilder.CreateTable(
                name: "ClientJob",
                columns: table => new
                {
                    ClientJobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobDataKeyId = table.Column<int>(type: "int", nullable: false, comment: "This column represents the module id( casebkyid, casewritid)"),
                    LPReferranceNumber = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    ReferralAcknolagedDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    ClientJobStatus = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "(N'O')"),
                    ClosedDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    LocalCounselId = table.Column<int>(type: "int", nullable: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientJob", x => x.ClientJobId);
                    table.ForeignKey(
                        name: "FKClientJobCaseId",
                        column: x => x.CaseId,
                        principalTable: "CaseMaster",
                        principalColumn: "CaseId");
                    table.ForeignKey(
                        name: "FKClientJobJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                    table.ForeignKey(
                        name: "FKClientJobLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                    table.ForeignKey(
                        name: "FKClientJobLocalCounselId",
                        column: x => x.LocalCounselId,
                        principalTable: "LocalCounsel",
                        principalColumn: "LocalCounselId");
                });

            migrationBuilder.CreateTable(
                name: "ClientLawPractice",
                columns: table => new
                {
                    ClientLawPracticeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttyHourRate = table.Column<decimal>(type: "money", nullable: false),
                    FirmwareUser = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ReferralPercent = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    LawPracticeState = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FCLDoesTitle = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    LawPracticeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientLawPractice", x => x.ClientLawPracticeId);
                    table.ForeignKey(
                        name: "FKClientLawPracticeClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKClientLawPracticeLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                });

            migrationBuilder.CreateTable(
                name: "LawPracticeJob",
                columns: table => new
                {
                    LawPracticeJobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ContectMemberId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    LPFileNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LPKey1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LawPracticeId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLawPracticeJob", x => x.LawPracticeJobId);
                    table.ForeignKey(
                        name: "FKLawPracticeJobJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                    table.ForeignKey(
                        name: "FKLawPracticeJobLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                });

            migrationBuilder.CreateTable(
                name: "LoginDetail",
                columns: table => new
                {
                    LoginDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTypeLid = table.Column<int>(type: "int", nullable: false),
                    LoginID = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    LoginPWD = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: false),
                    AccessToken = table.Column<string>(type: "varchar(3500)", unicode: false, maxLength: 3500, nullable: true),
                    LoginUserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentToken = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LogonIP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneAppCode = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EnforcePasswordPol = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    PasswordExpiresIn = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((45))"),
                    LastPasswordChange = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    SentSubscription = table.Column<bool>(type: "bit", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Fax = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    IsAcceptTermsandConditions = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    TermsandConditionsAcceptDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    PendingAttemptCount = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((3))"),
                    LockedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    isLocked = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))"),
                    CanAccessMenu = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CanAccessReports = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsClientAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    isSysAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    LocalCounselId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLoginDetail", x => x.LoginDetailId);
                    table.ForeignKey(
                        name: "FKLoginDetailClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKLoginDetailLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                    table.ForeignKey(
                        name: "FKLoginDetailLocalCounselId",
                        column: x => x.LocalCounselId,
                        principalTable: "LocalCounsel",
                        principalColumn: "LocalCounselId");
                    table.ForeignKey(
                        name: "FKLoginTypeLid",
                        column: x => x.LoginTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "ReportMapping",
                columns: table => new
                {
                    ReportMappingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    LocalCounselId = table.Column<int>(type: "int", nullable: true),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKReportMapping", x => x.ReportMappingId);
                    table.ForeignKey(
                        name: "FKReportMappingClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKReportMappingLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                    table.ForeignKey(
                        name: "FKReportMappingLocalCounselId",
                        column: x => x.LocalCounselId,
                        principalTable: "LocalCounsel",
                        principalColumn: "LocalCounselId");
                    table.ForeignKey(
                        name: "FKReportMappingReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId");
                });

            migrationBuilder.CreateTable(
                name: "ReportJobParameter",
                columns: table => new
                {
                    ReportJobParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    ReportJobId = table.Column<int>(type: "int", nullable: false),
                    ReportParameterId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKReportJobParameter", x => x.ReportJobParameterId);
                    table.ForeignKey(
                        name: "FKReportJobParameterReportJobId",
                        column: x => x.ReportJobId,
                        principalTable: "ReportJob",
                        principalColumn: "ReportJobId");
                    table.ForeignKey(
                        name: "FKReportJobParameterReportParameterId",
                        column: x => x.ReportParameterId,
                        principalTable: "ReportParameter",
                        principalColumn: "ReportParameterId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTaskCheckList",
                columns: table => new
                {
                    ClientAssignmentTaskCheckListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskListName = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    ProcessCommand = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    TaskListItemTag = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DropSql = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UseTaskListItemID = table.Column<bool>(type: "bit", nullable: true),
                    UpdateTable = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UpdateField = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UpdateKeyField = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UpdateKeyValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CompletesFileAssignmentTaskId = table.Column<bool>(type: "bit", nullable: true),
                    StartsFileAssignmentsTaskID = table.Column<bool>(type: "bit", nullable: true),
                    AssignmentsYes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssignmentsNo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CustomControlName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AutoCompletesTasks = table.Column<bool>(type: "bit", nullable: false),
                    RulesDefaultAssignments = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UsesValueRules = table.Column<bool>(type: "bit", nullable: false),
                    ShowDefendantForStartAssignment = table.Column<bool>(type: "bit", nullable: false),
                    DropUpdaterControl = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BindDocumentToAssignment = table.Column<bool>(type: "bit", nullable: true),
                    DefaultValue = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AssignClientWitness = table.Column<bool>(type: "bit", nullable: true),
                    CustomWorkScheduleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AttachDropDocToAssDocument = table.Column<bool>(type: "bit", nullable: true),
                    MergeToken = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    UpdateTopOne = table.Column<bool>(type: "bit", nullable: true),
                    OrderBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: true),
                    KillAssignmentSchedule = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsConditional = table.Column<bool>(type: "bit", nullable: true),
                    mirrorToComment = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false),
                    CheckListTypeLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTaskCheckList", x => x.ClientAssignmentTaskCheckListId);
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskCheckListClientAssignmentTaskId",
                        column: x => x.ClientAssignmentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskCheckListTypeLid",
                        column: x => x.CheckListTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTaskScheduled",
                columns: table => new
                {
                    ClientAssignmentTaskScheduledId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaysFromTargetDate = table.Column<int>(type: "int", nullable: false),
                    AlertWhenStarted = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    RunScheduledOnStartNewAssign = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CalendarDay = table.Column<bool>(type: "bit", nullable: true),
                    LaunchTime = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    UseSaleDate = table.Column<bool>(type: "bit", nullable: true),
                    ClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false),
                    StartClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTaskScheduled", x => x.ClientAssignmentTaskScheduledId);
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskScheduledClientAssignmentTaskId",
                        column: x => x.ClientAssignmentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                    table.ForeignKey(
                        name: "RefClientAssignmentTask221",
                        column: x => x.StartClientAssignmentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                });

            migrationBuilder.CreateTable(
                name: "CaseAuto",
                columns: table => new
                {
                    CaseAutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleVinNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VehicleMake = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VehicleModel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VehicleYear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VehicleTrim = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LPReferenceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InternalStockRefNum = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuaranteedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MMREstimatedValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RetailValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TitleTransferDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpenedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseAutoStatusLid = table.Column<int>(type: "int", nullable: false),
                    AssignedCSRLid = table.Column<int>(type: "int", nullable: true),
                    VehicleStatusLid = table.Column<int>(type: "int", nullable: true),
                    ClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseAuto", x => x.CaseAutoId);
                    table.ForeignKey(
                        name: "FKCaseAutoAssignedCSRLid",
                        column: x => x.AssignedCSRLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseAutoClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseAutoClosedReasonLid",
                        column: x => x.ClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseAutoStatusLid",
                        column: x => x.CaseAutoStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseAutoVehicleStatusLid",
                        column: x => x.VehicleStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseBkr",
                columns: table => new
                {
                    CaseBkrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BKROpenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BKRCaseNumber = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    FiledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientReferranceNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BKRLoanNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BKRInvestorNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttyAssignedTo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AttyAssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaintiffCap = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DefendantCap = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DefaultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BKYPOCBarDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CFMHearingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Debtor1Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Debtor1Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Debtor1Email = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Debtor1Addr1 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    Debtor1Addr2 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    Debtor1City = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Debtor1State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Debtor1Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Debtor2Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Debtor2Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Debtor2Email = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Debtor2Addr1 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    Debtor2Addr2 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    Debtor2City = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Debtor2State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Debtor2Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TrusteeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TrusteePhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TrusteeEmail = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    TrusteeAddr1 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    TrusteeAddr2 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    TrusteeCity = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    TrusteeState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    TrusteeZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PropertyAddr1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PropertyAddr2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PropertyCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PropertyState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    PropertyZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CountyID = table.Column<int>(type: "int", nullable: true),
                    LPReferanceId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PrincipalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ChargeOffDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BarDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ECFPOCID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    POCFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    APOCFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SOLDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LitigationType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    WOCFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SOCFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerFullName1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CustomerFullName2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ECFAPOCID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseBKRStatusLid = table.Column<int>(type: "int", nullable: false),
                    CaseBKRTypeLid = table.Column<int>(type: "int", nullable: false),
                    CaseBKRClientInvestorTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseBKRClientInvestorLid = table.Column<int>(type: "int", nullable: true),
                    BKRDistrictId = table.Column<int>(type: "int", nullable: true),
                    BKRCircuitLid = table.Column<int>(type: "int", nullable: true),
                    ClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    BKRSOLLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseBkr", x => x.CaseBkrId);
                    table.ForeignKey(
                        name: "FKBKRSOLLid",
                        column: x => x.BKRSOLLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseBKRBKRDistrictId",
                        column: x => x.BKRDistrictId,
                        principalTable: "BkrDistrict",
                        principalColumn: "BkrDistrictId");
                    table.ForeignKey(
                        name: "FKCaseBKRClientInvestorLid",
                        column: x => x.CaseBKRClientInvestorLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseBKRClientInvestorTypeLid",
                        column: x => x.CaseBKRClientInvestorTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseBKRClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseBKRStatusLid",
                        column: x => x.CaseBKRStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseBKRTypeLid",
                        column: x => x.CaseBKRTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCircuitLid",
                        column: x => x.BKRCircuitLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKClosedReasonLid",
                        column: x => x.ClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseComment",
                columns: table => new
                {
                    CaseCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: true),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    CommentTypeLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseComment", x => x.CaseCommentId);
                    table.ForeignKey(
                        name: "FKCaseCommentCaseId",
                        column: x => x.CaseId,
                        principalTable: "CaseMaster",
                        principalColumn: "CaseId");
                    table.ForeignKey(
                        name: "FKCaseCommentClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseCommentCommentTypeLid",
                        column: x => x.CommentTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseCommentWhiteboard",
                columns: table => new
                {
                    CaseCommentWhiteboardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: true),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    CommentTypeLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseCommentWhiteboard", x => x.CaseCommentWhiteboardId);
                    table.ForeignKey(
                        name: "FKCaseCommentWhiteboardCaseId",
                        column: x => x.CaseId,
                        principalTable: "CaseMaster",
                        principalColumn: "CaseId");
                    table.ForeignKey(
                        name: "FKCaseCommentWhiteboardClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseCommentWhiteboardCommentTypeLid",
                        column: x => x.CommentTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseEviction",
                columns: table => new
                {
                    CaseEvictionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileNumber = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FirstLegalActionDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OptionLetterSentDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CFKOfferDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedVacateDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualVacateDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedAmt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CFKFallthroughDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EVCReffRcvdAttrDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WritPossesionEntrdDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WritPossesionPostedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockoutDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockoutCmptDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseAndBillDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EvictionOpenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EVCAttorney = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LoanNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CourtCaseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PropAddr1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PropAddr2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PropCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PropState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    PropZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PropertyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TenentLeaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenentLeaseDuration = table.Column<int>(type: "int", nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrigPlaintiff = table.Column<string>(type: "varchar(1550)", unicode: false, maxLength: 1550, nullable: true),
                    PlaintiffCap = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    OridDefendant = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    DefendantCap = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    EvictionTypeLid = table.Column<int>(type: "int", nullable: false),
                    EvictionStatusLid = table.Column<int>(type: "int", nullable: false),
                    CaseJudgeId = table.Column<int>(type: "int", nullable: true),
                    CaseCountyId = table.Column<int>(type: "int", nullable: true),
                    CaseDistrictId = table.Column<int>(type: "int", nullable: true),
                    DivisionLid = table.Column<int>(type: "int", nullable: true),
                    CircuitLid = table.Column<int>(type: "int", nullable: true),
                    ClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseEviction", x => x.CaseEvictionId);
                    table.ForeignKey(
                        name: "FKCaseEvictionCaseCountyId",
                        column: x => x.CaseCountyId,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                    table.ForeignKey(
                        name: "FKCaseEvictionCaseDistrictId",
                        column: x => x.CaseDistrictId,
                        principalTable: "CaseDistrict",
                        principalColumn: "CaseDistrictId");
                    table.ForeignKey(
                        name: "FKCaseEvictionCaseJudgeId",
                        column: x => x.CaseJudgeId,
                        principalTable: "CaseJudge",
                        principalColumn: "CaseJudgeId");
                    table.ForeignKey(
                        name: "FKCaseEvictionCircuitLid",
                        column: x => x.CircuitLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseEvictionClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseEvictionClosedReasonLid",
                        column: x => x.ClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseEvictionDivisionLid",
                        column: x => x.DivisionLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseEvictionEvictionStatusLid",
                        column: x => x.EvictionStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseEvictionEvictionTypeLid",
                        column: x => x.EvictionTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseFcl",
                columns: table => new
                {
                    CaseFclId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FCLLoanNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FCLClientReferanceNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FCLCourtCaseNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    InversterLoanNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IndexNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FCLFullPlaintiff = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    FCLFullDefendant = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    FCLOridMortgagor = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    PropertyOwner = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    PrimaryBorrowerName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PropertyMortgagor = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    PropertyMortgagee = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    PropertyAddress1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    PropertyAddress2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PropertyCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    PropertyState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PropertyZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FCLOpenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaseFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaseFCLClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FCLReferralRecievedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FCLMortgageDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FCLMortgageDefaultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FCLBallanceAtDefault = table.Column<decimal>(type: "money", nullable: true),
                    FCLIntrestRate = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    FCLIntrestIsAdjustable = table.Column<bool>(type: "bit", nullable: true),
                    FCLCurrentBallance = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    FCLMortgageAmount = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    ReferralNote = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    isReferred = table.Column<bool>(type: "bit", nullable: false),
                    ReferredOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OccStatus = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AttorneyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MortgageReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SOLDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordedBook = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RecordedPage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RecordedInst = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FCLMonthlyPayment = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    FCLHomePhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MobileHomeManufacturedYear = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileHomeTradeModelName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MobileHomeSerialVINNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MobileHomeHUDConstructionCodeLabels = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MobileHomeHUDConstruction = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MobileHomeRealEstateTaxID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DeedInfoRecordingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeedInfoRecordingInstrumentNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DeedInfoRecordingBookNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DeedInfoRecordingPageNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DeedInfoFinalVestingInfo = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseFCLStatusLid = table.Column<int>(type: "int", nullable: false),
                    CaseFCLClientInvestorTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseFCLPropertyTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseFCLClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    CaseFCLCaseTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseJudgeId = table.Column<int>(type: "int", nullable: true),
                    CountyFiled = table.Column<int>(type: "int", nullable: true),
                    StateFiled = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseFcl", x => x.CaseFclId);
                    table.ForeignKey(
                        name: "FKCaseFCLCaseJudgeId",
                        column: x => x.CaseJudgeId,
                        principalTable: "CaseJudge",
                        principalColumn: "CaseJudgeId");
                    table.ForeignKey(
                        name: "FKCaseFCLCaseTypeLid",
                        column: x => x.CaseFCLCaseTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseFCLClientInvestorTypeLid",
                        column: x => x.CaseFCLClientInvestorTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseFCLClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseFCLClosedReasonLid",
                        column: x => x.CaseFCLClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseFCLCountyFiled",
                        column: x => x.CountyFiled,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                    table.ForeignKey(
                        name: "FKCaseFCLPropertyTypeLid",
                        column: x => x.CaseFCLPropertyTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseFCLStateFiled",
                        column: x => x.StateFiled,
                        principalTable: "CaseState",
                        principalColumn: "CaseStateId");
                    table.ForeignKey(
                        name: "FKCaseFCLStatusLid",
                        column: x => x.CaseFCLStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseWrit",
                columns: table => new
                {
                    CaseWritId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseOpenedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LPReferenceId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CourtCaseNum = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Garnishor = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    AnswerDueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnswerFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    GarnishmentDebtAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CheckIssuedAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WritServiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WritFiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HearingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailScannedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EWLCreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FundsRemittanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EWLCaseNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseWritStatusLid = table.Column<int>(type: "int", nullable: false),
                    ClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    CaseTypeLid = table.Column<int>(type: "int", nullable: true),
                    CountyId = table.Column<int>(type: "int", nullable: true),
                    CaseDetailLid = table.Column<int>(type: "int", nullable: true),
                    CourtTypeId = table.Column<int>(type: "int", nullable: true),
                    GarnisheeId = table.Column<int>(type: "int", nullable: true),
                    RtgLid = table.Column<int>(type: "int", nullable: true),
                    AdditionalDocumentationLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseWrit", x => x.CaseWritId);
                    table.ForeignKey(
                        name: "FKCaseWritAdditionalDocumentationLid",
                        column: x => x.AdditionalDocumentationLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritCaseDetailLid",
                        column: x => x.CaseDetailLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritCaseTypeLid",
                        column: x => x.CaseTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseWritClosedReasonLid",
                        column: x => x.ClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritCountyId",
                        column: x => x.CountyId,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                    table.ForeignKey(
                        name: "FKCaseWritCourtTypeId",
                        column: x => x.CourtTypeId,
                        principalTable: "CaseCourt",
                        principalColumn: "CaseCourtId");
                    table.ForeignKey(
                        name: "FKCaseWritGarnisheeId",
                        column: x => x.GarnisheeId,
                        principalTable: "Garnishee",
                        principalColumn: "GarnisheeId");
                    table.ForeignKey(
                        name: "FKCaseWritRtgLid",
                        column: x => x.RtgLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritStatusLid",
                        column: x => x.CaseWritStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CientJobLog",
                columns: table => new
                {
                    CientJobLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    LogText = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCientJobLog", x => x.CientJobLogId);
                    table.ForeignKey(
                        name: "FKCientJobLogClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                });

            migrationBuilder.CreateTable(
                name: "AppRoleLoginDetail",
                columns: table => new
                {
                    AppRoleLoginDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRoleId = table.Column<int>(type: "int", nullable: false),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKAppRoleLoginDetail", x => x.AppRoleLoginDetailId);
                    table.ForeignKey(
                        name: "FKAppRoleAppRoleLoginDetail",
                        column: x => x.AppRoleId,
                        principalTable: "AppRole",
                        principalColumn: "AppRoleId");
                    table.ForeignKey(
                        name: "FKLoginDetailAppRoleLoginDetail",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "ClientJobLegal",
                columns: table => new
                {
                    ClientJobLegalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegalDescriptionOrid = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    LegalDescriptionCur = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    LegalDescBook = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LegalDescPage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LegalDescInstrument = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VerifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    LegalDescFromLid = table.Column<int>(type: "int", nullable: true),
                    VerifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientJobLegal", x => x.ClientJobLegalId);
                    table.ForeignKey(
                        name: "FKClientJobLegalClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKClientJobLegalLegalDescFromLid",
                        column: x => x.LegalDescFromLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKClientJobLegalVerifiedBy",
                        column: x => x.VerifiedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "LawPracticeUser",
                columns: table => new
                {
                    LawPracticeUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enabled = table.Column<bool>(type: "bit", nullable: false),
                    IsAttorney = table.Column<bool>(type: "bit", nullable: false),
                    IsPara = table.Column<bool>(type: "bit", nullable: false),
                    IsPartner = table.Column<bool>(type: "bit", nullable: false),
                    AttyBarNumber = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    AttyPinNumer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AttyLastPinCreated = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    isRemote = table.Column<bool>(type: "bit", nullable: true),
                    isLocalCounsel = table.Column<bool>(type: "bit", nullable: true),
                    HourlyConntractRate = table.Column<decimal>(type: "money", nullable: true),
                    SMSEmail = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ActionTypeCode = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MgrLawPracticeUserId = table.Column<int>(type: "int", nullable: true),
                    SMTPEmail = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LawPracticeUserName = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    AttySignImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true, defaultValueSql: "((0))"),
                    LawPracticeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLawPracticeUser", x => x.LawPracticeUserId);
                    table.ForeignKey(
                        name: "FKLawPracticeUserClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FKLawPracticeUserLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                    table.ForeignKey(
                        name: "FKLawPracticeUserLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "LoginDetailJobListing",
                columns: table => new
                {
                    LoginDetailJobListingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLoginDetailJobListing", x => x.LoginDetailJobListingId);
                    table.ForeignKey(
                        name: "FKLoginDetailJobListingJobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "JobTypeId");
                    table.ForeignKey(
                        name: "FKLoginDetailJobListingLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "LoginDetailsAccessRole",
                columns: table => new
                {
                    LoginDetailsAccessRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessFieldName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AccessFieldValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AccessFieldClass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    AccessFieldLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLoginDetailsAccessRole", x => x.LoginDetailsAccessRoleId);
                    table.ForeignKey(
                        name: "FKLoginDetailsAccessRoleAccessFieldLid",
                        column: x => x.AccessFieldLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKLoginDetailsAccessRoleLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "LogonDetailsAssignmentPool",
                columns: table => new
                {
                    LogonDetailsAssignmentPoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isQueueAdmin = table.Column<bool>(type: "bit", nullable: false),
                    MaxQueueQuota = table.Column<int>(type: "int", nullable: false),
                    isAvailible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    NotifyOnNewTasks = table.Column<bool>(type: "bit", nullable: false),
                    CPAdditionalSql = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false),
                    UseReportId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLogonDetailsAssignmentPool", x => x.LogonDetailsAssignmentPoolId);
                    table.ForeignKey(
                        name: "FKLogonDetailsAssignmentPoolClientAssignmentTaskId",
                        column: x => x.ClientAssignmentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                    table.ForeignKey(
                        name: "FKLogonDetailsAssignmentPoolLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKLogonDetailsAssignmentPoolUseReportId",
                        column: x => x.UseReportId,
                        principalTable: "Report",
                        principalColumn: "ReportId");
                });

            migrationBuilder.CreateTable(
                name: "LogonDetailSubordinate",
                columns: table => new
                {
                    LogonDetailSubordinateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    canTakeAnyAssignment = table.Column<bool>(type: "bit", nullable: false),
                    isAvailible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    SubordinateLoginDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLogonDetailSubordinate", x => x.LogonDetailSubordinateId);
                    table.ForeignKey(
                        name: "FKLogonDetailSubordinateLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKLogonDetailSubordinateSubordinateLoginDetailsId",
                        column: x => x.SubordinateLoginDetailsId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentCheckListCr",
                columns: table => new
                {
                    ClientAssignmentCheckListCrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientAssignmentTaskCheckListCRId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentTaskCheckListId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentCheckListCr", x => x.ClientAssignmentCheckListCrId);
                    table.ForeignKey(
                        name: "FKClientAssignmentCheckListCRClientAssignmentTaskCheckListId",
                        column: x => x.ClientAssignmentTaskCheckListId,
                        principalTable: "ClientAssignmentTaskCheckList",
                        principalColumn: "ClientAssignmentTaskCheckListId");
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskCheckListCRId",
                        column: x => x.ClientAssignmentTaskCheckListCRId,
                        principalTable: "ClientAssignmentTaskCheckListCr",
                        principalColumn: "ClientAssignmentTaskCheckListCrId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTaskCheckListVr",
                columns: table => new
                {
                    ClientAssignmentTaskCheckListVrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompareValue = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    StartAssigmnmentOnMatch = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RunCommandOnMatch = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    StartAssigmnmentOnNoMatch = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RunCommandOnNoMatch = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ClientAssignmentTaskCheckListId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTaskCheckListVr", x => x.ClientAssignmentTaskCheckListVrId);
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskCheckListVRClientAssignmentTaskCheckListId",
                        column: x => x.ClientAssignmentTaskCheckListId,
                        principalTable: "ClientAssignmentTaskCheckList",
                        principalColumn: "ClientAssignmentTaskCheckListId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTaskRule",
                columns: table => new
                {
                    ClientAssignmentTaskRuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    EffectiveStartDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    EffectiveEndDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    OnlyIfMet = table.Column<bool>(type: "bit", nullable: true),
                    NotIfMet = table.Column<bool>(type: "bit", nullable: true),
                    State = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    County = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Client = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ReplevinType = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BKState = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BKDistrict = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BKChapter = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RuleType = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ClientAssignmentTaskCheckListId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTaskRule", x => x.ClientAssignmentTaskRuleId);
                    table.ForeignKey(
                        name: "FKClientAssignmentTaskRuleClientAssignmentTaskCheckListId",
                        column: x => x.ClientAssignmentTaskCheckListId,
                        principalTable: "ClientAssignmentTaskCheckList",
                        principalColumn: "ClientAssignmentTaskCheckListId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentTaskRecurrence",
                columns: table => new
                {
                    ClientAssignmentTaskRecurrenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientAssignmentTaskScheduledId = table.Column<int>(type: "int", nullable: false),
                    RecurrenceType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    EveryNumberType = table.Column<int>(type: "int", nullable: true),
                    EveryWeekday = table.Column<bool>(type: "bit", nullable: true),
                    Monday = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Tuesday = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Wednesday = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Thursday = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Friday = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DayOrder = table.Column<int>(type: "int", nullable: true),
                    TheOrder = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CreatedDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UpdateDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "(getdate())"),
                    UpdateBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StartDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    EndDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentTaskRecurrence", x => x.ClientAssignmentTaskRecurrenceId);
                    table.ForeignKey(
                        name: "FK_ClientAssignmentTaskRecurrence_ClientAssignmentTaskScheduled",
                        column: x => x.ClientAssignmentTaskScheduledId,
                        principalTable: "ClientAssignmentTaskScheduled",
                        principalColumn: "ClientAssignmentTaskScheduledId");
                });

            migrationBuilder.CreateTable(
                name: "CaseAutoBuyerInfo",
                columns: table => new
                {
                    CaseAutoBuyerInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BackgroundCheckLID = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AltPhoneNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DriverLicenseDocRepID = table.Column<int>(type: "int", nullable: true),
                    DLExpiryDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BuyingActionLID = table.Column<int>(type: "int", nullable: true),
                    OnlinePlacementLID = table.Column<int>(type: "int", nullable: true),
                    AssignedAgentLID = table.Column<int>(type: "int", nullable: true),
                    IsAgentNotified = table.Column<bool>(type: "bit", nullable: true),
                    BuyingStatusLID = table.Column<int>(type: "int", nullable: true),
                    TestDriveResultsLID = table.Column<int>(type: "int", nullable: true),
                    FollowUpDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    FollowUpComment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    UpdatedOn = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: true),
                    TestDriveDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CaseAutoId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseAutoBuyerInfo", x => x.CaseAutoBuyerInfoId);
                    table.ForeignKey(
                        name: "FKCaseAutoBuyerInfoCaseAutoId",
                        column: x => x.CaseAutoId,
                        principalTable: "CaseAuto",
                        principalColumn: "CaseAutoId");
                });

            migrationBuilder.CreateTable(
                name: "BkrCaseSummary",
                columns: table => new
                {
                    BkrCaseSummaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidenceorHomestead = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SurrenderedPursuant = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ArrearageCured = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ValuedorStripped = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ProvidedPursuant = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PropSurrendered = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PropPaidDirectly = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PropNotListed = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OEDEntered = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PlanConfirmed = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FinalJdgmntForeClosure = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ExemptPursuant = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TrusteeAbandonProp = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ObtainedOED = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PropertyProvidedPlan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DischargeOder = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrCaseSummary", x => x.BkrCaseSummaryId);
                    table.ForeignKey(
                        name: "FKBKRCaseSummaryCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrConditionalOrder",
                columns: table => new
                {
                    BkrConditionalOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentsDueFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentsDueTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentsDueAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentsDueTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AttysFeesAndCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MnthlyPymntAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NextPymntDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalDelinquency = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalDueDiv6Months = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrConditionalOrder", x => x.BkrConditionalOrderId);
                    table.ForeignKey(
                        name: "FKBKRConditionalOrderCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrFinancial",
                columns: table => new
                {
                    BkrFinancialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastBreakDownRequest = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastBreakDownReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnpaidPrincipal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InsuranceAdvances = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherFees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumInstallmentsDue = table.Column<int>(type: "int", nullable: true),
                    PreTotalAttyfees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreForcedInsurance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreTotalPetitionAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostTotalAttyFees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostAttyFeeBilled = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostFilingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostInspectionfees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostAppraisalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostForcedInsurance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PosttotalPetitionAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnappliedFunds = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreMonthlyPymntAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreNextPymntDue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrePayOffDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrePayOffAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreCountyPropertyAppraisal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostAtTimeOfBKYFiling = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostCurrentPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrePetitionUnappliedFunds = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrePetitionRefund = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastMonetaryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrFinancial", x => x.BkrFinancialId);
                    table.ForeignKey(
                        name: "FKBKRFinancialCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrFinInstallment",
                columns: table => new
                {
                    BKRFinInstallmentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberofInstallments = table.Column<int>(type: "int", nullable: false),
                    AmountofInstallments = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalInstallmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateofInstallment = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrFinInstallment", x => x.BKRFinInstallmentsId);
                    table.ForeignKey(
                        name: "FKBKRFinInstallmentCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrFinInterestRate",
                columns: table => new
                {
                    BkrFinInterestRateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IRFromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ITToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InterestRate = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    IRTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFixedRate = table.Column<bool>(type: "bit", nullable: true),
                    IsVariableRate = table.Column<bool>(type: "bit", nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrFinInterestRate", x => x.BkrFinInterestRateId);
                    table.ForeignKey(
                        name: "FKBKRFinInterestRateCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrFinMissedPayment",
                columns: table => new
                {
                    BkrFinMissedPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MPFromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MPPandI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MPEscrow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MPTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MPToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MPNumberOfMissedPayments = table.Column<int>(type: "int", nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrFinMissedPayment", x => x.BkrFinMissedPaymentId);
                    table.ForeignKey(
                        name: "FKBKRFinMissedPaymentCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrFinOtherCost",
                columns: table => new
                {
                    BKROtherCostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CostAmount = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DateIncurred = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    OtherDescription = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SupportDocumentRepositoryId = table.Column<int>(type: "int", nullable: true),
                    LPApproved = table.Column<bool>(type: "bit", nullable: false),
                    ClientApproved = table.Column<bool>(type: "bit", nullable: false),
                    WriteOffDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WriteOffNote = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    WriteOffBy = table.Column<int>(type: "int", nullable: true),
                    ActionNeededNote = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CostDecriptionLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrFinOtherCost", x => x.BKROtherCostId);
                    table.ForeignKey(
                        name: "FKBKRFinOtherCostCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                    table.ForeignKey(
                        name: "FKBKRFinOtherCostCostDecriptionLid",
                        column: x => x.CostDecriptionLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "BkrJournal",
                columns: table => new
                {
                    BKRJourneyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherKey = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    JournalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Action = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrJournal", x => x.BKRJourneyId);
                    table.ForeignKey(
                        name: "FKBKRJournalCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrLoanModification",
                columns: table => new
                {
                    BkrLoanModificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedInterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrincipalAndInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaturityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NewUnpaidPrincipalBal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrLoanModification", x => x.BkrLoanModificationId);
                    table.ForeignKey(
                        name: "FKBKRLoanModificationCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrMfr",
                columns: table => new
                {
                    BkrMfrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReliefByPlan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    StatementOfIntention = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FinalJudgment = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NegativeNotice = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MotionGranted = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    APOEntered = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TermsOfAPO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrMfr", x => x.BkrMfrId);
                    table.ForeignKey(
                        name: "FKBKRMFRCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrPaymentChange",
                columns: table => new
                {
                    BKRPaymentChangeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentEscrowPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrentInterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrentPrincipalAndInterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrentMrtgPmnt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewEscrowPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewInterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewPrincipalAndInterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewMrtgPmnt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewTotalPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrPaymentChange", x => x.BKRPaymentChangeId);
                    table.ForeignKey(
                        name: "FKBKRPaymentChangeCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "BkrProperty",
                columns: table => new
                {
                    BKRPropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BKYCourtAddress1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    BKYCourtAddress2 = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    BKYCourtCity = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    BKYCourtState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    BKYCourtZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BKYCourtPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BKYCourtEmail = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    BkyClientPaymentAddress1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    BkyClientPaymentAddress2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    BkyClientPaymentPhone = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    BkyClientPaymentZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BkyClientPaymentCity = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    BkyClientPaymentEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BkyClientPaymentState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CaseBKRId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKBkrProperty", x => x.BKRPropertyId);
                    table.ForeignKey(
                        name: "FKBKRPropertyCaseBKRId",
                        column: x => x.CaseBKRId,
                        principalTable: "CaseBkr",
                        principalColumn: "CaseBkrId");
                });

            migrationBuilder.CreateTable(
                name: "CaseEvictionJournal",
                columns: table => new
                {
                    CaseEvictionJournalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherKey = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    JournalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Action = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    CaseEvictionId = table.Column<int>(type: "int", nullable: false),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseEvictionJournal", x => x.CaseEvictionJournalId);
                    table.ForeignKey(
                        name: "FKCaseEvictionJournalCaseEvictionId",
                        column: x => x.CaseEvictionId,
                        principalTable: "CaseEviction",
                        principalColumn: "CaseEvictionId");
                    table.ForeignKey(
                        name: "FKCaseEvictionJournalLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "CaseSale",
                columns: table => new
                {
                    CaseSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFCLId = table.Column<int>(type: "int", nullable: false),
                    BidAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SaleAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SaleDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BidAssign = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    BidAssignAddr = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    BidAssignCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BidAssignState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    BidAssignZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BidAssignedToID = table.Column<int>(type: "int", nullable: true),
                    Bidder = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SuppJudgRecov = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    Comments = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PreSaleDate = table.Column<DateTime>(type: "date", nullable: true),
                    PreSalePubRunDate1 = table.Column<DateTime>(type: "date", nullable: true),
                    PreSalePubRunDate2 = table.Column<DateTime>(type: "date", nullable: true),
                    PreSaleReqBidInst = table.Column<DateTime>(type: "date", nullable: true),
                    SaleHeldDate = table.Column<DateTime>(type: "date", nullable: true),
                    SaleHeldBidAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SaleHeldBidInst = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SaleHeldBidder = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PostSalesCertofSales = table.Column<DateTime>(type: "date", nullable: true),
                    PostSalesCertofTitle = table.Column<DateTime>(type: "date", nullable: true),
                    PostSales3rdFunds = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PostSales3rdFundsRec = table.Column<DateTime>(type: "date", nullable: true),
                    PostSalesObjection = table.Column<DateTime>(type: "date", nullable: true),
                    PostSalesCTRecorded = table.Column<DateTime>(type: "date", nullable: true),
                    PostSalesAmndCTRecorded = table.Column<DateTime>(type: "date", nullable: true),
                    PerDiem = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    TotalInterestDue = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    RescheduleDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IntDays = table.Column<int>(type: "int", nullable: true),
                    TotalCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IntegrationId1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IntegrationId2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IntegrationId3 = table.Column<int>(type: "int", nullable: true),
                    RescheduleReasonLid = table.Column<int>(type: "int", nullable: true),
                    CancelReasonLid = table.Column<int>(type: "int", nullable: true),
                    CaseSaleStatusLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseSale", x => x.CaseSaleId);
                    table.ForeignKey(
                        name: "FKCaseSaleCancelReasonLid",
                        column: x => x.CancelReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSaleRescheduleReasonLid",
                        column: x => x.RescheduleReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSaleStatusLid",
                        column: x => x.CaseSaleStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FK__CaseSale__CaseFCLId",
                        column: x => x.CaseFCLId,
                        principalTable: "CaseFcl",
                        principalColumn: "CaseFclId");
                });

            migrationBuilder.CreateTable(
                name: "CaseWritFinancial",
                columns: table => new
                {
                    CaseWritFinancialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcctLast4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AmtinAcct = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FedBenefitsOverLookback = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmtOnHold = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AcctNotes = table.Column<string>(type: "varchar(4500)", unicode: false, maxLength: 4500, nullable: true),
                    ProtectedAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmtOnHold = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AcctHolderName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ExemptionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CaseWritId = table.Column<int>(type: "int", nullable: false),
                    AcctStatusLid = table.Column<int>(type: "int", nullable: true),
                    AcctStylingLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseWritFinancial", x => x.CaseWritFinancialId);
                    table.ForeignKey(
                        name: "FKCaseWritFinancialAcctStatusLid",
                        column: x => x.AcctStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritFinancialAcctStylingLid",
                        column: x => x.AcctStylingLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseWritFinancialCaseWritId",
                        column: x => x.CaseWritId,
                        principalTable: "CaseWrit",
                        principalColumn: "CaseWritId");
                });

            migrationBuilder.CreateTable(
                name: "CaseReplevin",
                columns: table => new
                {
                    CaseReplevinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LoanNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    VehicleValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VehicleMake = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VehicleModel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VehicleYear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TotalAmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UPB = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AITNO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefaultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PropAddr1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PropAddr2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PropCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PropState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    PropZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ReplevinOpenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CourtCaseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvestorLoanNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvestorName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EstimatedCollateralValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EstimatedCollateralDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    DaysDeliquentofLoan = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MonthlyPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RateofInterest = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VinNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CoDebtorLocation = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CoDebtorName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CurrentLender = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    OriginalLender = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DebtorName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DebtorAddress1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DebtorAddress2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DebtorCity = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DebtorState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DebtorZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DebtorCountyId = table.Column<int>(type: "int", nullable: true),
                    TitleCompany = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    JudgmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    JudgmentBook = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JudgmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JudgmentPage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxesDue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WhoSignedtheNote = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LPReferanceId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PlaintiffCaption = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    DefendantCaption = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    BillingMatterNum = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LocalCounselRefId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseReplevinStatusLid = table.Column<int>(type: "int", nullable: false),
                    CaseReplevinTypeLid = table.Column<int>(type: "int", nullable: false),
                    StateFiled = table.Column<int>(type: "int", nullable: true),
                    CountyFiledId = table.Column<int>(type: "int", nullable: true),
                    DefaultReasonLid = table.Column<int>(type: "int", nullable: true),
                    AssignedLocalCounsel = table.Column<int>(type: "int", nullable: true),
                    ClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    OccupancyStatusLid = table.Column<int>(type: "int", nullable: true),
                    InvestorTypeLid = table.Column<int>(type: "int", nullable: true),
                    AssignedAtty = table.Column<int>(type: "int", nullable: true),
                    AssignedPara = table.Column<int>(type: "int", nullable: true),
                    AssignedRep = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseReplevin", x => x.CaseReplevinId);
                    table.ForeignKey(
                        name: "FKCaseReplevinAssignedAtty",
                        column: x => x.AssignedAtty,
                        principalTable: "LawPracticeUser",
                        principalColumn: "LawPracticeUserId");
                    table.ForeignKey(
                        name: "FKCaseReplevinAssignedLocalCounsel",
                        column: x => x.AssignedLocalCounsel,
                        principalTable: "LocalCounsel",
                        principalColumn: "LocalCounselId");
                    table.ForeignKey(
                        name: "FKCaseReplevinAssignedPara",
                        column: x => x.AssignedPara,
                        principalTable: "LawPracticeUser",
                        principalColumn: "LawPracticeUserId");
                    table.ForeignKey(
                        name: "FKCaseReplevinAssignedRep",
                        column: x => x.AssignedRep,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKCaseReplevinClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseReplevinClosedReasonLid",
                        column: x => x.ClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseReplevinCountyFiledId",
                        column: x => x.CountyFiledId,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                    table.ForeignKey(
                        name: "FKCaseReplevinDebtorCountyId",
                        column: x => x.DebtorCountyId,
                        principalTable: "CaseCounty",
                        principalColumn: "CaseCountyId");
                    table.ForeignKey(
                        name: "FKCaseReplevinDefaultReasonLid",
                        column: x => x.DefaultReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseReplevinDivisionId",
                        column: x => x.DivisionId,
                        principalTable: "CaseDistrict",
                        principalColumn: "CaseDistrictId");
                    table.ForeignKey(
                        name: "FKCaseReplevinInvestorTypeLid",
                        column: x => x.InvestorTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseReplevinOccupancyStatusLid",
                        column: x => x.OccupancyStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseReplevinStateFiled",
                        column: x => x.StateFiled,
                        principalTable: "CaseState",
                        principalColumn: "CaseStateId");
                    table.ForeignKey(
                        name: "FKCaseReplevinStatusLid",
                        column: x => x.CaseReplevinStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseReplevinTypeLid",
                        column: x => x.CaseReplevinTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseSubpoena",
                columns: table => new
                {
                    CaseSubpoenaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenedDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    LPReferenceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CourtCaseNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NegotiatedDueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountyId = table.Column<int>(type: "int", nullable: true),
                    HoldReasons = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SubpoenaFormNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    LawPracticeId = table.Column<int>(type: "int", nullable: false),
                    CaseSubpoenaStatusLid = table.Column<int>(type: "int", nullable: false),
                    CaseSubpoenaTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseSubpoenaSubTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseSubpoenaClosedReasonLid = table.Column<int>(type: "int", nullable: true),
                    CaseSubpoenaPCIDataIncludedLid = table.Column<int>(type: "int", nullable: true),
                    CaseSubpoenaDocTransmissionMethodLid = table.Column<int>(type: "int", nullable: true),
                    TriageMSRSpecialistId = table.Column<int>(type: "int", nullable: true),
                    ServicingMSRSpecialistId = table.Column<int>(type: "int", nullable: false),
                    CertificationMSRSpecialistId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseSubpoena", x => x.CaseSubpoenaId);
                    table.ForeignKey(
                        name: "FKCaseSubpoenaClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaClosedReasonLid",
                        column: x => x.CaseSubpoenaClosedReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaDocTransmissionMethodLid",
                        column: x => x.CaseSubpoenaDocTransmissionMethodLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaPCIDataIncludedLid",
                        column: x => x.CaseSubpoenaPCIDataIncludedLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaStatusLid",
                        column: x => x.CaseSubpoenaStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaSubTypeLid",
                        column: x => x.CaseSubpoenaSubTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaTypeLid",
                        column: x => x.CaseSubpoenaTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKLoginDetailJobListingCaseSubpoena",
                        column: x => x.TriageMSRSpecialistId,
                        principalTable: "LoginDetailJobListing",
                        principalColumn: "LoginDetailJobListingId");
                    table.ForeignKey(
                        name: "FKLoginDetailJobListingCertificationMSRSpecialistId",
                        column: x => x.CertificationMSRSpecialistId,
                        principalTable: "LoginDetailJobListing",
                        principalColumn: "LoginDetailJobListingId");
                    table.ForeignKey(
                        name: "FKLoginDetailJobListingServicingMSRSpecialistId",
                        column: x => x.ServicingMSRSpecialistId,
                        principalTable: "LoginDetailJobListing",
                        principalColumn: "LoginDetailJobListingId");
                });

            migrationBuilder.CreateTable(
                name: "LogonDetailsAssignmentPoolTask",
                columns: table => new
                {
                    LogonDetailsAssignmentPoolTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogonDetailsAssignmentPoolId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKLogonDetailsAssignmentPoolTask", x => x.LogonDetailsAssignmentPoolTaskId);
                    table.ForeignKey(
                        name: "FKLogonDetailsAssignmentPoolTaskClientAssignmentTaskId",
                        column: x => x.ClientAssignmentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                    table.ForeignKey(
                        name: "FKLogonDetailsAssignmentPoolTaskLogonDetailsAssignmentPoolId",
                        column: x => x.LogonDetailsAssignmentPoolId,
                        principalTable: "LogonDetailsAssignmentPool",
                        principalColumn: "LogonDetailsAssignmentPoolId");
                });

            migrationBuilder.CreateTable(
                name: "CaseSalePubCost",
                columns: table => new
                {
                    CaseSalePubCostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseSaleId = table.Column<int>(type: "int", nullable: true),
                    PubDate = table.Column<DateTime>(type: "date", nullable: true),
                    PubCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseSalePubCost", x => x.CaseSalePubCostId);
                    table.ForeignKey(
                        name: "FK__CaseSalePubCosts__CaseSaleId",
                        column: x => x.CaseSaleId,
                        principalTable: "CaseSale",
                        principalColumn: "CaseSaleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseSalePubDate",
                columns: table => new
                {
                    CaseSalePubDateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseSaleId = table.Column<int>(type: "int", nullable: false),
                    PubDate = table.Column<DateTime>(type: "date", nullable: false),
                    RunOrder = table.Column<int>(type: "int", nullable: false),
                    PubCompany = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseSalePubDate", x => x.CaseSalePubDateId);
                    table.ForeignKey(
                        name: "FK__CaseSalePubDates__CaseSaleId",
                        column: x => x.CaseSaleId,
                        principalTable: "CaseSale",
                        principalColumn: "CaseSaleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseSubpoenaOrderInfo",
                columns: table => new
                {
                    CaseSubpoenaOrderInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InformationReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InformationRequestedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InformationRequestedComment = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    InformationRequestedStatusComment = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AdditionalComments = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AccountNumber = table.Column<int>(type: "int", nullable: true),
                    IntegrationId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CaseSubpoenaId = table.Column<int>(type: "int", nullable: false),
                    InformationRequestedLid = table.Column<int>(type: "int", nullable: true),
                    InformationRequestedStatusLid = table.Column<int>(type: "int", nullable: true),
                    IsOrderAskingForRecordsLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseSubpoenaOrderInfo", x => x.CaseSubpoenaOrderInfoId);
                    table.ForeignKey(
                        name: "FKCaseSubpoenaOrderInfoCaseSubpoenaId",
                        column: x => x.CaseSubpoenaId,
                        principalTable: "CaseSubpoena",
                        principalColumn: "CaseSubpoenaId");
                    table.ForeignKey(
                        name: "FKCaseSubpoenaOrderInfoInformationRequestedLid",
                        column: x => x.InformationRequestedLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKInformationRequestedStatusLid",
                        column: x => x.InformationRequestedStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKIsOrderAskingForRecordsLid",
                        column: x => x.IsOrderAskingForRecordsLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseCol",
                columns: table => new
                {
                    CaseColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ClientCaseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referance = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OpenedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FiledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JudgmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastPaymentAmount = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    BeginingPrincipal = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ClaimTypeDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CourtCaseNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DefendantCap = table.Column<string>(type: "varchar(600)", unicode: false, maxLength: 600, nullable: true),
                    PlaintiffCap = table.Column<string>(type: "varchar(600)", unicode: false, maxLength: 600, nullable: true),
                    InterestRate = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    PropertyAddress1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    PropertyAddress2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PropertyCity = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    PropertyState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PropertyZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    InvestorTypeDesc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientAttyName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SOLDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DefaultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    LastAssignmentId = table.Column<int>(type: "int", nullable: true),
                    NextAssignmentId = table.Column<int>(type: "int", nullable: true),
                    CaseCOLStatusLid = table.Column<int>(type: "int", nullable: true),
                    CaseCOLCloseReasonLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseCol", x => x.CaseColId);
                    table.ForeignKey(
                        name: "FKCaseCOLClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseCOLCloseReasonLid",
                        column: x => x.CaseCOLCloseReasonLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseCOLStatusLid",
                        column: x => x.CaseCOLStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseColTransaction",
                columns: table => new
                {
                    CaseColTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionDescription = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    TransactionAmount = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    TallyCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Tally = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    appCost = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    appPrince = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    appInterest = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    appOther = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    appFees = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    PaidbyDefendantId = table.Column<int>(type: "int", nullable: true),
                    CaseCOLId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseColTransaction", x => x.CaseColTransactionId);
                    table.ForeignKey(
                        name: "FKCaseCOLTransactionCaseCOLId",
                        column: x => x.CaseCOLId,
                        principalTable: "CaseCol",
                        principalColumn: "CaseColId");
                });

            migrationBuilder.CreateTable(
                name: "CaseColDefendantBankInfo",
                columns: table => new
                {
                    CaseColDefendantBankInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RountingNumber = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    AccountNumberLast4 = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Street = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LastVerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    NameOnAccount = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    AccountTypeLId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseColDefendantBankInfo", x => x.CaseColDefendantBankInfoId);
                    table.ForeignKey(
                        name: "FKCaseCOLDefendantBankInfoAccountTypeLId",
                        column: x => x.AccountTypeLId,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseColDefendantCardInfo",
                columns: table => new
                {
                    CaseColDefendantCardInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CCNumber = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    CCNumberLast4 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    CCExpirationMM = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CCExpirationYY = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CCcvv = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    CCName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CCAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastVerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CCCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CCState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CCZipCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TransactionType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NameOnAccount = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    AccountTypeLId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseColDefendantCardInfo", x => x.CaseColDefendantCardInfoId);
                    table.ForeignKey(
                        name: "FKCaseCOLDefendantCardInfoAccountTypeLId",
                        column: x => x.AccountTypeLId,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseJobDefendant",
                columns: table => new
                {
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyTypeLid = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    DefendantName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DefendantSSN = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DefendantDOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DefendantDOD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    AddressVacant = table.Column<bool>(type: "bit", nullable: true),
                    DefendantAlius = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CurrentWorkFlowId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PartyTypeName = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    HasAlternateAddress = table.Column<bool>(type: "bit", nullable: true),
                    AttemptNum = table.Column<int>(type: "int", nullable: false),
                    IsInternationalAddress = table.Column<bool>(type: "bit", nullable: true),
                    StopMailToDefendant = table.Column<bool>(type: "bit", nullable: true),
                    IntegrationId3 = table.Column<int>(type: "int", nullable: true),
                    FaxNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PacerSearchDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PacerSearchResults = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    PacerDocumentId = table.Column<int>(type: "int", nullable: true),
                    ServiceTypeLid = table.Column<int>(type: "int", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceAddress1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ServiceAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ServiceCity = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceState = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ServiceZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SameasPropertyAddress = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BusinessPhoneNum = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RequestorOrganizationLid = table.Column<int>(type: "int", nullable: true),
                    OrganizationName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CaseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DefendantSSN4 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    IntegrationId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseJobDefendantAttyId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJobDefendant", x => x.CaseJobDefendantId);
                    table.ForeignKey(
                        name: "FKCaseJobDefendantAttyId",
                        column: x => x.CaseJobDefendantAttyId,
                        principalTable: "CaseJobDefendantAtty",
                        principalColumn: "CaseJobDefendantAttyId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantPartyTypeLid",
                        column: x => x.PartyTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantRequestorOrganizationLid",
                        column: x => x.RequestorOrganizationLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantServiceTypeLid",
                        column: x => x.ServiceTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseJobDefendantAdditionalAddress",
                columns: table => new
                {
                    CaseJobDefendantAdditionalAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: false),
                    Address2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StateId = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Zip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsInternational = table.Column<bool>(type: "bit", nullable: false),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJobDefendantAdditionalAddress", x => x.CaseJobDefendantAdditionalAddressId);
                    table.ForeignKey(
                        name: "FKCaseJobDefendantAdditionalAddressCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                });

            migrationBuilder.CreateTable(
                name: "CaseJobDefendantByVirtueOf",
                columns: table => new
                {
                    CaseJobDefendantByVirtueOfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    ByVirtueOfLid = table.Column<int>(type: "int", nullable: false),
                    Book = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Page = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Instrument = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJobDefendantByVirtueOf", x => x.CaseJobDefendantByVirtueOfId);
                    table.ForeignKey(
                        name: "FKCaseJobDefendantByVirtueOfByVirtueOfLid",
                        column: x => x.ByVirtueOfLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantByVirtueOfCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                });

            migrationBuilder.CreateTable(
                name: "DefendantAddress",
                columns: table => new
                {
                    DefendantAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressIsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    Address1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Address2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    State = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Zip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ServedAtThisAddress = table.Column<bool>(type: "bit", nullable: false),
                    ServiceDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    NotFoundAtAddress = table.Column<bool>(type: "bit", nullable: false),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKDefendantAddress", x => x.DefendantAddressId);
                    table.ForeignKey(
                        name: "FKDefendantAddressCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                });

            migrationBuilder.CreateTable(
                name: "CaseJobDefendantSearchHistory",
                columns: table => new
                {
                    CaseJobDefendantSearchHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CameFrom = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    SentOutDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    SendOutRequest = table.Column<string>(type: "xml", nullable: true),
                    ResponseReceivedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseReceived = table.Column<string>(type: "xml", nullable: true),
                    CameFromAssignmentId = table.Column<int>(type: "int", nullable: true),
                    CaseJobDefendantSearchTypeLid = table.Column<int>(type: "int", nullable: false),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJobDefendantSearchHistory", x => x.CaseJobDefendantSearchHistoryId);
                    table.ForeignKey(
                        name: "FKCaseJobDefendantSearchHistoryCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantSearchHistoryCaseJobDefendantSearchTypeLid",
                        column: x => x.CaseJobDefendantSearchTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseJobDefendantService",
                columns: table => new
                {
                    CaseJobDefendantServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LPDefendantId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    LPKey1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DefendantWorkFlowKey = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DefendantAlius = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DefendantName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ServiceAddressId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((-1))"),
                    ServiceComplete = table.Column<bool>(type: "bit", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceNotAble = table.Column<bool>(type: "bit", nullable: true),
                    Notes = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    AddressVacant = table.Column<bool>(type: "bit", nullable: true),
                    isMobileHome = table.Column<bool>(type: "bit", nullable: true),
                    isMultiPlex = table.Column<bool>(type: "bit", nullable: true),
                    ServiceDefaultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceTTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentWorkFlowId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((-1))"),
                    ServiceAnswerDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    ServiceStatusLid = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeLid = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseJobDefendantService", x => x.CaseJobDefendantServiceId);
                    table.ForeignKey(
                        name: "FKCaseJobDefendantServiceCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantServiceDocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantServiceServiceStatusLid",
                        column: x => x.ServiceStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseJobDefendantServiceServiceTypeLid",
                        column: x => x.ServiceTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitle",
                columns: table => new
                {
                    CaseTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastPreparedBy = table.Column<int>(type: "int", nullable: true),
                    PreparedBy = table.Column<int>(type: "int", nullable: true),
                    LastPreparedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PreparedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueOnSale = table.Column<bool>(type: "bit", nullable: true),
                    TitleClaims = table.Column<bool>(type: "bit", nullable: true),
                    OpenLp = table.Column<bool>(type: "bit", nullable: true),
                    NonForeclosableLiens = table.Column<bool>(type: "bit", nullable: true),
                    NonForeclosableLiensDetail = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    OpenLpDetail = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    TitleClaimsDetail = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    MobileHomeDescription = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    MobileHomeDescriptionVarified = table.Column<bool>(type: "bit", nullable: true),
                    TitleTypeOfMortgage = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    isMultiplex = table.Column<bool>(type: "bit", nullable: true),
                    WhoSignedMortgage = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    WhoSignedNote = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LegalDescriptionIsGood = table.Column<bool>(type: "bit", nullable: true),
                    InconsistantDates = table.Column<bool>(type: "bit", nullable: true),
                    IsHomesteded = table.Column<bool>(type: "bit", nullable: true),
                    isMobilehome = table.Column<bool>(type: "bit", nullable: true),
                    isTaxRoll = table.Column<bool>(type: "bit", nullable: true),
                    ValidUntiDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastTISGeneratedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastTISGeneratedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GenrlNotes = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    NeedsReformation = table.Column<bool>(type: "bit", nullable: true),
                    NeedsReformationReason = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HasDelinquentTaxes = table.Column<bool>(type: "bit", nullable: true),
                    HasAssignments = table.Column<bool>(type: "bit", nullable: true),
                    HasMERSAssignment = table.Column<bool>(type: "bit", nullable: true),
                    PropelID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxDeedApp = table.Column<bool>(type: "bit", nullable: true),
                    TasSaleSched = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SuperiorLiens = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    GalNeeded = table.Column<bool>(type: "bit", nullable: true),
                    ProbateNeeded = table.Column<bool>(type: "bit", nullable: true),
                    TitleClaimBody = table.Column<string>(type: "varchar(2500)", unicode: false, maxLength: 2500, nullable: true),
                    TitleClaimPolicyNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NJLot = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NJBlock = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NJQualifier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ModificationParaReviewed = table.Column<bool>(type: "bit", nullable: true),
                    DeedType = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DeedGrantor = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    DeedGrantee = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    DeedBook = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeedPage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeedIntrumentNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeedRecordedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeedReRecordedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeedReRecBook = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeedReRecPage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeedReRecIntrumentNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NumberOfUnits = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    TaxId = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PropertyDistrictLID = table.Column<int>(type: "int", nullable: true),
                    TitleLegalDescription = table.Column<string>(type: "text", nullable: true),
                    TitleMortgagee = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TitleMortgagor = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TitleMortExecutedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TitleMortRecordedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TitleMortBook = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    TitleMortPage = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    TitleMortInstrumentNum = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    TitleUnderWriter = table.Column<int>(type: "int", nullable: true),
                    ChainofTitleInfoDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MortLegalDescriptionError = table.Column<string>(type: "text", nullable: true),
                    LeinLegalDescriptionError = table.Column<string>(type: "text", nullable: true),
                    OrderType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProductType = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    IntegrationId1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ServiceType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CaseFCLId = table.Column<int>(type: "int", nullable: false),
                    MortgagePositionLid = table.Column<int>(type: "int", nullable: true),
                    CurrentTISDocId = table.Column<int>(type: "int", nullable: true),
                    TitleCompanyLid = table.Column<int>(type: "int", nullable: true),
                    TypeOfMortLid = table.Column<int>(type: "int", nullable: true),
                    UnderwriterLid = table.Column<int>(type: "int", nullable: true),
                    CaseTitleStatusLid = table.Column<int>(type: "int", nullable: true),
                    ClientInvestorTypeLid = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitle", x => x.CaseTitleId);
                    table.ForeignKey(
                        name: "FKCaseTitleCaseFCLId",
                        column: x => x.CaseFCLId,
                        principalTable: "CaseFcl",
                        principalColumn: "CaseFclId");
                    table.ForeignKey(
                        name: "FKCaseTitleCaseTitleStatusLid",
                        column: x => x.CaseTitleStatusLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseTitleCaseTitleUnderWriterId",
                        column: x => x.TitleUnderWriter,
                        principalTable: "CaseTitleUnderWriter",
                        principalColumn: "CaseTitleUnderWriterId");
                    table.ForeignKey(
                        name: "FKCaseTitleClientInvestorTypeLid",
                        column: x => x.ClientInvestorTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseTitleMortgagePositionLid",
                        column: x => x.MortgagePositionLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseTitleTitleCompanyLid",
                        column: x => x.TitleCompanyLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseTitleTypeOfMortLid",
                        column: x => x.TypeOfMortLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKCaseTitleUnderwriterLid",
                        column: x => x.UnderwriterLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleAssignment",
                columns: table => new
                {
                    CaseTitleAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingFee = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    AssigmCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    AssignedTo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecievedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecievedBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DueOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    CompletedBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StoppedBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    StoppedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StoppedReason = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AssignmentTypeCode = table.Column<int>(type: "int", nullable: true),
                    AOMExecutedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleAssignment", x => x.CaseTitleAssignmentId);
                    table.ForeignKey(
                        name: "FKCaseTitleAssignmentCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleDlinqTax",
                columns: table => new
                {
                    CaseTitleDlinqTaxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForYear = table.Column<int>(type: "int", nullable: false),
                    TaxId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxGoodUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleDlinqTax", x => x.CaseTitleDlinqTaxId);
                    table.ForeignKey(
                        name: "FKCaseTitleDlinqTaxCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleFileAssign",
                columns: table => new
                {
                    CaseTitleFileAssignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignFrom = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    AssignTo = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InstrumentNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Book = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Page = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleFileAssign", x => x.CaseTitleFileAssignId);
                    table.ForeignKey(
                        name: "FKCaseTitleFileAssignCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleIrstaxLien",
                columns: table => new
                {
                    CaseTitleIrstaxLienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FileBy = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FileAgainst = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LienAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LienDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LienRecordDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Volume = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Page = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    SSNTaxID = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    IRSFormNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssessmentEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PendingTitleIssueInd = table.Column<bool>(type: "bit", nullable: true),
                    ClaimFileDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleIrstaxLien", x => x.CaseTitleIrstaxLienId);
                    table.ForeignKey(
                        name: "FKCaseTitleIRSTaxLienCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleJudgmentLien",
                columns: table => new
                {
                    CaseTitleJudgmentLienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FileBy = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AttachmentAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AttachmentRecordDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentVolume = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    AttachmentPage = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    LienDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JudgmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JudgmentDamageAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    JudgmentCostAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LienRecordDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Volume = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Page = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PendingTitleIssueInd = table.Column<bool>(type: "bit", nullable: true),
                    ClaimFileDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleJudgmentLien", x => x.CaseTitleJudgmentLienId);
                    table.ForeignKey(
                        name: "FKCaseTitleJudgmentLienCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleModParagraph",
                columns: table => new
                {
                    CaseTitleModParagraphId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Book = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Page = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Intrument = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UnrecordedMod = table.Column<bool>(type: "bit", nullable: false),
                    UnRecordedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModificationAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleModParagraph", x => x.CaseTitleModParagraphId);
                    table.ForeignKey(
                        name: "FKCaseTitleModParagraphCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleMortgTaxLien",
                columns: table => new
                {
                    CaseTitleMortgTaxLienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FileBy = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LienAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LienDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LienRecordDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Volume = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Page = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PendingTitleIssueInd = table.Column<bool>(type: "bit", nullable: true),
                    ClaimFileDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LienTypeLid = table.Column<int>(type: "int", nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleMortgTaxLien", x => x.CaseTitleMortgTaxLienId);
                    table.ForeignKey(
                        name: "FKCaseTitleMortgTaxLienCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                    table.ForeignKey(
                        name: "FKCaseTitleMortgTaxLienLienTypeLid",
                        column: x => x.LienTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleMortgWithAssignment",
                columns: table => new
                {
                    CaseTitleMortgWithAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CurrHolder = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OrigHolder = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OrigPrincipalBal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LienDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LienRecordDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Volume = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Page = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PendingTitleIssueInd = table.Column<bool>(type: "bit", nullable: true),
                    ClaimFileDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReplacementAOM = table.Column<bool>(type: "bit", nullable: true),
                    CorrectiveAOM = table.Column<bool>(type: "bit", nullable: true),
                    Instrument = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleMortgWithAssignment", x => x.CaseTitleMortgWithAssignmentId);
                    table.ForeignKey(
                        name: "FKCaseTitleMortgWithAssignmentCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleReRecorded",
                columns: table => new
                {
                    CaseTitleReRecordedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReRecorderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Book = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Page = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Instrument = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleReRecorded", x => x.CaseTitleReRecordedId);
                    table.ForeignKey(
                        name: "FKCaseTitleReRecordedCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleSpecialCount",
                columns: table => new
                {
                    CaseTitleSpecialCountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSpecialCountText = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    TitleSpecialCountTitle = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ByVirtueOf = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Book = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Page = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Grantors = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Grantees = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CaseTitleId = table.Column<int>(type: "int", nullable: false),
                    CaseTitleSpecialCountTemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleSpecialCount", x => x.CaseTitleSpecialCountId);
                    table.ForeignKey(
                        name: "FKCaseTitleSpecialCountCaseTitleId",
                        column: x => x.CaseTitleId,
                        principalTable: "CaseTitle",
                        principalColumn: "CaseTitleId");
                    table.ForeignKey(
                        name: "FKCaseTitleSpecialCountCaseTitleSpecialCountTemplateId",
                        column: x => x.CaseTitleSpecialCountTemplateId,
                        principalTable: "CaseTitleSpecialCountTemplate",
                        principalColumn: "CaseTitleSpecialCountTemplateId");
                });

            migrationBuilder.CreateTable(
                name: "CaseTitleAssignmentItem",
                columns: table => new
                {
                    CaseTitleAssignmentItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAssignmentDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TitleAssignmentCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    TitleAssignmentFee = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DefaultDaysToComplete = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CaseTitleAssignmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCaseTitleAssignmentItem", x => x.CaseTitleAssignmentItemId);
                    table.ForeignKey(
                        name: "FKCaseTitleAssignmentItemCaseTitleAssignmentId",
                        column: x => x.CaseTitleAssignmentId,
                        principalTable: "CaseTitleAssignment",
                        principalColumn: "CaseTitleAssignmentId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignment",
                columns: table => new
                {
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedByAssignmentId = table.Column<int>(type: "int", nullable: true),
                    ParentAssignmentId = table.Column<int>(type: "int", nullable: false),
                    ChainCompletedAssignmentId = table.Column<int>(type: "int", nullable: true),
                    ClientDepartmentId = table.Column<int>(type: "int", nullable: false),
                    TargetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedNote = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedBy = table.Column<int>(type: "int", nullable: true),
                    CompleteNotes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReprojectedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportectedVersion = table.Column<int>(type: "int", nullable: true),
                    AssignedDepartmentId = table.Column<int>(type: "int", nullable: true),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgressNotes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    IntegrationId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IntegrationKey = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IntegrationOther = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastAccessedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChainCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTasksOnComplete = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CheckDupesonChainComplete = table.Column<bool>(type: "bit", nullable: true),
                    ChainEventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SnoozeUntilDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AutomationId1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    AutomationId2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    VoidedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isVoided = table.Column<bool>(type: "bit", nullable: true),
                    SendtoServicer = table.Column<bool>(type: "bit", nullable: true),
                    IsInProgress = table.Column<bool>(type: "bit", nullable: true),
                    EventType = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EventAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    AssociatedMileStones = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ExtensionDuration = table.Column<int>(type: "int", nullable: true),
                    IsExtensionEvent = table.Column<bool>(type: "bit", nullable: true),
                    IsCarveOut = table.Column<bool>(type: "bit", nullable: true),
                    IsBillableEvent = table.Column<bool>(type: "bit", nullable: true),
                    AttyCompleteCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AttyCompleteCodeEnteredOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttyCompleteCodeIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttyCompleteCodeEnc = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ClientAssignmentTaskId = table.Column<int>(type: "int", nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    ReprojectedBy = table.Column<int>(type: "int", nullable: true),
                    StartedDocumentRepositoryId = table.Column<int>(type: "int", nullable: true),
                    CompleteDocumentRepositoryId = table.Column<int>(type: "int", nullable: true),
                    AssignedTo = table.Column<int>(type: "int", nullable: true),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: true),
                    LastAccessBy = table.Column<int>(type: "int", nullable: true),
                    ChainCompletedBy = table.Column<int>(type: "int", nullable: true),
                    VoidedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignment", x => x.ClientAssignmentId);
                    table.ForeignKey(
                        name: "FKClientAssignmentAssignedTo",
                        column: x => x.AssignedTo,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                    table.ForeignKey(
                        name: "FKClientAssignmentChainCompletedBy",
                        column: x => x.ChainCompletedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentClientAssignmentTaskId",
                        column: x => x.ClientAssignmentTaskId,
                        principalTable: "ClientAssignmentTask",
                        principalColumn: "ClientAssignmentTaskId");
                    table.ForeignKey(
                        name: "FKClientAssignmentClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKClientAssignmentCompletedBy",
                        column: x => x.CompletedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentCreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentLastAccessBy",
                        column: x => x.LastAccessBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentReprojectedBy",
                        column: x => x.ReprojectedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentUpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentVoidedBy",
                        column: x => x.VoidedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "RefClientAssignment194",
                        column: x => x.ParentAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "RefClientAssignment208",
                        column: x => x.ChainCompletedAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "RefClientAssignment210",
                        column: x => x.StartedByAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentCheckListVr",
                columns: table => new
                {
                    ClientAssignmentCheckListVrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ValueDisplay = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ClientAssignmentTaskCheckListId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentCheckListVr", x => x.ClientAssignmentCheckListVrId);
                    table.ForeignKey(
                        name: "FKClientAssignmentCheckListVRClientAssignmentId",
                        column: x => x.ClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentCheckListVRClientAssignmentTaskCheckListId",
                        column: x => x.ClientAssignmentTaskCheckListId,
                        principalTable: "ClientAssignmentTaskCheckList",
                        principalColumn: "ClientAssignmentTaskCheckListId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentJournal",
                columns: table => new
                {
                    ClientAssignmentJournalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondCounter = table.Column<long>(type: "bigint", nullable: false),
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentJournal", x => x.ClientAssignmentJournalId);
                    table.ForeignKey(
                        name: "FKClientAssignmentJournalClientAssignmentId",
                        column: x => x.ClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentJournalLoginDetailId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentScheduled",
                columns: table => new
                {
                    ClientAssignmentScheduledId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartOnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Processed = table.Column<bool>(type: "bit", nullable: false),
                    ProcessedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessTries = table.Column<int>(type: "int", nullable: true),
                    Aborted = table.Column<bool>(type: "bit", nullable: true),
                    ClientAssignmentTaskScheduledId = table.Column<int>(type: "int", nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    FromClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: true),
                    ProcessedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentScheduled", x => x.ClientAssignmentScheduledId);
                    table.ForeignKey(
                        name: "FKClientAssignmentScheduledClientAssignmentTaskScheduledId",
                        column: x => x.ClientAssignmentTaskScheduledId,
                        principalTable: "ClientAssignmentTaskScheduled",
                        principalColumn: "ClientAssignmentTaskScheduledId");
                    table.ForeignKey(
                        name: "FKClientAssignmentScheduledClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKClientAssignmentScheduledFromClientAssignmentId",
                        column: x => x.FromClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentScheduledNewClientAssignmentId",
                        column: x => x.ClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentScheduledProcessedBy",
                        column: x => x.ProcessedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "ClientJobActivity",
                columns: table => new
                {
                    ClientJobActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionNote = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ActionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActionTargetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    ActionClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientJobActivity", x => x.ClientJobActivityId);
                    table.ForeignKey(
                        name: "FKClientJobActivityActionClientAssignmentId",
                        column: x => x.ActionClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientJobActivityClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                });

            migrationBuilder.CreateTable(
                name: "DocumentRepository",
                columns: table => new
                {
                    DocumentRepositoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NextVersionDocumentId = table.Column<int>(type: "int", nullable: true),
                    LastVersionDocumentId = table.Column<int>(type: "int", nullable: true),
                    DocumentName = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    FileLocationVirtualPath = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    FileLocationPath = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    isCurrentVersion = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    CameFrom = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsFiled = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveredToDefendantsOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    InvoiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceFulfilmentDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    LawPracticeJobId = table.Column<int>(type: "int", nullable: true),
                    BoundCaseDefendantId = table.Column<int>(type: "int", nullable: true),
                    BoundServiceDefendantId = table.Column<int>(type: "int", nullable: true),
                    DeliveryMethodLid = table.Column<int>(type: "int", nullable: true),
                    BoundAssignmentId = table.Column<int>(type: "int", nullable: true),
                    FromCheckListId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKDocumentRepository", x => x.DocumentRepositoryId);
                    table.ForeignKey(
                        name: "FKDocumentRepositoryBoundAssignmentId",
                        column: x => x.BoundAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryBoundCaseDefendantId",
                        column: x => x.BoundCaseDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryBoundServiceDefendantId",
                        column: x => x.BoundServiceDefendantId,
                        principalTable: "CaseJobDefendantService",
                        principalColumn: "CaseJobDefendantServiceId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryDeliveryMethodLid",
                        column: x => x.DeliveryMethodLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryDocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryFromCheckListId",
                        column: x => x.FromCheckListId,
                        principalTable: "ClientAssignmentTaskCheckList",
                        principalColumn: "ClientAssignmentTaskCheckListId");
                    table.ForeignKey(
                        name: "FKDocumentRepositoryLawPracticeJobId",
                        column: x => x.LawPracticeJobId,
                        principalTable: "LawPracticeJob",
                        principalColumn: "LawPracticeJobId");
                    table.ForeignKey(
                        name: "RefDocumentRepository161",
                        column: x => x.LastVersionDocumentId,
                        principalTable: "DocumentRepository",
                        principalColumn: "DocumentRepositoryId");
                    table.ForeignKey(
                        name: "RefDocumentRepository162",
                        column: x => x.NextVersionDocumentId,
                        principalTable: "DocumentRepository",
                        principalColumn: "DocumentRepositoryId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentHold",
                columns: table => new
                {
                    ClientAssignmentHoldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenNote = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    CloseNote = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeniedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeniedReason = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    HoldStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoldEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    HoldingAssignmentId = table.Column<int>(type: "int", nullable: false),
                    ClientAssignmentParentId = table.Column<int>(type: "int", nullable: false),
                    HoldTypeLid = table.Column<int>(type: "int", nullable: false),
                    AttachmentDocumentRepositoryId = table.Column<int>(type: "int", nullable: true),
                    ApprovedById = table.Column<int>(type: "int", nullable: true),
                    LawPracticeId = table.Column<int>(type: "int", nullable: true),
                    DeniedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentHold", x => x.ClientAssignmentHoldId);
                    table.ForeignKey(
                        name: "FKAttachmentDocumentRepositoryId",
                        column: x => x.AttachmentDocumentRepositoryId,
                        principalTable: "DocumentRepository",
                        principalColumn: "DocumentRepositoryId");
                    table.ForeignKey(
                        name: "FKClientAssignmentHoldApprovedById",
                        column: x => x.ApprovedById,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentHoldClientAssignmentId",
                        column: x => x.ClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentHoldDeniedById",
                        column: x => x.DeniedById,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentHoldHoldTypeLid",
                        column: x => x.HoldTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKClientAssignmentHoldLawPracticeId",
                        column: x => x.LawPracticeId,
                        principalTable: "LawPractice",
                        principalColumn: "LawPracticeId");
                    table.ForeignKey(
                        name: "RefClientAssignment170",
                        column: x => x.ClientAssignmentParentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "RefClientAssignment171",
                        column: x => x.HoldingAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                });

            migrationBuilder.CreateTable(
                name: "ClientAssignmentReProHistory",
                columns: table => new
                {
                    ClientAssignmentReProHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReprojectedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewTargetDate = table.Column<DateTime>(type: "date", nullable: true),
                    OldTargetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reason = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SequenseNumber = table.Column<int>(type: "int", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientAssignmentId = table.Column<int>(type: "int", nullable: false),
                    ReprojectedBy = table.Column<int>(type: "int", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    DocumentRepositoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKClientAssignmentReProHistory", x => x.ClientAssignmentReProHistoryId);
                    table.ForeignKey(
                        name: "FKClientAssignmentReProHistoryApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKClientAssignmentReProHistoryClientAssignmentId",
                        column: x => x.ClientAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKClientAssignmentReProHistoryDocumentRespositoryId",
                        column: x => x.DocumentRepositoryId,
                        principalTable: "DocumentRepository",
                        principalColumn: "DocumentRepositoryId");
                    table.ForeignKey(
                        name: "FKClientAssignmentReProHistoryReprojectedBy",
                        column: x => x.ReprojectedBy,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                });

            migrationBuilder.CreateTable(
                name: "DocumentMailOutHistory",
                columns: table => new
                {
                    DocumentMailOutHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SentOutDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    VenderSentOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecipientName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    City = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    State = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Zip = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    VenderPostageAmount = table.Column<decimal>(type: "decimal(16,3)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TrackingLastEntry = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ReceiptID = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: true),
                    ProcessedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VendorPostalServiceSent = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VendorAdditionalCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VendorServiceCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VendorTotalCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsBadRecord = table.Column<bool>(type: "bit", nullable: true),
                    BadRecordMessage = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    VendorAffidavitCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsLetterImageProcessed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsInvoiceReceived = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    InvoiceNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InvoiceImageID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsInvoiceImageProcessed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    VendorPostalServiceRcvd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MailSentOutDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LetterDocID = table.Column<int>(type: "int", nullable: true),
                    InvoiceDocID = table.Column<int>(type: "int", nullable: true),
                    MasterInvoiceNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DocumentMailJobId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientJobId = table.Column<int>(type: "int", nullable: false),
                    CaseJobDefendantId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    MailServiceTypeLid = table.Column<int>(type: "int", nullable: false),
                    MailVendorLid = table.Column<int>(type: "int", nullable: false),
                    SentByAssignmentId = table.Column<int>(type: "int", nullable: true),
                    EnvelopeDocumentId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKDocumentMailOutHistory", x => x.DocumentMailOutHistoryId);
                    table.ForeignKey(
                        name: "FKDocumentMailOutHistoryCaseJobDefendantId",
                        column: x => x.CaseJobDefendantId,
                        principalTable: "CaseJobDefendant",
                        principalColumn: "CaseJobDefendantId");
                    table.ForeignKey(
                        name: "FKDocumentMailOutHistoryClientJobId",
                        column: x => x.ClientJobId,
                        principalTable: "ClientJob",
                        principalColumn: "ClientJobId");
                    table.ForeignKey(
                        name: "FKDocumentMailOutHistoryDocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId");
                    table.ForeignKey(
                        name: "FKDocumentMailOutHistoryMailServiceTypeLid",
                        column: x => x.MailServiceTypeLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKDocumentMailOutHistoryMailVendorLid",
                        column: x => x.MailVendorLid,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId");
                    table.ForeignKey(
                        name: "FKDocumentMailOutHistorySentByAssignmentId",
                        column: x => x.SentByAssignmentId,
                        principalTable: "ClientAssignment",
                        principalColumn: "ClientAssignmentId");
                    table.ForeignKey(
                        name: "FKEnvelopeDocumentId",
                        column: x => x.EnvelopeDocumentId,
                        principalTable: "DocumentRepository",
                        principalColumn: "DocumentRepositoryId");
                });

            migrationBuilder.CreateTable(
                name: "DocumentNote",
                columns: table => new
                {
                    DocumentNoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    NoteText = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    LoginDetailId = table.Column<int>(type: "int", nullable: false),
                    DocumentRepositoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKDocumentNote", x => x.DocumentNoteId);
                    table.ForeignKey(
                        name: "FKDocumentNoteByUserId",
                        column: x => x.LoginDetailId,
                        principalTable: "LoginDetail",
                        principalColumn: "LoginDetailId");
                    table.ForeignKey(
                        name: "FKDocumentNoteDocumentRepositoryId",
                        column: x => x.DocumentRepositoryId,
                        principalTable: "DocumentRepository",
                        principalColumn: "DocumentRepositoryId");
                });

            migrationBuilder.InsertData(
                table: "AppPermission",
                columns: new[] { "AppPermissionId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RegisterClient" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RegisterLawPractice" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RegisterLocalCounsel" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RegisterAdmin" }
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "AppRoleId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin" });

            migrationBuilder.CreateIndex(
                name: "FKAppRoleAppRoleLoginDetail",
                table: "AppRoleLoginDetail",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailAppRoleLoginDetail",
                table: "AppRoleLoginDetail",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "UXAppRoleLoginDetail",
                table: "AppRoleLoginDetail",
                columns: new[] { "AppRoleId", "LoginDetailId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKAppPermissionAppRolePermission",
                table: "AppRolePermission",
                column: "AppPermissionId");

            migrationBuilder.CreateIndex(
                name: "FKAppRoleAppRolePermission",
                table: "AppRolePermission",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "UXAppPermisionRole",
                table: "AppRolePermission",
                columns: new[] { "AppPermissionId", "AppRoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKBKRCaseSummaryCaseBKRId",
                table: "BkrCaseSummary",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRConditionalOrderCaseBKRId",
                table: "BkrConditionalOrder",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRFinancialCaseBKRId",
                table: "BkrFinancial",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRFinInstallmentCaseBKRId",
                table: "BkrFinInstallment",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRFinInterestRateCaseBKRId",
                table: "BkrFinInterestRate",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRFinMissedPaymentCaseBKRId",
                table: "BkrFinMissedPayment",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRFinOtherCostCaseBKRId",
                table: "BkrFinOtherCost",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRFinOtherCostCostDecriptionLid",
                table: "BkrFinOtherCost",
                column: "CostDecriptionLid");

            migrationBuilder.CreateIndex(
                name: "FKBKRJournalCaseBKRId",
                table: "BkrJournal",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRLoanModificationCaseBKRId",
                table: "BkrLoanModification",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRMFRCaseBKRId",
                table: "BkrMfr",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRPaymentChangeCaseBKRId",
                table: "BkrPaymentChange",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKBKRPropertyCaseBKRId",
                table: "BkrProperty",
                column: "CaseBKRId");

            migrationBuilder.CreateIndex(
                name: "FKCaseAutoAssignedCSRLid",
                table: "CaseAuto",
                column: "AssignedCSRLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseAutoClientJobId",
                table: "CaseAuto",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseAutoClosedReasonLid",
                table: "CaseAuto",
                column: "ClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseAutoStatusLid",
                table: "CaseAuto",
                column: "CaseAutoStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseAutoVehicleStatusLid",
                table: "CaseAuto",
                column: "VehicleStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseAutoBuyerInfoCaseAutoId",
                table: "CaseAutoBuyerInfo",
                column: "CaseAutoId");

            migrationBuilder.CreateIndex(
                name: "FKBKRSOLLid",
                table: "CaseBkr",
                column: "BKRSOLLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseBKRBKRDistrictId",
                table: "CaseBkr",
                column: "BKRDistrictId");

            migrationBuilder.CreateIndex(
                name: "FKCaseBKRClientInvestorLid",
                table: "CaseBkr",
                column: "CaseBKRClientInvestorLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseBKRClientInvestorTypeLid",
                table: "CaseBkr",
                column: "CaseBKRClientInvestorTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseBKRClientJobId",
                table: "CaseBkr",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseBKRStatusLid",
                table: "CaseBkr",
                column: "CaseBKRStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseBKRTypeLid",
                table: "CaseBkr",
                column: "CaseBKRTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCircuitLid",
                table: "CaseBkr",
                column: "BKRCircuitLid");

            migrationBuilder.CreateIndex(
                name: "FKClosedReasonLid",
                table: "CaseBkr",
                column: "ClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLClientJobId",
                table: "CaseCol",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLCloseReasonLid",
                table: "CaseCol",
                column: "CaseCOLCloseReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLLastAssignmentId",
                table: "CaseCol",
                column: "LastAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLNextAssignmentId",
                table: "CaseCol",
                column: "NextAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLStatusLid",
                table: "CaseCol",
                column: "CaseCOLStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLDefendantBankInfoAccountTypeLId",
                table: "CaseColDefendantBankInfo",
                column: "AccountTypeLId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLDefendantBankInfoCaseJobDefendantId",
                table: "CaseColDefendantBankInfo",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLDefendantCardInfoAccountTypeLId",
                table: "CaseColDefendantCardInfo",
                column: "AccountTypeLId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLDefendantCardInfoCaseJobDefendantId",
                table: "CaseColDefendantCardInfo",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCOLTransactionCaseCOLId",
                table: "CaseColTransaction",
                column: "CaseCOLId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCommentCaseId",
                table: "CaseComment",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCommentClientJobId",
                table: "CaseComment",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCommentCommentTypeLid",
                table: "CaseComment",
                column: "CommentTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseCommentWhiteboardCaseId",
                table: "CaseCommentWhiteboard",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCommentWhiteboardClientJobId",
                table: "CaseCommentWhiteboard",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCommentWhiteboardCommentTypeLid",
                table: "CaseCommentWhiteboard",
                column: "CommentTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseCountyCaseStateId",
                table: "CaseCounty",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCourtCaseCountyId",
                table: "CaseCourt",
                column: "CaseCountyId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCourtCaseDistrictId",
                table: "CaseCourt",
                column: "CaseDistrictId");

            migrationBuilder.CreateIndex(
                name: "FKCaseCourtCourtType",
                table: "CaseCourt",
                column: "CourtTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseDistrictCaseStateId",
                table: "CaseDistrict",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionCaseCountyId",
                table: "CaseEviction",
                column: "CaseCountyId");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionCaseDistrictId",
                table: "CaseEviction",
                column: "CaseDistrictId");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionCaseJudgeId",
                table: "CaseEviction",
                column: "CaseJudgeId");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionCircuitLid",
                table: "CaseEviction",
                column: "CircuitLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionClientJobId",
                table: "CaseEviction",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionClosedReasonLid",
                table: "CaseEviction",
                column: "ClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionDivisionLid",
                table: "CaseEviction",
                column: "DivisionLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionEvictionStatusLid",
                table: "CaseEviction",
                column: "EvictionStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionEvictionTypeLid",
                table: "CaseEviction",
                column: "EvictionTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionJournalCaseEvictionId",
                table: "CaseEvictionJournal",
                column: "CaseEvictionId");

            migrationBuilder.CreateIndex(
                name: "FKCaseEvictionJournalLoginDetailId",
                table: "CaseEvictionJournal",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLCaseJudgeId",
                table: "CaseFcl",
                column: "CaseJudgeId");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLCaseTypeLid",
                table: "CaseFcl",
                column: "CaseFCLCaseTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLClientInvestorTypeLid",
                table: "CaseFcl",
                column: "CaseFCLClientInvestorTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLClientJobId",
                table: "CaseFcl",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLClosedReasonLid",
                table: "CaseFcl",
                column: "CaseFCLClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLCountyFiled",
                table: "CaseFcl",
                column: "CountyFiled");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLPropertyTypeLid",
                table: "CaseFcl",
                column: "CaseFCLPropertyTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLStateFiled",
                table: "CaseFcl",
                column: "StateFiled");

            migrationBuilder.CreateIndex(
                name: "FKCaseFCLStatusLid",
                table: "CaseFcl",
                column: "CaseFCLStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantAttyId",
                table: "CaseJobDefendant",
                column: "CaseJobDefendantAttyId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantClientJobId",
                table: "CaseJobDefendant",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantPacerDocumentId",
                table: "CaseJobDefendant",
                column: "PacerDocumentId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantPartyTypeLid",
                table: "CaseJobDefendant",
                column: "PartyTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantRequestorOrganizationLid",
                table: "CaseJobDefendant",
                column: "RequestorOrganizationLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantServiceTypeLid",
                table: "CaseJobDefendant",
                column: "ServiceTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantAdditionalAddressCaseJobDefendantId",
                table: "CaseJobDefendantAdditionalAddress",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantByVirtueOfByVirtueOfLid",
                table: "CaseJobDefendantByVirtueOf",
                column: "ByVirtueOfLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantByVirtueOfCaseJobDefendantId",
                table: "CaseJobDefendantByVirtueOf",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantSearchHistoryCameFromAssignmentId",
                table: "CaseJobDefendantSearchHistory",
                column: "CameFromAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantSearchHistoryCaseJobDefendantId",
                table: "CaseJobDefendantSearchHistory",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantSearchHistoryCaseJobDefendantSearchTypeLid",
                table: "CaseJobDefendantSearchHistory",
                column: "CaseJobDefendantSearchTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantServiceCaseJobDefendantId",
                table: "CaseJobDefendantService",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantServiceClientAssignmentId",
                table: "CaseJobDefendantService",
                column: "ClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantServiceDocumentTypeId",
                table: "CaseJobDefendantService",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantServiceServiceStatusLid",
                table: "CaseJobDefendantService",
                column: "ServiceStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJobDefendantServiceServiceTypeLid",
                table: "CaseJobDefendantService",
                column: "ServiceTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseJudgeCaseCourtId",
                table: "CaseJudge",
                column: "CaseCourtId");

            migrationBuilder.CreateIndex(
                name: "FKCaseClientId",
                table: "CaseMaster",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKCaseMasterCaseCountyId",
                table: "CaseMaster",
                column: "CaseCountyId");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinAssignedAtty",
                table: "CaseReplevin",
                column: "AssignedAtty");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinAssignedLocalCounsel",
                table: "CaseReplevin",
                column: "AssignedLocalCounsel");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinAssignedPara",
                table: "CaseReplevin",
                column: "AssignedPara");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinAssignedRep",
                table: "CaseReplevin",
                column: "AssignedRep");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinClientJobId",
                table: "CaseReplevin",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinClosedReasonLid",
                table: "CaseReplevin",
                column: "ClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinCountyFiledId",
                table: "CaseReplevin",
                column: "CountyFiledId");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinDebtorCountyId",
                table: "CaseReplevin",
                column: "DebtorCountyId");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinDefaultReasonLid",
                table: "CaseReplevin",
                column: "DefaultReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinDivisionId",
                table: "CaseReplevin",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinInvestorTypeLid",
                table: "CaseReplevin",
                column: "InvestorTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinOccupancyStatusLid",
                table: "CaseReplevin",
                column: "OccupancyStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinStateFiled",
                table: "CaseReplevin",
                column: "StateFiled");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinStatusLid",
                table: "CaseReplevin",
                column: "CaseReplevinStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseReplevinTypeLid",
                table: "CaseReplevin",
                column: "CaseReplevinTypeLid");

            migrationBuilder.CreateIndex(
                name: "FK__CaseSale__CaseFCLId",
                table: "CaseSale",
                column: "CaseFCLId");

            migrationBuilder.CreateIndex(
                name: "FKCaseSaleCancelReasonLid",
                table: "CaseSale",
                column: "CancelReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSaleRescheduleReasonLid",
                table: "CaseSale",
                column: "RescheduleReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSaleStatusLid",
                table: "CaseSale",
                column: "CaseSaleStatusLid");

            migrationBuilder.CreateIndex(
                name: "FK__CaseSalePubCosts__CaseSaleId",
                table: "CaseSalePubCost",
                column: "CaseSaleId");

            migrationBuilder.CreateIndex(
                name: "FK__CaseSalePubDates__CaseSaleId",
                table: "CaseSalePubDate",
                column: "CaseSaleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaClientJobId",
                table: "CaseSubpoena",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaClosedReasonLid",
                table: "CaseSubpoena",
                column: "CaseSubpoenaClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaDocTransmissionMethodLid",
                table: "CaseSubpoena",
                column: "CaseSubpoenaDocTransmissionMethodLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaLawPracticeId",
                table: "CaseSubpoena",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaPCIDataIncludedLid",
                table: "CaseSubpoena",
                column: "CaseSubpoenaPCIDataIncludedLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaStatusLid",
                table: "CaseSubpoena",
                column: "CaseSubpoenaStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaSubTypeLid",
                table: "CaseSubpoena",
                column: "CaseSubpoenaSubTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaTypeLid",
                table: "CaseSubpoena",
                column: "CaseSubpoenaTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailJobListingCaseSubpoena",
                table: "CaseSubpoena",
                column: "TriageMSRSpecialistId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailJobListingCertificationMSRSpecialistId",
                table: "CaseSubpoena",
                column: "CertificationMSRSpecialistId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailJobListingServicingMSRSpecialistId",
                table: "CaseSubpoena",
                column: "ServicingMSRSpecialistId");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaOrderInfoCaseSubpoenaId",
                table: "CaseSubpoenaOrderInfo",
                column: "CaseSubpoenaId");

            migrationBuilder.CreateIndex(
                name: "FKCaseSubpoenaOrderInfoInformationRequestedLid",
                table: "CaseSubpoenaOrderInfo",
                column: "InformationRequestedLid");

            migrationBuilder.CreateIndex(
                name: "FKInformationRequestedStatusLid",
                table: "CaseSubpoenaOrderInfo",
                column: "InformationRequestedStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKIsOrderAskingForRecordsLid",
                table: "CaseSubpoenaOrderInfo",
                column: "IsOrderAskingForRecordsLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleCaseFCLId",
                table: "CaseTitle",
                column: "CaseFCLId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleCaseTitleStatusLid",
                table: "CaseTitle",
                column: "CaseTitleStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleCaseTitleUnderWriterId",
                table: "CaseTitle",
                column: "TitleUnderWriter");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleClientInvestorTypeLid",
                table: "CaseTitle",
                column: "ClientInvestorTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleCurrentTISDocId",
                table: "CaseTitle",
                column: "CurrentTISDocId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleMortgagePositionLid",
                table: "CaseTitle",
                column: "MortgagePositionLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleTitleCompanyLid",
                table: "CaseTitle",
                column: "TitleCompanyLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleTypeOfMortLid",
                table: "CaseTitle",
                column: "TypeOfMortLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleUnderwriterLid",
                table: "CaseTitle",
                column: "UnderwriterLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleAssignmentCaseTitleId",
                table: "CaseTitleAssignment",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleAssignmentItemCaseTitleAssignmentId",
                table: "CaseTitleAssignmentItem",
                column: "CaseTitleAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleDlinqTaxCaseTitleId",
                table: "CaseTitleDlinqTax",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleFileAssignCaseTitleId",
                table: "CaseTitleFileAssign",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleIRSTaxLienCaseTitleId",
                table: "CaseTitleIrstaxLien",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleJudgmentLienCaseTitleId",
                table: "CaseTitleJudgmentLien",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleModParagraphCaseTitleId",
                table: "CaseTitleModParagraph",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleMortgTaxLienCaseTitleId",
                table: "CaseTitleMortgTaxLien",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleMortgTaxLienLienTypeLid",
                table: "CaseTitleMortgTaxLien",
                column: "LienTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleMortgWithAssignmentCaseTitleId",
                table: "CaseTitleMortgWithAssignment",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleReRecordedCaseTitleId",
                table: "CaseTitleReRecorded",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleSpecialCountCaseTitleId",
                table: "CaseTitleSpecialCount",
                column: "CaseTitleId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleSpecialCountCaseTitleSpecialCountTemplateId",
                table: "CaseTitleSpecialCount",
                column: "CaseTitleSpecialCountTemplateId");

            migrationBuilder.CreateIndex(
                name: "FKCaseTitleSpecialCountTemplateCountTypeLid",
                table: "CaseTitleSpecialCountTemplate",
                column: "CountTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritAdditionalDocumentationLid",
                table: "CaseWrit",
                column: "AdditionalDocumentationLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritCaseDetailLid",
                table: "CaseWrit",
                column: "CaseDetailLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritCaseTypeLid",
                table: "CaseWrit",
                column: "CaseTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritClientJobId",
                table: "CaseWrit",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritClosedReasonLid",
                table: "CaseWrit",
                column: "ClosedReasonLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritCountyId",
                table: "CaseWrit",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritCourtTypeId",
                table: "CaseWrit",
                column: "CourtTypeId");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritGarnisheeId",
                table: "CaseWrit",
                column: "GarnisheeId");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritRtgLid",
                table: "CaseWrit",
                column: "RtgLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritStatusLid",
                table: "CaseWrit",
                column: "CaseWritStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritFinancialAcctStatusLid",
                table: "CaseWritFinancial",
                column: "AcctStatusLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritFinancialAcctStylingLid",
                table: "CaseWritFinancial",
                column: "AcctStylingLid");

            migrationBuilder.CreateIndex(
                name: "FKCaseWritFinancialCaseWritId",
                table: "CaseWritFinancial",
                column: "CaseWritId");

            migrationBuilder.CreateIndex(
                name: "FKCientJobLogClientJobId",
                table: "CientJobLog",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentAssignedTo",
                table: "ClientAssignment",
                column: "AssignedTo");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCaseJobDefendantId",
                table: "ClientAssignment",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentChainCompletedBy",
                table: "ClientAssignment",
                column: "ChainCompletedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentClientAssignmentTaskId",
                table: "ClientAssignment",
                column: "ClientAssignmentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentClientJobId",
                table: "ClientAssignment",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCompletedBy",
                table: "ClientAssignment",
                column: "CompletedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCompleteDocumentRepositoryId",
                table: "ClientAssignment",
                column: "CompleteDocumentRepositoryId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCreatedBy",
                table: "ClientAssignment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentLastAccessBy",
                table: "ClientAssignment",
                column: "LastAccessBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentReprojectedBy",
                table: "ClientAssignment",
                column: "ReprojectedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentStartedDocumentRepositoryId",
                table: "ClientAssignment",
                column: "StartedDocumentRepositoryId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentUpdatedBy",
                table: "ClientAssignment",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentVoidedBy",
                table: "ClientAssignment",
                column: "VoidedBy");

            migrationBuilder.CreateIndex(
                name: "Ref81194",
                table: "ClientAssignment",
                column: "ParentAssignmentId");

            migrationBuilder.CreateIndex(
                name: "Ref81208",
                table: "ClientAssignment",
                column: "ChainCompletedAssignmentId");

            migrationBuilder.CreateIndex(
                name: "Ref81210",
                table: "ClientAssignment",
                column: "StartedByAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCheckListCRClientAssignmentTaskCheckListId",
                table: "ClientAssignmentCheckListCr",
                column: "ClientAssignmentTaskCheckListId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskCheckListCRId",
                table: "ClientAssignmentCheckListCr",
                column: "ClientAssignmentTaskCheckListCRId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCheckListVRClientAssignmentId",
                table: "ClientAssignmentCheckListVr",
                column: "ClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentCheckListVRClientAssignmentTaskCheckListId",
                table: "ClientAssignmentCheckListVr",
                column: "ClientAssignmentTaskCheckListId");

            migrationBuilder.CreateIndex(
                name: "FKAttachmentDocumentRepositoryId",
                table: "ClientAssignmentHold",
                column: "AttachmentDocumentRepositoryId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentHoldApprovedById",
                table: "ClientAssignmentHold",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentHoldClientAssignmentId",
                table: "ClientAssignmentHold",
                column: "ClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentHoldDeniedById",
                table: "ClientAssignmentHold",
                column: "DeniedById");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentHoldHoldTypeLid",
                table: "ClientAssignmentHold",
                column: "HoldTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentHoldLawPracticeId",
                table: "ClientAssignmentHold",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "Ref81170",
                table: "ClientAssignmentHold",
                column: "ClientAssignmentParentId");

            migrationBuilder.CreateIndex(
                name: "Ref81171",
                table: "ClientAssignmentHold",
                column: "HoldingAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentJournalClientAssignmentId",
                table: "ClientAssignmentJournal",
                column: "ClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentJournalLoginDetailId",
                table: "ClientAssignmentJournal",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentReProHistoryApprovedBy",
                table: "ClientAssignmentReProHistory",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentReProHistoryClientAssignmentId",
                table: "ClientAssignmentReProHistory",
                column: "ClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentReProHistoryDocumentRespositoryId",
                table: "ClientAssignmentReProHistory",
                column: "DocumentRepositoryId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentReProHistoryReprojectedBy",
                table: "ClientAssignmentReProHistory",
                column: "ReprojectedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentScheduledClientAssignmentTaskScheduledId",
                table: "ClientAssignmentScheduled",
                column: "ClientAssignmentTaskScheduledId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentScheduledClientJobId",
                table: "ClientAssignmentScheduled",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentScheduledFromClientAssignmentId",
                table: "ClientAssignmentScheduled",
                column: "FromClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentScheduledNewClientAssignmentId",
                table: "ClientAssignmentScheduled",
                column: "ClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentScheduledProcessedBy",
                table: "ClientAssignmentScheduled",
                column: "ProcessedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskAssocMergePackageId",
                table: "ClientAssignmentTask",
                column: "AssocMergePackageId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskClientId",
                table: "ClientAssignmentTask",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskJobTypeId",
                table: "ClientAssignmentTask",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskRequiresDocumentId",
                table: "ClientAssignmentTask",
                column: "RequiresDocumentId");

            migrationBuilder.CreateIndex(
                name: "Ref87213",
                table: "ClientAssignmentTask",
                column: "ParentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskCheckListClientAssignmentTaskId",
                table: "ClientAssignmentTaskCheckList",
                column: "ClientAssignmentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskCheckListTypeLid",
                table: "ClientAssignmentTaskCheckList",
                column: "CheckListTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskCheckListVRClientAssignmentTaskCheckListId",
                table: "ClientAssignmentTaskCheckListVr",
                column: "ClientAssignmentTaskCheckListId");

            migrationBuilder.CreateIndex(
                name: "FK_ClientAssignmentTaskRecurrence_ClientAssignmentTaskScheduled",
                table: "ClientAssignmentTaskRecurrence",
                column: "ClientAssignmentTaskScheduledId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskRuleClientAssignmentTaskCheckListId",
                table: "ClientAssignmentTaskRule",
                column: "ClientAssignmentTaskCheckListId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskScheduledClientAssignmentTaskId",
                table: "ClientAssignmentTaskScheduled",
                column: "ClientAssignmentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKClientAssignmentTaskStartClientAssignmentTaskId",
                table: "ClientAssignmentTaskScheduled",
                column: "StartClientAssignmentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKClientDepartmentClientId",
                table: "ClientDepartment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKClientFacilityClientId",
                table: "ClientFacility",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKClientFacilityFacilityTypeLid",
                table: "ClientFacility",
                column: "FacilityTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKClientJobCaseId",
                table: "ClientJob",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobJobTypeId",
                table: "ClientJob",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobLawPracticeId",
                table: "ClientJob",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobLocalCounselId",
                table: "ClientJob",
                column: "LocalCounselId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobActivityActionClientAssignmentId",
                table: "ClientJobActivity",
                column: "ActionClientAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobActivityClientJobId",
                table: "ClientJobActivity",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobLegalClientJobId",
                table: "ClientJobLegal",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobLegalLegalDescFromLid",
                table: "ClientJobLegal",
                column: "LegalDescFromLid");

            migrationBuilder.CreateIndex(
                name: "FKClientJobLegalVerifiedBy",
                table: "ClientJobLegal",
                column: "VerifiedBy");

            migrationBuilder.CreateIndex(
                name: "FKClientJobListingClientId",
                table: "ClientJobListing",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKClientJobListingJobTypeId",
                table: "ClientJobListing",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKClientLawPracticeClientId",
                table: "ClientLawPractice",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKClientLawPracticeLawPracticeId",
                table: "ClientLawPractice",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKClientLawPracticeJobTypeJobTypeId",
                table: "ClientLawPracticeJobType",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKClientStateLocationClientId",
                table: "ClientStateLocation",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKDefendantAddressCaseJobDefendantId",
                table: "DefendantAddress",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentMailOutHistoryCaseJobDefendantId",
                table: "DocumentMailOutHistory",
                column: "CaseJobDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentMailOutHistoryClientJobId",
                table: "DocumentMailOutHistory",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentMailOutHistoryDocumentTypeId",
                table: "DocumentMailOutHistory",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentMailOutHistoryMailServiceTypeLid",
                table: "DocumentMailOutHistory",
                column: "MailServiceTypeLid");

            migrationBuilder.CreateIndex(
                name: "FKDocumentMailOutHistoryMailVendorLid",
                table: "DocumentMailOutHistory",
                column: "MailVendorLid");

            migrationBuilder.CreateIndex(
                name: "FKDocumentMailOutHistorySentByAssignmentId",
                table: "DocumentMailOutHistory",
                column: "SentByAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKEnvelopeDocumentId",
                table: "DocumentMailOutHistory",
                column: "EnvelopeDocumentId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentNoteByUserId",
                table: "DocumentNote",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentNoteDocumentRepositoryId",
                table: "DocumentNote",
                column: "DocumentRepositoryId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryBoundAssignmentId",
                table: "DocumentRepository",
                column: "BoundAssignmentId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryBoundCaseDefendantId",
                table: "DocumentRepository",
                column: "BoundCaseDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryBoundServiceDefendantId",
                table: "DocumentRepository",
                column: "BoundServiceDefendantId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryClientJobId",
                table: "DocumentRepository",
                column: "ClientJobId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryDeliveryMethodLid",
                table: "DocumentRepository",
                column: "DeliveryMethodLid");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryDocumentTypeId",
                table: "DocumentRepository",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryFromCheckListId",
                table: "DocumentRepository",
                column: "FromCheckListId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentRepositoryLawPracticeJobId",
                table: "DocumentRepository",
                column: "LawPracticeJobId");

            migrationBuilder.CreateIndex(
                name: "Ref117161",
                table: "DocumentRepository",
                column: "LastVersionDocumentId");

            migrationBuilder.CreateIndex(
                name: "Ref117162",
                table: "DocumentRepository",
                column: "NextVersionDocumentId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentTypeClientId",
                table: "DocumentType",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKDocumentTypeDocumentCategoryLid",
                table: "DocumentType",
                column: "DocumentCategoryLid");

            migrationBuilder.CreateIndex(
                name: "FKDocumentTypeJobTypeId",
                table: "DocumentType",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKGarnisheeClientId",
                table: "Garnishee",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKLawPracticeClientId",
                table: "LawPractice",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKPracticeTypeLid",
                table: "LawPractice",
                column: "PracticeTypeLid");

            migrationBuilder.CreateIndex(
                name: "UQ__LawPractice__54817C4C",
                table: "LawPractice",
                column: "ReferralCompanyCode",
                unique: true,
                filter: "[ReferralCompanyCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "FKLawPracticeJobJobTypeId",
                table: "LawPracticeJob",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKLawPracticeJobLawPracticeId",
                table: "LawPracticeJob",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKLawPracticeUserClientId",
                table: "LawPracticeUser",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKLawPracticeUserLawPracticeId",
                table: "LawPracticeUser",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKLawPracticeUserLoginDetailId",
                table: "LawPracticeUser",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ListItem_ClientId",
                table: "ListItem",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailClientId",
                table: "LoginDetail",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailLawPracticeId",
                table: "LoginDetail",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailLocalCounselId",
                table: "LoginDetail",
                column: "LocalCounselId");

            migrationBuilder.CreateIndex(
                name: "FKLoginTypeLid",
                table: "LoginDetail",
                column: "LoginTypeLid");

            migrationBuilder.CreateIndex(
                name: "UDX_LogonInfo",
                table: "LoginDetail",
                column: "LoginID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailJobListingJobTypeId",
                table: "LoginDetailJobListing",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailJobListingLoginDetailId",
                table: "LoginDetailJobListing",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailsAccessRoleAccessFieldLid",
                table: "LoginDetailsAccessRole",
                column: "AccessFieldLid");

            migrationBuilder.CreateIndex(
                name: "FKLoginDetailsAccessRoleLoginDetailId",
                table: "LoginDetailsAccessRole",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailsAssignmentPoolClientAssignmentTaskId",
                table: "LogonDetailsAssignmentPool",
                column: "ClientAssignmentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailsAssignmentPoolLoginDetailId",
                table: "LogonDetailsAssignmentPool",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailsAssignmentPoolUseReportId",
                table: "LogonDetailsAssignmentPool",
                column: "UseReportId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailsAssignmentPoolTaskClientAssignmentTaskId",
                table: "LogonDetailsAssignmentPoolTask",
                column: "ClientAssignmentTaskId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailsAssignmentPoolTaskLogonDetailsAssignmentPoolId",
                table: "LogonDetailsAssignmentPoolTask",
                column: "LogonDetailsAssignmentPoolId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailSubordinateLoginDetailId",
                table: "LogonDetailSubordinate",
                column: "LoginDetailId");

            migrationBuilder.CreateIndex(
                name: "FKLogonDetailSubordinateSubordinateLoginDetailsId",
                table: "LogonDetailSubordinate",
                column: "SubordinateLoginDetailsId");

            migrationBuilder.CreateIndex(
                name: "FKMergeDocumentCustomMergeDocumentId",
                table: "MergeDocumentCustom",
                column: "MergeDocumentId");

            migrationBuilder.CreateIndex(
                name: "FKReportClientId",
                table: "Report",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKReportJobReportId",
                table: "ReportJob",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "FKReportJobParameterReportJobId",
                table: "ReportJobParameter",
                column: "ReportJobId");

            migrationBuilder.CreateIndex(
                name: "FKReportJobParameterReportParameterId",
                table: "ReportJobParameter",
                column: "ReportParameterId");

            migrationBuilder.CreateIndex(
                name: "FKReportJobScheduleReportId",
                table: "ReportJobSchedule",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "FKReportMappingClientId",
                table: "ReportMapping",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "FKReportMappingLawPracticeId",
                table: "ReportMapping",
                column: "LawPracticeId");

            migrationBuilder.CreateIndex(
                name: "FKReportMappingLocalCounselId",
                table: "ReportMapping",
                column: "LocalCounselId");

            migrationBuilder.CreateIndex(
                name: "FKReportMappingReportId",
                table: "ReportMapping",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "FKReportParameterReportId",
                table: "ReportParameter",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseCOLLastAssignmentId",
                table: "CaseCol",
                column: "LastAssignmentId",
                principalTable: "ClientAssignment",
                principalColumn: "ClientAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseCOLNextAssignmentId",
                table: "CaseCol",
                column: "NextAssignmentId",
                principalTable: "ClientAssignment",
                principalColumn: "ClientAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseCOLDefendantBankInfoCaseJobDefendantId",
                table: "CaseColDefendantBankInfo",
                column: "CaseJobDefendantId",
                principalTable: "CaseJobDefendant",
                principalColumn: "CaseJobDefendantId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseCOLDefendantCardInfoCaseJobDefendantId",
                table: "CaseColDefendantCardInfo",
                column: "CaseJobDefendantId",
                principalTable: "CaseJobDefendant",
                principalColumn: "CaseJobDefendantId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseJobDefendantPacerDocumentId",
                table: "CaseJobDefendant",
                column: "PacerDocumentId",
                principalTable: "DocumentRepository",
                principalColumn: "DocumentRepositoryId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseJobDefendantSearchHistoryCameFromAssignmentId",
                table: "CaseJobDefendantSearchHistory",
                column: "CameFromAssignmentId",
                principalTable: "ClientAssignment",
                principalColumn: "ClientAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseJobDefendantServiceClientAssignmentId",
                table: "CaseJobDefendantService",
                column: "ClientAssignmentId",
                principalTable: "ClientAssignment",
                principalColumn: "ClientAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FKCaseTitleCurrentTISDocId",
                table: "CaseTitle",
                column: "CurrentTISDocId",
                principalTable: "DocumentRepository",
                principalColumn: "DocumentRepositoryId");

            migrationBuilder.AddForeignKey(
                name: "FKClientAssignmentCompleteDocumentRepositoryId",
                table: "ClientAssignment",
                column: "CompleteDocumentRepositoryId",
                principalTable: "DocumentRepository",
                principalColumn: "DocumentRepositoryId");

            migrationBuilder.AddForeignKey(
                name: "FKClientAssignmentStartedDocumentRepositoryId",
                table: "ClientAssignment",
                column: "StartedDocumentRepositoryId",
                principalTable: "DocumentRepository",
                principalColumn: "DocumentRepositoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentAssignedTo",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentChainCompletedBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentCompletedBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentCreatedBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentLastAccessBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentReprojectedBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentUpdatedBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentVoidedBy",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantPartyTypeLid",
                table: "CaseJobDefendant");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantRequestorOrganizationLid",
                table: "CaseJobDefendant");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantServiceTypeLid",
                table: "CaseJobDefendant");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantServiceServiceStatusLid",
                table: "CaseJobDefendantService");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantServiceServiceTypeLid",
                table: "CaseJobDefendantService");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentTaskCheckListTypeLid",
                table: "ClientAssignmentTaskCheckList");

            migrationBuilder.DropForeignKey(
                name: "FKDocumentRepositoryDeliveryMethodLid",
                table: "DocumentRepository");

            migrationBuilder.DropForeignKey(
                name: "FKDocumentTypeDocumentCategoryLid",
                table: "DocumentType");

            migrationBuilder.DropForeignKey(
                name: "FKPracticeTypeLid",
                table: "LawPractice");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantClientJobId",
                table: "CaseJobDefendant");

            migrationBuilder.DropForeignKey(
                name: "FKClientAssignmentClientJobId",
                table: "ClientAssignment");

            migrationBuilder.DropForeignKey(
                name: "FKDocumentRepositoryClientJobId",
                table: "DocumentRepository");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantServiceClientAssignmentId",
                table: "CaseJobDefendantService");

            migrationBuilder.DropForeignKey(
                name: "FKDocumentRepositoryBoundAssignmentId",
                table: "DocumentRepository");

            migrationBuilder.DropForeignKey(
                name: "FKCaseJobDefendantServiceCaseJobDefendantId",
                table: "CaseJobDefendantService");

            migrationBuilder.DropForeignKey(
                name: "FKDocumentRepositoryBoundCaseDefendantId",
                table: "DocumentRepository");

            migrationBuilder.DropTable(
                name: "AppRoleLoginDetail");

            migrationBuilder.DropTable(
                name: "AppRolePermission");

            migrationBuilder.DropTable(
                name: "BkrCaseSummary");

            migrationBuilder.DropTable(
                name: "BkrConditionalOrder");

            migrationBuilder.DropTable(
                name: "BkrFinancial");

            migrationBuilder.DropTable(
                name: "BkrFinInstallment");

            migrationBuilder.DropTable(
                name: "BkrFinInterestRate");

            migrationBuilder.DropTable(
                name: "BkrFinMissedPayment");

            migrationBuilder.DropTable(
                name: "BkrFinOtherCost");

            migrationBuilder.DropTable(
                name: "BkrJournal");

            migrationBuilder.DropTable(
                name: "BkrLoanModification");

            migrationBuilder.DropTable(
                name: "BkrMfr");

            migrationBuilder.DropTable(
                name: "BkrPaymentChange");

            migrationBuilder.DropTable(
                name: "BkrProperty");

            migrationBuilder.DropTable(
                name: "CaseAutoBuyerInfo");

            migrationBuilder.DropTable(
                name: "CaseColDefendantBankInfo");

            migrationBuilder.DropTable(
                name: "CaseColDefendantCardInfo");

            migrationBuilder.DropTable(
                name: "CaseColTransaction");

            migrationBuilder.DropTable(
                name: "CaseComment");

            migrationBuilder.DropTable(
                name: "CaseCommentWhiteboard");

            migrationBuilder.DropTable(
                name: "CaseEvictionJournal");

            migrationBuilder.DropTable(
                name: "CaseJobDefendantAdditionalAddress");

            migrationBuilder.DropTable(
                name: "CaseJobDefendantByVirtueOf");

            migrationBuilder.DropTable(
                name: "CaseJobDefendantSearchHistory");

            migrationBuilder.DropTable(
                name: "CaseReplevin");

            migrationBuilder.DropTable(
                name: "CaseSalePubCost");

            migrationBuilder.DropTable(
                name: "CaseSalePubDate");

            migrationBuilder.DropTable(
                name: "CaseSubpoenaOrderInfo");

            migrationBuilder.DropTable(
                name: "CaseTitleAssignmentItem");

            migrationBuilder.DropTable(
                name: "CaseTitleDlinqTax");

            migrationBuilder.DropTable(
                name: "CaseTitleFileAssign");

            migrationBuilder.DropTable(
                name: "CaseTitleIrstaxLien");

            migrationBuilder.DropTable(
                name: "CaseTitleJudgmentLien");

            migrationBuilder.DropTable(
                name: "CaseTitleModParagraph");

            migrationBuilder.DropTable(
                name: "CaseTitleMortgTaxLien");

            migrationBuilder.DropTable(
                name: "CaseTitleMortgWithAssignment");

            migrationBuilder.DropTable(
                name: "CaseTitleReRecorded");

            migrationBuilder.DropTable(
                name: "CaseTitleSpecialCount");

            migrationBuilder.DropTable(
                name: "CaseWritFinancial");

            migrationBuilder.DropTable(
                name: "CientJobLog");

            migrationBuilder.DropTable(
                name: "ClientAssignmentCheckListCr");

            migrationBuilder.DropTable(
                name: "ClientAssignmentCheckListVr");

            migrationBuilder.DropTable(
                name: "ClientAssignmentHold");

            migrationBuilder.DropTable(
                name: "ClientAssignmentJournal");

            migrationBuilder.DropTable(
                name: "ClientAssignmentReProHistory");

            migrationBuilder.DropTable(
                name: "ClientAssignmentScheduled");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTaskCheckListVr");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTaskRecurrence");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTaskRule");

            migrationBuilder.DropTable(
                name: "ClientDepartment");

            migrationBuilder.DropTable(
                name: "ClientFacility");

            migrationBuilder.DropTable(
                name: "ClientJobActivity");

            migrationBuilder.DropTable(
                name: "ClientJobLegal");

            migrationBuilder.DropTable(
                name: "ClientJobListing");

            migrationBuilder.DropTable(
                name: "ClientLawPractice");

            migrationBuilder.DropTable(
                name: "ClientLawPracticeJobType");

            migrationBuilder.DropTable(
                name: "ClientStateLocation");

            migrationBuilder.DropTable(
                name: "DefendantAddress");

            migrationBuilder.DropTable(
                name: "DocumentMailOutHistory");

            migrationBuilder.DropTable(
                name: "DocumentNote");

            migrationBuilder.DropTable(
                name: "LoginDetailsAccessRole");

            migrationBuilder.DropTable(
                name: "LogonDetailsAssignmentPoolTask");

            migrationBuilder.DropTable(
                name: "LogonDetailSubordinate");

            migrationBuilder.DropTable(
                name: "MergeDocumentCustom");

            migrationBuilder.DropTable(
                name: "MergeDocumentToken");

            migrationBuilder.DropTable(
                name: "MergeField");

            migrationBuilder.DropTable(
                name: "ReportJobParameter");

            migrationBuilder.DropTable(
                name: "ReportJobSchedule");

            migrationBuilder.DropTable(
                name: "ReportMapping");

            migrationBuilder.DropTable(
                name: "ThirdPartyConvertion");

            migrationBuilder.DropTable(
                name: "ZipCodeDictionary");

            migrationBuilder.DropTable(
                name: "AppPermission");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "CaseBkr");

            migrationBuilder.DropTable(
                name: "CaseAuto");

            migrationBuilder.DropTable(
                name: "CaseCol");

            migrationBuilder.DropTable(
                name: "CaseEviction");

            migrationBuilder.DropTable(
                name: "LawPracticeUser");

            migrationBuilder.DropTable(
                name: "CaseSale");

            migrationBuilder.DropTable(
                name: "CaseSubpoena");

            migrationBuilder.DropTable(
                name: "CaseTitleAssignment");

            migrationBuilder.DropTable(
                name: "CaseTitleSpecialCountTemplate");

            migrationBuilder.DropTable(
                name: "CaseWrit");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTaskCheckListCr");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTaskScheduled");

            migrationBuilder.DropTable(
                name: "LogonDetailsAssignmentPool");

            migrationBuilder.DropTable(
                name: "ReportJob");

            migrationBuilder.DropTable(
                name: "ReportParameter");

            migrationBuilder.DropTable(
                name: "BkrDistrict");

            migrationBuilder.DropTable(
                name: "LoginDetailJobListing");

            migrationBuilder.DropTable(
                name: "CaseTitle");

            migrationBuilder.DropTable(
                name: "Garnishee");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "CaseFcl");

            migrationBuilder.DropTable(
                name: "CaseTitleUnderWriter");

            migrationBuilder.DropTable(
                name: "CaseJudge");

            migrationBuilder.DropTable(
                name: "CaseCourt");

            migrationBuilder.DropTable(
                name: "CaseDistrict");

            migrationBuilder.DropTable(
                name: "LoginDetail");

            migrationBuilder.DropTable(
                name: "ListItem");

            migrationBuilder.DropTable(
                name: "ClientJob");

            migrationBuilder.DropTable(
                name: "CaseMaster");

            migrationBuilder.DropTable(
                name: "LocalCounsel");

            migrationBuilder.DropTable(
                name: "CaseCounty");

            migrationBuilder.DropTable(
                name: "CaseState");

            migrationBuilder.DropTable(
                name: "ClientAssignment");

            migrationBuilder.DropTable(
                name: "CaseJobDefendant");

            migrationBuilder.DropTable(
                name: "CaseJobDefendantAtty");

            migrationBuilder.DropTable(
                name: "DocumentRepository");

            migrationBuilder.DropTable(
                name: "CaseJobDefendantService");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTaskCheckList");

            migrationBuilder.DropTable(
                name: "LawPracticeJob");

            migrationBuilder.DropTable(
                name: "ClientAssignmentTask");

            migrationBuilder.DropTable(
                name: "LawPractice");

            migrationBuilder.DropTable(
                name: "MergeDocument");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "JobType");
        }
    }
}
