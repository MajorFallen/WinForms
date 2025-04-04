using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopRoomPlanner
{
    public class Blueprint
    {
        public Bitmap Bitmap { get; private set; }
        private Color backgroundColor = Color.White;

        public BindingList<Furniture> Furnitures { get; private set; }



        public Blueprint(int width, int height)
        {
            Bitmap = new Bitmap(width, height);
            Furnitures = new BindingList<Furniture>();

            Draw();

        }
        public void Draw()
        {
            using (Graphics g = Graphics.FromImage(Bitmap))     
            {
                g.Clear(backgroundColor);
            }
        }

        public void AddFurniture(Furniture furniture)
        {
            Furnitures.Add(furniture);
        }

}
}
