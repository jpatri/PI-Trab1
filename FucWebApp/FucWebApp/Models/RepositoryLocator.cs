using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FucWebApp.Models
{
    class RepositoryLocator
    {
        static private readonly FucMemoryRepository FucRepo = new FucMemoryRepository();
        static private readonly ProFucMemoryRepository ProFucRepo = new ProFucMemoryRepository();

        static public IFucRepository GetFuc()
        {
            return FucRepo;
        }
        static public IProFucRepository GetProFuc()
        {
            return ProFucRepo;
        }
    }
}
