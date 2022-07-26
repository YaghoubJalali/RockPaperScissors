using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RockPaperScissorsService.Contracts;
using RockPaperScissorsService.Model;

namespace RockPaperScissorsService
{
    public abstract class Hand
    {        
        private List<HandDispatcher> _dispatchers;

        public Hand()
        {
            _dispatchers = new List<HandDispatcher>();
        }

        public void AddDispatcher(Hand hand, Func<GameResult> action)
        {
            this._dispatchers.Add(new HandDispatcher(hand, action));
        }

        public IReadOnlyCollection<HandDispatcher> GetDispatchers()
        {
            return _dispatchers.AsReadOnly();
        }

        private GameResult Dispatch(Hand hand)
        {
            if (this.GetType().IsAssignableFrom(hand.GetType()))
                return GameResult.Equal;

            var dispatchers = _dispatchers.FirstOrDefault(o => o.GetHand().GetType().IsAssignableFrom(hand.GetType()));
            if (dispatchers != null)
                return dispatchers.PlayAction();

            return GameResult.Loser;
        }


        public GameResult PlayAgainst(Hand hand)
        {
            return Dispatch(hand);
        }
    }
}
