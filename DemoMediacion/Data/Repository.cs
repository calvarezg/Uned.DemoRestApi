using DemoMediacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMediacion.Data
{
    public class Repository
    {
        ApplicationDatabaseContext db;

        public Repository(ApplicationDatabaseContext db)
        {
            this.db = db;
        }

        public IEnumerable<Guitar> GetAll()
        {
            return db.Guitars.ToList();
        }

        public void Add(Guitar guitar)
        {
            db.Guitars.Add(guitar);
            db.SaveChanges();
        }

        public Guitar Find(int id)
        {
            return db.Guitars.Find(id);
        }

        public void Update(Guitar guitar)
        {
            db.Guitars.Update(guitar);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var guitar = Find(id);
            db.Remove(guitar);
            db.SaveChanges();
        }
    }
}
