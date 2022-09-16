using System.Collections.Generic;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.Business.Abstract
{
    public interface ICardService
    {
         void Add(Card card);
         void Delete(Card card);
         void Update(Card card);
         void Move(Card card);
    }
}