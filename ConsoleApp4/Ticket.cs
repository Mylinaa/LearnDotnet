using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Ticket
    {
        public Ticket(double distance) { 
            this.Distance = distance;
        }


        private double _distance;
        private double Distance
        {
            get { return _distance; }
            set { this._distance = value; }
        }
    }
}
