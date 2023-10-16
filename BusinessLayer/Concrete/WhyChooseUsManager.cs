using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WhyChooseUsManager : IWhyChooseUsService
    {
        IWhyChooseUsDal _whyChooseUsDal;

        public WhyChooseUsManager(IWhyChooseUsDal whyChooseUsDal)
        {
            _whyChooseUsDal = whyChooseUsDal;
        }

        public void TAdd(WhyChooseUs t)
        {
            _whyChooseUsDal.Insert(t);
        }

        public void TDelete(WhyChooseUs t)
        {
            _whyChooseUsDal.Delete(t);
        }

        public WhyChooseUs TGetByID(int id)
        {
            return _whyChooseUsDal.GetByID(id);
        }

        public List<WhyChooseUs> TGetList()
        {
            return _whyChooseUsDal.GetList();
        }

        public List<WhyChooseUs> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WhyChooseUs t)
        {
            _whyChooseUsDal.Update(t);
        }
    }
}
