using Delegate.Delegates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Delegate.Pages
{
    public class CalculoPacoteModel : PageModel
    {
        [BindProperty] public decimal PrecoDiaria { get; set; }
        [BindProperty] public int Diarias { get; set; }

        public decimal? PrecoComDesconto { get; set; }
        public decimal? Total { get; set; }

        private static readonly CalculateDelegate _calc = Desconto.AplicarDezPorCento;

        public void OnPost()
        {
            PrecoComDesconto = _calc(PrecoDiaria);
            
            var precoInt = (int)PrecoDiaria;
            Total = Totais.CalcularTotal(Diarias, precoInt);
        }
    }
}

