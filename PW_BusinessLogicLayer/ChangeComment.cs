using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain.Picture;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class ChangeComment : IChangeComment
    {
        private IChangeCommentDatabaseManager _changeCommentDatabaseManager;

        public ChangeComment()
        {
            _changeCommentDatabaseManager = new ChangeCommentDatabaseManager();
        }

        //public void HandleComment(PictureComment pictureComment)
        //{
        //    _changeCommentDatabaseManager.HandleChangedComment(pictureComment);
        //}

        public void HandleNewPictureComment(PictureComment editedComment)
        {
            _changeCommentDatabaseManager.PostNewPictureComment(editedComment);
        }
    }
}
