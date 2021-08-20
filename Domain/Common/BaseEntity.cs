using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
    }

    public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
    {
        [Key]
        public virtual TKey Id { get; set; }
    }
}
