using POS.Application.Commons.Bases;
using POS.Application.Dtos.response;
using POS.Infrastructure.Commons.Bases.request;
using POS.Infrastructure.Commons.Bases.response;

namespace POS.Application.Interfaces
{
    public interface ICategoryApplication
    {
        Task<BaseResponse<BaseEntityResponse<CategoryResponseDto>>> ListCategory(BaseFiltersRequest filters);
        Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories();
        Task<BaseResponse<CategoryResponseDto>> CategoryById(int categoryId);
        Task<BaseResponse<bool>> RegisterCategory(CategoryResponseDto requestDto);
        Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryResponseDto requestDto);
        Task<BaseResponse<bool>> RemoveCategory(int categoryId);
    }
}
