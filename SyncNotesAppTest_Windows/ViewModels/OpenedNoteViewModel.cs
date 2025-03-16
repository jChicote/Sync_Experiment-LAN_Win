using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SyncNotesAppTest_Windows.Commands;

namespace SyncNotesAppTest_Windows.ViewModels
{

    public class OpenedNoteViewModel
    {

        #region - - - - - Fields - - - - -



        #endregion Fields

        #region - - - - - Properties - - - - -

        public ICommand SaveNoteCommand;

        #endregion Properties

        #region - - - - - Constructors - - - - -

        public OpenedNoteViewModel()
        {
            this.SaveNoteCommand = new RelayCommand(this.SaveNote, this.CanSaveNote);
        }

        #endregion Constructors

        #region - - - - - Methods - - - - -

        private bool CanSaveNote(object obj)
            => true;

        private void SaveNote(object obj)
        {

        }

        #endregion Methods

    }

}
