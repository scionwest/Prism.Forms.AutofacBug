using Autofac;
using Prism.Autofac.Forms;

namespace AutofacPrism.Droid
{
    internal class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AndroidFooService>().AsImplementedInterfaces();
            builder.Update(container);
        }
    }
}