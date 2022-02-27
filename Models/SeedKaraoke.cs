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
        private static List<KaraokeModel> postsNum;
        private static List<KaraokeModel> postsA;
        private static List<KaraokeModel> postsB;
        private static List<KaraokeModel> postsC;
        private static List<KaraokeModel> postsD;
        private static List<KaraokeModel> postsE;
        private static List<KaraokeModel> postsF;
        private static List<KaraokeModel> postsG;
        private static List<KaraokeModel> postsH;
        private static List<KaraokeModel> postsI;
        private static List<KaraokeModel> postsJ;
        private static List<KaraokeModel> postsK;
        private static List<KaraokeModel> postsL;
        private static List<KaraokeModel> postsM;
        private static List<KaraokeModel> postsN;
        private static List<KaraokeModel> postsO;
        private static List<KaraokeModel> postsP;
        private static List<KaraokeModel> postsQ;
        private static List<KaraokeModel> postsR;
        private static List<KaraokeModel> postsS;
        private static List<KaraokeModel> postsT;
        private static List<KaraokeModel> postsU;
        private static List<KaraokeModel> postsV;
        private static List<KaraokeModel> postsW;
        private static List<KaraokeModel> postsX;
        private static List<KaraokeModel> postsY;
        private static List<KaraokeModel> postsZ;
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KaraokeDisplayContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KaraokeDisplayContext>>()))
            {
                try
                {
                    // Matches on start, so uses an index (on SQL Server)
                    List<KaraokeModel> postsNum0 = context.KaraokeModel.Where(p => p.Artist.StartsWith("0")).ToList();
                    List<KaraokeModel> postsNum1 = context.KaraokeModel.Where(p => p.Artist.StartsWith("1")).ToList();
                    List<KaraokeModel> postsNum2 = context.KaraokeModel.Where(p => p.Artist.StartsWith("2")).ToList();
                    List<KaraokeModel> postsNum3 = context.KaraokeModel.Where(p => p.Artist.StartsWith("3")).ToList();
                    List<KaraokeModel> postsNum4 = context.KaraokeModel.Where(p => p.Artist.StartsWith("4")).ToList();
                    List<KaraokeModel> postsNum5 = context.KaraokeModel.Where(p => p.Artist.StartsWith("5")).ToList();
                    List<KaraokeModel> postsNum6 = context.KaraokeModel.Where(p => p.Artist.StartsWith("6")).ToList();
                    List<KaraokeModel> postsNum7 = context.KaraokeModel.Where(p => p.Artist.StartsWith("7")).ToList();
                    List<KaraokeModel> postsNum8 = context.KaraokeModel.Where(p => p.Artist.StartsWith("8")).ToList();
                    List<KaraokeModel> postsNum9 = context.KaraokeModel.Where(p => p.Artist.StartsWith("9")).ToList();
                    postsA = context.KaraokeModel.Where(p => p.Artist.StartsWith("A")).ToList();
                    postsB = context.KaraokeModel.Where(p => p.Artist.StartsWith("B")).ToList();
                    postsC = context.KaraokeModel.Where(p => p.Artist.StartsWith("C")).ToList();
                    postsD = context.KaraokeModel.Where(p => p.Artist.StartsWith("D")).ToList();
                    postsE = context.KaraokeModel.Where(p => p.Artist.StartsWith("E")).ToList();
                    postsF = context.KaraokeModel.Where(p => p.Artist.StartsWith("F")).ToList();
                    postsG = context.KaraokeModel.Where(p => p.Artist.StartsWith("G")).ToList();
                    postsH = context.KaraokeModel.Where(p => p.Artist.StartsWith("H")).ToList();
                    postsI = context.KaraokeModel.Where(p => p.Artist.StartsWith("I")).ToList();
                    postsJ = context.KaraokeModel.Where(p => p.Artist.StartsWith("J")).ToList();
                    postsK = context.KaraokeModel.Where(p => p.Artist.StartsWith("K")).ToList();
                    postsL = context.KaraokeModel.Where(p => p.Artist.StartsWith("L")).ToList();
                    postsM = context.KaraokeModel.Where(p => p.Artist.StartsWith("M")).ToList();
                    postsN = context.KaraokeModel.Where(p => p.Artist.StartsWith("N")).ToList();
                    postsO = context.KaraokeModel.Where(p => p.Artist.StartsWith("O")).ToList();
                    postsP = context.KaraokeModel.Where(p => p.Artist.StartsWith("P")).ToList();
                    postsQ = context.KaraokeModel.Where(p => p.Artist.StartsWith("Q")).ToList();
                    postsR = context.KaraokeModel.Where(p => p.Artist.StartsWith("R")).ToList();
                    postsS = context.KaraokeModel.Where(p => p.Artist.StartsWith("S")).ToList();
                    postsT = context.KaraokeModel.Where(p => p.Artist.StartsWith("T")).ToList();
                    postsU = context.KaraokeModel.Where(p => p.Artist.StartsWith("U")).ToList();
                    postsV = context.KaraokeModel.Where(p => p.Artist.StartsWith("V")).ToList();
                    postsW = context.KaraokeModel.Where(p => p.Artist.StartsWith("W")).ToList();
                    postsX = context.KaraokeModel.Where(p => p.Artist.StartsWith("X")).ToList();
                    postsY = context.KaraokeModel.Where(p => p.Artist.StartsWith("Y")).ToList();
                    postsZ = context.KaraokeModel.Where(p => p.Artist.StartsWith("Z")).ToList();
                    postsNum = (List<KaraokeModel>)postsNum0.Concat(postsNum1).Concat(postsNum2).Concat(postsNum3).Concat(postsNum4).Concat(postsNum5).Concat(postsNum6).Concat(postsNum7).Concat(postsNum8).Concat(postsNum9);
                }
                catch (Exception ex)
                {

                }
            }
        }
        public static List<KaraokeModel> getIndex(String a)
        {
            a.ToLower();
            switch (a)
            {
                case "a":
                    return postsA;
                case "b":
                    return postsB;
                case "c":
                    return postsC;
                case "d":
                    return postsD;
                case "e":
                    return postsE;
                case "f":
                    return postsF;
                case "g":
                    return postsG;
                case "h":
                    return postsH;
                case "i":
                    return postsI;
                case "j":
                    return postsJ;
                case "k":
                    return postsK;
                case "l":
                    return postsL;
                case "m":
                    return postsM;
                case "n":
                    return postsN;
                case "o":
                    return postsO;
                case "p":
                    return postsP;
                case "q":
                    return postsQ;
                case "r":
                    return postsR;
                case "s":
                    return postsS;
                case "t":
                    return postsT;
                case "u":
                    return postsU;
                case "v":
                    return postsV;
                case "w":
                    return postsW;
                case "x":
                    return postsX;
                case "y":
                    return postsY;
                case "z":
                    return postsZ;
                default:
                    return postsNum;
            
            }
        }
    }
}
