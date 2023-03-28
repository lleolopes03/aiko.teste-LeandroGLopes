using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MP.ApiDotNet6.Application.Dtos;
using MP.ApiDotNet6.Application.services;
using MP.ApiDotNet6.Application.services.Interfaces;

namespace MP.ApiDotNet6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class Equipment_controller : ControllerBase
    {
        private readonly EquipmentServices equipmentServices;

        public Equipment_controller(EquipmentServices equipmentServices) 
        {
            equipmentServices = equipmentServices;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Equipment_Dtos equipment_Dtos)
        {
            var result = await equipmentServices.CreateAsync(equipment_Dtos);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }


         

        
    }
}
