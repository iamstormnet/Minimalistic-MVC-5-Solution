using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimalistic_MVC5.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}
