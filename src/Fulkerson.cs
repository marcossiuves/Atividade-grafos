using trabalhoGrafos;

namespace OperacoesGrafo
{
    class Fulkerson
    {
        int numVertices;
        Grafo G;
        int[] parente;

        public Fulkerson(Grafo g)
        {
            this.numVertices = g.numVertices;
            G = g;
            parente = new int[G.numVertices];
        }

        public bool bfs(int s, int t, int[,] grafoR)
        {

            bool[] visitado = new bool[G.numVertices];

            for (int i = 0; i < G.numVertices; i++)
            {
                visitado[i] = false;
            }

            //alterar por fila
            List<int> fila = new List<int>();
            fila.Add(s);
            visitado[s] = true;
            parente[s] = -1;

            while (fila.Count != 0)
            {
                int u = fila[0];
                fila.RemoveAt(0);

                for (int i = 0; i < G.numVertices; i++)
                {
                    if (visitado[i] == false && grafoR[u, i] > 0)
                    {

                        if (i == t)
                        {
                            parente[i] = u;
                            return true;
                        }
                        fila.Add(i);
                        parente[i] = u;
                        visitado[i] = true;

                    }
                }
            }


            return false;
        }

        public int fulkerson(int s, int t)
        {

            int u, v;


            int[,] grafoR;
            grafoR = G.grafo;

            int max = 0;
            while (bfs(s, t, grafoR))
            {

                int caminho = int.MaxValue;
                for (v = t; v != s; v = parente[v])
                {
                    u = parente[v];
                    caminho = Math.Min(caminho, grafoR[u, v]);
                }

                for (v = t; v != s; v = parente[v])
                {
                    u = parente[v];
                    grafoR[u, v] -= caminho;
                    grafoR[v, u] += caminho;
                }

                max += caminho;

            }

            return max;
        }

    }

}



