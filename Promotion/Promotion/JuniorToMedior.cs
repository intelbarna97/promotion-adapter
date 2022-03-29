using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion
{
    internal class JuniorToMedior : MediorSoftwareEngineer
    {
        public JuniorToMedior(JuniorSoftwareEngineer juniorSoftwareEngineer) : base(juniorSoftwareEngineer.Person){   }
    }
}
