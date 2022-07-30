using RockPaperScissorsService.Contracts;
using RockPaperScissorsService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsService
{
    public class ExtendedHandFactory : HandFactory, IExtendedHandFactory
    {
        public Hand CreateRockAndROllHand()
        {
            RockAndRole rockAndRole = new();
            rockAndRole.AddDispatcher(base.CreateRockHand(), () => { return GameResult.Loser; });
            rockAndRole.AddDispatcher(base.CreatePaperHand(), () => { return GameResult.Winner; });
            rockAndRole.AddDispatcher(base.CreateScissorsHand(), () => { return GameResult.Winner; });
            return rockAndRole;
        }

        public override Hand CreateRockHand()
        {
            Hand rockHand = base.CreateRockHand();
            rockHand.AddDispatcher(new RockAndRole(), () => { return GameResult.Winner; });
            return rockHand;
        }

    }
}
