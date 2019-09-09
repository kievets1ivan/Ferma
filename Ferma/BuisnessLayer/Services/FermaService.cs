using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Services
{
    public class FermaService
    {

        private UnitOfWork _unitOfWork;

        public FermaService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Farm
        public IEnumerable<FermaEntity> GetAll()
        {
            return _unitOfWork.FermaRepository.GetAll();
        }

        public void AddFarm(FermaEntity fermaEntity)
        {
            _unitOfWork.FermaRepository.Add(fermaEntity);
            _unitOfWork.Save();
        }

        public void DeleteFerma(FermaEntity fermaEntity)
        {
            _unitOfWork.FermaRepository.Delete(fermaEntity);
            _unitOfWork.Save();
        }

        public FermaEntity GetFermaById(int id)
        {
            return _unitOfWork.FermaRepository.GetById(id);
        }

        public void EditFerma(FermaEntity fermaEntity)
        {
            _unitOfWork.FermaRepository.Update(fermaEntity);
            _unitOfWork.Save();
        }
    }
}
