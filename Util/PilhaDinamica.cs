namespace util
{
    class PilhaDinamica
    {
        private Celula topo;
        private int contador;


        public PilhaDinamica()
        {
            topo = null;
            contador = 0;
        }

        public bool vazia()
        {
            return (topo == null);
        }

        public int tamanho()
        {
            return (contador);
        }

        public void empilhar(object novoItem)
        {
            Celula novaCelula = new Celula(novoItem);
            novaCelula.anterior = topo;
            topo = novaCelula;
            contador++;
        }

        public object desempilhar()
        {
            object x = null;
            if (vazia())
            {
                Console.WriteLine("Erro: Pilha vazia!");
            }
            else
            {
                Celula tempCelula = topo;
                topo = topo.anterior;
                contador--;
                x = tempCelula.item;
            }

            return x;
        }


        public object consultarTopo()
        {

            object x = null;

            if (vazia())
            {
                Console.WriteLine("Erro: pilha vazia!");
            }
            else
            {
                x = topo.item;
            }

            return x;

        }

        public object copiar()
        {
            PilhaDinamica tempPilha = new PilhaDinamica();
            PilhaDinamica copiaPilha = new PilhaDinamica();

            while(! vazia()){
                tempPilha.empilhar( desempilhar() );
            }

            while (!tempPilha.vazia()){
                object x = tempPilha.desempilhar();
                empilhar (x);
                copiaPilha.empilhar(x);
            }
            return copiaPilha;

        }

        public string toString()
        {
            string pilhaCheia = "";
            if (vazia())
            {
                pilhaCheia = null;
            }
            else
            {
                PilhaDinamica copiaPilha = (PilhaDinamica)copiar();
                while (!copiaPilha.vazia())
                {
                    pilhaCheia += "\n" + copiaPilha.desempilhar();
                }
            }

            return pilhaCheia;
        }
    }
}