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
    public class maps_equipment_state : IEntityTypeConfiguration<Equipments_state>
    {
        public void Configure(EntityTypeBuilder<Equipments_state> builder) 
        {

            builder.ToTable("equipment_state");
            builder.HasKey(c => c.id);
            builder.Property(c => c.id)
                .HasColumnName("idstate")
                .UseIdentityColumn();
            builder.Property(c => c.Name)
                .HasColumnName("nome");
            builder.Property(c => c.color)
                .HasColumnName("cor");
            builder.HasMany(c => c.Equipment_Position_Histories)
                .WithOne(p => p.equip_id)
                .HasforeignKey(c => c.id);
        }
    }
}
