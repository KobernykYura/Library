using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace WebService.Controllers
{
    /// <summary>
    /// Abstract controller for database tables.
    /// </summary>
    abstract public class AbstractController<T>
    {
        /// <summary>
        /// Access to data base.
        /// </summary>
        protected ModelDB dbAll;
        /// <summary>
        /// Create binding sours.
        /// </summary>
        protected BindingSource source;

        /// <summary>
        /// Abstarct constructor.
        /// </summary>
        public AbstractController()
        {
            this.dbAll = new ModelDB();
            this.source = new BindingSource();
        }
        /// <summary>
        /// Binding source.
        /// </summary>
        /// <returns></returns>
        public BindingSource GetSource()
        {
            return this.source;
        }
        /// <summary>
        /// Get list of data method.
        /// </summary>
        /// <returns></returns>
        abstract public List<T> GetList();
        /// <summary>
        /// Insert.
        /// </summary>
        /// <param name="obj"></param>
        abstract public void Insert(T obj);
        /// <summary>
        /// Update.
        /// </summary>
        /// <param name="obj"></param>
        abstract public void Update(T obj);
        /// <summary>
        /// Update source.
        /// </summary>
        virtual public void UpdateSource()
        {
            return;
        }
    }
}