<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmListado.aspx.cs" Inherits="UI.Web.frmListado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ObjectDataSource ID="odsPacientes" runat="server" SelectMethod="recuperarTodos" TypeName="Giangiordano.Negocio.Paciente"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsPacientes">
            <Columns>
                <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                <asp:BoundField DataField="EstadoPaciente" HeaderText="EstadoPaciente" SortExpression="EstadoPaciente" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:BoundField DataField="HistoriaClinica" HeaderText="HistoriaClinica" SortExpression="HistoriaClinica" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" ReadOnly="True" SortExpression="Edad" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click aqui para buscar Paciente" />
    </form>
</body>
</html>
