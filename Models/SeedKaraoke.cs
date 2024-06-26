﻿using System;
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
            }
        }
        public static void RequestInitialize(IServiceProvider serviceProvider)
        {
            using (var context = new RequestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RequestContext>>()))
            {
                if (context.RequestModel.Any())
                {
                    return;   // DB has been seeded
                }
                else
                {
                    context.AddRange(
                        new RequestModel
                        {
                            RequesterName ="Rich",
                            SongId=666,
                            Artist="Aaron Tippin",
                            Song= "I Got It Honest [NS Karaoke]"

                        }
                    );
                }
                context.SaveChanges();
            }
        }
    }
}
