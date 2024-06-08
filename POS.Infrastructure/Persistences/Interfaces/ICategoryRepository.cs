using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.request;
using POS.Infrastructure.Commons.Bases.response;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters);
    }
}
