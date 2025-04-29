using System.Linq;
using angular_tutorials_backend.Data;
using angular_tutorials_backend.Models;

namespace angular_tutorials_backend.Services
{
    public class PersonRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public Person? GetById(int id)
        {
            return _context.Persons.Find(id);
        }

        public void Add(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        public void Update(Person person)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var person = GetById(id);
            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }
        }
    }
}