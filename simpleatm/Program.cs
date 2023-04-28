/*
Simple Program that allows the user to make transactions at an ATM
*/

class Program
{
    static void Main()
    {
        int balance = 1000;

        Console.WriteLine("Welcome to Pretender's Credit Union!");
        Console.WriteLine("Your current balance is {0}", balance);

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Check balance");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the desired amount to withdraw: ");
                    int withdrawAmount = int.Parse(Console.ReadLine());

                    if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient funds!");
                    }
                    else{
                        balance -= withdrawAmount;
                        Console.WriteLine("New balance: {0}", balance);
                    }
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: ");
                    int depositAmount = int.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine("New balance: {0}", balance);
                    break;

                case 3:
                    Console.WriteLine("Current balance: {0}", balance);
                    break;

                case 4:
                    Console.WriteLine("Thank you for choosing Pretender's Credit Union!");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;

            }

            Console.WriteLine();
        }
    }
}
