using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FucWebApp.Models
{
    interface IFucRepository
    {
        IEnumerable<Fuc> GetAll();
        Fuc GetByAcronym(string ac);
        void Add(Fuc fuc);
    }
}
