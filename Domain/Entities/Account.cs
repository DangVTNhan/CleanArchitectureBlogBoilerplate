using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Account: AuditableBaseEntity<int>
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<AccountRole> Roles { get; set; }
    }
}
