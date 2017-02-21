using System;
using Autofac;
using Ofl.Data.EntityFramework;
using Ofl.Data.EntityFramework.Contracts;
using Ofl.Data.SqlClient;
using Ofl.Data.SqlClient.Contracts;

namespace Ofl.Data.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        #region Overrides of Module

        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<SqlConnectionFactory>().As<ISqlConnectionFactory>();
            builder.RegisterType<DbContextFactory>().As<IDbContextFactory>();
        }

        #endregion
    }
}
