using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DisplayAuthorTableForm : Form
    {
        public DisplayAuthorTableForm()
        {
            InitializeComponent();
        }

        private BookExamples.BooksEntities dbcontext =
            new BookExamples.BooksEntities();

        void DisplayAuthorTableForm_Load(object sender, System.EventArgs e)
        {
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .ToList();
            authorBindingSource.DataSource = dbcontext.Authors.Local;
            
           
        }
    }
}
