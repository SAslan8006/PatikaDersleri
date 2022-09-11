using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataAccess.NHihabernate
{
    public class NhQueryableRepository<T>: IQueryableRepository<T> where T:class,IEntity,new()
    {
        NHibernateHelper _nHibernateHelper;
        IQueryable<T> _entities;
        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table { get { return this.Entities;} }

        public virtual IQueryable<T> Entities 
        { 
            get 
            {
                if (_entities == null)
                {
                    _entities = _nHibernateHelper.OpenSession().Query<T>();
                }
            return _entities;
            } 
        }
    }
}
