using System.Reflection;
using Api.Controller;
using Autofac;
using DAL;
using Module = Autofac.Module;

namespace Api
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetAssembly(typeof(UserController));
            builder.RegisterAssemblyTypes(assembly)
                   .AsImplementedInterfaces();
            builder.RegisterModule(new DALModule());
        }
    }
}