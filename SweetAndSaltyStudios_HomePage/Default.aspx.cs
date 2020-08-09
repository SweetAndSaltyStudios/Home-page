using System;

namespace SweetAndSaltyStudios_HomePage
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clickCount = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = clickCount.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}