using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CharmsFluffyBears.Models
{
    public class FluffyBearsSizeViewModel
    {
        public List<FluffyBears> FluffyBears { get; set; }
        public SelectList Size { get; set; }
        public string FluffyBearsSize { get; set; }
        public string SearchString { get; set; }
    }
}
