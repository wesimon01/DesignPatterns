using System.ComponentModel.Design;
using System.Drawing;

namespace DesignPatternsForHumans.Creational.Builder
{
    public class Burger
    {
        protected int size;
        protected bool cheese;
        protected bool tomato;
        protected bool mustard;
        protected bool bacon;

        public Burger(BurgerBuilder builder)
        {
            size = builder.Size;
            cheese = builder.Cheese;
            tomato = builder.Tomato;
            mustard = builder.Mustard;
            bacon = builder.Bacon;
        }
    }
}
