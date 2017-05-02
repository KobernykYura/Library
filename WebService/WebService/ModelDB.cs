namespace WebService
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Common.Books;
    using Common.Readers;

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

        public virtual DbSet<NewBook> NewBooks { get; set; }
        public virtual DbSet<OldBook> OldBooks { get; set; }

        public virtual DbSet<Reader> Readers { get; set; }

        public virtual DbSet<> OldBooks { get; set; }


    }
}