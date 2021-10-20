using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public class MedicineStockContext : DbContext
    {
        public MedicineStockContext()
        {
        }

        public MedicineStockContext(DbContextOptions<MedicineStockContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=tcp:medicinestockmicroservicedbserver.database.windows.net,1433;Initial Catalog=MedicineStock_db;User Id=divya214@medicinestockmicroservicedbserver;Password=Divya@214");
                    /*Server=LAPTOP-NI5UBAVP\\SQLEXPRESS; database=StockDataBase; integrated security=true*/
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MedicineStock>().HasData(
            new MedicineStock
            {
                Name = "Dolo 650",
                ChemicalComposition = "Paracetamol,Acetaminophen",
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("31-12-2022"),
                NumberOfTabletsInStock = 300
            },
            new MedicineStock
            {
                Name = "Orthoherb",
                ChemicalComposition = "Castor Plant,Adulsa,Neem,Guggul",
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("26-11-2021"),
                NumberOfTabletsInStock = 190
            },
            new MedicineStock
            {
                Name = "Cholecalciferol",
                ChemicalComposition = "Ergocalciferol,Cholecalciferol,22-DiHydroergoCalciferol",
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("10-11-2023"),
                NumberOfTabletsInStock = 200
            },
            new MedicineStock
            {
                Name = "Gaviscon",
                ChemicalComposition = "Magnesium,Oxide,Silicon,Sodium",
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("20-08-2022"),
                NumberOfTabletsInStock = 150
            },
            new MedicineStock
            {
                Name = "Hilact",
                ChemicalComposition = "Pancreatin,Dimethicone,Polydimethylsiloxane",
                TargetAilment = "Gynaecology",
                DateOfExpiry = DateTime.Parse("11-06-2024"),
                NumberOfTabletsInStock = 400
            },
             new MedicineStock
             {
                 Name = "Cyclopam",
                 ChemicalComposition = "Dicyclomine,Hydrochloride,Paracetamol",
                 TargetAilment = "Gynaecology",
                 DateOfExpiry = DateTime.Parse("02-11-2025"),
                 NumberOfTabletsInStock = 500
             }
            );
        }
        public virtual DbSet<MedicineStock> MedicineStocks { get; internal set; }
    }
}
