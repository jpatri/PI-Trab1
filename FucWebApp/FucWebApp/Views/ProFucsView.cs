using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI.WebGarten;
using PI.WebGarten.HttpContent.Html;

namespace FucWebApp.Views
{
    using Models;

    class ProFucsView: HtmlDoc
    {
        public ProFucsView(IEnumerable<Fuc> fucs)
            :base("Propostas para Fichas de Unidades Curriculares",
            H1(Text("Proposal Fuc list")), 
            Ul(fucs.Select(fuc => Li(A(ResolveUri.ForPro(fuc),fuc.Name))).ToArray())) {}        
    }
}
