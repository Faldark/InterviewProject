using KanbanApp.DAL.MSSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities;
namespace TempProject.Data.MSSQL.Repositories
{
    public class AboutRepository : BaseRepository<int, About>
    {
        public AboutRepository(CareproDbContext context) : base(context) { }
    }
}
