using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI.WebGarten;
using PI.WebGarten.HttpContent.Html;
using System.Net;

namespace FucWebApp.Views
{
    using Models;

    class ProFucView: HtmlDoc
    {
        public ProFucView(Fuc fuc)
            :base("Ficha de Unidade Curricular",
            Form(HttpMethod.Post, ResolveUri.ForPro(fuc),
            Label("Acronym","Acronym"), InputText("Acronym"),
            Label("IsOptional", "Is Optional"), InputText("IsOptional"),
            Label("Semester", "Semester"), InputText("Semester"),
            Label("Ects", "Ects"), InputText("Ects"),
            Label("PreRequesite ", "Pre Requesite"), InputText("PreRequesite"),
            Label("Objectives", "Objectives"), InputText("Objectives"),
            Label("Results", "Results"), InputText("Results"),
            Label("AvaliationResults", "Avaliation Results"), InputText("AvaliationResults"),
            Label("ResumedProgram", "ResumedProgram"), InputText("ResumedProgram"),
            InputSubmit("Update"))
            ) {}        
    }
}
