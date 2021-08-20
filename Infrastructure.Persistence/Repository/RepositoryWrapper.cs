using Application.Interfaces;
using Application.Interfaces.Repositories;
using Infrastructure.Persistence.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _dbContext;
        private IAccountRepository _account;
        private IBlogRepository _blog;
        private IFileRepository _file;


        public RepositoryWrapper(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IAccountRepository AccountRepository
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepository(_dbContext);
                }
                return _account;
            }
        }

        public IBlogRepository BlogRepository
        {
            get
            {
                if (_blog == null)
                {
                    _blog = new BlogRepository(_dbContext);
                }
                return _blog;
            }
        }

        public IFileRepository FileRepository
        {
            get
            {
                if (_file == null)
                {
                    _file = new FileRepository(_dbContext);
                }
                return _file;
            }
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
