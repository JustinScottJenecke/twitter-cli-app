using System;

namespace ConsoleApp {
    class Program {

        static void Main(string[] args) {

            string choice;

            string[] tweetList = new string[5];
            int numTweets = 0;

            Console.WriteLine("========== Twitter App ===========");

            do {
                Console.WriteLine(" --- Menu --- ");
                Console.WriteLine("\n" +
                    "1) View all Tweets \n" +
                    "2) Post new Tweet \n" +
                    "3) Exit \n");

                Console.Write("Please select an option from the menu: (1-3)\n");
                choice = Console.ReadLine();
                Console.WriteLine("\n--- Your Choice: {0} ---\n", choice);

                switch (choice) {
                    case "1":
                        for (int i = 0; i < numTweets; i++) {
                            if(tweetList[i] != null)
                                Console.WriteLine("Tweet no{0}: '{1}'", i+1, tweetList[i]);
                        }
                        break;

                    case "2":
                        if (numTweets <= tweetList.Length){
                            Console.Write("Please enter your new Tweet: ");
                            string newTweet = Console.ReadLine();

                            if (newTweet.Length > 50) {
                                Console.WriteLine("Error, Tweets cannot have more than 50 characters.. \n exiting operation...");
                                continue;
                            }
                            else {
                                tweetList[numTweets] = newTweet;
                                numTweets++;
                                Console.WriteLine("Tweet posted successfully.");
                            }
                        }
                        else {
                            continue;
                        }
                        break;
                }

            } while (choice != "3");

            Console.WriteLine("Exiting application.");
            Console.ReadLine();

            /*
            Console.WriteLine("How many tweets to add? [Max 5]");
            int noTweets = int.Parse( Console.ReadLine() );

            string[] tweetList = new string[5];

            for (int i = 0; i < noTweets; i++) {

                Console.Write("Please enter tweet " + i + ": ");
                string newTweet = Console.ReadLine();

                if (newTweet.Length < 50) {

                    tweetList[i] = newTweet;
                }
                else {

                    Console.WriteLine("Error, Tweets cannot be longer than 50 characters");
                }
            }

            Console.WriteLine("Your Tweets are:");
            for (int i = 0; i < tweetList.Length; i++) {

                Console.WriteLine("Tweet {0}: {1}", i + 1, tweetList[i]);
            }

            Console.ReadLine();
            */
        }
    }
}
