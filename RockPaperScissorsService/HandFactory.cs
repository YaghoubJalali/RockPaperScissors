using RockPaperScissorsService.Contracts;
using RockPaperScissorsService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsService
{
    public class HandFactory: IHandFactory
    {
        public virtual Hand CreateRockHand()
        {
            Rock rock = new();
            rock.AddDispatcher(new Scissors(), () => { return GameResult.Winner; });
            rock.AddDispatcher(new Paper(), () => { return GameResult.Loser; });
            return rock;
        }

        public virtual Hand CreatePaperHand()
        {
            Paper paper = new();
            paper.AddDispatcher(new Rock(), () => { return GameResult.Winner; });
            paper.AddDispatcher(new Scissors(), () => { return GameResult.Loser; });
            return paper;
        }

        public virtual Hand CreateScissorsHand()
        {
            Scissors scissors = new();
            scissors.AddDispatcher(new Paper(), () => { return GameResult.Winner; });
            scissors.AddDispatcher(new Rock(), () => { return GameResult.Loser; });
            return scissors;
        }
    }
}
