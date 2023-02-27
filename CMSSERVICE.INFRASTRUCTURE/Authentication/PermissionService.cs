using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public class PermissionService : IPermissionService
{
    private readonly ApplicationDbContext _context;

    public PermissionService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<HashSet<string>> GetPermissionsAsync(int userId)
    {
        var userInfo = await _context.Set<LoginDetail>().FirstOrDefaultAsync(x => x.Id == userId);

        if (userInfo == null)
        {
            return new HashSet<string>();
        }

        // Fetch roles from db if applicable.
        ICollection<AppRole>[] roles = await _context.Set<LoginDetail>()
            .Include(x => x.AppRoles)
            .ThenInclude(x => x.AppPermissions)
            .Where(x => x.Id == userId)
            .Select(x => x.AppRoles)
            .ToArrayAsync();

        return roles
            .SelectMany(x => x)
            .SelectMany(x => x.AppPermissions)
            .Select(x => x.Name)
            .ToHashSet();

        ////var role = string.Empty;

        ////if (userInfo.ClientId != null)
        ////{
        ////    role = "Client";
        ////}

        ////if (userInfo.LawPracticeId != null)
        ////{
        ////    role = "LawPractice";
        ////}

        ////if (userInfo.LocalCounselId != null)
        ////{
        ////    role = "LocalCounsel";
        ////}

        ////if (Convert.ToBoolean(userInfo.IsAdmin) || Convert.ToBoolean(userInfo.IsSuperAdmin) || Convert.ToBoolean(userInfo.IsSysAdmin))
        ////{
        ////    role = "Admin";
        ////}

        ////return new HashSet<string> { role };
    }
}
