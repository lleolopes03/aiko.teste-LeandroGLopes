using MP.apiDotNet6.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Entidades
{
    public sealed class Equipments_state
    {
        public int id { get;private set; }
        public string Name { get;private set; }
        public string color { get;private set; }
        public ICollection<Equipment_position_history>Equipment_Position_Histories { get; set; }

        public Equipments_state(string Name, string color)
        {
            Validation(Name, color);
            Equipment_Position_Histories = new List<Equipment_position_history>();
        }

        public Equipments_state(int id,string Name, string color) 
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero");
            id = id;
            Validation(Name,color);
            
        }

        private void Validation(string Name, string color)
        {
            DomainValidationException.When(string.IsNullOrEmpty(Name), "Nome do estado do equipamento deve ser fornecido");
            DomainValidationException.When(string.IsNullOrEmpty(color), "Deve colocar o nome da cor do estado do equipamento");

        }
    }

    
}
