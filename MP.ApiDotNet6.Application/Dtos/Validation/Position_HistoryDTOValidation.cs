using FluentValidation;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Validation
{
    public class Position_HistoryDTOValidation :AbstractValidator<Position_History_Dtos>
    {
        public Position_HistoryDTOValidation() 
        {
            RuleFor(x => x.date)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite a data");
            RuleFor(y => y.lat)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite o valor da latitude");
            RuleFor(z => z.lon)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite o valor da longitude");
            
          



        }
    }
}
