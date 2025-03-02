namespace DesignPatterns.Core.Structural.Composite
{
    public class Course(string name, TimeSpan duration, decimal price) : LearningResource
    {
        public override TimeSpan Duration => duration;

        public override string Name => name;

        public override decimal Price => price;  
    }
}
