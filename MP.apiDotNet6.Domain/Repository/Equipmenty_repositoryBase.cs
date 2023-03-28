using MP.apiDotNet6.Domain.Entidades;

namespace MP.apiDotNet6.Domain.Repository
{
    public class Equipmenty_repositoryBase
    {

        public static Task CreateAsync(object equipment)
        {
            throw new NotImplementedException();
        }
        Task<Equipment> CreateAsync(Equipment equipment);
        Task DeleteAsync(Equipment equipment);
        Task EditAsync(Equipment equipment);

        Task<Equipment> GetbyIdasync(int id);
        Task<ICollection<Equipment>> GetEquipmentAsync();
    }
}