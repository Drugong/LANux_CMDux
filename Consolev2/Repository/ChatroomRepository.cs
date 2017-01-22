using Consolev2;
using Consolev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANux_CMDux.Repository
{
    public class ChatroomRepository
    {

        private MyContext _context = new MyContext();

        public List<Chatroom> FindAll()
        {
            return this._context.Chatrooms.ToList<Chatroom>();
        }

        public Chatroom FindById(int id)
        {
            return this._context.Chatrooms.Find(id);
        }

        public void Create(Chatroom p)
        {
            this._context.Chatrooms.Add(p);
            this._context.SaveChanges();
        }

        public void Update(Chatroom p)
        {
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Chatroom p)
        {
            this._context.Chatrooms.Remove(p);
            this._context.SaveChanges();
        }

    }
}
