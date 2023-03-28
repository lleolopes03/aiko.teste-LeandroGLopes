using MP.apiDotNet6.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Repository
{
    public interface Equip_model_repository
    {
        Task<Equip_model> GetByIdAysnc(int id); 
        Task<ICollection<Equip_model>> GetAll();
        Task<Equip_model>CreateAsync(Equip_model model);
        Task EditAsync(Equip_model model);
        Task DeleteAsync(Equip_model model);
    }
}
