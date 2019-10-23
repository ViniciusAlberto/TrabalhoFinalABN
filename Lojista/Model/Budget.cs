using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojista.Model
{
    public class Budget
    {

        public int ID { get; set; }

        public double Price { get; set; }

        public DateTime DateReceive { get; set; }

        public Solicitation Solicitation { get; set; }
    }
}
