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
    public class maps_equipment_eranings:IEntityTypeConfiguration<Equipment_model_state_hourly_earnings>
    {
        public void Configure(EntityTypeBuilder<Equipment_model_state_hourly_earnings> builder)
        {
            builder.ToTable("Ganhos_Hora");
            builder.HasKey(c => c.value);
            builder.Property(c => c.value)
                .HasColumnName("valor");
            builder.Property(c => c.equipment_model_id)
                .HasColumnName("idequip_model");
            builder.Property(c => c.equipment_state_id)
                .HasColumnName("idequip_state");
        }
    }
}
