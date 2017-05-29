using Common.Readers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebService.Controllers
{
    /// <summary>
    /// Controller for manipulate readers in database.
    /// </summary>
    public class ReadersController : AbstractController<Reader>
    {
        public ReadersController() : base()
        {
            dbAll.Readers.Load();
            this.source.DataSource = this.dbAll.Readers.Local.ToBindingList();
        }

        public override List<Reader> GetList()
        {
            this.dbAll.Readers.Load();
            return this.dbAll.Readers.Local.ToList();
        }

        public override void Insert(Reader obj)
        {
            this.dbAll.Readers.Add(obj);
            this.dbAll.SaveChanges();
        }

        public override void Update(Reader obj)
        {
            Reader dep = this.dbAll.Readers.Find(obj.Id);
            if (dep != null)
            {
                dep = obj;
                this.dbAll.SaveChanges();

                foreach (var entity in dbAll.ChangeTracker.Entries().Where(x => x.Entity == dep))
                {
                    entity.Reload();
                }

            }
        }
    }
}