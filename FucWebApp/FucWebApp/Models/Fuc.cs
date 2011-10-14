using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FucWebApp.Models
{
    class Fuc
    {
        public string   Name                { get; set; }
        public string   Acronym             { get; set; }
        public bool     Optional            { get; set; }
        public int      Semester            { get; set; }
        public List<KeyValuePair<string, string>>
                        Prereq              { get; set; }
        public float    Ects                { get; set; }
        public string   Objectives          { get; set; }
        public string   Results             { get; set; }
        public string   AvaliationResults   { get; set; }
        public string   ResumedProgram      { get; set; }
    }
}
