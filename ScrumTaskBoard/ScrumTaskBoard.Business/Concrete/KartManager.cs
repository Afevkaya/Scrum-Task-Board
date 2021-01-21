using FluentValidation;
using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Business.Validation_Rules.Fluent_Validation;
using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBorad.DataAccess.Abstarct;
using ScrumTaskBorad.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Concrete
{
    public class KartManager:IKartService
    {
        private IKartDal _kartdal;
        KartValidator _kartValidator = new KartValidator();

        private void Validation(Kart kart)
        {
            var result = _kartValidator.Validate(kart);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }

        public KartManager(IKartDal kartdal)
        {
            _kartdal = kartdal;
        }

        public void Add(Kart kart)
        {
            Validation(kart);
            _kartdal.Add(kart);
        }

       

        public void Delete(Kart kart)
        {
            _kartdal.Delete(kart);
        }

        public List<Kart> GetAll()
        {
            return _kartdal.GetAll();
        }

        public void Update(Kart kart)
        {
            Validation(kart);
            _kartdal.Update(kart);
        }
    }
}
