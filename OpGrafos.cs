namespace trabalhoGrafos
{
    class OpGrafos
    {

        public void isIsomophic(Grafo A, Grafo B)
        {

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

        public int CalcularArestas(int[,] grafo, int numVertices)
        {

            int arestas = 0;

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {                   
                    if(grafo[i,j] == 1 && (grafo[i,j] == grafo[j,i])){
                        arestas ++ ;
                    }
                }
            }

            return arestas/2;


        }

    }

}
