using PictureApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp.ViewModels
{
    public class CommentsViewModel : INotifyPropertyChanged
    { 

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ObservableCollection<Comment> _comments;
        public ObservableCollection<Comment> Comments
        {
            get
            {
                return _comments;
            }

            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    OnPropertyChanged(nameof(Comments));
                }
            }

        }

        public void RefreshList()
        {
            Comments.Clear();
            List<Comment> commentList = Task.Run(async () => await App.dbContext.Comments_GetCommentsAsync()).Result;


            foreach (Comment comment in commentList)
            {
                Comments.Add(comment);
            }
        }
    }
}
