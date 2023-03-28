using FluentValidation;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Validation
{
    public class EquipmentDTOValidation :AbstractValidator<Equipment_Dtos>
    {
        public EquipmentDTOValidation() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome deve ser inserido");

        }
    }
}
