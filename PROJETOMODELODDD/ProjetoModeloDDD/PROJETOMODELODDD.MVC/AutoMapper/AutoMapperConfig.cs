using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;


namespace PROJETOMODELODDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        // ao ser chamado o metodo entao registra-se os mapeamentos
        public static void RegistraMapeamento()
        {

            Mapper.Initialize(x =>
           {
               x.AddProfile<DominioToViewModelMappingProfile>();
               x.AddProfile<ViewModelToDominiolMappingProfile>();
           });

        }
    }
}