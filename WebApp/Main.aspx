<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApp.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="C#">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ввод данных</title>
    <link rel="stylesheet" href="CSS/style.css">
</head>
<body>
<div class="container">
    <div class="form">
        <form runat="server">
            <div class="form__container">
                <textarea ID="textBox" runat="server" placeholder="Введите текст..."/>
                <div class="right">
                    <div class="load">
                        <asp:FileUpload ID="fileUpload" runat="server" accept=".txt, .docx"/>
                    </div>
                    <div class="key">
                        <div class="inp">
                            <span runat="server">Введите ключ:</span>
                            <input class="input" ID="keyBox" runat="server" type="text"/>
                        </div>
                        <div class="btns">
                            <asp:Button runat="server" CssClass="button" Text="Зашифровать" OnClick="EncryptClick"/>
                            <asp:Button runat="server" CssClass="button" Text="Расшифровать" OnClick="DecryptClick"/>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>
</body>
</html>