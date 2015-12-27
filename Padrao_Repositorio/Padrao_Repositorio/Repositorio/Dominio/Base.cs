namespace Repositorio.Dominio
{

    //servira de base em comum dentre todas as entidades do projeto, 
    //as entidades herdarão dela o campo "id" pois todos as entidades 
    //terão códigos para representa-las visto que as entidades seram copias fieis das tabelas 
    //do nosso banco de dados
    public class Base
    {
        public int id { get; set; } 
    }
}
