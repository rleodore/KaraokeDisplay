using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KaraokeDisplay.Models;

namespace KaraokeDisplay.Data
{
    public class RequestContext : DbContext
    {
        public RequestContext (DbContextOptions<RequestContext> options)
            : base(options)
        {
        }

        public DbSet<KaraokeDisplay.Models.RequestModel> RequestModel { get; set; }
    }
}
