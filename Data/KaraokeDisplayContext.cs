using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KaraokeDisplay.Models;

namespace KaraokeDisplay.Data
{
    public class KaraokeDisplayContext : DbContext
    {
        public KaraokeDisplayContext (DbContextOptions<KaraokeDisplayContext> options)
            : base(options)
        {
        }

        public DbSet<KaraokeDisplay.Models.KaraokeModel> KaraokeModel { get; set; }
    }
}
