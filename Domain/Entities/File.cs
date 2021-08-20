using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class File: AuditableBaseEntity<int>
    {
        public string MimeType { get; set; }
        public string OriginalName { get; set; }
        public string  UniqueName { get; set; }
        public string Url { get; set; }

        public int? AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
