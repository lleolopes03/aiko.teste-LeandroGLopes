using AutoMapper;
using MP.apiDotNet6.Domain.Entidades;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Mappings
{
    public class DtotoDomainsMapping : Profile 
    {
        public DtotoDomainsMapping() 
        {
            CreateMap<Equipment_Dtos,Equipment>();
        
        }    
    }
    
}
