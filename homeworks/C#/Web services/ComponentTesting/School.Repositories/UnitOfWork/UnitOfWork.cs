using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using School.EF.Data;
using School.Models;
using School.Repositories.RepoFactory;

namespace School.Repositories.UnitOfWork
{
    public sealed class UnitOfWorkScope : IDisposable
    {
        [ThreadStatic]
        private static UnitOfWorkScope currScope;
        private SchoolDbContext context;
        private bool isDisposed;
        private bool toSaveAllChanges;
        private static IRepository<Student> studentRepository;

        public static IRepository<Student> StudentRepository
        {
            get
            {
                if (studentRepository == null)
                {
                    studentRepository = RepositoryFactory.Create<Student, EFRepository<Student>>(Context);
                }

                return studentRepository;
            }
        }


        public bool ToSaveAllChanges
        {
            get { return this.toSaveAllChanges; }
            set { this.toSaveAllChanges = value; }
        }

        public static SchoolDbContext Context
        {
            get { return currScope != null ? currScope.context : null; }
        }

        public UnitOfWorkScope()
            : this(false)
        {
        }

        public UnitOfWorkScope(bool toSaveAllChanges)
        {
            if ((currScope != null) && (!currScope.isDisposed))
            {
                throw new InvalidOperationException(String.Format("Nestig of contexts is not allowed!"));
            }

            this.toSaveAllChanges = toSaveAllChanges;
            this.context = new SchoolDbContext();
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
                    this.context.SaveChanges();
                }
                this.context.Dispose();
                this.isDisposed = true;
            }
        }
    }
}
