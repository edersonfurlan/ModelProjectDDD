using AutoMapper;
using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelProjectDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
        }
    }
}