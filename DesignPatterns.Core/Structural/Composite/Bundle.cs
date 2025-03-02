
namespace DesignPatterns.Core.Structural.Composite
{
    // bundle is the composite
    public class Bundle(string name) : LearningResource
    {
        private readonly List<LearningResource> children = new();

        public override decimal Price =>       
            children.Sum(c => c.Price);
        
        public override TimeSpan Duration =>  
            new(children.Sum(c => c.Duration.Ticks));
        
        public override void Add(LearningResource learningResource)
        {
            children.Add(learningResource);
        }

        public override void Remove(LearningResource learningResource)
        {
            children.Remove(learningResource);
        }

        public override LearningResource? GetLearningResource(string name)
        {
            return children.SingleOrDefault(ls => ls.Name.Equals(name));
        }

        public override string Name => name;
    }
}
