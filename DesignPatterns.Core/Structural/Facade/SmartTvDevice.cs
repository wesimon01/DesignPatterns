namespace DesignPatterns.Core.Structural.Facade
{
    public class SmartTvDevice : IDevice
    {
        public async Task<Connection> ConnectionAsync()
        {
            Console.WriteLine("TV is off");
            throw new NotImplementedException();
        }

        public async Task<Connection> TurnOnAsync()
        {
            Console.WriteLine("Turning on TV");
            return new Connection();
        }
    }
}
