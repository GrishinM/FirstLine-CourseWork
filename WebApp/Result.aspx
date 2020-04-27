<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebApp.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="C#">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Результат</title>
    <link rel="stylesheet" href="CSS/style.css">
</head>
<body>
<form runat="server">
    <asp:Button runat="server" CssClass="button" Text="Назад" OnClick="BackClick"/>
    <div class="container">
        <div class="form">
            <div class="form__container">
                <textarea ID="textBox" runat="server" readonly="readonly"/>
                <div class="right">
                    <div class="key">
                        <div class="inp">
                            <span runat="server">Введите имя директории для сохранения:</span>
                            <input class="input" ID="filePathBox" runat="server" type="text"/>
                            <span runat="server">Введите имя файла:</span>
                            <input class="input" ID="fileNameBox" runat="server" type="text"/>
                        </div>
                        <div class="btns">
                            <asp:Button ID="Button1" runat="server" CssClass="button" Text="Сохранить" OnClick="SaveClick"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</form>
</body>
</html>