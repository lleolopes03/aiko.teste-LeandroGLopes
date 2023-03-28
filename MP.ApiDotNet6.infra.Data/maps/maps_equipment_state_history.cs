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
    public class maps_equipment_state_history:IEntityTypeConfiguration<Equipment_state_history>
    {
        public void Configure(EntityTypeBuilder<Equipment_state_history>builder) 
        {
            builder.ToTable("historic_position");
            builder.HasKey(c => c.date);
            builder.Property(c => c.date)
                .HasColumnName("data");
            builder.Property(c => c.equipment_id)
                .HasColumnName("equipmentid");
            builder.Property(c => c.equipment_state_id)
                .HasColumnName("equipament_state");



        
        }

    }
}
