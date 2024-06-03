using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Other.Thread.Dtos.Accounting;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OtherThread.Accounting;

public interface ISafeAppService :
    ICrudAppService< //Defines CRUD methods
        SafeDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        SafeCreateUpdateDto> //Used to create/update a book
{
    
}