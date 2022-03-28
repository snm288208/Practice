using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzzeen.Practice.DataAccess
{
    public class BaseDataAccess
    {
        private readonly IConfiguration _config;
        public BaseDataAccess(IConfiguration Config)
        {
            _config = Config;

        }
        public string ConnectionString 
        {
            get
            {
              return _config.GetConnectionString("ConnectionString");
            }
        }
    }
}
