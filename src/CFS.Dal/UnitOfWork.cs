using CFSDDD.Core;
using CFSDDD.Core.Repositories;
using CFSDDD.Dal.Repo;

namespace CFSDDD.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CFSContext Context;

        public UnitOfWork(CFSContext context)
        {
            Context = context;
            Settings = new SettingRepository(context);
        }

        public ISettingRepository Settings { get; private set; }

        public int Complete()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
