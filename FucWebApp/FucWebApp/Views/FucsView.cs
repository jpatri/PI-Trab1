using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI.WebGarten;
using PI.WebGarten.HttpContent.Html;

namespace FucWebApp.Views
{
    using Models;

    class FucsView: HtmlDoc
    {
        public FucsView(IEnumerable<Fuc> fucs)
            :base("Fichas de Unidades Curriculares",
            H1(Text("Fuc list")), 
            Ul(fucs.Select(fuc => Li(A(ResolveUri.For(fuc),fuc.Name))).ToArray())) {}        
    }
}
