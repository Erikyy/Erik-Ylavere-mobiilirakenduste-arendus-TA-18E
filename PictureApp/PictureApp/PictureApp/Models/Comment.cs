using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PictureApp.Models
{
    public class Comment
    {
        //CommentId
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int PostId { get; set; }

        //UserName
        public string UserName { get; set; }

        //Comment 
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
