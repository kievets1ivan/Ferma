using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FermaStorage
    {
        private readonly static List<FermaEntity> _fermaInternalStoragel;
        private static int id = 1;
        static FermaStorage()
        {
            _fermaInternalStoragel = new List<FermaEntity>();
        }

        public FermaStorage() { }

        public IEnumerable<FermaEntity> GetAllFermas()
        {
            return _fermaInternalStoragel.ToList();
        }

        public FermaEntity GetFermaById(int id)
        {
            return _fermaInternalStoragel.FirstOrDefault(ferma => ferma.Id == id);
        }

        public void AddFerma(FermaEntity newFerma)
        {
            if (newFerma == null)
                throw new ArgumentNullException(nameof(newFerma));


            newFerma.Id = id++;



            _fermaInternalStoragel.Add(newFerma);
        }

        public void DeleteFerma(int id)
        {
            var ferma = GetFermaById(id);

            if (ferma == null)
                return;

            _fermaInternalStoragel.Remove(ferma);


        }

    }
}
