using System;

namespace WeekendOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            Console.WriteLine("Hello, Human. I'm Karey's program.");
            Console.WriteLine("She's told me so much about your world");
            Console.WriteLine("If you dont know what to do this weekend");
            while (again)
            {
            Console.WriteLine("I'd be happy to make some suggestions");
            Console.WriteLine("Hmm. What are you most in the mood for?\n");

            Console.WriteLine("1. Something new");
            Console.WriteLine("2. Something exciting");
            Console.WriteLine("3. Something to laugh about");
            Console.WriteLine("4. Something relaxing\n");
            string mood = Console.ReadLine();
                try
                {
                    if (mood == "1" || mood == "1.")
                    {
                        Console.WriteLine("\nOkay, something new.");
                        Console.WriteLine("Will you be..");
                        Console.WriteLine("1. Solo");
                        Console.WriteLine("2. With a few people");
                        Console.WriteLine("3. With a larger group");
                        Console.WriteLine("4. With a small army\n");
                        string people = Console.ReadLine();

                        if (people == "1" || people == "1.")
                        {
                            Console.WriteLine("\nAh, solo, yeah me too.");
                            Console.WriteLine("If you want to try something new and its just you,");
                            Console.WriteLine("you should take a train to a lake or park you've never seen.");
                            Console.WriteLine("Its a big world, try something new for me.\n");
                            again = Again();
                        }

                        if (people == "2" || people == "2.")
                        {
                            Console.WriteLine("\nA few people, okay.");
                            Console.WriteLine("If you want to do something new with a few people");
                            Console.WriteLine("you dont have to go far to invent a hybrid of your favorite games");
                            Console.WriteLine("(Bowling + Football = Fowling) just invite them over.");
                            Console.WriteLine("Well I hope that helps!\n");
                            again = Again();
                        }

                        if (people == "3" || people == "3.")
                        {
                            Console.WriteLine("\nIf you want to try something new with a large group");
                            Console.WriteLine("you should set up a race, not by car, but via hotair balloon!");
                            Console.WriteLine("Good luck!\n");
                            again = Again();
                        }

                        if (people == "4" || people == "4.")
                        {
                            Console.WriteLine("\nTrying something new with a small army? Oh boy.");
                            Console.WriteLine("You should organize a scavenger hunt downtown.");
                            Console.WriteLine("You could get there via hoverboard.");
                            Console.WriteLine("Well I hope that helps!\n");
                            again = Again();
                        }

                    }
                    if (mood == "2" || mood == "2.")
                    {

                        Console.WriteLine("\nOkay, something exciting it is.");
                        Console.WriteLine("Will you be..");
                        Console.WriteLine("1. Solo");
                        Console.WriteLine("2. With a few people");
                        Console.WriteLine("3. With a larger group");
                        Console.WriteLine("4. With a small army\n");
                        string people = Console.ReadLine();

                        if (people == "1" || people == "1.")
                        {
                            Console.WriteLine("\nAh, solo, yeah me too.");
                            Console.WriteLine("If you want to try something exciting and its just you,");
                            Console.WriteLine("you should take a helicopter to the jungle and try to survive.");
                            Console.WriteLine("I'm sure it wouldnt be dull!\n");
                            again = Again();
                        }
                        if (people == "2" || people == "2.")
                        {
                            Console.WriteLine("\nA few people");
                            Console.WriteLine("If you want to do something exciting with a few people");
                            Console.WriteLine("you should help one another conqure your biggest fears.");
                            Console.WriteLine("Reward yourself by traveling via limo.");
                            Console.WriteLine("That would make a memoriable weekend. Have a good one!\n");
                            again = Again();
                        }

                        if (people == "3" || people == "3.")
                        {
                            Console.WriteLine("\nIf you want to do something exciting with a large group");
                            Console.WriteLine("you should find buried treasure, theres got to be some somewhere.");
                            Console.WriteLine("Luckily you have crew for the ship you'll need to travel on.");
                            Console.WriteLine("Good luck. Have a good weekend!\n");
                            again = Again();
                        }

                        if (people == "4" || people == "4.")
                        {
                            Console.WriteLine("\nIf you want to do something exciting with a small army");
                            Console.WriteLine("you should rent out an island. I suggest arriving via boat.");
                            Console.WriteLine("If only I were waterproof.. Enjoy it for me!\n");
                            again = Again();
                        }

                    }
                    if (mood == "3" || mood == "3.")
                    {
                        Console.WriteLine("\n Oh good, I'll get a kick out of this one.");
                        Console.WriteLine("Will you be..");
                        Console.WriteLine("1. Solo");
                        Console.WriteLine("2. With a few people");
                        Console.WriteLine("3. With a larger group");
                        Console.WriteLine("4. With a small army\n");
                        string people = Console.ReadLine();

                        if (people == "1" || people == "1.")
                        {
                            Console.WriteLine("\nAh, solo, yeah me too.");
                            Console.WriteLine("If you want to do something goofy and its just you,");
                            Console.WriteLine("put on a snowman costume and chase the icecream man");
                            Console.WriteLine("I suggest rollerblading for the best effect.");
                            Console.WriteLine("Try not to laugh while doing that!\n");
                            again = Again();
                        }

                        if (people == "2" || people == "2.")
                        {
                            Console.WriteLine("\n Hm. Oh! I have the perfect activity for a few silly people,");
                            Console.WriteLine("put on dinosuar costumes and go to the museum to look at fossils.");
                            Console.WriteLine("I suggest taking the bus for additional funny looks.");
                            Console.WriteLine("Oh, I hope to see those pictures on the internet. Have fun!\n");
                            again = Again();
                        }

                        if (people == "3" || people == "3.")
                        {
                            Console.WriteLine("\n If you want to do something funny with a large group");
                            Console.WriteLine("you should dress up like superheros and ask people walking by if they need help");
                            Console.WriteLine("The best method of arriving would be by batmobile, but if thats not an option just run");
                            Console.WriteLine("You're sure to get a few giggles. Have a good time!\n");
                            again = Again();
                        }

                        if (people == "4" || people == "4.")
                        {
                            Console.WriteLine("\nA small army");
                            Console.WriteLine("If you want to do something silly with a small army of people");
                            Console.WriteLine("you should count down and celebrate a new holiday in a populated area.");
                            Console.WriteLine("The best way to get there would be by floats you created.");
                            Console.WriteLine("Happy holiday!\n");
                            again = Again();
                        }
                    }

                    if (mood == "4" || mood == "4.")
                    {
                        Console.WriteLine("\nOkay, something relaxing");
                        Console.WriteLine("Will you be..");
                        Console.WriteLine("1. Solo");
                        Console.WriteLine("2. With a few people");
                        Console.WriteLine("3. With a larger group");
                        Console.WriteLine("4. With a small army\n");
                        string people = Console.ReadLine();

                        if (people == "1" || people == "1.")
                        {
                            Console.WriteLine("\nAh, solo, yeah me too.");
                            Console.WriteLine("If you want to do something relaxing and its just you,");
                            Console.WriteLine("you should set up a hammock and bring something to read");
                            Console.WriteLine("I would suggest longboarding there.");
                            Console.WriteLine("I hope that helps. Have a good weekend!\n");
                            again = Again();
                        }

                        if (people == "2" || people == "2.")
                        {
                            Console.WriteLine("\nA few people");
                            Console.WriteLine("If you want to relax with a few people");
                            Console.WriteLine("you should carpool to get to the beach.");
                            Console.WriteLine("There you could go for a swim and listen to the waves.");
                            Console.WriteLine("Well I hope that helps. Have a good weekend!\n");
                            again = Again();
                        }

                        if (people == "3" || people == "3.")
                        {
                            Console.WriteLine("\nIf you want to do something relaxing with a large group");
                            Console.WriteLine("you should plan a trip to go stargazing with a telescope.");
                            Console.WriteLine("I suggest traveling by train to take in the view.");
                            Console.WriteLine("Well I hope that helps. Have a good weekend!\n");
                            again = Again();
                        }

                        if (people == "4" || people == "4.")
                        {
                            Console.WriteLine("\nIf you want to do something relaxing with a small army");
                            Console.WriteLine("you should try yoga on a rooftop to enjoy the view.");
                            Console.WriteLine("To get there I suggest taking the elavator, not climbing.\n");
                            again = Again();
                        }
                    }
                }
                //checks for vaild input
                catch
                {
                    if (mood != "1" || mood != "2" || mood != "3" || mood != "4" || mood == "Yes" || mood == "yes")
                    {
                        Console.WriteLine("\nI'm sorry, I dont understand but if you could enter your responce with a number 1-4 I could. Thanks.");
                        Console.ReadLine();
                    }
                }
            }
        }
        //method that will loop the program again 
        public static bool Again()
        {
            Console.WriteLine("\n If you would like another suggestion please enter: Yes");
            string another = Console.ReadLine();
            if (another == "Yes" || another == "yes")
            {
                bool yes = true;
                return yes;
            }
            else
            {
                Console.WriteLine("Okay, Take care!");
                bool no = false;
                return no;
            }
        }
    }
}

