namespace DesignPatternsForHumans.Creational.FactoryMethod
{
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer CreateInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}

