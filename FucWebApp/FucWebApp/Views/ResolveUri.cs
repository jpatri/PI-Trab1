using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FucWebApp.Views
{
    using Models;

    static class ResolveUri
    {
        public static string For(Fuc fuc)
        {
            return string.Format("/leic/fuc/{0}", fuc.Acronym);
        }

        public static string For()
        {
            return "/leic/fuc";
        }

        public static string ForPro(Fuc fuc)
        {
            ProFuc pro = fuc as ProFuc;
            return string.Format("/leic/profuc/{0}", pro.Id);
        }

        public static string ForPro()
        {
            return "/leic/profuc";
        }

        public static string ForCreate()
        {
            return "/leic/profuc/create";
        }

        public static string ForCreate(Fuc fuc)
        {
            return string.Format("/leic/profuc/create/{0}", fuc.Acronym);
        }

    }
}
