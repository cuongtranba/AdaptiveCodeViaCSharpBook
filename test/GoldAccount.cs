using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class GoldAccount:BaseAccount
    {
        public override string GetInfo()
        {
            return "Gold account";
        }
    }
}
