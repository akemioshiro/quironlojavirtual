using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        // Quantidade de itens que possuo no banco
        public int ItensTotal { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        // Quantidade de página que possuirá
        public int TotalPagina {
            get
            {
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);
            }
        }

    }
}
