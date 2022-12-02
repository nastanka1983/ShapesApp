using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    public abstract class ShapeWithArea : Shape
    {
        protected ShapeWithArea(float x, float y) : base(x, y)
        {
        }


        public abstract float Area();
    }
}
