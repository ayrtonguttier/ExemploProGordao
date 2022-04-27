using Dominio.Modelo;
using Dominio.Repositories;

namespace Dominio;

public class DominioPessoa
{
    private readonly IRepositoryPessoa _repositoryPessoa;

    public DominioPessoa(IRepositoryPessoa repositoryPessoa)
    {
        _repositoryPessoa = repositoryPessoa;
    }
    

    public void CadastrarPessoa(Pessoa pessoa)
    {
        _repositoryPessoa.GetPessoaPorId(Guid.NewGuid());
    }
    
    
    
    
    
}