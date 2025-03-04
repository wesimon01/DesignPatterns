﻿namespace DesignPatterns.Core.Creational.Factory
{
    public static class LevelFactory
    {
        public static Level CreateLevel(int levelNumber)
        {
            return levelNumber switch
            {
                1 => new CaveLevel(),
                2 => new HauntedHouseLevel(),
                _ => throw new InvalidOperationException($"Level number {levelNumber} not found"),
            };
        }
    }
}
