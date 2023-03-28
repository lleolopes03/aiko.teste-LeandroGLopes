using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Repository
{
    public interface Equipment_state_history_repository
    {
        Task<Equipment_state_history> GetByIdAysnc(int id);
        Task<ICollection<Equipment_state_history>> GetAll();
        Task<Equipment_state_history>CreateAsync(Equipment_state_history entity);
        Task EditAsync(Equipment_state_history entity);
        Task DeleteAsync(int id);
    }
}
