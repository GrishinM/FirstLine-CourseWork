using System;
using System.IO;
using System.Web.UI;

namespace WebApp
{
    public partial class Result : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        protected void SaveClick(Object sender, EventArgs e)
        {
            if (!Directory.Exists(filePathBox.Text))
            {
                Response.Write("<script>alert('Директории с таким именем не существует!');</script>");
                return;
            }

            if (fileNameBox.Text == "")
            {
                Response.Write("<script>alert('Пустое имя файла!');</script>");
                return;
            }

            File.WriteAllText($"{filePathBox.Text}/{fileNameBox.Text}.txt", textBox.Text);
            Response.Write("<script>alert('Успешно сохранено!');</script>");
        }

        protected void BackClick(Object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}