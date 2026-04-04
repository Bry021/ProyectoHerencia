namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballos caballo = new Caballos(Console.ReadLine());

            Humanos humano = new Humanos(Console.ReadLine());

            Gorillas gorilla = new Gorillas(Console.ReadLine());

            Chimpances chimpance = new Chimpances(Console.ReadLine());

        }
    }

    class Mamifero
    {
        private string nombreSerVivo;

        public Mamifero(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public void Respirar()
        {
            Console.WriteLine("El mamífero está respirando.");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Las cuidos hasta que sean mayores");
        }
    }

    class Caballos : Mamifero
    {
        public Caballos(string horseName) : base(horseName)
        {

        }
        public void Galopar()
        {
            Console.WriteLine("El caballo está galopando.");
        }
    }
    class Humanos : Mamifero
    {
        public Humanos(string humanName) : base(humanName)
        {

        }
        public void Hablar()
        {
            Console.WriteLine("El humano está hablando.");
        }
    }
    class Gorillas : Mamifero
    {
        public Gorillas(string gorillaName) : base(gorillaName)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("El gorila está trepando.");
        }
    }
    class Chimpances : Mamifero
    {
        public Chimpances(string chimpanceName) : base(chimpanceName)
        {

        }
        public void Saltar()
        {
            Console.WriteLine("El chimpancé está saltando.");
        }
    }
}
