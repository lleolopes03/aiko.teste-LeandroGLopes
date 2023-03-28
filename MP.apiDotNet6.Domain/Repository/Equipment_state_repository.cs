using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Repository
{
    public interface Equipment_state_repository
    {
        Task<Equipments_state>GetByIdAysnc(int id);
        Task<ICollection<Equipments_state>> GetAll();
        Task<Equipments_state> CreateAsync(Equipments_state equipments_state);
        Task EditAsync(Equipments_state equipments_);
        Task DeleteAsync(Equipments_state equipments_State);
    }
}
