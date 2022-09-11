﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.NHihabernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        static ISessionFactory _sessionFactory;
        public virtual ISessionFactory SessionFactory 
        { 
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession() 
        { 
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
    }
}
