namespace DesignPatterns.Core.Structural.Composite
{
    public abstract class LearningResource
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract TimeSpan Duration { get; }
        public virtual void Add(LearningResource learningResource) { }
        public virtual void Remove(LearningResource learningResource) { }
        public virtual LearningResource? GetLearningResource(string name) { return null; }
    }
}
