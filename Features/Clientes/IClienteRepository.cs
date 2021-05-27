using System;
using Features.Core;

namespace Features.Clientes
{
    public interface IClienteRepository : IRepository<Cliente>, IDisposable
    {
        Cliente ObterPorEmail(string email);
    }
}