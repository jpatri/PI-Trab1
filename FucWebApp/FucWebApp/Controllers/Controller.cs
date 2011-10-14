using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI.WebGarten;
using PI.WebGarten.MethodBasedCommands;
using System.Net;


namespace FucWebApp.Controllers
{
    using Views;
    using Models;

    class Controller
    {
        [HttpCmd(HttpMethod.Get, "/leic/fuc")]
        public HttpResponse GetFucAll()
        {
            return new HttpResponse(HttpStatusCode.OK, new FucsView(RepositoryLocator.GetFuc().GetAll()));
        }

        [HttpCmd(HttpMethod.Get, "/leic/profuc")]
        public HttpResponse GetProFucAll()
        {
            return new HttpResponse(HttpStatusCode.OK, new ProFucsView(RepositoryLocator.GetProFuc().GetAll()));
        }

        [HttpCmd(HttpMethod.Get, "/leic/fuc/{uc}")]
        public HttpResponse GetFuc(string uc)
        {
            Fuc fuc = RepositoryLocator.GetFuc().GetByAcronym(uc);
            if (fuc == null) {
                return new HttpResponse(HttpStatusCode.NotFound);
            }
            return new HttpResponse(HttpStatusCode.OK, new FucView(fuc));
        }

        [HttpCmd(HttpMethod.Get, "/leic/profuc/{id}")]
        public HttpResponse GetProFuc(int id)
        {
            ProFuc fuc = RepositoryLocator.GetProFuc().GetById(id) as ProFuc;
            if (fuc == null)
            {
                return new HttpResponse(HttpStatusCode.NotFound);
            }
            return new HttpResponse(HttpStatusCode.OK, new ProFucView(fuc));
        }

        [HttpCmd(HttpMethod.Post, "/leic/profuc/{id}")]
        public HttpResponse PostProFuc(int id)
        {
            // Obter o Fuc dado o id e actualizar com o conteúdo do form.
            // Redireccionar para uma página com Get.
            throw new NotImplementedException();
        }
    }
}
