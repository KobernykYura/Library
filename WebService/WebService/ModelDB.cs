namespace WebService
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Common.Books;
    using Common.Readers;
    using Common.Workers;

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
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

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
        public virtual DbSet<> Workers { get; set; }


    }
}