
namespace HomeWorkModule10.Task1
{
    public class Calculator : ISum<int>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Sum()
        {
            return X + Y;
        }
    }
}
