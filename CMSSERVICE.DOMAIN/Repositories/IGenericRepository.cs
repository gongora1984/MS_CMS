﻿namespace CMSSERVICE.DOMAIN.Repositories;

public interface IGenericRepository<in T>
    where T : class
{
    Task<bool> Add(T entity);

    Task<bool> Update(T entity);
}