using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Data
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IModelConfiguration
    {
        void OnModelCreating(ModelBuilder builder);
    }
}