namespace ArqTransfer.Dominio.Entidades.Interface
{
    // Interface que todas Entidades
    // devem implementar
    // Ela garante a criação de um
    // Repositório Genérico,
    // poupando muito código na
    // camada de Repositório
    public interface IEntidade
    {

        long Id { get; }
    }
}
