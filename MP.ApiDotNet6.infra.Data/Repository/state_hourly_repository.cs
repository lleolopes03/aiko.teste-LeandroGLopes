using MP.apiDotNet6.Domain.Entidades;
using MP.apiDotNet6.Domain.Repository;
using MP.ApiDotNet6.infra.Data.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.infra.Data.Repository
{
    public class state_hourly_repository : Equipment_earnings_repository
    {
        private readonly applicationDbcontext _db;

        public state_hourly_repository(applicationDbcontext db)
        {
            _db = db;
        }

        
        public async Task<Equipment_model_state_hourly_earnings> CreateAsync(Equipment_model_state_hourly_earnings model)
        {
            _db.Add(model);
            await _db.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(Equipment_model_state_hourly_earnings equipment_Model_State_Hourly_Earnings)
        {
            _db.Remove(equipment_Model_State_Hourly_Earnings);
            await _db.SaveChangesAsync();

        }

        public async Task EditAsync(Equipment_model_state_hourly_earnings entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Equipment_model_state_hourly_earnings>> GetAll()
        {
            return await _db.Equipment_model_state_hourly_earning.ToListAsync();
        }

        public async Task<Equipment_model_state_hourly_earnings> GetByIdAysnc(int id)
        {
            return await _db.Equipment_model_state_hourly_ear.FirstOrDefaultAsync( x => x.Id == id);
        }
    }
}
