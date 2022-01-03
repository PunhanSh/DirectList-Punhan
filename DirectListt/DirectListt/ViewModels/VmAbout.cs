using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmAbout : VmLayout
    {
        public About About { get; set; }
        public Setting Setting { get; set; }
        public Banner Banner { get; set; }

    }
}
