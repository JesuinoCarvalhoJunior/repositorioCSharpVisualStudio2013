using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PROJETOMODELODDD.MVC.ViewModels;
using PROJETOMODELODDD.DOMINIO.Entidades;
namespace PROJETOMODELODDD.MVC.AutoMapper
{
    public class DominioToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DominioToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            // aqui é o contrario de ViewModelToDominiolMappingProfile.cs
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}