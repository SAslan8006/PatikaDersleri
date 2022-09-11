
using Core.DataAccess.NHihabernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace DataAcsess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012//Buradaki conetionları değiştirerek değişik veri tabana adapta edebilirsin.
            .ConnectionString(("NortwindContext")))
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .BuildSessionFactory();                     
               
        }
        
    }
}
