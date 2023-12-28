
class Miniräknare
{
    static void Main(string[] args)
    {
        // En lista för att spara historik för räkningar
        List<string> historik = new List<string>();

        do
        {
            // Välkomnande meddelande
            Console.WriteLine("Välkommen till min miniräknare!");
            Console.WriteLine("------------------------------");

            // Användaren matar in tal och matematiska operation
            Console.Write("Var god ange ett tal: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett giltigt tal.");
                continue; // Gå till nästa iteration av loopen
            }

            Console.Write("Vilken matematisk operator vill du använda? (+, -, *, /): ");
            char operatorSymbol = Console.ReadLine()[0];

            Console.Write("Var god ange ett till tal: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett giltigt tal.");
                continue; // Gå till nästa iteration av loopen
            }

            // OBS! Användaren måste mata in ett tal för att kunna ta sig vidare i programmet! 

            // Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
            if (operatorSymbol == '/' && num2 == 0)
            {
                Console.WriteLine("Ogiltig inmatning. Delning med 0 är ej tillåtet.");
                continue; // Gå till nästa iteration av loopen
            }

            // Utför beräkning
            double result = 0;

            switch (operatorSymbol)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2;
                    break;
            }

            // Lägga resultat till listan
            string calculation = $"{num1} {operatorSymbol} {num2} = {result}";
            historik.Add(calculation);

            // Visa resultat
            Console.WriteLine($"Ditt resultat blir: {calculation}");

            // Fråga användaren om den vill visa tidigare resultat
            Console.Write("Vill du se tidigare resultat? ja/nej: ");
            string visaHistorik = Console.ReadLine();

            if (visaHistorik == "ja")
            {
                // Visa tidigare resultat
                Console.WriteLine("\nBeräkningshistorik:");
                foreach (string savedCalculation in historik)
                {
                    Console.WriteLine(savedCalculation);
                }
            }

            // Fråga användaren om den vill avsluta eller fortsätta
            Console.Write("Vill du avsluta? ja/nej: ");
            string avslutaSvar = Console.ReadLine();

            if (avslutaSvar == "ja")
            {
                Console.WriteLine("Tack för att du har använt min miniräknare!");
                break; // Avsluta loopen om svaret är "ja"
            }
            else
            {
                Console.WriteLine("Då fortsätter vi!");
                Console.WriteLine("-----------------");
            }
        
        } while (true);
    }
}



