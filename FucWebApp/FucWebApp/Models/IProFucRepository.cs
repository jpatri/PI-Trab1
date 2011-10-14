using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FucWebApp.Models
{
    interface IProFucRepository: IFucRepository
    {
        Fuc GetById(int id);
    }
}
