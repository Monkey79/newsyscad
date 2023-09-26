using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.repository
{
    public interface CommonsOprt<T>
    {
        public T Save(T entity);
        public List<T> GetAll();
        public T GetById(int id);
        public T DeleteById(int id);
    }
}
