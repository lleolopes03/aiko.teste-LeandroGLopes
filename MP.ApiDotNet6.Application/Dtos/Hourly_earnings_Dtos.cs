using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Dtos
{
    public class Hourly_earnings_Dtos
    {
        public decimal value { get;set; }
        public int equipment_model_id { get;  set; }
        public int equipment_state_id { get;  set; }
    }
}
