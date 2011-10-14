using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace FucWebApp.Models
{
    class ProFucMemoryRepository : FucMemoryRepository, IProFucRepository
    {
        private readonly IDictionary<int, Fuc> _repo;
        private int _cid = 0;

        public ProFucMemoryRepository()
        {
            _repo = new Dictionary<int, Fuc>();
            IEnumerable<string> fucFilenames = Directory.EnumerateFiles(@"D:\My Work\Isel\PI\i1112\trab1\FucWebApp\FucWebApp\ProFucDB");
            foreach(var fucFilename in fucFilenames) {
                ProFuc fuc = new ProFuc();
                StreamReader fucReader = new StreamReader(fucFilename);

                ParseTxtFuc(fucReader, fuc);

                // Parser da identidade do autor da proposta de Fuc
                fuc.Identity = fucReader.ReadLine().Trim();

                fuc.Id = _cid++;
                _repo.Add(fuc.Id, fuc);
            }
        }

        new public IEnumerable<Fuc> GetAll()
        {
            return _repo.Values;
        }

        new public Fuc GetByAcronym(string ac)
        {
            throw new NotImplementedException();
        }
        public Fuc GetById(int id)
        {
            Fuc fuc = null;
            _repo.TryGetValue(id, out fuc);
            return fuc;
        }

        new public void Add(Fuc fuc)
        {
            _repo.Add(_cid++, fuc);
        }
    }
}