using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Other.Thread.Dtos.Accounting;
using Other.Thread.Entities.Accounting;
using Other.Thread.Permissions;
using OtherThread.Accounting;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Validation;

namespace Other.Thread.Accounting;

public class SafeAppService :
    CrudAppService<
        Safe, //The Book entity
        SafeDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        SafeCreateUpdateDto>, //Used to create/update a book
    ISafeAppService //implement the IBookAppService
{
    IRepository<Safe, Guid> safeRepository;
    public SafeAppService(IRepository<Safe, Guid> repository)
        : base(repository)
    {
        safeRepository = repository;
        GetPolicyName = OtherThreadPermissions.Safes.Default;
        GetListPolicyName = OtherThreadPermissions.Safes.Default;
        CreatePolicyName = OtherThreadPermissions.Safes.Create;
        UpdatePolicyName = OtherThreadPermissions.Safes.Edit;
        DeletePolicyName = OtherThreadPermissions.Safes.Delete;
    }

    public async override Task<SafeDto> CreateAsync(SafeCreateUpdateDto input)
    {
        IQueryable<Safe> queryable = await safeRepository.GetQueryableAsync();
        Safe? safe = queryable.FirstOrDefault(x => x.Code == input.Code && x.IsDeleted == false);

        if (safe != null)
        {
            throw new AbpValidationException(
                "Kasa Kodu Tekil Olmalı!",
                new List<ValidationResult>
                {
                    new ValidationResult(
                        "Kasa Kodu Tekil Olmalı!",
                        new []{"Code"}
                    )
                }
            );        
        }

        if (input.IsDefault)
        {
            safe = queryable.FirstOrDefault(x => x.IsDefault == true && x.IsDeleted == false);
            if (safe != null)
            {
                safe.IsDefault = false;
                await base.UpdateAsync(safe.Id, ObjectMapper.Map<Safe, SafeCreateUpdateDto>(safe));
            }
        }

        return await base.CreateAsync(input);
    }

    public async override Task<SafeDto> UpdateAsync(Guid id, SafeCreateUpdateDto input)
    {
        IQueryable<Safe> queryable = await safeRepository.GetQueryableAsync();
        Safe? safe = queryable.FirstOrDefault(x => x.Code == input.Code && x.IsDeleted == false && x.Id != id);

        if (safe != null)
        {
            throw new AbpValidationException(
                "Kasa Kodu Tekil Olmalı!",
                new List<ValidationResult>
                {
                    new ValidationResult(
                        "Kasa Kodu Tekil Olmalı!",
                        new []{"Code"}
                    )
                }
            );        
        }

        if (input.IsDefault)
        {
            safe = queryable.FirstOrDefault(x => x.IsDefault == true && x.IsDeleted == false);
            if (safe != null)
            {
                safe.IsDefault = false;
                await base.UpdateAsync(safe.Id, ObjectMapper.Map<Safe, SafeCreateUpdateDto>(safe));
            }
        }

        return await base.UpdateAsync(id, input);
    }
}

