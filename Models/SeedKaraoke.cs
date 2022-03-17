using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaraokeDisplay.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace KaraokeDisplay.Models
{
    public class SeedKaraoke
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KaraokeDisplayContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KaraokeDisplayContext>>()))
            {
                try
                {
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
