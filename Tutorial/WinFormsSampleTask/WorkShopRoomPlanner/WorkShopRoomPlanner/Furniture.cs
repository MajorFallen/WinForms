using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopRoomPlanner
{
    public class Furniture
    {
        private Point position;
        private Image icon;

        public Furniture(Point position, Image icon)
        {
            this.position = position;
            this.icon = icon;
        }
    }
}
