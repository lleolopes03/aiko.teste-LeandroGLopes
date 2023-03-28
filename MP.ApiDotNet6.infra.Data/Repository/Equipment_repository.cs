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
    public class Equipment_repositories: Equipmenty_repository
    {
        private readonly applicationDbcontext _db;

        public Equipment_repositories(applicationDbcontext db)
        {
            _db = db;
        }

        public async Task<Equipment> CreateAsync(Equipment equipment) 
        { 
            _db.Add(equipment);
            await _db.SaveChangesAsync();
            return equipment;
        }
        public async Task DeleteAsync(Equipment equipment) 
        {
            _db.Remove(equipment);
            await _db.SaveChangesAsync();
        }
       
        public  async Task EditAsync(Equipment equipment) 
        {
            _db.Update(equipment);
            await _db.SaveChangesAsync();
        }
        public async Task<Equipment> GetByIdAsync(int id) 
        {
            return await _db.Equipment.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<ICollection<Equipment>> GetEquipmentAsync() 
        {
            return await _db.Equipment.ToListAsync();
        
        }
    }
}
