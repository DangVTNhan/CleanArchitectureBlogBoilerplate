using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role: BaseEntity<int>
    {
        public string Rolename { get; set; }
        public virtual ICollection<AccountRole> Accounts { get; set; }
    }
}
