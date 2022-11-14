using trabalhoGrafos;

namespace OperacoesGrafo
{


    class Kruskal
    {

        int numVertices;
        Grafo G;
        int[] parente;

        public Kruskal(Grafo g)
        {
            this.numVertices = g.numVertices;
            G = g;
            parente = new int[G.numVertices];
        }


        public void kruskal()
        {

            int[,] custo = G.grafo;

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


