using System.Reflection;
using Autofac;
using PhoneBook.Domain.AggregatesModel.PhoneBookAggregate;
using PhoneBook.Domain.SeedWork;
using PhoneBook.Infrastructure;
using PhoneBook.Infrastructure.Repositories;
using Module = Autofac.Module;

namespace PhoneBook.API.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Context<>))
                .InstancePerDependency();
            
            builder.RegisterType<ContactRepository>().As<IContactRepository>()
                .InstancePerDependency();
            
            builder.RegisterType<ContactQueryRepository>().As<IContactQueryRepository>()
                .InstancePerDependency();

        }
    }
}