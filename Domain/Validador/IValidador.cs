namespace Atron.Sgc.Domain.Validador
{
    public interface IValidador<Entidade>
    {
        void Validar(Entidade entidade);
    }
}