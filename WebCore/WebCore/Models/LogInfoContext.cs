using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class LogInfoContext:DbContext
    {
        public DbSet<LogInfoModel> LogInfo { get; set; }
        public LogInfoContext(DbContextOptions<LogInfoContext> options)
            :base(options)
        {

        }
    }
}
