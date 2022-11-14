using OperacoesGrafo;

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
            int[,] grafoc = modelos.alimentarGrafoC();
            int[,] grafocusto = modelos.grafoComCusto();
            int[,] grafomaximo = modelos.grafoMaximo();

            Grafo grafoA = new Grafo(grafoa);
            Grafo grafoB = new Grafo(grafob);
            Grafo grafoC = new Grafo(grafoc);
            Grafo grafoCusto = new Grafo(grafocusto);
            Grafo grafoMaximo = new Grafo(grafomaximo);



            Kruskal k = new Kruskal(grafoC);
            Dfs d = new Dfs(grafoMaximo);
            Dijkstra dj = new Dijkstra(grafoCusto);
            Fulkerson f = new Fulkerson(grafoMaximo);

            Console.WriteLine("Grafo A");
            Console.WriteLine(grafoA.grauToString());
            Console.WriteLine("Numero de vertices: {0} ", grafoA.numVertices);
            Console.WriteLine("Numero de arestas: {0} ", grafoA.numArestas);


            Console.WriteLine("Grafo B");
            Console.WriteLine(grafoB.grauToString());
            Console.WriteLine("Numero de vertices: {0} ", grafoB.numVertices);
            Console.WriteLine("Numero de arestas: {0} ", grafoB.numArestas);


            Console.WriteLine("\nBusca em profundidade: ");
            d.buscaEmProfundidade(0);

            Console.WriteLine("\n\nDijkstra:");
            Console.WriteLine(dj.dijkstra(0));

            Console.WriteLine("\nKruskal:");
            k.kruskal();

            Console.WriteLine("\nFulkerson:");
            Console.WriteLine("O maior caminho possivel é: " + f.fulkerson(0, 5));





        }
    }
}
