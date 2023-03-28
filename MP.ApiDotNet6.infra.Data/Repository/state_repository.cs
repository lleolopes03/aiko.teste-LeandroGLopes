using MP.apiDotNet6.Domain.Entidades;
using MP.apiDotNet6.Domain.Repository;
using MP.ApiDotNet6.infra.Data.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.infra.Data.Repository
{
    public class state_repository : Equipment_state_repository
    {
        private readonly applicationDbcontext _db;

        public state_repository(applicationDbcontext db)
        {
            _db = db;
        }

        public async Task<Equipments_state> CreateAsync(Equipments_state equipments_state)
        {
            _db.Add(equipments_state);
            await _db.SaveChangesAsync();
            return equipments_state;
        }

        public async Task DeleteAsync(Equipments_state equipments_State)
        {
            _db.Remove(equipments_State);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Equipments_state equipments_)
        {
            _db.Update(equipments_);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Equipments_state>> GetAll()
        {
            return await _db.DisposeAsync();
        }

        public async Task<Equipments_state> GetByIdAysnc(int id)
        {
            return await _db.DisposeAsync.FirstOrDefaultAsync(x=>x.Id == id);
        }
    }
}
