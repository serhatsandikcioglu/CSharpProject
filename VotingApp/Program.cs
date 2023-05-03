using VotingApp;
List<Category> categories = new List<Category>();
categories.Add(new Category("Movie Categories", 0));
categories.Add(new Category("Tech Stack Categories", 0));
categories.Add(new Category("Sport Categories", 0));
List<Users> users = new List<Users>();
int input = 0;
string userName = "";
string password = "";
string input1 = "";
do
{
    Console.WriteLine($"(1) {categories[0].Name} \n(2) {categories[1].Name} \n(3) {categories[2].Name} \n(0) Exit");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            Console.Write("Username: ");
            userName = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            if (users.Any(x=> x.UserName == userName && x.Password == password))
            {
                categories[0].VoteCount++;
                Console.WriteLine("Your vote have been completed.");
            }
            else
            {
                Console.WriteLine("You are not registered do you want to register ? y/n");
                input1 = Console.ReadLine();
                if (input1 == "y")
                {
                    Console.WriteLine("Username: ");
                    userName = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    password = Console.ReadLine();
                    users.Add(new Users() { UserName = userName, Password = password });
                    categories[0].VoteCount++;
                    Console.WriteLine("Your membership and your vote have been completed successfully.");
                }
            }
            break;
        case 2:
            Console.Write("Username: ");
            userName = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            if (users.Any(x => x.UserName == userName && x.Password == password))
            {
                categories[1].VoteCount++;
                Console.WriteLine("Your vote have been completed.");
            }
            else
            {
                Console.WriteLine("You are not registered do you want to register ? y/n");
                input1 = Console.ReadLine();
                if (input1 == "y")
                {
                    Console.Write("Username: ");
                    userName = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    users.Add(new Users() { UserName = userName, Password = password });
                    categories[1].VoteCount++;
                    Console.WriteLine("Your membership and your vote have been completed successfully.");
                }
            }
            break;
        case 3:
            Console.Write("Username: ");
            userName = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            if (users.Any(x => x.UserName == userName && x.Password == password))
            {
                categories[2].VoteCount++;
                Console.WriteLine("Your vote have been completed.");
            }
            else
            {
                Console.WriteLine("You are not registered do you want to register ? y/n");
                input1 = Console.ReadLine();
                if (input1 == "y")
                {
                    Console.Write("Username: ");
                    userName = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    users.Add(new Users() { UserName = userName, Password = password });
                    categories[2].VoteCount++;
                    Console.WriteLine("Your membership and your vote have been completed successfully.");
                }
            }
            break;
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
} while (input != 0);
double sumVote = categories[0].VoteCount + categories[1].VoteCount + categories[2].VoteCount;
double category1Rate = categories[0].VoteCount / sumVote * 100;
double category2Rate = categories[1].VoteCount / sumVote* 100;
double category3Rate = categories[2].VoteCount / sumVote * 100;
Console.WriteLine($"{categories[0].Name}: %{category1Rate.ToString()} \n{categories[1].Name}: %{category2Rate.ToString()} \n{categories[2].Name}: %{category3Rate.ToString()} \n");