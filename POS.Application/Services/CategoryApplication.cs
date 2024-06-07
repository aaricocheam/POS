using AutoMapper;
using POS.Application.Commons.Bases;
using POS.Application.Dtos.response;
using POS.Application.Interfaces;
using POS.Application.Validators.Category;
using POS.Infrastructure.Commons.Bases.request;
using POS.Infrastructure.Commons.Bases.response;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Application.Services
{
    public class CategoryApplication : ICategoryApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly CategoryValidator _validationRules;

        public CategoryApplication(IUnitOfWork unitOfWork, IMapper mapper, CategoryValidator validationRules)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public Task<BaseResponse<BaseEntityResponse<CategoryResponseDto>>> ListCategory(BaseFiltersRequest filters)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<CategoryResponseDto>> CategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> RegisterCategory(CategoryResponseDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryResponseDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> RemoveCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
