using FluentValidation;
using MP.ApiDotNet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Validation
{
    public class State_HistoryDTOValidation : AbstractValidator<State_History_DTos>
    {
        public State_HistoryDTOValidation() 
        {
            RuleFor(x => x.date)
                .NotEmpty()
                .NotNull()
                .WithMessage("Digite a data");
        }
    }
}
