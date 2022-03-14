using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Data.Abstract
{
    public interface IRepository <TEntity>
    {
        List<TEntity> Liste();
        void Ekle(TEntity entity);

    }
}
