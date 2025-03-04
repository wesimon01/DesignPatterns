using DesignPatterns.Core.Creational.Factory;

namespace DesignPatterns.UI.Services
{
    public class FactoryService
    {
        private int caveLevelNumber = 1;
        private int hauntedHouseLevelNumber = 2;

        public void Run()
        {
            Level level1 = LevelFactory.CreateLevel(caveLevelNumber);
            level1.EncounterEnemy();

            Level level2 = LevelFactory.CreateLevel(hauntedHouseLevelNumber);
            level2.EncounterEnemy();
        }
    }
}
