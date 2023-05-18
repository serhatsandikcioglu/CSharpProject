using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace ATM_App
{
    public class ATMActions
    {
        private Logger logger;
        string userName = string.Empty;
        string password = string.Empty;
        int input;
        User loggingUser;
        public ATMActions()
        {
            logger = new Logger("C:\\Users\\serhat\\Desktop");
        }
        public void Withdrawals()
        {
            Console.Write("Id: ");
            userName = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            loggingUser = FindLoggingUser(userName, password);
            if (loggingUser == null)
            {
                Console.WriteLine("Incorrect Username or Password");
            }
            else
            {
                Console.WriteLine("Enter the amount you want to withdraw");
                input = int.Parse(Console.ReadLine());
                if (loggingUser.Balance >= input)
                {
                    loggingUser.Balance = loggingUser.Balance - input;
                    Console.WriteLine($"New Balance: {loggingUser.Balance}");
                    logger.Log($"money was withdrawn by user {loggingUser.Name} ${input.ToString()}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }

            loggingUser = null;

        }
        public void Deposit()
        {
            Console.Write("Id: ");
            userName = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            loggingUser = FindLoggingUser(userName, password);
            if (loggingUser == null)
            {
                Console.WriteLine("User not found");
            }
            else
            {
                Console.WriteLine("Enter the amount you want to deposit");
                input = int.Parse(Console.ReadLine());
                loggingUser.Balance = loggingUser.Balance + input;
                Console.WriteLine($"New Balance: {loggingUser.Balance}");
                logger.Log($"Money was deposited by user {loggingUser.Name} ${input.ToString()}");
            }
            
            loggingUser = null;

        }
        public void Payment()
        {
            Console.Write("Id: ");
            userName = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            loggingUser = FindLoggingUser(userName, password);
            if (loggingUser == null)
            {
                Console.WriteLine("User not found");
            }
            else
            {
                Console.Write("Enter the id of the person you want to send money to: ");
                var receiverId = Console.ReadLine();
                Console.Write("Enter the name of the person you want to send money to: ");
                var receiverName = Console.ReadLine();
                Console.Write("Enter the surname of the person you want to send money to: ");
                var receiverSurName = Console.ReadLine();
                Console.Write("Enter the amount you want to sending");
                input = int.Parse(Console.ReadLine());
                if (loggingUser.Balance >= input)
                {
                    var receiverUser = FindUser(receiverId,receiverName,receiverSurName);
                    if (receiverUser == null)
                    {
                        Console.WriteLine("Receiver not found");
                    }
                    else
                    {
                        using (var scope = new TransactionScope())
                        {
                            try
                            {
                                loggingUser.Balance = loggingUser.Balance - input;
                                receiverUser.Balance = receiverUser.Balance + input;
                                Console.WriteLine($"New Balance: {loggingUser.Balance}");
                                scope.Complete();
                                logger.Log($"${input.ToString()} was sent from user {loggingUser.Name} to user {receiverUser.Name} ${input.ToString()}");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The transaction could not be completed");
                            }
                        }
                        
                    }

                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            loggingUser = null;
        }
        public void EndOfDay()
        {
            logger.PrintLogs();
        }
        public User FindLoggingUser(string id,string password)
        {
                var loggingUser = User.Users.FirstOrDefault(x => x.Id == id && x.Password == password);
            var incorrectEntry = User.Users.FirstOrDefault(x => x.Id == id);
            if (loggingUser == null)
            {
                logger.Log($"Incorrect login attempt by user {incorrectEntry.Name}");
            }
                return loggingUser;
        }
        public User FindUser(string id, string name,string surName)
        {
            var user = User.Users.FirstOrDefault(x => x.Id == id && x.Name == name && x.Surname == surName);
            return user;
        }
    }
}
