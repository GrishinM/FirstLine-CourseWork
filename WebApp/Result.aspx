<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebApp.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="C#">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Результат</title>
</head>
<body>
<form id="form1" runat="server" style="text-align: center">
    <asp:Label runat="server" style="font-size: 30px" Text="Результат:"/>
    <br/>
    <br/>
    <asp:TextBox ID="textBox" runat="server" Height="400" Width="800" TextMode="MultiLine" BackColor="White" Enabled="False" Style="resize:none" Text="<% # WebApp.Main.text %>"/>
    <br/>
    <br/>
    <asp:Label runat="server" Text="Введите имя директории для сохранения:"/>
    <br/>
    <br/>
    <asp:TextBox ID="filePathBox" runat="server" Width="500"/>
    <br/>
    <br/>
    <asp:Label runat="server" Text="Введите имя файла:"/>
    <br/>
    <br/>
    <asp:TextBox ID="fileNameBox" runat="server" Width="500"/>
    <br/>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="Сохранить" OnClick="SaveClick"/>
    <br/>
    <br/>
    <asp:Button ID="Button2" runat="server" Text="Назад" OnClick="BackClick"/>
</form>
</body>
</html>