using System.Threading.Tasks;

namespace AutofacPrism.iOS
{
    internal class iOSFooService : IFooService
    {
        public Task GetBar() => Task.CompletedTask;
    }
}