using System;
using System.Threading.Tasks;
using TempProject.Data.Entities;

namespace TempProject.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<int, User> UserRepository { get; }
        IRepository<int, About> AboutRepository { get; }
        IRepository<int, PersonalInformation> PersonalInformationRepository { get; }
        IRepository<int, Pricing> PricingRepository { get; }
        IRepository<int, Schedule> ScheduleRepository { get; }
        IRepository<int, WorkAbilities> WorkAbilitiesRepository { get; }

        Task SaveAsync();
    }
}
