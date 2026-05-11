public class No{

    // atributo - caracteristicas

    public int valor; // valor do nó
    
    public No prox; // ponteiro ou apontador para o proximo nó

    //constructor

    public No(int Valor){
        this.valor = Valor;
        this.prox = null;
    }

    //metodos

    public void imprimir(){
        Console.WriteLine("Valor: " + this.valor);
    }


}