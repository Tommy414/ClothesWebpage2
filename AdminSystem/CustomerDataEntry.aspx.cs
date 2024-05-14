﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtDateOfBirth { get; private set; }
    public object txtEmail { get; private set; }
    public object chkActive { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtHouseNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtAddressId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the CustomerName
        AnCustomer.CustomerName = txtCustomerName.Text;
        //caputure the Date of Birth
        AnCustomer.DateOfBirth = txtDateOfBirth.Text;
        //capture the email
        AnCustomer.Email = txtEmail.Text;
        //capture the Is Active
        AnCustomer.Active = chkActive.Checked;
        //store the address in the section object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}