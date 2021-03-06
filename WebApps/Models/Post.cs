﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApps.Models
{
    /// <summary>
    /// This class stores information about a post in a social network,
    /// containing the common properties such as a username, timestamp,
    /// likes, comments and more. It acts as a superclass for the
    /// MessagePost and PhotoPost classes.
    /// </summary>
    /// <author>
    /// Tyronne Bradburn 
    /// version 1.0
    /// </author>
    [Serializable]
    public class Post
    {
        // Primary Key
        public int PostId { get; set; }

        // Username of the post's author
        [StringLength(20), Required]
        public String Username { get; set; }

        public DateTime Timestamp { get; set; }

        public int likes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        /// <summary>
        /// Constructor for getting the Posts values
        /// </summary>
        /// <param name="author"></param>
        public Post()
        {
            Timestamp = DateTime.Now;
            likes = 0;
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        public String FormatElapsedTime()
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - Timestamp;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
