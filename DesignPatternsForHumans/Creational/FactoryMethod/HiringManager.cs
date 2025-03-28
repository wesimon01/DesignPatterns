namespace DesignPatternsForHumans.Creational.FactoryMethod
{
    public abstract class HiringManager
    { 
        protected abstract IInterviewer CreateInterviewer();

        public void TakeInterview()
        {
            var interviewer = CreateInterviewer();
            interviewer.AskQuestions();
        }
    }
}

