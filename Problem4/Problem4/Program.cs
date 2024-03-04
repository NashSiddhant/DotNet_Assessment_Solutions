using System;

namespace Problem4
{
    
        class Post
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime CreatedOn { get; set; }
            public int Votes { get; private set; } 

            //Upvote the current vote count
            public void UpVote()
            {
                Votes++;
            }

            //Downvote the current vote count
            public void DownVote()
            {
                Votes--;
            }
            
            //Display post details
            public void DisplayPost()
            {
                Console.WriteLine(Title);
                Console.WriteLine(Description);
                Console.WriteLine("Date Posted: " + CreatedOn.ToLongDateString());
                Console.WriteLine("Votes: " + Votes);

            }

        }
    class Program
    {
        public static void Main(string[] args)
        {
            var Post = new Post(); //object creation

            Post.Title = "Learning Class and Object";
            Post.Description = "Encapsuation! One of the feature of Classes and Object";
            Post.CreatedOn = DateTime.UtcNow;

            Post.UpVote();       //1
            Post.UpVote();       //2
            Post.UpVote();       //3
            Post.DisplayPost();  //Vote Count should be 3

            Console.WriteLine();

            Post.DownVote();     //2
            Post.DownVote();     //1
            Post.DisplayPost();  //Vote Count should be 1
        }
    }


    
}