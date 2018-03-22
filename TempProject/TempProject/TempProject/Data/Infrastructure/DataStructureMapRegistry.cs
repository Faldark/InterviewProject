using Microsoft.EntityFrameworkCore;

using StructureMap;


using KanbanApp.DAL.MSSQL;
using TempProject.Data.Abstract;
using TempProject.Data.MSSQL;
using TempProject.Data.MSSQL.Repositories;
using TempProject.Data.Entities;
using StructureMap.AutoFactory;

namespace TempProject.Data.Infrastructure
{
    public class DataStructureMapRegistry : Registry
    {
        public DataStructureMapRegistry()
        {
            For<IRepository<int, User>>().Use<UserRepository>();
            For<IUnitOfWork>().Use<UnitOfWork>();
            For<IUnitOfWorkFactory>().CreateFactory();
            For<IRepositoryFactory>().CreateFactory();
            For<DbContext>().Use<CareproDbContext>();
            
        }
    }
}
