using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Other.Thread.Dtos.Accounting;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Other.Thread.Accounting;

public interface IAccountAppService :
    ICrudAppService< //Defines CRUD methods
        AccountDto, //Used to show books
        Guid, //Primary key of the book entity
        AccountPagedAndSortedResultRequestDto, //Used for paging/sorting
        AccountCreateUpdateDto> //Used to create/update a book
{
    
}