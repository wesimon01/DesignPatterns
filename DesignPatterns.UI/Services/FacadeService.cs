using DesignPatterns.Core.Structural.Facade;

namespace DesignPatterns.UI.Services
{
    public class FacadeService
    {
        public async Task RunAsync()
        {
            var castingFacade = new CastingFacade(
                new DeviceExplorer());

            await castingFacade.CastAsync(
                deviceId: Guid.NewGuid(),
                videoId: Guid.NewGuid());
        }
    }
}
