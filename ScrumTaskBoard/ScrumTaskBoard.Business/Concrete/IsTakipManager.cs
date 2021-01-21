using FluentValidation;
using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Business.Validation_Rules.Fluent_Validation;
using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBorad.DataAccess.Abstarct;
using ScrumTaskBorad.DataAccess.Concrete;
using ScrumTaskBorad.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Concrete
{
    public class IsTakipManager:IIsTakipService
    {
        private IIsTakipDal _isTakipDal;
        private IsTakipValidator _isTakipValidator = new IsTakipValidator();

        private void Validation(IsTakip isTakip)
        {
            var result = _isTakipValidator.Validate(isTakip);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }

        public IsTakipManager(IIsTakipDal isTakipDal)
        {
            _isTakipDal = isTakipDal;
        }

        public void Add(IsTakip isTakip)
        {
            Validation(isTakip);
            _isTakipDal.Add(isTakip);

        }

        public void Delete(IsTakip isTakip)
        {
            _isTakipDal.Delete(isTakip);
        }

        public List<IsTakip> GetAll()
        {
            return _isTakipDal.GetAll();
        }

        public void Update(IsTakip isTakip)
        {
            Validation(isTakip);
            _isTakipDal.Update(isTakip);
        }

        public List<IsTakip> GetIsTakipByKart(int kartId)
        {
            return _isTakipDal.GetAll(i => i.KartId == kartId);
        }
    }
}
