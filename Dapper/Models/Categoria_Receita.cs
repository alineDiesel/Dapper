using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dapper.Models
{
    public class Categoria_Receita
    {
        public int ID { get; set; }
        public String Descricao { get; set; }
        public Boolean isAtivo { get; set; }
        public Categoria_Receita_Tipo CategoriaReceitaTipo { get; set; }

        public Categoria_Receita(int ID, String Descricao, Boolean isAtivo, Categoria_Receita_Tipo CategoriaReceitaTipo)
        {
            this.ID = ID;
            this.Descricao = Descricao;
            this.isAtivo = isAtivo;
            this.CategoriaReceitaTipo = CategoriaReceitaTipo;
        }

        
    }
}