namespace DesignPatterns.Core.Creational.Factory
{
    public class HauntedHouseLevel : Level
    {
        protected override IEnemy CreateEnemy()
        {
            return new Ghost();
        }
    }
}
