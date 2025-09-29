namespace Delegate.Delegates { 

 public delegate decimal CalculateDelegate(decimal preco);

    public static class Desconto
    {        
        public static decimal AplicarDezPorCento(decimal preco) => preco * 0.90m;
    }
}