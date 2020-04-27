using System;
using System.IO;
using System.Web.UI;
using Encryption;

namespace WebApp
{
    public partial class Main : Page
    {
        public static string Text { get; private set; }

        private readonly Encryptor encryptor = new Encryptor();

        private Func<string, string> cryptFile;

        private Func<string, string> cryptText;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void EncryptClick(Object sender, EventArgs e)
        {
            cryptFile = encryptor.EncryptFile;
            cryptText = encryptor.EncryptText;
            f();
        }

        protected void DecryptClick(Object sender, EventArgs e)
        {
            cryptFile = encryptor.DecryptFile;
            cryptText = encryptor.DecryptText;
            f();
        }

        private void f()
        {
            var text = textBox.Value;
            var key = keyBox.Value;
            if (!fileUpload.HasFile && text == "")
            {
                Response.Write("<script>alert('Введите данные!');</script>");
                return;
            }

            if (key == "")
            {
                Response.Write("<script>alert('Введите ключ!');</script>");
                return;
            }

            try
            {
                encryptor.Key = key;
            }
            catch (MyException e)
            {
                Response.Write($"<script>alert('{e.Message}');</script>");
                return;
            }

            if (fileUpload.HasFile)
            {
                var fileName = Server.MapPath($"~/{fileUpload.FileName}");
                fileUpload.SaveAs(fileName);
                try
                {
                    Text = cryptFile(fileName);
                }
                catch (MyException e)
                {
                    Response.Write($"<script>alert('{e.Message}');</script>");
                    return;
                }
                finally
                {
                    File.Delete(fileName);
                }
            }
            else
                Text = cryptText(text);

            Response.Redirect("Result.aspx");
        }
    }
}