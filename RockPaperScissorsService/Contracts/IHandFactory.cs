using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsService.Contracts
{
    public interface IHandFactory
    {
        Hand CreateRockHand();
        Hand CreatePaperHand();
        Hand CreateScissorsHand();
    }
}
