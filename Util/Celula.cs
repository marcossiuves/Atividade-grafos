namespace util
{
    class Celula
    {

        public object item {get; set;}
        public Celula anterior;

        public Celula(){
            this.item = null;
            this.anterior = null;        
        }
    
        public Celula( object valorItem ){
            this.item = valorItem;
            this.anterior = null;        
        }

        public Celula( object valorItem, Celula celulaAnterior){
            this.item = valorItem;
            this.anterior = celulaAnterior;        
        }


    }
}

