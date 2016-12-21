using System.Threading.Tasks;

namespace AutofacPrism.Droid
{
    internal class AndroidFooService : IFooService
    {
        public Task GetBar() => Task.CompletedTask;
    }
}