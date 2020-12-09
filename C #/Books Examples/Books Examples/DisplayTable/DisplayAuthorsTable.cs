// DisplayAuthorsTable.cs
// Displaying data from a database table in DataGridView

using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        // Entity Framework DbContext
        private Books_Examples.BooksEntities dbcontext =
            new Books_Examples.BooksEntities();

        // load data from Database intro DataGridView
        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            // load Authors table ordered by LastName then FirstName
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            // specify DataSource for authorBindingSource
            authorBindingSource.DataSource = dbcontext.Authors.Local;
        }

        // Click event handler for thew Save Button in the
        // BindingNavigator saves the chnages made to the data
        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // Validate the input fields
            authorBindingSource.EndEdit(); // Complete current edit. if any

            // try to save changes
            try
            {
                dbcontext.SaveChanges(); // write changes to the database file
            }
            catch(DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values", "Entity Validation Exception");
            }
         }
    }
 }
