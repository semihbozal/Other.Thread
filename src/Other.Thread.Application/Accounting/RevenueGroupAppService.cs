using System;
using OtherThread.Accounting;
using Other.Thread.Dtos.Accounting;
using Other.Thread.Entities.Accounting;
using Other.Thread.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Other.Thread.Accounting;

public class RevenueGroupAppService :
    CrudAppService<
        RevenueGroup, //The Book entity
        RevenueGroupDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        RevenueGroupCreateUpdateDto>, //Used to create/update a book
    IRevenueGroupAppService //implement the IBookAppService
{
    IRepository<RevenueGroup, Guid> revenueGroupRepository;
    public RevenueGroupAppService(IRepository<RevenueGroup, Guid> repository) : base(repository)
    {
        revenueGroupRepository = repository;
        GetPolicyName = OtherThreadPermissions.RevenueGroups.Default;
        GetListPolicyName = OtherThreadPermissions.RevenueGroups.Default;
        CreatePolicyName = OtherThreadPermissions.RevenueGroups.Create;
        UpdatePolicyName = OtherThreadPermissions.RevenueGroups.Edit;
        DeletePolicyName = OtherThreadPermissions.RevenueGroups.Delete;
    }
}
