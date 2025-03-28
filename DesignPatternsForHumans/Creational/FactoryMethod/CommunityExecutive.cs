namespace DesignPatternsForHumans.Creational.FactoryMethod
{
    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about real estate development.");
        }
    }
}

