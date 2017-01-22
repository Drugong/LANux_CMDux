using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consolev2.Models;
using Consolev2;

namespace LANux_CMDux.Repository
{
    public class UserRepository
    {
        private MyContext _context = new MyContext();

        public List<User> FindAll()
        {
            return this._context.Users.ToList<User>();
        }

        public User FindById(int id)
        {
            return this._context.Users.Find(id);
        }

        public void Create(User p)
        {
            this._context.Users.Add(p);
            this._context.SaveChanges();
        }

        public void Update(User p)
        {
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(User p)
        {
            this._context.Users.Remove(p);
            this._context.SaveChanges();
        }
    }
}
