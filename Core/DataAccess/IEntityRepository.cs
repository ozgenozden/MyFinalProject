using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
   // where T clasını kısıtlamaya generic constraint denir.
    //class :bir referans tip olabilir demek.
    //IEntity :IEntity veya IEntity yi implement eden bir class olabilir.
    //new() :new lenebilir bir clas olmalıdır demek(böylece IEntity nin kensisinin olmasını engellemiş oluruz.)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       // List<T> GetAllByCategory(int categoryId);

    }
}
