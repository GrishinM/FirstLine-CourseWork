using System;
using System.IO;
using System.Web.UI;

namespace WebApp
{
    public partial class Result : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textBox.Value = Main.Text;
        }

        protected void SaveClick(Object sender, EventArgs e)
        {
            var filePath = filePathBox.Value;
            var fileName = fileNameBox.Value;
            if (!Directory.Exists(filePath))
            {
                Response.Write("<script>alert('Директории с таким именем не существует!');</script>");
                return;
            }

            if (fileName == "")
            {
                Response.Write("<script>alert('Пустое имя файла!');</script>");
                return;
            }

            File.WriteAllText($"{filePath}/{fileName}.txt", textBox.Value);
            Response.Write("<script>alert('Успешно сохранено!');</script>");
        }

        protected void BackClick(Object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}