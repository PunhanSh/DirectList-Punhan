using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmContact : VmLayout
    {
        public Setting Setting { get; set; }
        public Banner Banner { get; set; }
        public Contact Contact { get; set; }

    }
}
