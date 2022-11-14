using trabalhoGrafos;
using util;

namespace OperacoesGrafo
{


    class Dfs
    {

        int numVertices;
        Grafo G;
        PilhaDinamica p;

        public Dfs(Grafo g)
        {
            this.numVertices = g.numVertices;
            G = g;
            p = new PilhaDinamica();

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
                        
            for (int i = 0; i < G.numVertices; i++)
            {
                if (!marcados[i])
                {
                    DFS(i, marcados);
                }
            }
        }

    }
}


