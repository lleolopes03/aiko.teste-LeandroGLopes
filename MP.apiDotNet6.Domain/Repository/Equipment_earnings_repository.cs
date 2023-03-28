using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Repository
{
    public interface Equipment_earnings_repository
    {
        Task<Equipment_model_state_hourly_earnings>GetByIdAysnc(int id);
        Task<ICollection<Equipment_model_state_hourly_earnings>> GetAll();
        Task<Equipment_model_state_hourly_earnings>CreateAsync(Equipment_model_state_hourly_earnings model);
        Task EditAsync(Equipment_model_state_hourly_earnings entity);
        Task DeleteAsync(Equipment_model_state_hourly_earnings equipment_Model_State_Hourly_Earnings);
    }
}
