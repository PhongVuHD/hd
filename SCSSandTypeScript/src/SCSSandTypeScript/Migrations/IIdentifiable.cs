using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Data
{
    public interface IIdentifiable<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }
    }
}