namespace Program
{
    public abstract class LogaAbstr
    {
        protected abstract void Schot(float x, float y, int z);
    }
    public class Loga : LogaAbstr
    {
        public static void Input()
        {
            Console.WriteLine("Введите логорифм, основание и до какого числа после запятой округлять.");
        }
        protected override void Schot(float x, float y, int z)
        {
            Console.WriteLine(Math.Round(Math.Log(x, y), z));
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