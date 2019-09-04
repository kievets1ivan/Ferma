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
        private UnitOfWork _unitOfWork;

        public FermaController()
        {
            _unitOfWork = new UnitOfWork();

            _fermaRepository = _unitOfWork.FermaRepository;
        }

        public IEnumerable<FermaEntity> Get()
        {
            
            return _fermaRepository.GetAll();
        }

        public void Post([FromBody] FermaEntity fermaEntity)
        {
            _fermaRepository.Add(fermaEntity);
            _unitOfWork.Save();
        }

    }
}
