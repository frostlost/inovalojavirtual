using System;

namespace Inova.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; } //Itens no BD
        public int ItensPorPagina { get; set; } //Itens visualizados por página
        public int PaginaAtual { get; set; }
        public int TotalPagina
        {
            get
            {
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);
            }
        }
    }
}