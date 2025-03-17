using Microsoft.EntityFrameworkCore;
using SyncNotesAppTest_Windows.Models;

namespace SyncNotesAppTest_Windows.Application.Data
{

    public class ApplicationDbContext : DbContext
    {

        #region - - - - - Properties - - - - -

        public DbSet<Device> Devices { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<SyncChanges> SyncChanges { get; set; }

        public DbSet<User> Users { get; set; }

        public string DbPath { get; }

        #endregion Properties

        #region - - - - - Constructors - - - - -

        public ApplicationDbContext()
        {
            var _Folder = Environment.SpecialFolder.LocalApplicationData;
            var _Path = Environment.GetFolderPath(_Folder);
            DbPath = System.IO.Path.Join(_Path, "SyncNoteTest_Development.db");
        }

        #endregion Constructors

        #region - - - - - Methods - - - - -

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        #endregion Methods

    }

}
