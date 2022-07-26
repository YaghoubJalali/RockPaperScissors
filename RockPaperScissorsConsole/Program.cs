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


Console.ReadKey();

