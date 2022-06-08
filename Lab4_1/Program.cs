namespace Program
{
    public abstract class LogaAbstr // Абстрактный класс.
    {
        protected abstract void Schot(float x, float y, int z); // Абстрактный метод.
    }
    public class Loga : LogaAbstr // Наследование бстрактного класса.
    {
        public static void Input() // Статический метод вывода информации по входным данным.
        {
            Console.WriteLine("Введите логорифм, основание и до какого числа после запятой округлять.");
        }
        protected override void Schot(float x, float y, int z) // Переопредиление абстрактного метода. Посчёт логарифма с огруглением.
        {
            Console.WriteLine(Math.Round(Math.Log(x, y), z)); // Посчёт логарифма с огруглением.
        }
        public Loga(float x, float y, int z)
        {
            Schot(x, y, z);
        }
    }
    public class ProgramMain
    {
        static void Main()
        {
            Loga.Input();            
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Loga program1 = new Loga(x, y, z);
        }
    }
}