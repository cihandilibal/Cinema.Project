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
    public class BoxOfficeManager : BaseManager<BoxOffice>, IBoxOfficeManager
    {
        readonly IBoxOfficeRepository _boRep;

        public BoxOfficeManager(IBoxOfficeRepository boRep) : base(boRep)
        {
            _boRep = boRep;
        }
    }
}
