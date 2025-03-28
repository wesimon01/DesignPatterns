namespace DesignPatternsForHumans.Creational.FactoryMethod
{
    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about design patterns.");
        }
    }
}

