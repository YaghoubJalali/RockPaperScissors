using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsService.Model
{
    public class HandDispatcher
    {
        private readonly Hand _hand;
        readonly Func<GameResult> _playAction;
        public HandDispatcher(Hand hand,Func<GameResult> playAction)
        {
            _hand = hand ?? throw new ArgumentNullException(nameof(hand));
            _playAction = playAction ?? throw new ArgumentNullException(nameof(playAction));
        }

        public Hand GetHand()
        {
            return this._hand;
        }

        public GameResult PlayAction()
        {
            return this._playAction();
        }
    }
}
