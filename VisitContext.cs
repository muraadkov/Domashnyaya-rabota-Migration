namespace MigrationDZ_18._04._2019
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VisitContext : DbContext
    {
        // Контекст настроен для использования строки подключения "VisitContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "MigrationDZ_18._04._2019.VisitContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "VisitContext" 
        // в файле конфигурации приложения.
        public VisitContext()
            : base("name=VisitContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Visit> Visits { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}