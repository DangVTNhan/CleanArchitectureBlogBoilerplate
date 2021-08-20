using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Blog : AuditableBaseEntity<int>
    {
        public string Slug { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }

        public int? AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
