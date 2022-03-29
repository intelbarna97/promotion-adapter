using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion
{
    internal class MediorToSenior : SeniorSoftwareEngineer
    {
        public MediorToSenior(MediorSoftwareEngineer mediorSoftwareEngineer) : base(mediorSoftwareEngineer.Person) { }
    }
}
