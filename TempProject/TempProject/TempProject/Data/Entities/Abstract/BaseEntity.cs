using System;
using System.Collections.Generic;
using System.Text;

namespace TempProject.Data.Entities.Abstract
{
    public abstract class BaseEntity<TKey> where TKey : IComparable
    {
        public TKey Id { get; set; }
    }
}
