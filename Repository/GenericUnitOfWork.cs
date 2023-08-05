using New_OnlineTaxibooking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New_OnlineTaxibooking.Repository
{
    public class GenericUnitOfWork : IDisposable
    {
        private DB_MyonlinetaxinewoneEntities DBEntity = new DB_MyonlinetaxinewoneEntities();
        public Repository<tbl_EntityType> GetRepositoryInstance<tbl_EntityType>() where tbl_EntityType : class
        {
            return new GenericRepository<tbl_EntityType>(DBEntity); 
        }
        public void SaveChanges()
        {
            DBEntity.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed) 
            {
                if (disposing)
                {
                    DBEntity.Dispose();
                }
              
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed=false;
    }
}