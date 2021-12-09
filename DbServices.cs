using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Application_with_Database
{
    public static class DbServices
    {
        public static List<Card> GetAllCards()
        {
            using (var context = new BoardContext())
            {
                return context.Board.ToList();
            }
        }
        public static void UpdateCardColumn(string cardName ,string columnToMoveCardTo)
        {
            using (var context = new BoardContext())
            {
                Card cardTobeUpdated = context.Board.Where(card => card.CardName == cardName).FirstOrDefault();
                if (cardTobeUpdated != null)
                {
                    cardTobeUpdated.BoardColumn = columnToMoveCardTo;
                    context.Board.Update(cardTobeUpdated);
                    context.SaveChanges();
                }
            }
        }
        public static Card GetCard(string cardName)
        {
            using (var context = new BoardContext())
            {
                var firstCardFound = context.Board.Where(card => card.CardName == cardName).FirstOrDefault();
                return firstCardFound;
            }
        }
        public static void RemoveCard(string cardName)
        {
            using (var context = new BoardContext())
            {
                var firstCardFound = context.Board.Where(card => card.CardName == cardName).FirstOrDefault();
                context.Remove(firstCardFound);
                context.SaveChanges();
            }
        }
        public static void AddCard(Card card)
        {
            using (var context = new BoardContext())
            {
                context.Add(card);
                context.SaveChanges();
            }
        }

        internal static List<Card> GetAllCardsDONE()
        {
            using (var context = new BoardContext())
            {
                return context.Board.Where(card=>card.BoardColumn=="DONE").ToList();
            }
        }

        internal static List<Card> GetAllCardsINPROGRESS()
        {
            using (var context = new BoardContext())
            {
                return context.Board.Where(card => card.BoardColumn == "IN PROGRESS").ToList();
            }
        }

        internal static List<Card> GetAllCardsTODO()
        {
            using (var context = new BoardContext())
            {
                return context.Board.Where(card => card.BoardColumn == "TODO").ToList();
            }
        }
    }
}