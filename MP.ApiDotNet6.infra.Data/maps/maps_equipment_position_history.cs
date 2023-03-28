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
    public class maps_equipment_position_history:IEntityTypeConfiguration<Equipment_position_history>
    {
        public void Configure(EntityTypeBuilder<Equipment_position_history>builder) 
        {
            builder.ToTable("estado_equipment");
            builder.HasKey(c => c.date);
            builder.Property(c =>c.date)
                .HasColumnName("data");
            builder.Property(c => c.lat)
                .HasColumnName("lat");
            builder.Property(c => c.lon)
                .HasColumnName("long");
            builder.Property(c=>c.equip_id)
                .HasColumnName("idequipmento");
            builder.HasMany(c => c.equipment_Model_State_Hourly_Earnings)
                .WithOne(p => p.equipment_state_id)
                .HasForeignkey(c => c.equip.id);
            builder.HasMany(c=>c.Equip_Models)
                .WithOne(p=>p.equip_position)
                .HasForeignKey(c=>c.equip.id);





        
        }
    }
}
