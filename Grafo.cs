namespace trabalhoGrafos
{
    public class Grafo
    {
        public int[,] grafo { get; set; }
        public int[] grau { get; set; }
        public int numVertices { get; set; }
        public int numArestas { get; set; }
        private int [,] matrizAdjacencia;

        public Grafo(int[,] grafo)
        {

            this.grafo = grafo;
            this.numVertices = (int)Math.Sqrt(grafo.Length);
            this.numArestas = calcularArestas(grafo, numVertices);
            this.grau = calcularGrau(grafo, numVertices);

        }
        public String grauToString()
        {

            String grauString = "";

            for (int i = 0; i < this.grau.Length; i++)
            {
                grauString += "Vertice " + i + " - grau: " + grau[i] + ". ";
            }

            return grauString;


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


        public Boolean existeVertice(int linha, int coluna){

            if(grafo[linha,coluna] == grafo[coluna, linha] && grafo[coluna, linha] == 1 ){
                return true;
            }

            return false;
        }

    }
}