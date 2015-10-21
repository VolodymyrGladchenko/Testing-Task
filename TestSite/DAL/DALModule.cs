using System.Reflection;
using Autofac;
using DAL.DA;
using Module = Autofac.Module;

namespace DAL
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetAssembly(typeof (DataAccess));
            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces();
        }
    }
}