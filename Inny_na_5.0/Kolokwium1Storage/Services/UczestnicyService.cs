using Kolokwium1Storage.Dtos;
using Kolokwium1Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1Storage.Services
{
    public class UczestnicyService : IUczestnicyService
    {
        private readonly StorageDbContext _context;
        public UczestnicyService(StorageDbContext context)
        {
            _context = context;
            DbInitializer.Initialize(context);
        }

        public void Create(UczestnicyDto dto)
        {
            var uczestnikEntity = new Uczestnicy() { Id = dto.Id, Email = dto.Email, Imie = dto.Imie, Nazwisko=dto.Nazwisko, KonkursId = dto.KonkursId };
            _context.Set<Uczestnicy>().Add(uczestnikEntity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Console.WriteLine(id);
            var uczestnik = _context.Uczestnicy.FirstOrDefault(uczestnik => uczestnik.Id == id);
            if (uczestnik != null)
            {
                _context.Uczestnicy.Remove(uczestnik);
                _context.SaveChanges();
            }
        }
        public List<UczestnicyDto> Read()
        {
            var uczestnicy = _context.Uczestnicy.Select(uczestnik => new UczestnicyDto
            {
                Id = uczestnik.Id,
                Imie = uczestnik.Imie,
                Nazwisko = uczestnik.Nazwisko,
                KonkursNazwa = uczestnik.Konkurs.Nazwa,
                Email = uczestnik.Email,
            }).ToList();
            return uczestnicy;
        }

        public List<Konkursy> ReadKonkursy()
        {
            return _context.Konkursy.ToList();
        }

        public void Update(UczestnicyDto dto)
        {
            var uczestnik = _context.Uczestnicy.FirstOrDefault(uczestnik => uczestnik.Id == dto.Id);
            if (uczestnik != null)
            {
                uczestnik.Imie= dto.Imie;
                uczestnik.Nazwisko= dto.Nazwisko;
                uczestnik.KonkursId= dto.KonkursId;
                uczestnik.Email = dto.Email;
            }
            _context.Set<Uczestnicy>().Update(uczestnik);
            _context.SaveChanges();
        }
    }
}
