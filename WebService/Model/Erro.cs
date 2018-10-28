using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class Erro
    {
        public string operacao { get; set; } = "Porcentagem";
        public string mensagem { get; set; } = "Divisao por 0";
    }
}