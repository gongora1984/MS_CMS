using System.Reflection;

namespace CMSSERVICE.APPLICATION;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}