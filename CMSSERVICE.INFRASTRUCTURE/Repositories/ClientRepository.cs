using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal sealed class ClientRepository : GenericRepository<Client>, IClientRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ClientRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddClient(Client newClient) =>
        await Add(newClient);

    public async Task<List<Client>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Client>()
            .ToListAsync(cancellationToken);

    public async Task<Client?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Client>()
            .FirstOrDefaultAsync(client => client.ClientName == name, cancellationToken);

    public async Task<Client?> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Client>()
            .FirstOrDefaultAsync(client => client.Id == id, cancellationToken);

    public async Task UpdateClient(Client existingClient) =>
        await Update(existingClient);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
    !await _dbContext
    .Set<Client>()
            .AnyAsync(client => client.ClientName == name, cancellationToken);
}
