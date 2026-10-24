using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIA.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; } 
        public string Sku { get; set; } = string.Empty;
        public string DescricaoResumida { get; set; } = string.Empty;
        public string DescricaoCompleta {  get; set; } = string.Empty;
        public decimal Preco {  get; set; } 
        public string Marca { get; set; } = string.Empty;
    }
}
