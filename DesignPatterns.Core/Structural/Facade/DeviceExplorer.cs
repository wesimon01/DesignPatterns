﻿namespace DesignPatterns.Core.Structural.Facade
{
    public class DeviceExplorer
    {
        public async Task<IDevice> GetAsync(Guid deviceId)
        {
            Console.WriteLine($"Getting {deviceId}");
            return await Task.FromResult(new SmartTvDevice());
        }
    }
}
