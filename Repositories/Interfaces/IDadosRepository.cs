namespace Atron.Sgc.Repositories.Interfaces
{
    public abstract class DadosRepository<T>
    {
        public IList<T> Dados { get; set; }
    }
}