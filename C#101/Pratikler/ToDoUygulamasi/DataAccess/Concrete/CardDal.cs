using System.Collections.Generic;
using ToDoUygulamasi.DataAccess.Abstract;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.DataAccess.Concrete
{
    public class CardDal : ICardDal
    {
       
        public void Add(Card card)
        {
            Board.ToDoList.Add(card);
        }

        public void Delete(Card card)
        {
            var silinecekCard = Board.ToDoList.Find(x => x.Id == card.Id);
            Board.ToDoList.Remove(silinecekCard);
        }

        public List<Card> Get(string baslik)
        {
            return Board.ToDoList;
        }
        public void Move(Card card)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Card card)
        {
            var guncellenecekCard = Board.ToDoList.Find(x => x.Id == card.Id);
            guncellenecekCard.Baslik = card.Baslik;
            guncellenecekCard.Buyukluk = card.Buyukluk;
            guncellenecekCard.AtananKisiId = card.AtananKisiId;
            guncellenecekCard.Icerik = card.Icerik;
        }
        public List<Card> GetToDoList()
        {
            return Board.ToDoList;
        }
        public List<Card> GetInProgressList()
        {
            return Board.InProgressList;
        }
        public List<Card> GetDoneList()
        {
            return Board.DoneList;
        }
    }
}