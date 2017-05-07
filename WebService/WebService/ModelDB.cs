namespace WebService
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Common.Books;
    using Common.Readers;
    using Common.Workers;
    using Common.LoginData;
    using System.Collections.Generic;

    /// <summary>
    /// Model of Data base from code.
    /// </summary>
    public class ModelDB : DbContext
    {
        // Контекст настроен для использования строки подключения "ModelDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebService.ModelDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ModelDB" 
        // в файле конфигурации приложения.
        /// <summary>
        /// ModelDB();
        /// </summary>
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        /// <summary>
        /// Table for new books.
        /// </summary>
        public virtual DbSet<NewBook> NewBooks { get; set; }
        /// <summary>
        /// Table for old books.
        /// </summary>
        public virtual DbSet<OldBook> OldBooks { get; set; }
        /// <summary>
        /// Table for readers.
        /// </summary>
        public virtual DbSet<Reader> Readers { get; set; }
        /// <summary>
        /// Table for Workers.
        /// </summary>
        public virtual DbSet<Worker> Workers { get; set; }
        /// <summary>
        /// Table for Departments.
        /// </summary>
        public virtual DbSet<Department> Departments { get; set; }
        /// <summary>
        /// Table for Logins.
        /// </summary>
        public virtual DbSet<LoginData> Logins { get; set; }
    }
    class StructureContextInitializer : DropCreateDatabaseIfModelChanges<ModelDB>
    {
        protected override void Seed(ModelDB context)
        {

            context.Departments.AddRange(new List<Department>()
            {
                new Department{ Name = "Отдел IT"},
                new Department{ Name = "Отдел продаж"},
                new Department{ Name = "Отдел рекламы"},
                new Department{ Name = "Канцелярия"},
            });

            context.SaveChanges();

            context.Workers.AddRange(new List<Worker>()
            {
                new Worker{Name = "Александр В", Age = 26, Salary = 45000m, DepartmentID = context.Departments.Where(x => x.Id == 1).FirstOrDefault()},
                new Worker{Name = "Игорь Б", Age = 31, Salary = 47000m, DepartmentID = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Worker{Name = "Сергей К", Age = 28, Salary = 31000m, DepartmentID = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Worker{Name = "Иван П", Age = 23, Salary = 35000m, DepartmentID = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Worker{Name = "Алексей Д", Age = 31, Salary = 35000m, DepartmentID = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Worker{Name = "Светлана И", Age = 26, Salary = 65000m, DepartmentID = context.Departments.Where(x => x.Id == 1).FirstOrDefault()},
                new Worker{Name = "Инна К", Age = 24, Salary = 50000m, DepartmentID = context.Departments.Where(x => x.Id == 4).FirstOrDefault()},
                new Worker{Name = "Антон Ж", Age = 29, Salary = 45000m, DepartmentID = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Worker{Name = "Степан С", Age = 28, Salary = 43000m, DepartmentID = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Worker{Name = "Кристина У", Age = 23, Salary = 32000m, DepartmentID = context.Departments.Where(x => x.Id == 4).FirstOrDefault()},
            });

            context.SaveChanges();
        }
    }
}