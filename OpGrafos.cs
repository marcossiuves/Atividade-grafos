//Separar essas super classe em outras mais especificas...

namespace trabalhoGrafos
{
    class OpGrafos
    {
        int numVertices;
        Grafo G;
        int[] parente;

        public OpGrafos(Grafo g)
        {
            this.numVertices = g.numVertices;
            G = g;
            parente = new int[G.numVertices];
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

            int[,] visitados = G.grafo;
            for (int i = 0; i < G.numVertices; i++)
            {
                if (!marcados[i])
                {
                    DFS(i, marcados);
                }
            }
        }

        //corrigir...
        public String dijkstra(int v0)
        {

            String caminhoStr = "";
            int[] custo = new int[G.numVertices];
            bool[] menorCam = new bool[G.numVertices];
            int menor;
            int menorIndex;

            for (int n = 0; n < custo.Length; n++)
            {
                custo[n] = int.MaxValue;
                menorCam[n] = false;
            }

            custo[v0] = 0;

            for (int i = 0; i < G.numVertices - 1; i++)
            {

                menor = int.MaxValue;
                menorIndex = -1;

                for (int j = 0; j < G.numVertices; j++)
                {

                    if (menorCam[j] == false && custo[j] <= menor)
                    {
                        menor = custo[j];
                        menorIndex = j;
                    }
                }

                menorCam[menorIndex] = true;

                for (int j = 0; j < G.numVertices; j++)
                {
                    if ((!menorCam[j]) && (G.grafo[menorIndex, j] != 0) && (custo[menorIndex] != int.MaxValue) && (custo[menorIndex] + G.grafo[menorIndex, j] < custo[j]))
                        custo[j] = custo[j] + G.grafo[menorIndex, j];
                }


            }


            for (int n = 0; n < custo.Length; n++)
            {
                caminhoStr += "vertice " + n + "\t distancia " + custo[n] + "\n";
            }

            return caminhoStr;

        }


        public void kruskal()
        {

            int[,] custo = G.grafo;
            int minimo = 0;

            for (int i = 0; i < G.numVertices; i++)
            {
                parente[i] = i;
            }

            int contador = 0;

            while (contador < G.numVertices - 1)
            {

                int min = int.MaxValue, a = -1, b = -1;
                for (int i = 0; i < G.numVertices; i++)
                {

                    for (int j = 0; j < G.numVertices; j++)
                    {

                        if (encontrar(i) != encontrar(j) && custo[i, j] < min)
                        {
                            min = custo[i, j];
                            a = i;
                            b = j;
                        }

                    }
                }


                uniao(a, b);
                Console.WriteLine("Aresta {0}: ({1},{2}) custo:{3}", contador++, a, b, min);

            }

        }

        public void uniao(int i, int j)
        {
            int a = encontrar(i);
            int b = encontrar(j);

            parente[a] = b;
        }

        public int encontrar(int i)
        {
            while (parente[i] != i)
            {
                i = parente[i];
            }

            return i;
        }

    }
}



