using MP.apiDotNet6.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MP.apiDotNet6.Domain.Entidades
{
    public sealed class Equipment_state_history
    {
        public DateTime date { get; private set; }
        public int equipment_id { get; private set; }
        public int equipment_state_id { get; private set; }


       
        public Equipment_state_history (DateTime date)
        {
            Validation(date);
        }

        private void Validation(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
