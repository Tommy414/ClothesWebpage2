﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ItemID;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemID = Convert.ToInt32(Session["ItemID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(ItemID);
        StockBook.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}