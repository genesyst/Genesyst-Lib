using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst
{
    public class Repository<T> : IQueryable<T>
    {
        private readonly ISession session;
        public Repository(ISession SessionPass)
        {
            session = SessionPass;
        }

        public Type ElementType
        {
            get { return session.Query<T>().ElementType; }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return session.Query<T>().Expression; }
        }

        public IQueryProvider Provider
        {
            get { return session.Query<T>().Provider; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T entity)
        {
            session.Save(entity);
        }

        public void AddOrUpdate(T entity)
        {
            session.SaveOrUpdate(entity);
        }

        public void Update(T entity)
        {
            session.Update(entity);
        }

        public T Get(Guid id)
        {
            return session.Get<T>(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return session.Query<T>().GetEnumerator();
        }

        public List<T> GetList()
        {
            return session.Query<T>().ToList();
        }

        public void Remove(T entity)
        {
            if (entity != null)
            {
                session.Delete(entity);
            }
        }

        public void Removes(List<T> entitys)
        {
            foreach (var entity in entitys)
            {
                session.Delete(entity);
            }
        }

        public T CastTypeValue<T>(object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
