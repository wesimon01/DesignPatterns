using DesignPatterns.Core.Structural.Adapter;

namespace DesignPatterns.UI.Services
{
    public class AdapterService
    {
        public void Run()
        {
            Console.WriteLine("Running Adapter Service ... \n");

            var legacyRectangle = new LegacyRectangle(
                left: 1, 
                top: 10, 
                right: 10, 
                bottom: 0);

            IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);
            CenterRectangle(rectangle);
        }

        private void CenterRectangle(IRectangle rectangle)
        {
            Console.WriteLine("Centered Rectangle.");
        }
    }
}
