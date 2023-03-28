using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Repository
{
    public interface Equipment_hist_posi_repository
    {
        Task<Equipment_position_history>GetByIdAysnc(int id);
        Task<ICollection<Equipment_position_history>> GetAll();
        Task<Equipment_position_history>CreateAsync(Equipment_position_history equipment_position_history);
        Task EditAsync(Equipment_position_history equipment_);
        Task DeleteAsync(Equipment_position_history equipment_Position_History);
    }
}
