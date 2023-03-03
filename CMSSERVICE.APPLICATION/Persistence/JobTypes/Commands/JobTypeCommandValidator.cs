using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.JobTypes.Commands;

internal class JobTypeCommandValidator : AbstractValidator<RegisterJobTypeCommand>
{
    public JobTypeCommandValidator()
    {
        RuleFor(x => x.jt.JobName).NotEmpty().WithMessage("Job Type name is required").MaximumLength(50).WithMessage("Maximum length for Job Type Name 1 is 50 characters.");

        RuleFor(x => x.jt.JobSysCode).NotEmpty().WithMessage("Job Type System Code is required").MaximumLength(15).WithMessage("Maximum length for Job Type System Code 1 is 15 characters.");

        RuleFor(x => x.jt.JobDepartmentId).NotNull().WithMessage("Job department id is required").GreaterThan(0).WithMessage("Job department id should be greater than 0.");
    }
}
