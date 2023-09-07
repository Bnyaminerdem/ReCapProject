using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {

        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAll()
        {
            //iş kodları
            return _colorDal.GetAll();  
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c=>c.ColorId == colorId);
        }
    }
}
