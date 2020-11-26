using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingTrails.Web.Features.Home
{
    public class Trail
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
        public int Length { get; set; }
    }
}
