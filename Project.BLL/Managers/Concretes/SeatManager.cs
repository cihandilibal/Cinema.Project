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
    public class SeatManager : BaseManager<Seat>, ISeatManager
    {
        readonly ISeatRepository _sRep;

        public SeatManager(ISeatRepository sRep) : base(sRep)
        {
            _sRep = sRep;
        }
    }
}
