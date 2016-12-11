using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimalistic_MVC5
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commit changes.
        /// </summary>
        /// <exception cref="TransactionAlreadyClosedException">UoW have already been saved.</exception>
        void SaveChanges();
    }
}
