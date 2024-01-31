using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(int id); // TEntity anlamı Bilinmeyen demektir. Bilinmeyen bir GETBYID al Anlamına gelir

        IEnumerable<TEntity> GetAll(); // IEnumerable butun verileri çek

        TEntity Insert(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(TEntity entity);

    }
}
