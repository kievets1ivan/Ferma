using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFermaRepository
    {
        void Add(FermaEntity fermaEntity);
        void Delete(FermaEntity fermaEntity);
        IEnumerable<FermaEntity> GetAll();
        FermaEntity GetById(int id);
    }

    public class FermaRepository : IFermaRepository
    {

        private FermaContext _db;

        public FermaRepository(FermaContext context)
        {
            _db = context;
        }

        public void Add(FermaEntity fermaEntity)
        {

            _db.FermaEntities.Add(fermaEntity);

        }


        public void Delete(FermaEntity fermaEntity)
        {
            _db.FermaEntities.Remove(fermaEntity);
        }


        public FermaEntity GetById(int id)
        {
            return _db.FermaEntities.Find(id);
        }

        public IEnumerable<FermaEntity> GetAll()
        {
            return _db.FermaEntities;
        }


    }
}
