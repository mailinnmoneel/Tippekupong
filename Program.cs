using System;

namespace Tippekupong
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowBetInfo();

            var bet = Console.ReadLine();
            Match match = new Match(bet); 

            while (match.IsRunning)
            {
                ShowCommands();
                string command = Console.ReadLine();
                if (command == "X") match.Stop();
                else if (command == "H" || command == "B") match.AddGoal(command == "H");
                Console.WriteLine($"Stillingen er {match.GetScore()}.");
            }
          

            var isBetCorrectText = match.IsBetCorrect() ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }

        private static void ShowCommands()
        {
            Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
        }

        private static void ShowBetInfo()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
        }
    }
}
