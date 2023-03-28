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

    
    public class Equip_model_repositories : Equip_model_repository

    {
        private readonly applicationDbcontext _db;

        public Equip_model_repositories(applicationDbcontext db)
        {
            _db = db;
        }

        public async Task<Equip_model> CreateAsync(Equip_model model)
        {
            _db.Add(Equip_model);
            await _db.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(Equip_model model)
        {
            _db.Remove(model); 
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Equip_model model)
        {
            _db.Update(model);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Equip_model>> GetAll()
        {
            return await _db.Model.ToListAsync();
        }

        public async Task<Equip_model> GetByIdAysnc(int id)
        {
            return await _db.Model.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
