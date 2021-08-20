using Application.Interfaces.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repository.Entities
{
    public class FileRepository: RepositoryBase <File>,IFileRepository
    {
        private ApplicationDbContext _db;
        public FileRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            _db = dbContext;
        }
    }
}
