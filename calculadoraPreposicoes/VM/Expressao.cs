using System.ComponentModel.DataAnnotations;

namespace calculadoraPreposicoes.VM
{
    public class Expressao
    {
        [Required(ErrorMessage = "A expressão é obrigatória.")]
        public string expressao { get; set; }
    }
}
