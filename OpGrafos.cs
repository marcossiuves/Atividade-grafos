namespace trabalhoGrafos
{

    using util;
    class OpGrafos
    {
        PilhaDinamica P;
        bool[] marcado;
        int[] antecessor;
        int numVertices;

        public OpGrafos()
        {
            this.P = new PilhaDinamica();
            this.marcado = new bool[10];
            this.antecessor = new int[10];
            this.numVertices = 10;
        }
        public OpGrafos(int numVertices)
        {
            this.P = new PilhaDinamica();
            this.marcado = new bool[numVertices];
            this.antecessor = new int[numVertices];
            this.numVertices = numVertices;

        }
        public int[] calcularGrau(int[,] grafo, int numVertice)
        {

            int[] grau = new int[numVertice];

            int aux_grau = 0;
            int aux_vertice = 0;


            for (int i = 0; i < numVertice; i++)
            {
                for (int j = 0; j < numVertice; j++)
                {
                    // calcular grauB do grafoA
                    if (grafo[i, j] == 1)
                    {
                        aux_grau++;
                        if (grafo[i, j] == grafo[j, i])
                        {
                            aux_vertice++;
                        }

                    }
                    else if (grafo[i, j] == 2)
                    {
                        aux_grau += grafo[i, j];
                    }

                }
                grau[i] = aux_grau;
                aux_grau = 0;


            }
            return grau;
        }

        public int calcularArestas(int[,] grafo, int numVertices)
        {

            int arestas = 0;

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    if (grafo[i, j] == 1 && (grafo[i, j] == grafo[j, i]))
                    {
                        arestas++;
                    }
                }
            }

            return arestas / 2;

        }

        public void buscaEmProfundidade(int[,] grafo, int v = 0)
        {

            marcado[v] = true;

            for (int w = 0; w < this.numVertices; w++)
            {
                if (!marcado[w])
                {
                    antecessor[w] = v;
                    DFS(w);
                }

            }

        }


        public void DFS(int v)
        {

            int w;
            marcado[v] = true;

            P.empilhar(v);

            while (!P.vazia())
            {
                w = (int)P.desempilhar();

                for (int z = 0; z < numVertices; z++)
                {
                    marcado[z] = true;
                    P.empilhar(z);
                }

                Console.WriteLine(w);
            }
        }
    }
}



