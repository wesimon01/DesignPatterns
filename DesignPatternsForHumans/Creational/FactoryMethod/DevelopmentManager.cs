namespace DesignPatternsForHumans.Creational.FactoryMethod
{
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer CreateInterviewer()
        {
            return new Developer();
        }
    }
}

