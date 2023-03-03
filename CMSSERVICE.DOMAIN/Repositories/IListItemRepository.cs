using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IListItemRepository
{
    void AddListItem(ListItem newListItem);

    Task<List<ListItem>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<ListItem?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<List<ListItem>?> GetBySystemCategoryAsync(string sysCategory, CancellationToken cancellationToken = default);

    Task<List<ListItem>?> GetBySystemTagAsync(string sysTag, CancellationToken cancellationToken = default);

    Task<List<ListItem>?> GetBySystemCategoryTagAsync(string sysCategory, string sysTag, CancellationToken cancellationToken = default);

    Task<ListItem?> GetBySystemCategoryTagDisplayTextAsync(string sysCategory, string sysTag, string displayText, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string sysCategory, string sysTag, string displayText, CancellationToken cancellationToken = default);

    Task<int> GetListOrderAsync(string sysCategory, string sysTag, CancellationToken cancellationToken = default);

    void UpdateListItem(ListItem existingListItem);
}
