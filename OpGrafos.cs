namespace trabalhoGrafos
{

    using util;
    class OpGrafos
    {

        int[] antecessor;
        int numVertices;
        int[,] vGraph;
        Grafo G;

        public OpGrafos(Grafo g)
        {
            this.antecessor = new int[numVertices];
            this.numVertices = g.numVertices;
            vGraph = new int[numVertices, numVertices];
            G = g;
        }


        public void buscaEmProfundidade(int v)
        {

            bool[] marcado = new bool[numVertices];

            DFS(v, marcado);


        }

        //arrumar para funcionar com a pilha...
        private void DFS(int v, bool[] marcados)
        {

            marcados[v] = true;
            Console.Write(v + " ");

            int [,] visitados = G.grafo;
            for(int i = 0; i < G.numVertices; i++){
                if(!marcados[i]){
                    DFS(i, marcados);
                }
            }
        }

    }
}



