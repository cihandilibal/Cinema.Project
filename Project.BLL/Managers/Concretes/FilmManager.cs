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
    public class FilmManager : BaseManager<Film>, IFilmManager
    {
        readonly IFilmRepository _fRep;

        public FilmManager(IFilmRepository fRep) : base(fRep)
        {
            _fRep = fRep;
        }
    }
}
