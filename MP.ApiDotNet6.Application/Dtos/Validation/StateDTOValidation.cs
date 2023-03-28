using FluentValidation;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Validation
{
    public class StateDTOValidation : AbstractValidator<State_DTos>
    {
        public StateDTOValidation() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite o estado do equipamento");
            RuleFor(x => x.color)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite a cor");
        }
    }
}
