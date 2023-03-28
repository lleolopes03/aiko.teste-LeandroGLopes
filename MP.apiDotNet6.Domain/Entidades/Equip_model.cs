using MP.apiDotNet6.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Entidades
{
    public sealed class Equip_model

    {
        public int id { get;private set; }
        public int equip_position { get; private set; }
        public string Name { get; private set; }
        public ICollection<Equipment> equipment { get;set; }
        public ICollection<Equipment_model_state_hourly_earnings> equipment_state_hourly_ {get; set; }
        public Equip_model(int id, int equip_position, string name)
        {
            Validation(Name);
            equipment = new List<Equipment>();
            equipment_state_hourly_ =new List<Equipment_model_state_hourly_earnings>();

        }
        public Equip_model(int id, string Name, int equip_position)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero");
            id = id;
            Validation(Name);
            this.equip_position = equip_position;
        }
        private void Validation(string Name)
        {
            DomainValidationException.When(string.IsNullOrEmpty(Name), "Nome do modelo do equipamento deve ser informado");
        }

    }
}
