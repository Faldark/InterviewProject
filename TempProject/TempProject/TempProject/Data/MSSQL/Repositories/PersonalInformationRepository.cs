using KanbanApp.DAL.MSSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities;

namespace TempProject.Data.MSSQL.Repositories
{
    public class PersonalInformationRepository : BaseRepository<int, PersonalInformation>
    {
        public PersonalInformationRepository(CareproDbContext context) : base(context) { }
    }
}
