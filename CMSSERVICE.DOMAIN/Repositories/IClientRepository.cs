﻿using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Repositories;

public interface IClientRepository
{
    Task<Client?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<Client?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<List<Client>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    void AddClient(Client newClient);

    void UpdateClient(Client existingClient);
}
