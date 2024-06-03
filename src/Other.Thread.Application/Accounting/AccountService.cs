using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Other.Thread.Dtos.Accounting;
using Other.Thread.Entities.Accounting;
using Other.Thread.Interfaces.Accounting;
using Other.Thread.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Other.Thread.Accounting;

public class AccountAppService :
    CrudAppService<
        Account, //The Book entity
        AccountDto, //Used to show books
        Guid, //Primary key of the book entity
        AccountPagedAndSortedResultRequestDto, //Used for paging/sorting
        AccountCreateUpdateDto>, //Used to create/update a book
    IAccountAppService //implement the IBookAppService
{
    IAccountRepository accountRepository;
    public AccountAppService(IAccountRepository repository)
        : base(repository)
    {
        accountRepository = repository;
        GetPolicyName = OtherThreadPermissions.Accounts.Default;
        GetListPolicyName = OtherThreadPermissions.Accounts.Default;
        CreatePolicyName = OtherThreadPermissions.Accounts.Create;
        UpdatePolicyName = OtherThreadPermissions.Accounts.Edit;
        DeletePolicyName = OtherThreadPermissions.Accounts.Delete;
    }

    public override async Task<PagedResultDto<AccountDto>> GetListAsync(AccountPagedAndSortedResultRequestDto input)
    {
            var filter = ObjectMapper.Map<AccountPagedAndSortedResultRequestDto, AccountFilter>(input);

            var sorting = (string.IsNullOrEmpty(input.Sorting) ? "Name DESC" : input.Sorting).Replace("ShortName", "Name");

            var accounts = await accountRepository.GetListAsync(input.SkipCount, input.MaxResultCount, sorting, filter);
            var totalCount = await accountRepository.GetTotalCountAsync(filter);

            return new PagedResultDto<AccountDto>(totalCount,ObjectMapper.Map<List<Account>, List<AccountDto>>(accounts));
    }
}

