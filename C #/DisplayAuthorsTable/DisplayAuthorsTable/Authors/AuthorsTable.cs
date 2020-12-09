using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authors
{
    public partial class AuthorsTable : Form
    {
        public AuthorsTable()
        {
            InitializeComponent();
        }
        // Entity Framework DbContext

        private Authors.AuthorsTable dbcontext = null;
        // fill our authorBindingSource with all rows, ordered by name
        private void RefreshContacts()
        {
            // Dispose old DbContext so we can reorder records based on edits

            if (dbcontext != null)

                dbcontext.Dispose();

            // create new DbContext so we can reorder records based on edits
            dbcontext = new Authors.AuthorsTable();

            // use LINQ to order the Address table contents
            // by last name, then first name

            dbcontext.Books.OrderBy(entry => entry.LastName)
                                .ThenBy(entry => entry.FirstName).Load();

            // specify DataSource for addressBindingSource
            authorBindingSource.DataSource = dbcontext.Books.Local;
            authorBindingSource.MoveFirst(); // go to first result
            findTextBox.Clear(); // clear the find TextBox

        } // end Method RefreshContacts

        // when the form loads, fill it with data from the database

        
        private void findButton_Click(object sender, EventArgs e)
        {
            // use LINQ to filter contacts with last names that
            // start with findTextBox contents

            var lastNameQuery =

            from authors in dbcontext.Books

            where authors.LastName.StartsWith(findTextBox.Text)

            orderby authors.LastName, authors.FirstName

            select authors;

            // display matching contacts

            authorBindingSource.DataSource = lastNameQuery.ToList();
            authorBindingSource.MoveFirst(); // go to first result

            
        }

        private void browseAllButton_Click(object sender, EventArgs e)
        {
           

            RefreshContacts();
        }
    }
}
