using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PROJETOMODELODDD.MVC.ViewModels;
using PROJETOMODELODDD.DOMINIO.Entidades;

namespace PROJETOMODELODDD.MVC.AutoMapper
{
    public class ViewModelToDominiolMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDominiolMappingProfile"; }

        }

        protected override void Configure()
        {
            // quando tiver ClienteViewModel transforma-se para Cliente
            // quando tiver ProdutoViewModel transforma-se para Produto
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}