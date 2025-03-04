using DesignPatterns.Core.Structural.Composite;

namespace DesignPatterns.UI.Services
{
    public class CompositeService
    {
        public void Run()
        {
            Bundle rootBundle = new("Root Bundle");

            LearningResource courseA = new Course("CourseA", TimeSpan.FromHours(2), 100.00m);
            LearningResource courseB = new Course("CourseB", TimeSpan.FromHours(4), 165.99m);

            rootBundle.Add(courseA);
            rootBundle.Add(courseB);

            Console.WriteLine($"{rootBundle.Name} price is ${rootBundle.Price}");
        }
    }
}
