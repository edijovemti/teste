<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcluirContato.aspx.cs" Inherits="AgendaContato.ExcluirContato" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Código:<asp:TextBox ID="TxtIdcontado" runat="server"></asp:TextBox>
        <br />

        <asp:Button ID="Btnexcluir" runat="server" Text="Excluir" Width="77px" 
            onclick="Btnexcluir_Click" />
    
    </div>
    </form>
</body>
</html>
