using System;

namespace NetcoreLslUtnFra.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
