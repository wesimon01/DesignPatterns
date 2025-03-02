namespace DesignPatterns.Core.Structural.Adapter
{
    public interface IRectangle
    {
        long GetArea();
        long GetPerimeter();
        void Move(long dx, long dy);
    }
}
