using CursoCSharpModuloII.NHibernate.Dados;
using CursoCSharpModuloII.NHibernate.Dominio;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using NHibernate.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpModuloII.NHibernate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();


            NhibernateHelper.Configurar();
            using (var session = NhibernateHelper.AbrirSessao())
            {
                Categoria categoria = session.Get<Categoria>(35);
                categoria.Codigo = "xx";
                categoria.Descricao = "aa";
                
                var list = session.Query<Categoria>().ToList();

                session.Flush();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
