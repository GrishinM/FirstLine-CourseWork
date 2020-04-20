<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApp.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" xmlns="http://www.w3.org/1999/html" lang="C#">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ввод данных</title>
</head>
<body>
<form id="form1" runat="server" style="text-align: center">
    <asp:FileUpload ID="fileUpload" runat="server" accept=".txt, .docx"/>
    <br/>
    <br/>
    <asp:Label runat="server" style="font-size: 25px" Text="Или введите текст:"/>
    <br/>
    <br/>
    <asp:TextBox ID="textBox" runat="server" Height="400" Width="800" TextMode="MultiLine" style="resize:none"/>
    <br/>
    <br/>
    <asp:Label runat="server" Text="Введите ключ:"/>
    <br/>
    <br/>
    <asp:TextBox ID="keyBox" runat="server" Width="200"/>
    <br/>
    <br/>
    <asp:Button runat="server" Text="Зашифровать" OnClick="EncryptClick"/>
    <asp:Button runat="server" Text="Расшифровать" OnClick="DecryptClick"/>
</form>
</body>
</html>