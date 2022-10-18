namespace trabalhoGrafos
{
    public class Grafo
    {
        int [,] grafo;
        int [] grau;

        public Grafo(int [,] grafo){

            OpGrafos op = new OpGrafos();

            this.grafo = grafo;
            this.grau =  op.calcularGrau(grafo, ((int) Math.Sqrt(grafo.Length)));
        }

        public String grauToString(){

            String grauString = "";

            for(int i = 0; i < this.grau.Length; i++){

                grauString += "Vertice " + i + " - grau: " + grau[i] + ". ";
            }

            return grauString;

            
        }


    }
}