using AutoMapper;
using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.MVC.ViewModels;

namespace ModelProjectDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile";  }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<ProductViewModel, Product>();
        }
    }
}