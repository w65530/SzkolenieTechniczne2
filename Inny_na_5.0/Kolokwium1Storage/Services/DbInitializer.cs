using Kolokwium1Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1Storage.Services
{
    public class DbInitializer
    {
        public static void Initialize(StorageDbContext context) { 
            if (!context.Konkursy.Any())
            {
                var konkurs1 = new Konkursy() { 
                    Id = 1,
                    Nazwa = "Matematyka"
                };
                var konkurs2 = new Konkursy()
                {
                    Id = 2,
                    Nazwa = "Programowanie"
                };
                context.Konkursy.AddRange(konkurs1, konkurs2);
                context.SaveChanges();
            }
            if (!context.Uczestnicy.Any())
            {
                var uczestnik1 = new Uczestnicy() { Id = 1, Imie = "John", Nazwisko = "Doe", Email = "jdoe@gmail.com", KonkursId = 2 };
                context.Uczestnicy.AddRange(uczestnik1);
                context.SaveChanges();
            }
        }
    }
}
