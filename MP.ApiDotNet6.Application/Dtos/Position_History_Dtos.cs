using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Dtos
{
    public class Position_History_Dtos
    {
        public DateTime date { get;  set; }
        public double lat { get;  set; }
        public double lon { get;  set; }
        public int equip_id { get;  set; }
    }
}
