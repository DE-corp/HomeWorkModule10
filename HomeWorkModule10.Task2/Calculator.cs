
namespace HomeWorkModule10.Task2
{
    public class Calculator : ISum<int>
    {
        public ILogger Logger { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int Sum()
        {
            try
            {
                Logger.Event("Выполняется суммирование!");
                return X + Y;
            }
            catch
            {
                Logger.Error("Ошибка вычисления!");
                return 0;
            }
        }
    }
}
