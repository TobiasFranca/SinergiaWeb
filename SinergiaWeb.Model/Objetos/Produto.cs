using SinergiaWeb.Model.Genericos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinergiaWeb.Model.Objetos
{
    public class Produto : ModelGenerico
    {
        public CategoriaDoProduto Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueDesejavel { get; set; }
        public decimal ValorDeCusto { get; set; }
        public string Descricao { get; set; }
        public string InformacoesTecnicas { get; set; }
        public decimal ValorDeVenda { get; set; }
        public decimal Peso { get; set; }
        public int EstoqueAtual { get; set; }
        public string CodigoDeBarras { get; set; }

    }
}
