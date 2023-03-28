using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.infra.Data.maps
{
    public class maps_equip_model : IEntityTypeConfiguration<Equip_model>

    {
        public void Configure(EntityTypeBuilder<Equip_model> builder)
        {
            builder.ToTable("equipment_model");
            builder.HasKey(c => c.id);
            builder.Property(c=>c.id)
                .HasColumnName("idmodel")
                .UseIdentityColumn();
            builder.Property(c => c.equip_position)
                .HasColumnName("equipment_position");
            builder.Property(c => c.Name)
                .HasColumnName("cor");
            builder.HasMany(c => c.equipment)
                .WithOne(p => p.equipment_model_id)
                .HasForeignkey(c => id);
            builder.HasMany(c=>c.equipment_state_hourly_)
                .WithOne(p=>p.equipment_model_id)
                .HasForeignkey(c => id);


        }
    }
}
