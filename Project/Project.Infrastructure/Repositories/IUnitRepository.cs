﻿using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    /// <summary>
    /// 功能描述    ：IUnitRepository  
    /// 创 建 者    ：鲁岩奇
    /// 创建日期    ：2021/2/5 11:14:12 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2021/2/5 11:14:12 
    /// </summary>
    public interface IUnitRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> AddAsync(TEntity entity);
        bool Remove(Entity entity);
        Task<bool> RemoveAsync(Entity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
