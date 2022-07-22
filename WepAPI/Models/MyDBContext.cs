using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebAPI.Domain;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Entity.ModelConfiguration;

namespace WebAPI.DataAccess
{
    class MyDBContext : DbContext
    {
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Turret> Turrets { get; set; }
        public DbSet<PartNumberTool> PartNumberTool { get; set; }
        public DbSet<PartNumber> PartNumber { get; set; }
        public DbSet<ToolMachine> ToolMachine { get; set; }
        public DbSet<Machine> Machines { get; set; }
        
        public MyDBContext() : base("name=ToolsConnectionString")
        {
            Database.Log = sql => Debug.Write(sql);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Config");

            modelBuilder.Entity<Tool>().ToTable("Tools");
            modelBuilder.Entity<Turret>().ToTable("Turrets");
            modelBuilder.Entity<PartNumberTool>().ToTable("PartNumberTool");
            modelBuilder.Entity<PartNumber>().ToTable("PartNumbers");
            modelBuilder.Entity<ToolMachine>().ToTable("ToolMachine");
            modelBuilder.Entity<Machine>().ToTable("Machines");

            modelBuilder.Entity<PartNumberTool>().HasKey(p => new { p.PartNumber, p.ToolCode });

            modelBuilder.Entity<ToolMachine>().HasKey(t => new { t.IdTool, t.MachineCode });

      
            modelBuilder.Entity<ToolMachine>()
                .Property(t => t.IdTool)
                .HasMaxLength(50);
            modelBuilder.Entity<ToolMachine>()
                .Property(t => t.MachineCode)
                .HasMaxLength(50);
            modelBuilder.Entity<ToolMachine>()
                .HasRequired(tm => tm.Tool)
                .WithMany(t => t.ToolMachine)
                .HasForeignKey(tm => tm.IdTool);
            modelBuilder.Entity<ToolMachine>()
                .HasRequired(tm => tm.Machine)
                .WithMany(t => t.ToolMachine)
                .HasForeignKey(tm => tm.MachineCode);


            modelBuilder.Entity<Machine>()
                .HasKey(m => m.MachineCode);
            modelBuilder.Entity<Machine>()
                .Property(m => m.MachineCode)
                .HasMaxLength(50);
            modelBuilder.Entity<Machine>()
                .Property(m => m.Description)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Machine>()
                .Property(m => m.StoreToolsFileName)
                .HasMaxLength(250);
            modelBuilder.Entity<Machine>()
                .Property(m => m.Line)
                .HasMaxLength(50);

            modelBuilder.Entity<Tool>()
                .HasKey(t => t.IdTool);
            modelBuilder.Entity<Tool>()
                .Property(t => t.IdTool)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.BoschCode)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Tool>()
                .Property(t => t.Description)
                .HasMaxLength(100);
            modelBuilder.Entity<Tool>()
                .Property(t => t.PrimarySupplier)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.SecondarySupplier)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.PrimarySharpener)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.SecondarySharpener)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.Quantity)
                .IsOptional();
            modelBuilder.Entity<Tool>()
                .Property(t => t.PresettingQuoteNGEM1)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.PresettingQuoteNGEM2)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.PresettingDiameter)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.Life)
                .IsOptional();
            modelBuilder.Entity<Tool>()
                .Property(t => t.SProposal)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.FProposal)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.SValue)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.FValue)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.Refrigeration)
                .HasMaxLength(50);
            modelBuilder.Entity<Tool>()
                .Property(t => t.Accessories)
                .HasMaxLength(100);
           

            modelBuilder.Entity<PartNumber>()
                .HasKey(p => p.Code);
            modelBuilder.Entity<PartNumber>()
                .Property(p => p.Code)
                .HasMaxLength(50);
            modelBuilder.Entity<PartNumber>()
                .Property(p => p.Description)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<PartNumber>()
                .Property(p => p.Npk)
                .IsRequired();
            modelBuilder.Entity<PartNumber>()
                .Property(p => p.ToolFile)
                .HasMaxLength(200)
                .IsOptional();
            modelBuilder.Entity<PartNumber>()
                .Property(p => p.RelatedCode)
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<Turret>()
                .HasKey(t => t.TurretCode);
            modelBuilder.Entity<Turret>()
                .Property(t => t.TurretCode)
                .HasMaxLength(50);
            modelBuilder.Entity<Turret>()
                .Property(t => t.Description)
                .HasMaxLength(50)
                .IsRequired();


            // Altra possibile implementazione della relazione 1 a M
            //modelBuilder.Entity<PartNumberTool>()
            //    .HasRequired(p => p.ParentPartNumber)
            //    .WithMany(p => p.PartNumberTools)
            //    .HasForeignKey(p => p.PartNumber);

            modelBuilder.Entity<PartNumber>()
                .HasMany(p => p.PartNumberTools)
                .WithRequired(p => p.ParentPartNumber)
                .HasForeignKey(p => p.PartNumber); 

            modelBuilder.Entity<PartNumberTool>()
                .Property(p => p.PartNumber)
                .HasMaxLength(50);
            modelBuilder.Entity<PartNumberTool>()
                .Property(p => p.ToolCode)
                .HasMaxLength(50);
        }
    }
}
