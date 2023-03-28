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
    public class maps_equipment : IEntityTypeConfiguration<Equipment>
    {
       public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("equipment");

            builder.HasKey(c => c.id);

            builder.Property(c => c.id)
                .HasColumnName("Idequipment")
                .UseIdentityColumn();
            builder.Property(c =>c.Name)
                .HasColumnName("Nome");
            
            
             

        }

    }
        
   
   
}
