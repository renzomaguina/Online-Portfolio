// DisplayAuthorsTable.cs
// Displaying data from a database table in DataGridView

using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayBaseballTable : Form
    {
        public DisplayBaseballTable()
        {
            InitializeComponent();
        }

        // Entity Framework DbContext
        private DisplayTable.BaseballEntities dbcontext =
            new DisplayTable.BaseballEntities();

        // load data from Database intro DataGridView

        private void RefreshContacts()
        {
            // Dispose old DbContext so we can reorder records based on edits

            if (dbcontext != null)

                dbcontext.Dispose();

            // create new DbContext so we can reorder records based on edits
            dbcontext = new DisplayTable.BaseballEntities();

            // use LINQ to order the Address table contents
            // by last name, then first name

            dbcontext.Players.OrderBy(entry => entry.LastName)
                                .ThenBy(entry => entry.FirstName).Load();

            // specify DataSource for addressBindingSource
            baseballDataSet.DataSource = dbcontext.Players.Local;
            baseballDataSet.MoveFirst(); // go to first result
            findTextBox.Clear(); // clear the find TextBox

        } // end Method RefreshContacts

        // when the form loads, fill it with data from the database
        private void DisplayBaseballTable_Load(object sender, EventArgs e)
        {
            // load Authors table ordered by LastName then FirstName
            dbcontext.Players
                .OrderBy(Player => Player.PlayerID)
                .ThenBy(Player => Player.LastName)
                .ThenBy(Player => Player.FirstName)
                .Load();

            // specify DataSource for authorBindingSource
            baseballDataSet.DataSource = dbcontext.Players.Local;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // use LINQ to filter contacts with last names that
            // start with findTextBox contents

            var lastnameQuery =

            from Author in dbcontext.Players

            where Author.LastName.StartsWith(findTextBox.Text)

            orderby Author.LastName, Author.FirstName

            select Author;

            baseballDataSet.DataSource = lastnameQuery.ToList();
            baseballDataSet.MoveFirst(); // go to first result
        }

        private void browseAllButton_Click(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void baseballDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
