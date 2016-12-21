using Autofac;
using Prism.Autofac.Forms;

namespace AutofacPrism.iOS
{
    internal class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<iOSFooService>().AsImplementedInterfaces();
            builder.Update(container);
        }
    }
}