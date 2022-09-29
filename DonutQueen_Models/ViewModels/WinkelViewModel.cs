using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Models.ViewModels
{
    public class WinkelViewModel
    {
        public string SearchQuery { get; set; }
        public string Url = @"https://www.thomasmore.be/sites/default/files/homepage/2021_hoofdbeeldtm_homepage.png";
       public IEnumerable<Winkel> Winkels { get; set; }
    }
}
