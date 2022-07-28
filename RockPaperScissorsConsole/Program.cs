// See https://aka.ms/new-console-template for more information

using RockPaperScissorsService;
using RockPaperScissorsService.Contracts;

IHandFactory handFactory = new HandFactory();
Hand rock = handFactory.CreateRockHand();
Hand scissors = handFactory.CreateScissorsHand();
Hand paper = handFactory.CreatePaperHand();

Console.WriteLine($"Rock VS Rock: {rock.PlayAgainst(rock)}");
Console.WriteLine($"Rock VS Paper: {rock.PlayAgainst(paper)}");
Console.WriteLine($"Rock VS Scissors: {rock.PlayAgainst(scissors)}");


IExtendedHandFactory extendedHand = new ExtendedHandFactory();
Hand rockAndRoleHand = extendedHand.CreateRockAndROllHand();
Hand extendedRock = extendedHand.CreateRockHand();
Hand extendedScissors = extendedHand.CreateScissorsHand();

Console.WriteLine($"RockAndRole VS ExtendedRock: {rockAndRoleHand.PlayAgainst(extendedRock)}");
Console.WriteLine($"ExtendedRock VS RockAndRole: {extendedRock.PlayAgainst(rockAndRoleHand)}");
Console.WriteLine($"RockAndRole VS ExtendedSissors: {extendedRock.PlayAgainst(extendedScissors)}");
Console.WriteLine($"RockAndRole VS Sissors: {extendedRock.PlayAgainst(scissors)}");

Console.ReadKey();

