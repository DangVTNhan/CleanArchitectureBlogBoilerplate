using Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAccountRepository AccountRepository { get; }
        IBlogRepository BlogRepository { get; }
        IFileRepository FileRepository { get; }
        Task<bool> SaveAsync();

    }
}
