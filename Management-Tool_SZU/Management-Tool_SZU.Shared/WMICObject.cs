using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Management_Tool_SZU.Shared
{
    public class WMICObject
    {
        DateTime _time;
        IPAddress _ip;
        string _name;
        int _value;
        string _additionalinformation;

        public WMICObject(DateTime time, IPAddress ip, string name, int value, string additionalinformation)
        {
            _time = time;
            _ip = ip;
            _name = name;
            _value = value;
            _additionalinformation = additionalinformation;
        }

        public DateTime Time { get => _time; set => _time = value; }
        public IPAddress Ip { get => _ip; set => _ip = value; }
        public string Name { get => _name; set => _name = value; }
        public int Value { get => _value; set => _value = value; }
        public string Additionalinformation { get => _additionalinformation; set => _additionalinformation = value; }


        public override string ToString()
        {
            return "";
            //
        }



    }
}
