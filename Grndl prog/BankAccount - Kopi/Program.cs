namespace BankAccount
{
    internal class Program
    {
        static void Main()
        {
            ConsoleKeyInfo esc;
            BankAccount bankAccount = new();
            do
            {
                Console.WriteLine($"Balance:{bankAccount.GetBalance()} kr\n");
                Console.WriteLine("You now have 3 choices:\n 1 for Withdraw.\n 2 for Deposit.\n 3 to check your balance.");
                Console.Write("Type here: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.Write("How much money do you want to Withdraw? ");
                            bankAccount.WithDraw(double.Parse(Console.ReadLine()));
                        }
                        break;
                    case 2:
                        {
                            Console.Write("How much money do you want to Deposit? ");
                            bankAccount.Deposit(double.Parse(Console.ReadLine()));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine($"Your balance is: {bankAccount.GetBalance()} kr");
                        }
                        break;

                    default:
                        { Console.WriteLine("Incorrect value..."); }
                        break;
                }

                Console.WriteLine("tryk esc for at lukke Programmet");
                esc = Console.ReadKey();
            } while (esc.Key != ConsoleKey.Escape);
        }
    }
}