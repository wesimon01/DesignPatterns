namespace DesignPatterns.Core.Structural.Adapter
{
    public class LegacyRectangle(int left, int top, int right, int bottom)
    {
        public int CalculateArea()
        {
            return (bottom - top) * (right - left);
        }

        public int CalculatePerimeter()
        {
            int height = bottom - top;
            int width = right - left;

            return 2 * (height + width);
        }

        public void Shift(int horizontal, int vertical)
        {
            top += vertical;
            bottom += vertical;

            left += horizontal;
            right += horizontal;
        }
    }
}
