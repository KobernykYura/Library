namespace WebService.Data
{ 
    using System;
    using System.Data.Entity;
    using System.Linq;
    
    public class DataBase : DbContext
    {
        // Контекст настроен для использования строки подключения "DataBase" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebЫукмшсу.Data.DataBase" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataBase" 
        // в файле конфигурации приложения.
        public DataBase()
            : base("name=DataBase")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}