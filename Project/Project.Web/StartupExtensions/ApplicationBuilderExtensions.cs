﻿using Microsoft.AspNetCore.Builder;
using Project.Web.Infrastructure;
using System.IO;

namespace Project.Web.StartupExtensions
{
    /// <summary>
    /// 功能描述    ：ApplicationBuilder扩展
    /// 创 建 者    ：鲁岩奇
    /// 创建日期    ：2021/1/12 9:40:56 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2021/1/12 9:40:56 
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// log4日志
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseLog4net(this IApplicationBuilder app)
        {
            var logRepository = log4net.LogManager.CreateRepository(System.Reflection.Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            return app;
        }
        /// <summary>
        /// 异常处理中间件
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseErrorHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
