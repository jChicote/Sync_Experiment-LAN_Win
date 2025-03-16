using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SyncNotesAppTest_Windows.Commands;
using SyncNotesAppTest_Windows.Models;

namespace SyncNotesAppTest_Windows.ViewModels
{

    public class MainViewModel
    {

        private User m_LoggedInUser;
        private Note m_CurrentNote;

        #region - - - - - Properties - - - - -

        public ICommand NewNoteCommand { get; set; }

        #endregion Properties

        #region - - - - - Constructors - - - - -

        public MainViewModel()
        {
            this.m_LoggedInUser = new User();
            this.m_LoggedInUser.ID = Guid.NewGuid();
            this.m_LoggedInUser.UserName = "test username";
            this.m_LoggedInUser.Password = "testPassword";

            this.NewNoteCommand = new RelayCommand(this.CreateNewNote, this.CanCreateNewNote);
        }

        #endregion Constructors

        private bool CanCreateNewNote(object obj)
            => true;

        private void CreateNewNote(object obj)
        {
            var _NewNote = new Note();
            _NewNote.CreatedAt = DateTime.Now;
            _NewNote.OwningUserID = this.m_LoggedInUser.ID;
            _NewNote.ID = Guid.NewGuid();
            _NewNote.LastUpdatedAt = DateTime.Now;
            _NewNote.TextContent = "";
            _NewNote.Version = 0;


        }
}

}
