namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballos caballo = new Caballos("Path");
            Humanos humano = new Humanos("Akane");
            Gorillas gorilla = new Gorillas("Sra. Kong");
            Chimpances chimpance = new Chimpances("Diddy Kong");

            Mamifero[] mamiferos = new Mamifero[4];

            mamiferos[0] = humano;
            mamiferos[1] = caballo;
            mamiferos[2] = gorilla;
            mamiferos[3] = chimpance;
            
            for (int i = 0; i < mamiferos.Length; i++)
            {
                mamiferos[i].Pensar();
            }

            /*caballo.getNombre();
            humano.getNombre();
            gorilla.getNombre();
            chimpance.getNombre();*/
        }
    }

    class Mamifero
    {
        private string nombreSerVivo;

        public Mamifero(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }
        protected void Respirar()
        {
            Console.WriteLine("El mamífero está respirando.");
        }
        public virtual void Pensar()
        {
            Console.WriteLine("El mamífero está pensando.");
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
        public override void Pensar()
        {
            Console.WriteLine("El humano está pensando.");
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
        public override void Pensar()
        {
            Console.WriteLine("El gorila está pensando.");
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
