using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.TenantManagement;

namespace Acme.BookStore
{
    public  class BookService : BookStoreAppService
    {
        private readonly IRepository<Tenant, Guid> _todoRepository;

        public BookService(IRepository<Tenant, Guid> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<List<Tenant>> GetAll()
        {
            return await _todoRepository.GetListAsync();
        }
    }
}
