﻿namespace DesignPatterns.Core.Structural.Facade
{
    public class YouTubeApp : IApp
    {
        public async Task PlayAsync(Guid videoId)
        {
            Console.WriteLine($"Playing {videoId}");
            await Task.CompletedTask;
        }
    }
}
