using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojista.Model
{
    public class Order
    {

        public int ID { get; set;  }

        public Solicitation Solicitation { get; set; }

        public string Status { get; set; }
    }
}
