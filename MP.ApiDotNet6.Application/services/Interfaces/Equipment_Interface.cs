using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.services.Interfaces
{
    public class Equipment_Interface
    {
        private Task<ResultServices<Equipment_Dtos>> CreateAsync(Equipment_Dtos equipment_Dtos);
    }
}
