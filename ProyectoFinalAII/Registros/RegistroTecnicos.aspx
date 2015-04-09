<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroTecnicos.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroTecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 383px;
    }
    .auto-style2 {
        width: 239px;
    }
    .auto-style3 {
    }
    .auto-style4 {
        width: 247px;
    }
    .auto-style5 {
        width: 81px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO TECNICOS&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="IdLabel" runat="server" Text="IdTecnicos"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="IdClienteTextBox" runat="server" BackColor="White" Width="56px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Nombreslabel" runat="server" Text="Nombres          "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="NombresTextBox" runat="server" BackColor="White" Width="152px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NombresValidator" runat="server" ControlToValidate="NombresTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe de ingresar un nombre.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="TelefonoLabel" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TelefonoTextBox" runat="server" BackColor="White" Width="152px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TelefonoValidator" runat="server" ControlToValidate="TelefonoTextBox" ErrorMessage="*" ForeColor="Red">Debe ingresar un telefono.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="DireccionLabel" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="DireccionTextBox" runat="server" BackColor="White" Width="176px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="DireccionValidator" runat="server" ControlToValidate="DireccionTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar la direccion.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="EmailTextBox" runat="server" BackColor="White" Width="159px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe de ingresar un email.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="PctComisionlabel" runat="server" Text="PctComision"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="PctComisionTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="91px" />
                &nbsp;
                &nbsp;
                <asp:Button ID="GuardarButton" runat="server" ForeColor="Black" OnClick="SaveButton_Click" Text="Guardar" Width="88px" />
                &nbsp;&nbsp;
                <asp:Button ID="EliminarButton" runat="server" ForeColor="Black" OnClick="DeleteButton_Click" Text="Eliminar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
