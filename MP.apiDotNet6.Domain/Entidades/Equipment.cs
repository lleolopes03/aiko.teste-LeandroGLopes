using MP.apiDotNet6.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Entidades
{
    public sealed class Equipment
    {
        public int id { get; private set; }
        public string Name { get; private set; }
        public int equipment_model_id { get; private set; }

        public Equipment(int id, string name, int equipment_model_id)
        {
            Validation(Name);
        }
        public Equipment(int id, string Name)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero");
            id=id;
            Validation(Name);
        }
        private void Validation(string Name) 
        {
            DomainValidationException.When(string.IsNullOrEmpty(Name), "Nome do equipamento deve ser informado");
        }
    }
}
