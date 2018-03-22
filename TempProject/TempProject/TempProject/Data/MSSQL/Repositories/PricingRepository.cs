using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities;

namespace TempProject.Data.MSSQL.Repositories
{
    public class PricingRepository : BaseRepository<int, Pricing>
    {
        public PricingRepository(CareproDbContext context) : base(context) { }
    }
}
