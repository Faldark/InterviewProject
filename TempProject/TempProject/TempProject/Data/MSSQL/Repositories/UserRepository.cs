using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities;

namespace TempProject.Data.MSSQL.Repositories
{
    public class UserRepository : BaseRepository<int, User>
    {
        public UserRepository(CareproDbContext context) : base(context) { }
    }
}
