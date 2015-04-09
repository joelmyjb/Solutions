<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroClientes.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
            width: 536px;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO CLIENTES&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="IdLabel" runat="server" Text="IdCliente"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="IdClienteTextBox" runat="server" BackColor="White" Width="56px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Nombreslabel" runat="server" Text="Nombres          "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="NombresTextBox" runat="server" BackColor="White" Width="172px" MaxLength="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NombresTextBox" ErrorMessage="*" ForeColor="Red">Debe de ingresar el nombre.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="TelefonoLabel" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TelefonoTextBox" runat="server" BackColor="White" Width="121px" MaxLength="12"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="CelularLabel" runat="server" Text="Celular"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="CelularTextBox" runat="server" BackColor="White" Width="121px" MaxLength="12"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="DireccionLabel" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="DireccionTextBox" runat="server" BackColor="White" Width="200px" MaxLength="30"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="EmailTextBox" runat="server" BackColor="White" Width="148px" MaxLength="30"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="73px" />
                &nbsp;
                <asp:Button ID="GuardarButton" runat="server" ForeColor="Black" OnClick="SaveButton_Click" Text="Guardar" Width="88px" />
                &nbsp;
                <asp:Button ID="EliminarButton" runat="server" ForeColor="Black" OnClick="DeleteButton_Click" Text="Eliminar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
    </table>
</asp:Content>
