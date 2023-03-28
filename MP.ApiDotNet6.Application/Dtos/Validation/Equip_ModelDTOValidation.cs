using FluentValidation;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Validation
{
    public class Equip_ModelDTOValidation : AbstractValidator<Equip_model_Dtos>

    {
        public Equip_ModelDTOValidation() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite o nome da cor");
        }
       
    }
}
