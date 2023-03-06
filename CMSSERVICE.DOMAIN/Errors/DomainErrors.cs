namespace CMSSERVICE.DOMAIN.Errors;

public static class DomainErrors
{
    public static class LoginError
    {
        public static readonly Error UsernameInUse = new(
            "LoginDetail.LoginId",
            "The specified email is already in use");

        public static readonly Error InvalidUsername = new(
            "LoginDetail.LoginId",
            "The provided username is invalid");

        public static readonly Error InvalidCredentials = new(
            "LoginDetail.LoginPwd",
            "The provided credentials are invalid");

        public static readonly Error NotFound = new(
            "LoginDetail.LoginDetailId",
            "The provided user id was not found.");
    }

    public static class RoleError
    {
        public static readonly Error RoleNotFound = new(
            "AppRole.Id",
            "Role not found.");

        public static readonly Error RoleNameInUse = new(
            "AppRole.Name",
            "The specified role name is already in use");

        public static readonly Error RoleMissing = new(
            "AppRole.Name",
            "Roles were missing.");
    }

    public static class PermissionError
    {
        public static readonly Error PermissionNotFound = new(
            "AppPermission.Id",
            "Permission not found.");

        public static readonly Error PermissionNameInUse = new(
            "AppPermission.Name",
            "The specified permission name is already in use");

        public static readonly Error PermissionMissing = new(
            "AppPermission.Name",
            "Permissions were missing.");
    }

    public static class RegistrationError
    {
        public static readonly Error MissingRoleByName = new(
            "AppRole.Name",
            "Role not found.");
    }

    public static class ClientError
    {
        public static readonly Error InvalidClientId = new(
            "Client.ClientId",
            "Client not found.");

        public static readonly Error ClientNameInUse = new(
            "Client.ClientName",
            "The specified client name is already in use");
    }

    public static class LawPracticeError
    {
        public static readonly Error InvalidLawPracticeId = new(
            "LawPractice.LawPracticeId",
            "Law Practice not found.");

        public static readonly Error LawPracticeNameInUse = new(
            "LawPractice.PracticeName",
            "The specified law practice name is already in use");
    }

    public static class LocalCounselError
    {
        public static readonly Error InvalidLocalCounselId = new(
            "LocalCounsel.LocalCounselId",
            "Local Counsel not found.");

        public static readonly Error LocalCounselNameInUse = new(
            "LocalCounsel.LCName",
            "The specified local counsel name is already in use");
    }

    public static class ListItemError
    {
        public static readonly Error SystemCategoryInUse = new(
            "ListItem.SystemCategory",
            "The specified system category is already in use");

        public static readonly Error SystemTagInUse = new(
            "ListItem.SystemTag",
            "The specified system tag under that category is already in use");

        public static readonly Error SystemCategoryTagDisplayInUse = new(
            "ListItem.SystemCategory, ListItem.SystemTag, ListItem.ListItemDisplayText",
            "The specified category, tag and display text is already in use");

        public static readonly Func<Guid, Error> NotFound = id => new Error(
            "ListItem.Id",
            $"The list item with the identifier {id} was not found.");
    }

    public static class CaseStateError
    {
        public static readonly Error CaseStateById = new(
            "CaseState.CaseStateId",
            "State not found.");

        public static readonly Error CaseStateNameInUse = new(
            "CaseState.StateName",
            "The specified state name is already in use");

        public static readonly Error CaseStateAbbrevInUse = new(
            "CaseState.StateName",
            "The specified state abbreviation is already in use");
    }

    public static class CaseCountyError
    {
        public static readonly Error CaseStateById = new(
            "CaseState.CaseStateId",
            "State not found.");

        public static readonly Error CaseCountyNameInUse = new(
            "CaseState.StateName",
            "The specified county name is already in use");
    }

    public static class CaseDistrictError
    {
        public static readonly Error CaseDistrictIdById = new(
            "CaseDistrict.CaseDistrictId",
            "District not found.");

        public static readonly Error CaseDistrictNameByStateInUse = new(
            "CaseDistrict.DistrictName",
            "The specified district name on the specified state is already in use");
    }

    public static class JobTypeError
    {
        public static readonly Error JobTypeId = new(
            "JobType.JobTypeId",
            "Job Type not found.");

        public static readonly Error JobTypeNameInUse = new(
            "JobType.JobName",
            "The specified job type name is already in use");

        public static readonly Error JobTypeDeparmentId = new(
            "JobType.JobDepartmentId",
            "Job Department not found.");
    }

    public static class State
    {
        public static readonly Func<Guid, Error> NotFound = id => new Error(
            "State.Id",
            $"The state with the identifier {id} was not found.");

        public static readonly Func<string, Error> NotFoundByName = name => new Error(
            "State.StateDescription",
            $"The state with the name {name} was not found.");

        public static readonly Func<string, Error> NotFoundByNameBilling = name => new Error(
            "State.StateDescription",
            $"The billing state with the name {name} was not found.");

        public static readonly Func<string, Error> NotFoundByNameReturn = name => new Error(
            "State.StateDescription",
            $"The return state with the name {name} was not found.");

        public static readonly Func<string, Error> NotFoundByAbbreviation = name => new Error(
            "State.StateAbbreviation",
            $"The state with the abbreviation {name} was not found.");

        public static readonly Func<string, Error> NotFoundByAbbreviationBilling = name => new Error(
            "State.StateAbbreviation",
            $"The billing state with the abbreviation {name} was not found.");

        public static readonly Func<string, Error> NotFoundByAbbreviationReturn = name => new Error(
            "State.StateAbbreviation",
            $"The return state with the abbreviation {name} was not found.");

        public static readonly Error StateNameInUse = new(
           "State.StateDescription",
           "The specified name is already in use");

        public static readonly Error StateAbbreviationInUse = new(
           "State.StateAbbreviation",
           "The specified abbreviation is already in use");
    }
}
