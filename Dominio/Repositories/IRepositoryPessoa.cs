using Dominio.Modelo;

namespace Dominio.Repositories;

public interface IRepositoryPessoa
{
    Pessoa GetPessoaPorId(Guid id);
}