using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class history_repository : Equipment_state_history_repository

    {
        private readonly applicationDbcontext _db;

        public history_repository(applicationDbcontext db)
        {
            _db = db;
        }

        public async Task<Equipment_state_history> CreateAsync(Equipment_state_history entity)
        {
            _db.Add(entity);
            await _db.SaveChangesAsync();
            return entity;

        }

        public async Task DeleteAsync(Equipment_state_history entity)
        
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Equipment_state_history entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Equipment_state_history>> GetAll(Equipment_state_history entity)
        {
            return await _db.entity.toListAsync();
        }

        public async Task<Equipment_state_history> GetByIdAysnc(Equipment_state_history entity)
        {
            return await _db.Entity.FirstOrdefaultAsync(x => x.Id == Id);
        }
    }
}
