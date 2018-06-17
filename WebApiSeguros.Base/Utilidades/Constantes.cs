namespace WebApiSeguros.Base.Utilidades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Constantes
    {
        public string Codigo { get; set; }

        public string Valor { get; set; }

        private Constantes(string codigoConstante, string ValorConstante)
        {
            this.Codigo = codigoConstante;
            this.Valor = ValorConstante;
        }

        private Constantes(string codigoConstante)
        {
            this.Codigo = codigoConstante;
        }

        public static readonly Constantes Riesgo_Alto = new Constantes("1");
    }
}
