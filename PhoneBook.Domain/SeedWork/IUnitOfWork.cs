﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneBook.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}