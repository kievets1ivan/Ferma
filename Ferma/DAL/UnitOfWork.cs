using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork
    {
        private FermaStorage _fermaStorage;

        private IFermaRepository _fermaRepository;


        public UnitOfWork()
        {
            _fermaStorage = new FermaStorage();
        }


        public IFermaRepository FermaRepository
        {
            get
            {
                if(_fermaRepository == null)
                {
                    _fermaRepository = new FermaRepository(_fermaStorage);
                }

                return _fermaRepository;
            }
        }

    }
}
