using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Models
{
    public class LeverancierDonut : EntityId
    {
        public int DonutId { get; set; }
        public int LeverancierId { get; set; }
        public Leverancier Leverancier { get; set; }
        public Donut Donut { get; set; }
    }
}
