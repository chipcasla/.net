<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRecuperar.aspx.cs" Inherits="UI.Web.frmRecuperar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Bienvenido a la busqueda de un paciente"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblBuscar" runat="server" Text="Ingrese el numero de Historia Clinica:"></asp:Label>
            <asp:TextBox ID="txtHistoriaClinica" runat="server"></asp:TextBox>
        </div>
                <br />
                <br />
        <asp:Button ID="btmRecuperar" runat="server" Text="Buscar" OnClick="btmRecuperar_Click" />
               <br />       <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label>
            <asp:Label ID="lblApelldos" runat="server" Text="Apellidos"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Estado Paciente:"></asp:Label>
            <asp:Label ID="lblEstadoPaciente" runat="server" Text="Estado Paciente"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Fecha Nacimiento:"></asp:Label>
            <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha Nacimiento"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Historia Clinica:"></asp:Label>
            <asp:Label ID="lblHistoriaClinica" runat="server" Text="Historia Clinica"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Nombres:"></asp:Label>
            <asp:Label ID="lblNombres" runat="server" Text="Nombres"></asp:Label>
        </div>
        <br />

    </form>
</body>
</html>
