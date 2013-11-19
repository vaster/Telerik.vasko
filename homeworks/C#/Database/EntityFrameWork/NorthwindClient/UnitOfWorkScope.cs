using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace NorthwindClient
{
    public sealed class UnitOfWorkScope : IDisposable
    {
        [ThreadStatic]
        private static UnitOfWorkScope currScope;

        private northwindEntities northwindContext;

        private bool isDisposed;

        private bool toSaveAllChanges;


        public bool ToSaveAllChanges
        {
            get { return this.toSaveAllChanges; }
            set { this.toSaveAllChanges = value; }
        }

        internal static northwindEntities NorthwindContext
        {
            get { return currScope != null ? currScope.northwindContext : null; }
        }

        public UnitOfWorkScope()
            : this(false)
        {
        }

        public UnitOfWorkScope(bool toSaveAllChanges)
        {
            if ((currScope != null) && (!currScope.isDisposed))
            {
                throw new InvalidOperationException(String.Format("Nestig of nothwindContexts is not allowed!"));
            }

            this.toSaveAllChanges = toSaveAllChanges;
            northwindContext = new northwindEntities();
            this.isDisposed = false;
            Thread.BeginThreadAffinity();
            currScope = this;
        }

        public void Dispose()
        {
            if (!this.isDisposed)
            {
                currScope = null;

                Thread.EndThreadAffinity();

                if (this.ToSaveAllChanges)
                {
                    this.northwindContext.SaveChanges();
                }
                this.northwindContext.Dispose();
                this.isDisposed = true;
            }
        }
    }
}
