using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class CountItem<T>
    {
        public int Count { get; set; }

        public T Value { get; set; }
    }
}
