using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTut
{
    public partial class Projection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Insert Label and Textboxes
            Label1.Visible = false;
            Label2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            InsSub.Visible = false;
            //Update labels and textBoxes
            UpdNewLName.Visible = false;
            UpdOldlab.Visible = false;
            UpdOldLName.Visible = false;
            UpdSubmit.Visible = false;
            UpdNewlab.Visible = false;

            //Code for projecting required columns

            //LinqClassDataContext context = new LinqClassDataContext();
            //{
            //    var result = from value in context.ProTabs
            //                 select new { value.LName };
            //    ProjectionView.DataSource = result;
            //    ProjectionView.DataBind();
            //}
        }

        protected void GetDataBut_Click(object sender, EventArgs e)
        {
            //Labels and textboxes of Insert
            Label1.Visible = false;
            Label2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            InsSub.Visible = false;
            //Labels and textboxes of Update
            UpdNewLName.Visible = false;
            UpdOldlab.Visible = false;
            UpdOldLName.Visible = false;
            UpdSubmit.Visible = false;
            UpdNewlab.Visible = false;
            GetData();
        }        

        protected void InsertBut_Click(object sender, EventArgs e)
        {
            //Labels and textboxes of Insert
            Label1.Visible = true;
            Label2.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            InsSub.Visible = true;
            //Labels and textboxes of Update
            UpdNewLName.Visible = false;
            UpdOldlab.Visible = false;
            UpdOldLName.Visible = false;
            UpdSubmit.Visible = false;
            UpdNewlab.Visible = false;

        }

        protected void InsSub_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        protected void UpdBut_Click(object sender, EventArgs e)
        {
            UpdNewLName.Visible = true;
            UpdOldlab.Visible = true;
            UpdOldLName.Visible = true;
            UpdSubmit.Visible = true;
            UpdNewlab.Visible = true;
        }

        protected void UpdSubmit_Click(object sender, EventArgs e)
        {
            UpdateMethod();
        }
        //Method implemented on direct button click
        protected void DelBut_Click(object sender, EventArgs e)
        {
            using (LinqClassDataContext delete = new LinqClassDataContext())
            {
                ProTab1 delvalue = delete.ProTab1s.SingleOrDefault(value => value.LName=="lorry");
                delete.ProTab1s.DeleteOnSubmit(delvalue);
                delete.SubmitChanges();
                GetData();
            }
        }


    //Method storage area
        //Method to update the table
        private void UpdateMethod()
        {
            using (LinqClassDataContext update = new LinqClassDataContext())
            {
                ProTab1 insMet = update.ProTab1s.SingleOrDefault(value => value.LName == UpdOldLName.Text);
                insMet.LName = UpdNewLName.Text.ToString();
                update.SubmitChanges();
                GetData();
            }
        }

        //Method contains Code for insertion
        private void InsertData()
        {
            using (LinqClassDataContext context = new LinqClassDataContext())
            {
                ProTab1 instab = new ProTab1
                {
                    Name = TextBox1.Text.ToString(),
                    LName = TextBox2.Text.ToString()
                };
                context.ProTab1s.InsertOnSubmit(instab);
                context.SubmitChanges();
                GetData();
            }
        }

        //Method to DisplayData
        private void GetData()
        {
            LinqClassDataContext context = new LinqClassDataContext();
            {
                //Logger is used to log data and provide query syntax
                context.Log = Response.Output;
                ProjectionView.DataSource = context.ProTab1s;
                ProjectionView.DataBind();
            }
        }

    }
}