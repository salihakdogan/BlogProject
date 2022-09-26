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
    public class NewstellerManager : INewstellerService
    {
        INewstellerDal _newstellerDal;

        public NewstellerManager(INewstellerDal newstellerDal)
        {
            _newstellerDal = newstellerDal;
        }

        public Newsletter GetT(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Newsletter t)
        {
            _newstellerDal.Insert(t);
        }

        public List<Newsletter> TList()
        {
            throw new NotImplementedException();
        }

        public void TRemove(Newsletter t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Newsletter t)
        {
            throw new NotImplementedException();
        }
    }
}
