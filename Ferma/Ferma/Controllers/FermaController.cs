using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Ferma.Controllers
{
    public class FermaController : ApiController
    {

        private IFermaRepository _fermaRepository;

        public FermaController()
        {
            var unitOfWork = new UnitOfWork();

            _fermaRepository = unitOfWork.FermaRepository;
        }

        public IEnumerable<FermaEntity> Get()
        {
            return _fermaRepository.GetAll();
        }

        public void Post([FromBody] FermaEntity fermaEntity)
        {
            _fermaRepository.Add(fermaEntity);
        }

    }
}
