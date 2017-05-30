using CFSDDD.Core.Domain;
using CFSDDD.Core.Repositories;

namespace CFSDDD.Dal.Repo
{
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        private CFSContext context;

        public SettingRepository(CFSContext context) : base(context)
        {
            this.context = context;
        }

        public CFSContext CFSContext => Context as CFSContext;
    }
}
