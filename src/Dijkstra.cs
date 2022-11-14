using trabalhoGrafos;


namespace OperacoesGrafo
{


    class Dijkstra
    {

        int numVertices;
        Grafo G;

        public Dijkstra(Grafo g)
        {
            this.numVertices = g.numVertices;
            G = g;
        }

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

    }
}


