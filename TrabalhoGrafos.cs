namespace trabalhoGrafos
{
    // See https://aka.ms/new-console-template for more information
    class Principal
    {

        public static void Main(string[] args)
        {
            Models modelos = new Models();

            int[,] grafoa = modelos.alimentarGrafoA();
            int[,] grafob = modelos.alimentarGrafoB();

            Grafo grafoA = new Grafo(grafoa);
            Grafo grafoB = new Grafo(grafob);


            Console.WriteLine("Grafo A");
            Console.WriteLine(grafoA.grauToString());

            Console.WriteLine("Grafo B");
            Console.WriteLine(grafoB.grauToString());

        }
    }
}
