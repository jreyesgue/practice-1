namespace Practice1.Bank
{
    public class ATM
    {
        private double balance;

        public ATM(double balance)
        {
            this.balance = balance;
        }

        public void Start()
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (GetOption())
                {
                    case 1:
                        Console.WriteLine("\nYour total balance is: " + balance);
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("\nReturning to the main menu...\n");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.");
                        break;
                }
            } while (!finish);
        }

        private static int GetOption()
        {
            Console.Write("\nSelect an option: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- ATM Menu ---\n");
            Console.WriteLine("1. Check balance.");
            Console.WriteLine("2. Deposit money.");
            Console.WriteLine("3. Withdraw money.");
            Console.WriteLine("4. Exit.");
        }

        private void DepositMoney()
        {
            Console.Write("\nHow much would you like to deposit? ");
            balance += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nYour new balance is: " + balance);
        }

        private void WithdrawMoney()
        {
            Console.Write("\nHow much would you like to withdraw? ");
            double quantity = Convert.ToDouble(Console.ReadLine());

            if (quantity <= balance)
            {
                balance -= quantity;
                Console.WriteLine("\nYour new balance is: " + balance);
            }
            else
            {
                Console.WriteLine("\nError: Your don't have enough money");
            }
        }
    }
}
