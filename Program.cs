namespace grupo_D
{
    internal class Program
    {
         void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = Sum(2, 3);
            string nombreCompleto = NombreCompleto("Andy", "Guzman");
        }


        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public string NombreCompleto(string name, string lastName)
        {
            return name + lastName;
        }
    }
}