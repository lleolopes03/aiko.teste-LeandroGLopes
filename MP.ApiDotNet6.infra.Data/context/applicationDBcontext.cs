using Microsoft.EntityFrameworkCore;
using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.infra.Data.context
{
    public class applicationDbcontext :DbContext
    {
        public applicationDbcontext(DbContextOptions<applicationDbcontext> options):base(options)
        {}

        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Equip_model> Equipment_model { get; set; }
        public DbSet<Equipment_model_state_hourly_earnings>ganhos_hora { get; set; }
        public DbSet<Equipment_position_history>estado_equipment { get; set; }
        public DbSet<Equipment_state_history>historic_position { get; set; }
        public DbSet<Equipments_state>equipments_States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(applicationDbcontext).Assembly);
        }
    }
}
