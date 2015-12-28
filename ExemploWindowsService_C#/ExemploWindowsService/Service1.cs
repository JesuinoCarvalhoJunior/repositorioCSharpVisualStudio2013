using System;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ExemploWindowsService
{


    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private StreamWriter arquivoLog;

        protected override void OnStart(string[] args)
        {

            // enviar email a cada 5 segundos
            ThreadStart start = new ThreadStart(EnviarEmailPendente);
            Thread thread = new Thread(start);
            thread.Start();

            //Instancie a variável criada, que receberá como parâmetro o caminho de meu arquivo de texto,
            //que será o log destes eventos do meu serviço, e o parâmetro encoding com o valor true.

            //    arquivoLog = new StreamWriter(@"E:\ExemploWindowsService_C#\ExemploWindowsService\Log\Log.txt", true);
            arquivoLog = new StreamWriter(@"C:\Aprendendo_C#\ExemploWindowsService_C#\ExemploWindowsService\Log", true);

            //Escrevo no arquivo texto no momento que o arquivo for iniciado
            arquivoLog.Write("Serviço iniciado em: " + DateTime.Now);

            // eventos do serviço do windows
            EventLog.WriteEntry("Serviço foi iniciado: " + DateTime.Now, EventLogEntryType.Information);

            //Limpo o buffer com o método Flush
            arquivoLog.Flush();


        }

        protected override void OnStop()
        {

            //Escrevo no arquivo texto no momento exato que o arquivo for encerrado
            arquivoLog.WriteLine("Serviço encerrado em: " + DateTime.Now);

            // eventos do serviço do windows - painel controle - ferramentsa admin
            // visualizado de eventos - aplicativos
            EventLog.WriteEntry("Serviço foi parado: " + DateTime.Now, EventLogEntryType.Information);

            //Fecho o arquivo com o método Close
            arquivoLog.Flush();
            arquivoLog.Close();

        }


        public void EnviarEmailPendente()
        {

            while (true)
            {
                Thread.Sleep(5000);

                MySqlConnection conmysql = new MySqlConnection(@"server=localhost; User Id=root; database=bdwebservice; password=root");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM USUARIO WHERE nome = 'yuri' ", conmysql);

                conmysql.Open();

                MySqlDataReader myreader = comando.ExecuteReader();


                SqlConnection conexao = new SqlConnection(@"Data Source=JRCARVALHOVAIO\SQLEXPRESS;Initial Catalog=DB_EXERCICIO_MODII_CATEGORIA_PRODUTO;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select top 100 * from enviaremail where status = 'N' ", conexao);

                conexao.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    enviarEmail(reader["EmailOrigem"].ToString(),
                               reader["EmailDestino"].ToString(),
                               reader["NomeOrigem"].ToString(),
                               reader["NomeDestino"].ToString(),
                               reader["Assunto"].ToString(),
                               reader["Mensagem"].ToString());

                    atualizarEmail(Convert.ToInt32(reader["id"].ToString()));

                }
            }
        }


        private void enviarEmail(string emailOrigem, string emailDestino, string nomeOrigem, string nomeDestino,
            string assunto, string mensagemEmail)
        {
            MailAddress origem = new MailAddress(emailOrigem, nomeOrigem);
            MailAddress destino = new MailAddress(emailDestino, nomeDestino);

            MailMessage mensagem = new MailMessage(origem, destino);

            MailMessage priori = new MailMessage();
            priori.Priority = MailPriority.High;

            MailMessage encode = new MailMessage();
            encode.BodyEncoding = Encoding.GetEncoding("UTF-8");

            mensagem.Subject = assunto;
            mensagem.Body = mensagemEmail;

            SmtpClient smtp = new SmtpClient();
            //gmail
            //smtp.Host = "smtp.gmail.com";
            //gmail
            // smtp.Port = 587; //25

            smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(origem.Address, "senha");
            smtp.Send(mensagem);
        }

        private void atualizarEmail(int id)
        {

            SqlConnection conexao = new SqlConnection(@"Data Source=JRCARVALHOVAIO\SQLEXPRESS;Initial Catalog=DB_EXERCICIO_MODII_CATEGORIA_PRODUTO;Integrated Security=True");
            SqlCommand cmdUpdate = new SqlCommand("update EnviarEmail set Status = 'S' Where id=@id ", conexao);

            cmdUpdate.Parameters.Add(new SqlParameter("@id", id));

            conexao.Open();
            cmdUpdate.ExecuteNonQuery();
            conexao.Close();


            MySqlConnection conmysql = new MySqlConnection(@"server=localhost; User Id=root; database=bdwebservice; password=root");
            MySqlCommand upCommand = new MySqlCommand("Update USUARIO set Login = 'yuri' WHERE id=@id ", conmysql);


            upCommand.Parameters.Add(new MySqlParameter("@id", id));

            conmysql.Open();
            upCommand.ExecuteNonQuery();
            conmysql.Close();
        
        }

    }
}
//Data Source=JRCARVALHOVAIO\SQLEXPRESS;Initial Catalog=DB_EXERCICIO_MODII_CATEGORIA_PRODUTO;Integrated Security=True
//Data Source=JRCARVALHOVAIO\SQLEXPRESS;Initial Catalog=DB_EXERCICIO_MODII_CATEGORIA_PRODUTO;Integrated Security=True