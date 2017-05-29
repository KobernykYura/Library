using Common.Workers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WebService.Controllers
{
    /// <summary>
    /// Controller for manipulate workers in data base.
    /// </summary>
    public class WorkersController : AbstractController<Worker>
    {
        public WorkersController() : base()
        {
            dbAll.Workers.Load();
            this.source.DataSource = this.dbAll.Workers.Local.ToBindingList();
        }

        public override List<Worker> GetList()
        {
            this.dbAll.Workers.Load();
            return this.dbAll.Workers.Local.ToList();
        }

        public override void Insert(Worker obj)
        {
            this.dbAll.Workers.Add(obj);
            this.dbAll.SaveChanges();
        }

        public override void Update(Worker obj)
        {
            Worker dep = this.dbAll.Workers.Find(obj.Id);
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