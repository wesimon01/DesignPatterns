using DesignPatternsForHumans.Creational.Builder;
using DesignPatternsForHumans.Creational.FactoryMethod;

namespace DesignPatternsForHumans
{
    public sealed class Usages
    {
        public static void Program()
        {
            //Builder
            var burger = new BurgerBuilder(20)
                .AddMustard()
                .AddCheese()
                .AddTomato()
                .AddBacon()
                .Build();

            //Factory Method
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();

            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();


            //Abstract Factory

        }
    }
}
