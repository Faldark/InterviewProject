using System;
using System.Threading.Tasks;

using TempProject.Data.Entities;
using TempProject.Data.MSSQL;
using TempProject.Data.Abstract;

namespace KanbanApp.DAL.MSSQL
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<int, User> UserRepository {
            get
            {
                return _userRepository ?? (_userRepository = _factory.CreateRepository<int, User>(_context));
            }
        }

        public IRepository<int, About> AboutRepository
        {
            get
            {
                return _aboutRepository ?? (_aboutRepository = _factory.CreateRepository<int, About>(_context));
            }
        }
        public IRepository<int, PersonalInformation> PersonalInformationRepository
        {
            get
            {
                return _personalInformationRepository ?? (_personalInformationRepository = _factory.CreateRepository<int, PersonalInformation>(_context));
            }
        }
        public IRepository<int, Pricing> PricingRepository
        {
            get
            {
                return _pricingRepository ?? (_pricingRepository = _factory.CreateRepository<int, Pricing>(_context));
            }
        }
        public IRepository<int, Schedule> ScheduleRepository
        {
            get
            {
                return _scheduleRepository ?? (_scheduleRepository = _factory.CreateRepository<int, Schedule>(_context));
            }
        }
        public IRepository<int, WorkAbilities> WorkAbilitiesRepository
        {
            get
            {
                return _workAbilitiesRepository ?? (_workAbilitiesRepository = _factory.CreateRepository<int, WorkAbilities>(_context));
            }
        }


        public UnitOfWork(CareproDbContext context, IRepositoryFactory factory)
        {
            _context = context;
            _factory = factory;
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;

        private IRepositoryFactory _factory;
        private CareproDbContext _context;

        private IRepository<int, User> _userRepository;
        private IRepository<int, About> _aboutRepository;
        private IRepository<int, PersonalInformation> _personalInformationRepository;
        private IRepository<int, Pricing> _pricingRepository;
        private IRepository<int, Schedule> _scheduleRepository;
        private IRepository<int, WorkAbilities> _workAbilitiesRepository;
    }
}
