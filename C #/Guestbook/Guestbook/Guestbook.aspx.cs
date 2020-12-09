using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guestbook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        // use GuestbookEntities DbContext to add a new message 
        using ( GuestbookEntities dbcontext = new GuestbookEntities() )
        {  
            // create a new Message to add to the database; Message is  
            // the entity data model class representing a table row 
            Message message = new Message();
            
            // set new Message's properties
            message.Date = DateTime.Now.ToShortDateString();
            message.Name = nameTextBox.Text;
            message.Email = emailTextBox.Text;
            message.Message1 = messageTextBox.Text;

            // add new Message to GuestbookEntities DbContext  
            dbcontext.Messages.Add( message );  
            dbcontext.SaveChanges(); // save changes to the database 27	
        } // end using statement
        // clear the TextBoxes
        nameTextBox.Text = String.Empty; 
       	emailTextBox.Text = String.Empty;
        messageTextBox.Text = String.Empty;
 
        // update the GridView with the new database table contents 
        messagesGridView.DataBind();
    }

    // Clear Button clears the Web Form's TextBoxes
    protected void clearButton_Click(object sender, EventArgs e)
    {
        nameTextBox.Text = String.Empty;
        emailTextBox.Text = String.Empty;
        messageTextBox.Text = String.Empty;
    }//end method clearButton_Click
}//end class Guestbook