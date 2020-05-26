using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    
}
