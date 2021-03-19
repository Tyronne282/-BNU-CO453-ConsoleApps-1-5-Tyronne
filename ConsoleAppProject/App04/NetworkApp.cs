using System;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {

        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// The user can select between 1-9 and
        /// then the user then process the selected 
        /// option
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("\tTyronne News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Remove a Post", "Display All Posts", "" +
                "Display Posts by Author", "Display Posts by Date", "" +
                "Add Comments to a Post", "Like/Unlike Posts", "" +
                "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }

        /// <summary>
        /// The user can enter and post a message.
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputHeading("Post a Message");
            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputHeading("Your Message has been Posted:");
            post.Display();
        }

        /// <summary>
        /// The user can upload an image/photo with their name 
        /// and caption and then it gets uploaded.
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputHeading("Posting an Image/Photo");
            string author = InputName();

            Console.Write(" Please upload your Image/Photo file > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your Image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputHeading("Your Image/Photo has been Posted:");
            post.Display();
        }

        /// <summary>
        /// The user enters their name and returns it.
        /// </summary>
        /// <returns></returns>
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }

        /// <summary>
        /// The user can remove a post that they made
        /// by using the post ID number.
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputHeading($"Select a post to remove");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post Id > ",
                                                    1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// The user can search for posts created by
        /// the defined author and then displays all
        /// the posts created by the defined author
        /// </summary>
        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputHeading("Display Posts by Author");

            Console.Write("\tPlease enter the author you'd like " +
                "to search for > ");
            string author = Console.ReadLine();

            news.DisplayByAuthor(author);
        }


        /// <summary>
        /// The user can search for posts created on 
        /// a set date and then any posts created by 
        /// the defined date will be displayed.
        /// </summary>
        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The user can search for a post by using 
        /// the post ID number and then the user 
        /// will be able to add a comment to the 
        /// selected post
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputHeading("Adding a Comment");

            int id = (int)ConsoleHelper.InputNumber("\tPlease enter "
                + "the post's ID > ", 1, Post.GetNumberOfPosts());

            Console.Write("\tPlease enter a comment for this post > ");
            string comment = Console.ReadLine();

            news.AddComment(id, comment);
        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }
    }
}
