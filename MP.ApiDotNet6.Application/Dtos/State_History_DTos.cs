using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Dtos
{
    public class State_History_DTos
    {
        public DateTime date { get;  set; }
        public int equipment_id { get;  set; }
        public int equipment_state_id { get;  set; }
    }
}
