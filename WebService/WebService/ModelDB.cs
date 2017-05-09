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
        /// <summary>
        /// ModelDB();
        /// </summary>
        public ModelDB()
            : base("name=ModelDB")
        {
            Database.SetInitializer(new StructureContextInitializer());
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
        /// <summary>
        /// Table for BookTypes.
        /// </summary>
        public virtual DbSet<BookType> BookTypes { get; set; }
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

            context.BookTypes.AddRange(new List<BookType>()
            {
                new BookType{ BTypeName = "Fantasy"},
                new BookType{ BTypeName = "Science Fiction"},
                new BookType{ BTypeName = "Cookbook"},
                new BookType{ BTypeName = "Tecnical literarure"},
            });

            context.SaveChanges();

            context.Logins.AddRange(new List<LoginData>()
            {
                new LoginData{ Login = "root", Password = "1111", Id = 1},
                new LoginData{ Login = "user", Password = "2222", Id = 2},
                new LoginData{ Login = "press", Password = "2222", Id = 1},
                new LoginData{ Login = "user1", Password = "1111", Id = 2},
            });

            context.SaveChanges();

            context.NewBooks.AddRange(new List<NewBook>()
            {
                new NewBook{ Name = "Gulliver's Travels", AuthorName = "Jonathan Swift", ModernDesign = "Digital printing", ModernMaterial = "Paper", Price = 1000m, Year =1726, BookType = context.BookTypes.Where(x => x.Id == 1).FirstOrDefault()},
                new NewBook{ Name = "Frankenstein or Modern Prometheus", AuthorName = "Mary Shelley", ModernDesign = "Digital printing", ModernMaterial = "Paper", Year =1818, Price = 1200m, BookType = context.BookTypes.Where(x => x.Id == 1).FirstOrDefault()},
                new NewBook{ Name = "Alice in Wonderland", AuthorName = "Lewis Carroll", ModernDesign = "Audiobook", ModernMaterial = "Audio File", Price = 134000m, Year =1865, BookType = context.BookTypes.Where(x => x.Id == 1).FirstOrDefault()},
                new NewBook{ Name = "I'm a robot", AuthorName = "Isaac Asimov", ModernDesign = "Audiobook", ModernMaterial = "Audio File", Price = 9000m, Year =1950, BookType = context.BookTypes.Where(x => x.Id == 2).FirstOrDefault()},
                new NewBook{ Name = "Sirens of Titan", AuthorName = "Kurt Vonnegut", ModernDesign = "Audiobook", ModernMaterial = "Audio File", Price = 4500m, Year =1959, BookType = context.BookTypes.Where(x => x.Id == 2).FirstOrDefault()},
                new NewBook{ Name = "Contact", AuthorName = "Carl Sagan", ModernDesign = "Digital printing", ModernMaterial = "Paper", Price = 100m, Year =1985, BookType = context.BookTypes.Where(x => x.Id == 2).FirstOrDefault()},
                new NewBook{ Name = "Rules and subtleties of cuisine", AuthorName = "William Pohlebkin", ModernDesign = "Digital printing", ModernMaterial = "Paper", Price = 220m, Year =1938, BookType = context.BookTypes.Where(x => x.Id == 3).FirstOrDefault()},
                new NewBook{ Name = "Java philosophy. 4th full edition", AuthorName = "Eckel B.", ModernDesign = "EBook", ModernMaterial = "Document File", Price = 400m, Year =2006, BookType = context.BookTypes.Where(x => x.Id == 4).FirstOrDefault()},
                new NewBook{ Name = "Linux server with own hands", AuthorName = "Denis Kolisnichenko", ModernDesign = "EBook", ModernMaterial = "Document File", Price = 700m, Year =2009, BookType = context.BookTypes.Where(x => x.Id == 4).FirstOrDefault()},
                new NewBook{ Name = "Brief history of time", AuthorName = "Stephen Hawking", ModernDesign = "Digital printing", ModernMaterial = "Paper", Price = 330m, Year =1988, BookType = context.BookTypes.Where(x => x.Id == 4).FirstOrDefault()},
            });

            context.SaveChanges();

            context.OldBooks.AddRange(new List<OldBook>()
            {
                new OldBook{ Name = "Sinaitic Bible Code", AuthorName = "N/A", OldDesign = "Code", OldMaterial = "Parchment", Price = 1000000m, Year = 1},
                new OldBook{ Name = " Vergilius Augusteus", AuthorName = "N/A", OldDesign = "The Scroll", OldMaterial = "Papyrus", Price = 1900000m, Year = 300},
                new OldBook{ Name = "The Bibles of Mazarin", AuthorName = "Johann Gutenberg", OldDesign = "Gutenberg", OldMaterial = "Paper", Price = 18900000m, Year = 1453},
                new OldBook{ Name = "Prayer of the parishioner", AuthorName = "John Baskerville", OldDesign = "Gutenberg", OldMaterial = "Paper", Price = 9000m, Year = 1762},
                new OldBook{ Name = "Paradise Lost", AuthorName = "John Milton", OldDesign = "Dialing form", OldMaterial = "Paper", Price = 3000000m, Year = 1657},
            });

            context.SaveChanges();

            context.Readers.AddRange(new List<Reader>()
            {
                new Reader{ Name = "Alex", SecoundName = "White", Sex = "male", Day = DateTime.Today.Day, Mounth = DateTime.Today.Month, Year = DateTime.Today.Year},
                new Reader{ Name = "Sam", SecoundName = "Black", Sex = "male", Day = DateTime.Today.Day, Mounth = DateTime.Today.Month, Year = DateTime.Today.Year},
                new Reader{ Name = "Smith", SecoundName = "Richards", Sex = "male", Day = DateTime.Today.Day, Mounth = DateTime.Today.Month, Year = DateTime.Today.Year},
                new Reader{ Name = "Anna", SecoundName = "Popko", Sex = "female", Day = DateTime.Today.Day, Mounth = DateTime.Today.Month, Year = DateTime.Today.Year},
            });

            context.SaveChanges();

            context.Workers.AddRange(new List<Worker>()
            {
                new Worker{Name = "Александр В", Age = 26, Salary = 45000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 1).FirstOrDefault()},
                new Worker{Name = "Игорь Б", Age = 31, Salary = 47000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Worker{Name = "Сергей К", Age = 28, Salary = 31000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Worker{Name = "Иван П", Age = 23, Salary = 35000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Worker{Name = "Алексей Д", Age = 31, Salary = 35000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Worker{Name = "Светлана И", Age = 26, Salary = 65000m, Sex = "female", DepartmentID = context.Departments.Where(x => x.Id == 1).FirstOrDefault()},
                new Worker{Name = "Инна К", Age = 24, Salary = 50000m, Sex = "female", DepartmentID = context.Departments.Where(x => x.Id == 4).FirstOrDefault()},
                new Worker{Name = "Антон Ж", Age = 29, Salary = 45000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Worker{Name = "Степан С", Age = 28, Salary = 43000m, Sex = "male", DepartmentID = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Worker{Name = "Кристина У", Age = 23, Salary = 32000m, Sex = "female", DepartmentID = context.Departments.Where(x => x.Id == 4).FirstOrDefault()},
            });

            context.SaveChanges();
        }
    }
}