using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SigmaManager : ISigmaService
    {
        ISigmaDal _denemeDal;
        public SigmaManager(ISigmaDal denemeDal)
        {
            _denemeDal = denemeDal;
        }
        public void Add(Sigma deneme)
        {
            _denemeDal.Add(deneme);
        }

        public Sigma Get()
        {
            return _denemeDal.Get(x => x.SigmaId == 1);
        }

        public List<Sigma> GetAll()
        {
            return _denemeDal.GetAll();
        }

        public void Update(Sigma deneme)
        {
            _denemeDal.Update(deneme);
        }
    }
}
