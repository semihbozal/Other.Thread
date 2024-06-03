using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Other.Thread.Dtos.Accounting;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OtherThread.Accounting;

public interface IRevenueGroupAppService :
    ICrudAppService< //Defines CRUD methods
        RevenueGroupDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        RevenueGroupCreateUpdateDto> //Used to create/update a book
{
    
}
