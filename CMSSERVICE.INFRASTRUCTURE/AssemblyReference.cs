using System.Reflection;

namespace CMSSERVICE.INFRASTRUCTURE;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}