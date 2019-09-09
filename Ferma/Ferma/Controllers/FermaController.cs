using BuisnessLayer.Services;
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

        private FermaService _fermaService;

        public FermaController()
        {
            _fermaService = new FermaService(new UnitOfWork());
        }


        public IEnumerable<FermaEntity> Get()
        {

            return _fermaService.GetAll();
        }

        public void Post([FromBody] FermaEntity fermaEntity)
        {
            _fermaService.AddFarm(fermaEntity);
        }

        public void Delete([FromBody]FermaEntity fermaEntity)
        {
            _fermaService.DeleteFerma(fermaEntity);
        }

        public FermaEntity Get(int id)
        {
            return _fermaService.GetFermaById(id);
        }

        public void Put([FromBody]FermaEntity fermaEntity)
        {
            _fermaService.EditFerma(fermaEntity);
        }
    }
}
