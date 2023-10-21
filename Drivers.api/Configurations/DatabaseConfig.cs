using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.api.Configurations
{
    public class DatabaseConfig
    {
        public int timeoutTime { get; set; }
        public bool detailedError {get; set;}
        public bool sensitiveDataLogging {get; set;}
    }
}