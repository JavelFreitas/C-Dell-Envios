using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGoF
{
    class MotoCreator : Creator
    {
        public override Veiculo criar()
        {
            return new Moto();
        }
    }
}
