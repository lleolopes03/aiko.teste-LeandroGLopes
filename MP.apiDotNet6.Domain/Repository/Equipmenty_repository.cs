using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Repository
{
    public class Equipmenty_repository
    {

        Task<Equipment> GetByIdAsync(int id);       
        Task<Equipment>CreateAsync(Equipment equipment);
        Task EditAsync(Equipment equipment);    
        Task DeleteAsync(Equipment equipment);

        public static Task CreateAsync(object equipment)
        {
            throw new NotImplementedException();
        }
    }
}
