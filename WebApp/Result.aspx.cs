using System;
using System.IO;
using System.Web.UI;

namespace WebApp
{
    public partial class Result : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textarea.Value = Main.text;
        }

        protected void SaveClick(Object sender, EventArgs e)
        {
            if (!Directory.Exists(filePath.Value))
            {
                Response.Write("<script>alert('Директории с таким именем не существует!');</script>");
                return;
            }

            if (fileName.Value == "")
            {
                Response.Write("<script>alert('Пустое имя файла!');</script>");
                return;
            }

            File.WriteAllText($"{filePath.Value}/{fileName.Value}.txt", textarea.Value);
            Response.Write("<script>alert('Успешно сохранено!');</script>");
        }

        protected void BackClick(Object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}