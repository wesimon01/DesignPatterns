namespace DesignPatternsForHumans.Creational.Builder
{
    public class BurgerBuilder
    {
        public int Size { get; }
        public bool Cheese { get; private set; }
        public bool Tomato { get; private set; }
        public bool Mustard { get; private set; }
        public bool Bacon { get; private set; }

        public BurgerBuilder(int size)
        {
            Size = size;
        }

        public BurgerBuilder AddCheese()
        {
            Cheese = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            Tomato = true;
            return this;
        }

        public BurgerBuilder AddMustard()
        {
            Mustard = true;
            return this;
        }

        public BurgerBuilder AddBacon()
        {
            Bacon = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
        
    }
  
}
