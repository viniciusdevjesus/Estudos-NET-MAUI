using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMVVM.Models;

namespace TesteMVVM.ViewModel
{
    public class ProductViewModel
    {
        public Produtos produto { get; set; }
        public ProductViewModel()
        {
            produto = new Produtos { Nome = "caderno", Preco = 0.9m };
        }
    }
}
