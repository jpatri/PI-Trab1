using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FucWebApp.Models
{
    class FucMemoryRepository : IFucRepository
    {
        private readonly IDictionary<string, Fuc> _repo;

        protected void ParseTxtFuc(StreamReader reader, Fuc fuc)
        {
            string line = reader.ReadLine();
            int indexOfName = line.IndexOf(' ') + 1;
            fuc.Acronym = line.Substring(0, indexOfName - 1);
            fuc.Name = line.Substring(indexOfName);
            line = reader.ReadLine();
            string[] unrelateds = line.Split();
            fuc.Optional = Boolean.Parse(unrelateds[0]);
            fuc.Semester = Int32.Parse(unrelateds[1]);
            fuc.Ects = (float)Double.Parse(unrelateds[2]);
            fuc.Prereq = new List<KeyValuePair<string, string>>();
            while ((line = reader.ReadLine()) != null && line.Length != 0)
            {
                indexOfName = line.IndexOf(' ') + 1;
                string acronym = line.Substring(0, indexOfName - 2);
                string name = line.Substring(indexOfName);
                fuc.Prereq.Add(new KeyValuePair<string, string>(acronym, name));
            }
            StringBuilder builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null && line.Length != 0)
                builder.Append(line);
            fuc.Objectives = builder.ToString();

            builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null && line.Length != 0)
                builder.Append(line);
            fuc.Results = builder.ToString();

            builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null && line.Length != 0)
                builder.Append(line);
            fuc.AvaliationResults = builder.ToString();

            builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null && line.Length != 0)
                builder.Append(line);
            fuc.ResumedProgram = builder.ToString();
        }

        public FucMemoryRepository()
        {
            _repo = new Dictionary<string, Fuc>();
            IEnumerable<string> fucFilenames = Directory.EnumerateFiles(@"D:\My Work\Isel\PI\i1112\trab1\FucWebApp\FucWebApp\FucDB");
            foreach(var fucFilename in fucFilenames) {
                Fuc fuc = new Fuc();
                StreamReader fucReader = new StreamReader(fucFilename);

                ParseTxtFuc(fucReader, fuc);

                _repo.Add(fuc.Acronym, fuc);
            }
        }

        public IEnumerable<Fuc> GetAll()
        {
            return _repo.Values;
        }

        public Fuc GetByAcronym(string ac)
        {
            Fuc fuc = null;
            _repo.TryGetValue(ac, out fuc);
            return fuc;
        }

        public void Add(Fuc fuc)
        {
            _repo.Add(fuc.Acronym, fuc);
        }
    }
}