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
                var lCategoriasReceitaTipo = conexao.Query<Categoria_Receita_Tipo>("SELECT ID, Descricao, isAtivo FROM Categoria_Receita_Tipo WHERE isAtivo =1");
                return lCategoriasReceitaTipo as List<Categoria_Receita_Tipo>;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Conexao.desconectar();
            }
        }

        public int Cadastrar(Categoria_Receita_Tipo categoriaReceitaTipo)
        {
            try
            {
                var conexao = Conexao.conectar();
                String query = "INSERT INTO Categoria_Receita_Tipo VALUES('" + categoriaReceitaTipo.Descricao + "', '" + categoriaReceitaTipo.isAtivo + "')SELECT CAST(SCOPE_IDENTITY() as int)";
                var id = conexao.Query<int>(query).Single();
                return id;
            }
            catch
            {
                return 0;
            }
            finally
            {
                Conexao.desconectar();
            }
        }

        public Boolean Editar(Categoria_Receita_Tipo categoriaReceitaTipo)
        {
            try
            {
                var conexao = Conexao.conectar();
                String query = "UPDATE Categoria_Receita_Tipo SET Descricao = '" + categoriaReceitaTipo.Descricao + "' WHERE ID = " + categoriaReceitaTipo.ID;
                conexao.Query(query);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Conexao.desconectar();
            }
        }

        public Boolean Excluir(int ID)
        {
            try
            {
                var con = Conexao.conectar();
                con.Query("UPDATE Categoria_Receita_Tipo SET isAtivo = 0 WHERE ID=" + ID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conexao.desconectar();
            }
        }
    }
}