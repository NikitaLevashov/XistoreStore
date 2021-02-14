using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace XistoreStore.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) :
          base(options)
        { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                   new Product
                   {
                        ProductID = 1,
                        Name = "Poco F2 Pro",
                        Description = "6.67 AMOLED(1080x2400) / 2 SIM / Android 10.0 / 2840 МГц(Ядер: 8) / 6Gb / 128Gb / 64 Мп + 12 Мп + 5 Мп + 5 Мп / 4 700 мАч / пурпурный",
                        Category = "POCO",
                        Price = 1699
                   },

                    new Product
                    {
                        ProductID = 2,
                        Name = "Poco X3",
                        Description = "6.67 IPS(1080x2400) / 2 SIM / Android 10.0 / 2300 МГц(Ядер: 8) / 6Gb / 128Gb / 64 Мп + 13 Мп + 2 Мп + 2 Мп / 5 160 мАч / чёрный",
                        Category = "POCO",
                        Price = 999
                    },

                    new Product
                    {
                        ProductID = 3,
                        Name = "Redmi Note 9 Pro",
                        Description = "6.67 IPS (1080x2400) /2 SIM / Android 10 с оболочкой MIUI 11 / 2300 МГц (Ядер: 8) / 6Gb /64Gb / 64 Мп + 8 Мп + 2 Мп + 5 Мп / 5 020 мАч / серый",
                        Category = "Redmi Note",
                        Price = 729
                    },

                    new Product
                    {
                        ProductID = 4,
                        Name = "Redmi Note 9S",
                        Description = "6.67 (1080x2400) /2 SIM / 2300 МГц (Ядер: 8) / 4Gb /64Gb / 48 Мп + 8 Мп + 5 Мп + 2 Мп / 5 020 мАч / Синяя Мгла",
                        Category = "Redmi Note",
                        Price = 649
                    },

                    new Product
                    {
                        ProductID = 5,
                        Name = "Redmi Note 9",
                        Description = "6.53 IPS(1080x2340) / 2 SIM / Android 10 с оболочкой MIUI 11 / 2000 МГц(Ядер: 8) / 3Gb / 64Gb / 48 Мп + 8 Мп + 2 Мп + 2 Мп / 5 020 мАч / серый",
                        Category = "Redmi Note",
                        Price = 559
                    },

                    new Product
                    {
                        ProductID = 6,
                        Name = "Redmi Note 8 Pro",
                        Description = "6.53 IPS (1080x2340) /2 SIM / Android 9 Pie / 2050 МГц (Ядер: 8) / 6Gb /64Gb / 64 Мп + 8 Мп + 2 Мп + 2 Мп / 4 500 мАч / зелёный",
                        Category = "Redmi Note",
                        Price = 649
                    },

                    new Product
                    {
                        ProductID = 7,
                        Name = "Redmi Note 9T",
                        Description = "6.53 IPS(1080x2340) / 2 SIM / Android 10.0 / (Ядер: 8) / 4Gb / 128Gb / 48 Мп + 2 Мп + 2 Мп / 5 000 мАч / чёрный",
                        Category = "Redmi Note",
                        Price = 799
                    },


                    new Product
                    {
                        ProductID = 8,
                        Name = "Redmi 9",
                        Description = "6.53 IPS(1080x2340) / 2 SIM / Android 10 с оболочкой MIUI 11 / 2000 МГц(Ядер: 8) / 3Gb / 32Gb / 13 Мп + 8 Мп + 2 Мп + 5 Мп / 5 020 мАч / зелёный",
                        Category = "Redmi",
                        Price = 449
                    },

                    new Product
                    {
                        ProductID = 9,
                        Name = "Redmi 9A",
                        Description = "6.53 IPS(720x1600) / 2 SIM / Android 10.0 / 2000 МГц(Ядер: 8) / 2Gb / 32Gb / 13 Мп / 5 000 мАч / синийй",
                        Category = "Redmi",
                        Price = 299
                    },

                    new Product
                    {
                        ProductID = 10,
                        Name = "Redmi 9C",
                        Description = "6.53 IPS(720x1600) / 2 SIM / Android 10 с оболочкой MIUI 12 / 2300 МГц(Ядер: 8) / 3Gb / 64Gb / 13 Мп + 2 Мп + 2 Мп / 5 000 мАч / синий",
                        Category = "Redmi",
                        Price = 399
                    },

                     new Product
                     {
                         ProductID = 11,
                         Name = "Xiaomi Mi10T",
                         Description = "6.67 IPS (1080x2400) /2 SIM / Android 10.0 / 2840 МГц (Ядер: 8) / 8Gb /128Gb / 64 Мп + 13 Мп + 5 Мп / 5 000 мАч / чёрный",
                         Category = "Mi",
                         Price = 1499
                     }
                });

        }
}   }
