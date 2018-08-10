using ExercicioMecanica.DataBase;
using ExercicioMecanica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExercicioMecanica.Repositorio
{
    public class ServicoRepositorio
    {
        public List<Servico> ObterTodos()
        {
            List<Servico> servicos = new List<Servico>();
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = "SELECT id, nomeDono, modelo, cor, colaboradorResponsavel, status, dataOrcamento, valorOrcamento, valorServico, valorDesconto, valorTotal, finalizacaoServico FROM servicos";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = new Servico()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Cliente = linha[1].ToString(),
                    Modelo = linha[2].ToString(),
                    Cor = linha[3].ToString(),
                    ColaboradorResponsavel = linha[4].ToString(),
                    Status = linha[5].ToString(),
                    DataOrcamento = Convert.ToDateTime(linha[6].ToString()),
                    ValorOrcamento = Convert.ToDouble(linha[7].ToString()),
                    ValorServico = Convert.ToDouble(linha[8].ToString()),
                    ValorDesconto = Convert.ToDouble(linha[9].ToString()),
                    ValorTotal = Convert.ToDouble(linha[10].ToString()),
                    FinalizacaoServico = Convert.ToDateTime(linha[11].ToString())
                };
                servicos.Add(servico);
            }
            return servicos;
        }


        public int Cadastrar(Servico servico)
        {
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = @"INSERT INTO servicos (nomeDono) OUTPUT INSERTED.ID VALUES (@NOME)";
            comando.Parameters.AddWithValue("@NOME", servico.Cliente);
            comando.Parameters.AddWithValue("@ID", servico.Id);
            int id = Convert.ToInt32(comando.ExecuteScalar().ToString());
            return id;
        }
    }
}