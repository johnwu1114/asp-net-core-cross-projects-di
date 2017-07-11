using System;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public abstract class AbstractBaseDAL : IDisposable
    {
        protected readonly string _dbConnectionString;

        public AbstractBaseDAL(IConfigurationRoot config)
        {
            _dbConnectionString = config["DbConnection"];
            // Connect to Database...
        }

        public void Dispose()
        {
            // Disconnect from Database...
        }
    }
}