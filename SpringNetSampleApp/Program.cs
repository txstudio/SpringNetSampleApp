using Spring.Context;
using Spring.Context.Support;
using System;

namespace SpringNetSampleApp
{
    class Program
    {
        const string springObjectName = "InjectDateTime";

        static void Main(string[] args)
        {
            IApplicationContext _context;
            IDateTime _dateTime;

            _context = ContextRegistry.GetContext();
            _dateTime = _context[springObjectName] as IDateTime;

            Console.WriteLine("{0:yyyy-MM-dd HH:mm:ss}", _dateTime.Now());

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }

    public interface IDateTime
    {
        DateTime Now();
    }

    public class LocalDateTime : IDateTime
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }

    public class UtcDateTime : IDateTime
    {
        public DateTime Now()
        {
            return DateTime.UtcNow;
        }
    }

    public class BirthDateTime : IDateTime
    {
        public DateTime Now()
        {
            return Convert.ToDateTime("1988/01/18");
        }
    }
}
