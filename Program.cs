using System;
using System.Collections.Generic;

Random randomizer = new Random();
List<string> responseList = new List<string>();

Console.WriteLine("Welcome to the Enthusiastic Magic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
IntializeList();
AskMoose();


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

void IntializeList() {
    responseList.Add("As I see it, yes.");
    responseList.Add("Ask again later.");
    responseList.Add("Better not tell you now.");
    responseList.Add("Cannot predict now.");
    responseList.Add("Concentrate and ask again.");
    responseList.Add("Don't count on it.");
    responseList.Add("It is certain.");
    responseList.Add("It is decidedly so.");
    responseList.Add("Most likely.");
    responseList.Add("My reply is no.");
    responseList.Add("My sources say no.");
    responseList.Add("Outlook not so good.");
    responseList.Add("Outlook good.");
    responseList.Add("Reply hazy, try again.");
    responseList.Add("Signs point to yes.");
    responseList.Add("Very doubtful.");
    responseList.Add("Without a doubt.");
    responseList.Add("Yes.");
    responseList.Add("Yes-definitely.");
    responseList.Add("You may rely on it.");
}

void AskMoose() {
    MooseSays("Ask me anything, I know all.");
    string question = Console.ReadLine();
    while (question != "") {
        int randomNumber = randomizer.Next(20);
        MooseSays(responseList[randomNumber]);
        Console.WriteLine("Ask me another. I know all.");
        question = Console.ReadLine();
    }
}