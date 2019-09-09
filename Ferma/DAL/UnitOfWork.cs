using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork
    {
        private FermaContext _fermaContext;

        private IFermaRepository _fermaRepository;


        public UnitOfWork(FermaContext fermaContext)
        {
            _fermaContext = fermaContext;
        }


        public IFermaRepository FermaRepository
        {
            get
            {
                if(_fermaRepository == null)
                {
                    _fermaRepository = new FermaRepository(_fermaContext);
                }

                return _fermaRepository;
            }
        }

        public void Save()
        {
            _fermaContext.SaveChanges();
        }

    }
}
