using MP.apiDotNet6.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MP.apiDotNet6.Domain.Entidades
{
    public sealed class Equipment_model_state_hourly_earnings
    {
        public decimal value { get;private set; }   
        public int equipment_model_id { get; private set; }
        public int equipment_state_id { get; private set; }


        
        public Equipment_model_state_hourly_earnings(decimal value)
        {
            DomainValidationException.When(value < 0, "O valor deve ser informado");


            Validation(value);
        }
        private void Validation(decimal value)
        {
            DomainValidationException.When(value<0, "Nome do equipamento deve ser informado");
        }
    }
}
