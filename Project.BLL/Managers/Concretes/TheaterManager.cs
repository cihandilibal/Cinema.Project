using Project.BLL.Managers.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Concretes
{
    public class TheaterManager : BaseManager<Theater>, ITheaterManager
    {
        readonly ITheaterRepository _tRep;

        public TheaterManager(ITheaterRepository tRep) : base(tRep)
        {
            _tRep = tRep;
        }
    }
}
