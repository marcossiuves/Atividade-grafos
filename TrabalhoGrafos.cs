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

            Grafo grafoA = new Grafo(grafoa);
            Grafo grafoB = new Grafo(grafob);
            Grafo grafoC = new Grafo(grafoc);
            Grafo grafoCusto = new Grafo(grafocusto);


            OpGrafos op = new OpGrafos(grafoCusto);

            // Console.WriteLine("Grafo A");
            // Console.WriteLine(grafoA.grauToString());
            // Console.WriteLine("Numero de vertices: {0} ", grafoA.numVertices);
            // Console.WriteLine("Numero de arestas: {0} ", grafoA.numArestas);


            // Console.WriteLine("Grafo B");
            // Console.WriteLine(grafoB.grauToString());
            // Console.WriteLine("Numero de vertices: {0} ", grafoB.numVertices);
            // Console.WriteLine("Numero de arestas: {0} ", grafoB.numArestas);

            //op.buscaEmProfundidade(3);

            //Console.WriteLine(op.dijkstra(0));

            op.kruskal();

        }
    }
}
