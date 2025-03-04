namespace DesignPatterns.Core.Creational.Factory
{
    public class Ghost : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine($"{this} attack");
        }

        public void Scream()
        {
            Console.WriteLine($"{this} scream");
        }
    }
}
