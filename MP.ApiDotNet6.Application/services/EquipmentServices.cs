using AutoMapper;
using MP.apiDotNet6.Domain.Repository;
using MP.ApiDotNet6.Application.Dtos;
using MP.ApiDotNet6.Application.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.services
{
    public class EquipmentServices : Equipment_Interface
    {
        private readonly Equipmenty_repository equipmenty_Repository;
        private readonly IMapper _mapper;
        public EquipmentServices() 
        {
        }
        public async Task<ResultServices<Equipment_Dtos>> CreateAsync(Equipment_Dtos equipment_Dtos) 
        {
            if (equipment_Dtos == null)
                return ResultServices.Fail<Equipment_Dtos>("Objetto deve ser informado");
            var result = new ResultServices<Equipment_Dtos>().Validate(equipment_Dtos: Equipment_Dtos);
            if (!result.IsValid)
                return ResultServices.RequestError<Equipment_Dtos>("Problemas a resolver", result);

            var Equipment = _mapper.Map<Equipment>(Equipment_Dtos);
            var Data = await Equipmenty_repository.CreateAsync(Equipment);
            return ResultServices.Ok<Equipment_Dtos>(_mapper.Map<Equipment_Dtos>(Data));
        }

        public Task CreateAsync(Equip_model_Dtos equip_Model_Dtos)
        {
            throw new NotImplementedException();
        }
    }
}
