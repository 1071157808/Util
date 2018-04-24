﻿using System.Threading.Tasks;
using Util.Domains.Repositories;
using Util.Security.Identity.Models;

namespace Util.Security.Identity.Repositories {
    /// <summary>
    /// 角色仓储
    /// </summary>
    /// <typeparam name="TRole">角色类型</typeparam>
    /// <typeparam name="TKey">角色标识类型</typeparam>
    /// <typeparam name="TParentId">角色父标识类型</typeparam>
    public interface IRoleRepository<TRole, in TKey, TParentId> : IRepository<TRole, TKey> where TRole : Role<TRole,TKey, TParentId> {
        /// <summary>
        /// 获取最大排序号
        /// </summary>
        /// <param name="role">角色</param>
        Task<int> GetMaxSortIdAsync( TRole role );
    }
}