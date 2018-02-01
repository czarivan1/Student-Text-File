using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_Project_Address
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFName.Focus();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Create the variables needed for the sqldatasource
            string fName = "";
            string lName = "";
            string address = "";

            // Getting the user's input for the first and last name
            fName = txtFName.Text;
            lName = txtLName.Text;            

            // I made a datasource earlier because I couldn't get the entity framework models to work so I went with something simple and familiar right away. 
            // I madea  query that uses the first and last name and then shows the address of said person
            SqlDataSource1.SelectParameters.Add("@CustFName", fName);
            SqlDataSource1.SelectParameters.Add("@CustLName", lName);

            // I made the command here using the paramenters from users
            SqlDataSource1.SelectCommand = "Select CustAddress From Customers Where CustFName = @CustFName AND CustLName = @CustLName";

            btnClear.Focus();

        }

        // I made this to clear the objects but I decided to just to auto call back on the text boxes for the names to make life so much simpler
        
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";

            //SqlDataSource1.SelectParameters.Clear();
           // SqlDataSource1.SelectParameters.Clear();

            FormView1.Visible = false;

            txtFName.Focus();
        }
        
        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }
    }
}