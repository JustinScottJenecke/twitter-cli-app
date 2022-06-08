using System;

namespace ConsoleApp {
    class Program {

        static void Main(string[] args) {

            Console.Write("How many tweets to add? [Max 5]");
            int noTweets = int.Parse( Console.ReadLine() );

            string[] tweetList = new string[5];

            for (int i = 0; i < noTweets; i++) {

                string newTweet = Console.ReadLine();

                tweetList[i] = newTweet;
            }

            Console.WriteLine("Your Tweets are:");
            for (int i = 0; i < tweetList.Length; i++) {

                Console.WriteLine("Tweet {0}: {1}", i, tweetList[i]);
            }

            Console.ReadLine();
            /*
            string tweet = "saluton mundo";
            int tweetLength = tweet.Length;

            Console.WriteLine("Registering Tweet.. \n Posting Tweet to your timeline... \n Tweet posted successfully.... \n");
            Console.Write(
                "Your Tweet is {0} and its lenght is {1} characters",
                tweet,
                tweetLength
                );
            Console.ReadLine();
            */
        }
    }
}
