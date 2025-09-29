namespace Delegate.Delegates
{
    public class Totais
    {
        public static readonly Func<int, int, decimal> CalcularTotal =
            (diarias, precoInteiro) => diarias * (decimal)precoInteiro;
    }
}
