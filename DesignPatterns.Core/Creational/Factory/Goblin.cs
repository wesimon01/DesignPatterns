namespace DesignPatterns.Core.Creational.Factory
{
    public class Goblin : IEnemy
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
