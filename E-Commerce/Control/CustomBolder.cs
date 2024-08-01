using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Control
{
    public class CustomBolder: Border
    {
        public CustomBolder()
        {
            AddCornerRadius();
        }
        public List<int> CornerValues = new List<int> { 10,40,70,100};

        public void AddCornerRadius()
        {
            var index = new Random().Next(maxValue: 4);
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(CornerValues[index])
            };
        }
    }
}
