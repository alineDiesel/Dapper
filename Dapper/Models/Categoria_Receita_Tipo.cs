using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace Dapper.Models
{
    public sealed class Categoria_Receita_Tipo
    {
        public int ID { get; set; }
        public String Descricao { get; set; }
        public Boolean isAtivo { get; set; }

        public Categoria_Receita_Tipo() { }
        public Categoria_Receita_Tipo(int ID, String Descricao, Boolean isAtivo)
        {
            this.ID = ID;
            this.Descricao = Descricao;
            this.isAtivo = isAtivo;
        }

        public List<Categoria_Receita_Tipo> ObterTodos()
        {
            try
            {
                var conexao = Conexao.conectar();
                var lCategoriasReceitaTipo = conexao.Query<Categoria_Receita_Tipo>("SELECT * FROM Categoria_Receita_Tipo");
                conexao.Close();
                return lCategoriasReceitaTipo as List<Categoria_Receita_Tipo>;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}