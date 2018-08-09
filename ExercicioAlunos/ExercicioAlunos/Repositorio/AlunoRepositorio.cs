using ExercicioAlunos.DataBase;
using ExercicioAlunos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExercicioAlunos.Repositorio
{
    public class AlunoRepositorio
    {
        public List<Aluno> ObterTodos()
        {
            List<Aluno> alunos = new List<Aluno>();
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = "SELECT id, nome, matricula, nota1, nota2, nota3, frequencia FROM alunos";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            foreach (DataRow linha in tabela.Rows)
            {
                Aluno aluno = new Aluno()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    Matricula = linha[2].ToString(),
                    Nota_1 = Convert.ToDouble(linha[3].ToString()),
                    Nota_2 = Convert.ToDouble(linha[4].ToString()),
                    Nota_3 = Convert.ToDouble(linha[5].ToString()),
                    Frequencia = Convert.ToByte(linha[6].ToString())
                };
                alunos.Add(aluno);
            }
            return alunos;
        }

        public int Cadastrar(Aluno aluno)
        {
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = @"INSERT INTO alunos OUTPUT INSERTED.ID VALUES (@NOME, @MATRICULA, @NOTA1, @NOTA2, @NOTA3, @FREQUENCIA)";

            comando.Parameters.AddWithValue("@NOME", aluno.Nome);

            comando.Parameters.AddWithValue("@MATRICULA", aluno.Matricula);

            comando.Parameters.AddWithValue("@NOTA1", aluno.Nota_1);

            comando.Parameters.AddWithValue("@NOTA2", aluno.Nota_2);

            comando.Parameters.AddWithValue("@NOTA3", aluno.Nota_3);

            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);

            int id = Convert.ToInt32(comando.ExecuteScalar().ToString());
            return id;

        }


        public bool Alterar(Aluno aluno)
        {
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = @"UPDATE alunos SET nome = @NOME, matricula = @MATRICULA, nota1 = @NOTA1, nota2 = @NOTA2, nota3 = @NOTA3, frequencia = @FREQUENCIA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", aluno.Nome);
            comando.Parameters.AddWithValue("@MATRICULA", aluno.Matricula);
            comando.Parameters.AddWithValue("@NOTA1", aluno.Nota_1);
            comando.Parameters.AddWithValue("@NOTA2", aluno.Nota_2);
            comando.Parameters.AddWithValue("@NOTA3", aluno.Nota_3);
            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            comando.Parameters.AddWithValue("@ID", aluno.Id);
            return comando.ExecuteNonQuery() == 1;
        }

        public bool Excluir(int id)
        {
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = "DELETE FROM alunos WHERE id= @ID";
            comando.Parameters.AddWithValue("@ID", id);
            return comando.ExecuteNonQuery() == 1;
        }

        public Aluno ObterPeloId(int id)
        {
            Aluno aluno = null;
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = "SELECT nome, matricula, nota1, nota2, nota3, frequencia FROM alunos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            if (tabela.Rows.Count == 1)
            {
                aluno = new Aluno();
                aluno.Id = id;
                aluno.Nome = tabela.Rows[0][0].ToString();
                aluno.Matricula = tabela.Rows[0][1].ToString();
                aluno.Nota_1 = Convert.ToDouble(tabela.Rows[0][2].ToString());
                aluno.Nota_2 = Convert.ToDouble(tabela.Rows[0][3].ToString());
                aluno.Nota_3 = Convert.ToDouble(tabela.Rows[0][4].ToString());
                aluno.Frequencia = Convert.ToByte(tabela.Rows[0][5].ToString());
            }
            return aluno;
        }
    }
}