using System.Collections.Generic;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.DataAccess.Abstract
{
    public interface ICardDal
    {
         void Add(Card card);
         void Delete(Card card);
         void Update(Card card);
         void Move(Card card);
         List<Card> GetToDoList();
         List<Card> GetInProgressList();
         List<Card> GetDoneList();
    }
}