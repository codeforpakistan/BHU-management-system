using MaternityCareSystem.Domain;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace MaternityCareSystem.Models
{
    public class VirtualCrud<T> : IDisposable where T : new()
    {
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        protected HmsContext db = new HmsContext();
        public virtual List<T> SelectAll(out OutParamModel outparam)
        {
            var toReturn = new List<T>();
            outparam = new OutParamModel();
            return toReturn;
        }
        public virtual T SelectByID(int ID, out OutParamModel outparam)
        {
            var obj = new T();
            outparam = new OutParamModel();
            return obj;
        }
        public virtual T SelectByID(string ID, out OutParamModel outparam)
        {
            var obj = new T();
            outparam = new OutParamModel();
            return obj;
        }
        public virtual T Save(T entity, out OutParamModel outparam) 
        { 
            var obj = new T(); 
            outparam = new OutParamModel();
            return obj;
        }
        //public virtual T Save(T entity)
        //{
        //    var obj = new T();
        //    return obj;
        //}
        public virtual T Update(T entity, out OutParamModel outparam) 
        { 
            var obj = new T(); 
            outparam = new OutParamModel(); 
            return obj; 
        }
        public virtual T Delete(int ID, out OutParamModel outparam) 
        { 
            var obj = new T(); 
            outparam = new OutParamModel();
            return obj; 
        }
     
        //-- Database connection 
        public void OpenConnection()
        {
            var Connection = db.Database.Connection;
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
            //return Connection;
        }
        public void CloseConnection()
        {
            var Connection = db.Database.Connection;
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
            //return Connection;
        }
        public DbConnection GetDbConnection
        {
            get
            {
                return db.Database.Connection;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                handle.Dispose();
            }
            disposed = true;
        }

    }
}