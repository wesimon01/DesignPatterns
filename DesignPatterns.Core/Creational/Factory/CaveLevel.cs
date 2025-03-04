namespace DesignPatterns.Core.Creational.Factory
{
    public class CaveLevel : Level
    {
        protected override IEnemy CreateEnemy()
        {
            return new Goblin();
        }
    }
}
