using MySql.Data.MySqlClient;
using System;
using ProjetoLojaJogos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLojaJogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        public void CadastrarCliente(Cliente cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.DataNascimento).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@Cpf,@Nome,@DataNascimento,@Email,@Celular,@Endereco)", con.ConectarBD());
            cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar).Value = cliente.Cpf;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = cliente.Nome;
            cmd.Parameters.Add("@DataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cliente.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = cliente.Celular;
            cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = cliente.Endereco;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Cliente ListarCodCliente(int cod)
        {
            var comando = String.Format("select * from tbCliente where Cpf = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodCli = cmd.ExecuteReader();
            return ListarTodosClientes(DadosCodCli).FirstOrDefault();
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbCliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosClientes(DadosCliente);
        }

        public List<Cliente> ListarTodosClientes(MySqlDataReader dt)
        {
            var todosClientes = new List<Cliente>();
            while (dt.Read())
            {
                var clienteTemp = new Cliente()
                {
                    Cpf = dt["Cpf"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    DataNascimento = DateTime.Parse(dt["DataNascimento"].ToString()),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Endereco = dt["Endereco"].ToString(),

                };
                todosClientes.Add(clienteTemp);
            }
            dt.Close();
            return todosClientes;
        }


        //Funcionario
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            string data_sistema = Convert.ToDateTime(funcionario.DataNascimento).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@Codigo, @Cpf, @Rg, @Nome, @DataNascimento, @Email, @Celular, @Endereco, @Cargo)", con.ConectarBD());
            cmd.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = funcionario.Codigo;
            cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar).Value = funcionario.Cpf;
            cmd.Parameters.Add("@Rg", MySqlDbType.VarChar).Value = funcionario.Rg;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = funcionario.Nome;
            cmd.Parameters.Add("@DataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = funcionario.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = funcionario.Celular;
            cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = funcionario.Endereco;
            cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = funcionario.Cargo;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from tbFuncionario where Codigo = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarTodosFuncionarios(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbFuncionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionarios(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionarios(MySqlDataReader dt)
        {
            var todosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var funcionarioTemp = new Funcionario()
                {
                    Codigo = Convert.ToInt32(dt["Codigo"].ToString()),
                    Cpf = dt["Cpf"].ToString(),
                    Rg = dt["Rg"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    DataNascimento = DateTime.Parse(dt["DataNascimento"].ToString()),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Endereco = dt["Endereco"].ToString(),
                    Cargo = dt["Cargo"].ToString(),
                };
                todosFuncionarios.Add(funcionarioTemp);
            }
            dt.Close();
            return todosFuncionarios;
        }

        //Jogo

        public void CadastrarJogo(Jogo jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@Codigo, @Nome, @Versao, @Desenvolvedor, @Genero, @FaixaEtaria, @Plataforma, @AnoLancamento, @Sinopse)", con.ConectarBD());
            cmd.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = jogo.Codigo;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = jogo.Nome;
            cmd.Parameters.Add("@Versao", MySqlDbType.VarChar).Value = jogo.Versao;
            cmd.Parameters.Add("@Desenvolvedor", MySqlDbType.VarChar).Value = jogo.Desenvolvedor;
            cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = jogo.Genero;
            cmd.Parameters.Add("@FaixaEtaria", MySqlDbType.VarChar).Value = jogo.FaixaEtaria;
            cmd.Parameters.Add("@Plataforma", MySqlDbType.VarChar).Value = jogo.Plataforma;
            cmd.Parameters.Add("@AnoLancamento", MySqlDbType.VarChar).Value = jogo.AnoLancamento;
            cmd.Parameters.Add("@Sinopse", MySqlDbType.VarChar).Value = jogo.Sinopse;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Jogo ListarCodJogo(int cod)
        {
            var comando = String.Format("select * from tbJogo where JogoID = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodJogo = cmd.ExecuteReader();
            return ListarTodosJogos(DadosCodJogo).FirstOrDefault();
        }

        public List<Jogo> ListarJogo()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbJogo", con.ConectarBD());
            var DadosJogos = cmd.ExecuteReader();
            return ListarTodosJogos(DadosJogos);
        }

        public List<Jogo> ListarTodosJogos(MySqlDataReader dt)
        {
            var todosJogos = new List<Jogo>();
            while (dt.Read())
            {
                var jogoTemp = new Jogo()
                {
                    Codigo = Convert.ToInt32(dt["Codigo"].ToString()),
                    Nome = dt["Nome"].ToString(),
                    Versao = dt["Versao"].ToString(),
                    Desenvolvedor = dt["Desenvolvedor"].ToString(),
                    Genero = dt["Genero"].ToString(),
                    FaixaEtaria = dt["FaixaEtaria"].ToString(),
                    Plataforma = dt["Plataforma"].ToString(),
                    AnoLancamento = dt["AnoLancamento"].ToString(),
                    Sinopse = dt["Sinopse"].ToString(),


                };
                todosJogos.Add(jogoTemp);
            }
            dt.Close();
            return todosJogos;
        }
    }
}