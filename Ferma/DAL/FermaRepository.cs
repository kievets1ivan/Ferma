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

        private FermaStorage _fermaStorage;

        public FermaRepository(FermaStorage fermaStorage)
        {
            _fermaStorage = fermaStorage;
        }

        public void Add(FermaEntity fermaEntity)
        {

            _fermaStorage.AddFerma(fermaEntity);

        }


        public void Delete(FermaEntity fermaEntity)
        {
            _fermaStorage.DeleteFerma(fermaEntity.Id);

        }


        public FermaEntity GetById(int id)
        {
            return _fermaStorage.GetFermaById(id);
        }

        public IEnumerable<FermaEntity> GetAll()
        {
            return _fermaStorage.GetAllFermas();
        }


    }
}
