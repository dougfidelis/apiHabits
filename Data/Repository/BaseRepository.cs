using Data.Contest;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (HabtsNowContest habitsNowContext = new HabtsNowContest())
            {
                list = habitsNowContext.Set<T>().ToList();
            }

            return list;
        }

        public virtual string Create(T entity)
        {
            using (HabtsNowContest habitsNowContext = new HabtsNowContest())
            {
                habitsNowContext.Add(entity);
                habitsNowContext.SaveChanges();
            }
            return "Criado";
        }
       

        public virtual string Delete(int id)
        {
            using (HabtsNowContest context = new HabtsNowContest())
            {
                context.Entry(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
            return "Deleted";
        }
        

        public virtual T GetById(int id)
        {
            T model = null;
            using (HabtsNowContest context = new HabtsNowContest())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Update(T entity)
        {
            using (HabtsNowContest context = new HabtsNowContest())
            {
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Modified";
        }
    }
}
