﻿namespace DesignPatterns.Core.Structural.Facade
{
    public class Connection
    {
        public async Task<IApp> LaunchAppAsync(string appId)
        {
            Console.WriteLine($"Launching {appId}");

            return new YouTubeApp();
        }
    }
}
