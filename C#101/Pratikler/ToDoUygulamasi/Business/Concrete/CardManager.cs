using System.Collections.Generic;
using ToDoUygulamasi.Business.Abstract;
using ToDoUygulamasi.DataAccess.Abstract;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.Business.Concrete
{
    public class CardManager : ICardService
    {
        private ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public void Add(Card card)
        {
            _cardDal.Add(card);
        }

        public void Delete(Card card)
        {
            _cardDal.Delete(card);
        }
        public void Move(Card card)
        {
            _cardDal.Move(card);
        }

        public void Update(Card card)
        {
            _cardDal.Update(card);
        }
        public List<Card> GetToDoList()
        {
            return _cardDal.GetToDoList();
        }
        public List<Card> GetInProgressList()
        {
            return _cardDal.GetInProgressList();
        }
        public List<Card> GetDoneList()
        {
            return _cardDal.GetDoneList();
        }
    }
}