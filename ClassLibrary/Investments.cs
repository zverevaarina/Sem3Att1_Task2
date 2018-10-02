using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Investments : Firm
    {
        public int P;

        public Investments (string name, int income, int rating, int p): base (name, income, rating)
        {
            this.P = p;
        }

        public override int QFunction()
        {
            return P*P*P+base.Q;
        }
    }
}
