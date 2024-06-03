using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Other.Thread.Entities.Accounting;
using Volo.Abp.Domain.Repositories;

namespace Other.Thread.Interfaces.Accounting
{
    public interface IAccountRepository : IRepository<Account, Guid>
    {
        Task<List<Account>> GetListAsync(int skipCount, int maxResultCount, string sorting = "Name", AccountFilter? filter = null);
        Task<int> GetTotalCountAsync(AccountFilter filter);
    }
}