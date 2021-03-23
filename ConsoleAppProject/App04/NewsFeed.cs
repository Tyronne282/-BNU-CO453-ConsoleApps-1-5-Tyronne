using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Tyronne Bradburn
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Tyronne";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "Test post");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.Jpg", "Visual studio 2019");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// This allows the user to add comments to posts 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="comment"></param>
        public void AddComment(int id, string comment)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\n\tPost with ID {id} doesn't exist.\n");
            }
            else if (comment == "")
            {
                Console.WriteLine($"\n\tNo comment has been entered.\n");
            }
            else
            {
                Console.WriteLine("\n\tComment has been added to post with "
                    + $"ID {id}\n");
                post.AddComment(comment);
                post.Display();
            }
        }

        /// <summary>
        /// This allows the user to remove a post that has
        /// been made
        /// </summary>
        /// <param name="id"></param>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($" \nPost with ID = {id} does not exists!!\n");
            }
            else
            {
                Console.WriteLine($" \nThe following Post {id} has been removed!\n");

                if (post is MessagePost mp)
                {
                    mp.Display();
                }
                else if (post is PhotoPost pp)
                {
                    pp.Display();
                }

                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// This creates a ID for each post in order to help
        /// the user find older posts 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }

            return null;

        }

        /// <summary>
        /// Allows the user to find a post based on
        /// the user.
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public Post FindPostByAuthor(string author)
        {
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    return post;
                }
            }

            return null;
        }

        /// <summary>
        /// Allows the user to display posts based on 
        /// on the author
        /// </summary>
        /// <param name="author"></param>
        public void DisplayByAuthor(string author)
        {
            int count = 0;

            // TODO: Need to add else statement if author doesn't exist.
            foreach (Post post in posts)
            {
                if (post == FindPostByAuthor(author))
                {
                    post.Display();
                    Console.WriteLine();
                }
            }

            if (count < 1)
            {
                Console.WriteLine("\tThere are no posts that match that name!\n");
            }
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }
}
