using MP.apiDotNet6.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.apiDotNet6.Domain.Entidades
{
    public sealed class Equipment_position_history
    {
        public DateTime date { get; private set; }
        public double lat { get;private set; }
        public double lon { get; private set; }
        public int equip_id { get; private set; }
        public ICollection<Equipment_model_state_hourly_earnings>equipment_Model_State_Hourly_Earnings { get; set; }
        public ICollection<Equip_model>Equip_Models { get; set; }
        
        public Equipment_position_history( DateTime date,double lat,double lon)
        {
           Validation(date,lat,lon);
            equipment_Model_State_Hourly_Earnings =new List<Equipment_model_state_hourly_earnings>();
            Equip_Models = new List<Equip_model>();

        }

        private void Validation(DateTime date, double lat, double lon)
        {
            throw new NotImplementedException();
        }
    }
}
