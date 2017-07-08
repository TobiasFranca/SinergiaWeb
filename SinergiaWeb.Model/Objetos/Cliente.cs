using SinergiaWeb.Enumerador;
using SinergiaWeb.Model.Dependencias;
using SinergiaWeb.Model.Genericos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinergiaWeb.Model.Objetos
{
    public class Cliente : ModelGenerico
    {
        public bool PessoaFisica { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RG { get; set; }
        public string InscricaoEstadual { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Observacao { get; set; }
        public bool CreditoAprovado { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public eSituacao Situacao { get; set; }
    }
}
