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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public List<Testimonial> GetAll()
        {
          return  _testimonialDal.getAll();
        }

        public void TAdd(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
