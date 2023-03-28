using MP.apiDotNet6.Domain.Entidades;
using MP.apiDotNet6.Domain.Repository;
using MP.ApiDotNet6.infra.Data.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.infra.Data.Repository
{
    public class Position_history_repository : Equipment_hist_posi_repository
    {
        private readonly applicationDbcontext _db;

        public Position_history_repository(applicationDbcontext db)
        {
            _db = db;
        }

        public async Task<Equipment_position_history> CreateAsync(Equipment_position_history equipment_position_history)
        {
            _db.Add(equipment_position_history);
            await _db.SaveChangesAsync();
            return equipment_position_history;
        }

        public async Task DeleteAsync(Equipment_position_history equipment_Position_History)
        {
            _db.Remove(equipment_Position_History);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Equipment_position_history equipment_)
        {
            _db.Update(equipment_);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Equipment_position_history>> GetAll()
        {
            return await _db.DisposeAsync.TolistAsync();
        }

        public async Task<Equipment_position_history> GetByIdAysnc(int id)
        {
            return await _db.DisposeAsync,FirstOrDefaultAsync(x=>x.Id == id);
        }
    }
}
