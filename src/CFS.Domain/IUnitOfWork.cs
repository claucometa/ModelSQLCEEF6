using CFSDDD.Core.Repositories;
using System;

namespace CFSDDD.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ISettingRepository Settings { get; }
        int Complete();
    }
}
