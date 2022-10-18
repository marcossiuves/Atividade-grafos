namespace trabalhoGrafos
{
    public class Grafo
    {
        public int[,] grafo { get; set; }
        public int[] grau { get; set; }
        public int numVertices { get; set; }
        public int numArestas { get; set; }


        public Grafo(int[,] grafo)
        {

            OpGrafos op = new OpGrafos();

            this.grafo = grafo;
            this.numVertices = (int)Math.Sqrt(grafo.Length);
            this.numArestas = op.CalcularArestas(grafo, numVertices);
            this.grau = op.calcularGrau(grafo, numVertices);
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


    }
}