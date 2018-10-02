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

        public Firm(string name, int income, int rating)
        {
            this.Name = name;
            this.Income = income;
            this.Rating = rating;
        }

        public virtual int QFunction()
        {
            return Income * Rating;
        }

        public string ShowInfo()
        {
            return Convert.ToString(Name + ' ' + Income + ' ' + Rating);
        }
    }
}
