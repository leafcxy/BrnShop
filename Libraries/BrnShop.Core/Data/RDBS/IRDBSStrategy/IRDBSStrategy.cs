using System;
using System.Data.Common;

namespace BrnShop.Core
{
    /// <summary>
    /// BrnShop关系型数据库策略
    /// </summary>
    public partial interface IRDBSStrategy
    {
        /// <summary>
        /// 获取数据库提供程序工厂
        /// </summary>
        DbProviderFactory GetDbProviderFactory();

        /// <summary>
        /// 运行Sql
        /// </summary>
        /// <param name="sql">运行Sql</param>
        /// <returns></returns>
        string RunSql(string sql);
    }
}
