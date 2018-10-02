using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Firm
    {
        protected string Name;
        protected int Income;
        protected int Rating;
        protected int Q;

        public Firm(string name, int income, int rating)
        {
            this.Name = name;
            this.Income = income;
            this.Rating = rating;
        }

        public virtual int QFunction()
        {
            Q = Income * Rating;
            return Q;
        }
        public string ShowInfo()
        {
            return Convert.ToString(Name + ' ' + Income + ' ' + Rating);
        }
    }
}
