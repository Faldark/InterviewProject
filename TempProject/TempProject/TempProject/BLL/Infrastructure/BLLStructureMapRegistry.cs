using StructureMap;
using TempProject.BLL.Abstract;
using TempProject.BLL.Services;

namespace TempProject.BLL.Infrastructure
{
    public class BLLStructureMapRegistry : Registry
    {
        public BLLStructureMapRegistry()
        {
            For<IUserService>().Use<UserService>();
        }
    }
}
