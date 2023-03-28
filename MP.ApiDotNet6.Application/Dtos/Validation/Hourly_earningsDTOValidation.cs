using FluentValidation;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Validation
{
    public class Hourly_earningsDTOValidation :AbstractValidator<Hourly_earnings_Dtos>
    {
        public Hourly_earningsDTOValidation() 
        {
            RuleFor(x => x.value)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite o valor");
        }
    }
}
