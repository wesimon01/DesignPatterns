namespace DesignPatterns.Core.Creational.Factory
{
    public abstract class Level
    {
        protected abstract IEnemy CreateEnemy();

        public void EncounterEnemy()
        {
            IEnemy enemy = CreateEnemy();
            enemy.Attack();
            enemy.Scream();
        }
    }
}
