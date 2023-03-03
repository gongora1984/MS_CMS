using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class ListItemRepository : IListItemRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ListItemRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddListItem(ListItem newListItem) =>
        _dbContext.Set<ListItem>().Add(newListItem);

    public async Task<List<ListItem>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .ToListAsync(cancellationToken);

    public async Task<ListItem?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .FirstOrDefaultAsync(li => li.Id == id, cancellationToken);

    public async Task<List<ListItem>?> GetBySystemCategoryAsync(string sysCategory, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .Where(li => li.SystemCategory == sysCategory)
            .ToListAsync(cancellationToken);

    public async Task<List<ListItem>?> GetBySystemCategoryTagAsync(string sysCategory, string sysTag, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .Where(li => li.SystemCategory == sysCategory && li.SystemTag == sysTag)
            .ToListAsync(cancellationToken);

    public async Task<List<ListItem>?> GetBySystemTagAsync(string sysTag, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .Where(li => li.SystemTag == sysTag)
            .ToListAsync(cancellationToken);

    public async Task<ListItem?> GetBySystemCategoryTagDisplayTextAsync(string sysCategory, string sysTag, string displayText, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .FirstOrDefaultAsync(li => li.SystemCategory == sysCategory && li.SystemTag == sysTag && li.DisplayText == displayText, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string sysCategory, string sysTag, string displayText, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<ListItem>()
            .AnyAsync(li => li.SystemCategory == sysCategory && li.SystemTag == sysTag && li.DisplayText == displayText, cancellationToken);

    public void UpdateListItem(ListItem existingListItem) =>
        _dbContext.Set<ListItem>().Update(existingListItem);

    public async Task<int> GetListOrderAsync(string sysCategory, string sysTag, CancellationToken cancellationToken = default)
    {
        var items = await GetBySystemCategoryTagAsync(sysCategory, sysTag, cancellationToken);

        return (items != null && items.Any()) ? items.Max(x => x.ListOrder) : 0;
    }
}
