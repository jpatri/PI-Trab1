using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI.WebGarten.HttpContent.Html;

namespace FucWebApp.Views
{
    using Models;

    class FucView: HtmlDoc
    {
        public FucView(Fuc fuc)
            :base("Ficha de Unidade Curricular",
            P(Text(string.Format("{0} {1}", fuc.Acronym, fuc.Name))), 
            P(Text(string.Format("Is optional = {0}", fuc.Optional))),
            P(Text(string.Format("Semester = {0}", fuc.Semester))),
            P(Text(string.Format("Ects = {0}", fuc.Ects))),
            P(Text("Pre-requesites: ")),
            Ul(fuc.Prereq.Select(prereq => Li(Text(string.Format("{0} {1}", prereq.Key, prereq.Value)))).ToArray()),
            P(Text(string.Format("Objectives = {0}", fuc.Objectives))),
            P(Text(string.Format("Results = {0}", fuc.Results))),
            P(Text(string.Format("AvaliationResults = {0}", fuc.AvaliationResults))),
            P(Text(string.Format("ResumedProgram = {0}", fuc.ResumedProgram)))
            ) {}        
    }
}
