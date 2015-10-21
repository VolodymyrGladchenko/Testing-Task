using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.WebApi;
using DAL;

namespace Api
{
    public class ApiKernel
    {
        public static readonly ApiKernel Instance = new ApiKernel();

        public ApiKernel()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ApiModule>();
            builder.RegisterModule<DALModule>();            
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); // add resolver for the Controller
            Container = builder.Build();
        }

        public IContainer Container { get; set; }

    }
}
