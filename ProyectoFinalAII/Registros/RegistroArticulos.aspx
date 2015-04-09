<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroArticulos.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
    }
        .auto-style3 {
            width: 621px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:102%;">
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Label ID="RLabel" runat="server" Text="REGISTRO DE ARTICULOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="IdArticuloLabel" runat="server" Text="IdArticulo"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="IdArticuloTextBox" runat="server" Height="16px" Width="34px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="DescripcionTextBox" runat="server" Height="16px" Width="209px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DescripcionTextBox" ErrorMessage="*" ForeColor="Red">Debe ingresar la descripcion.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="TipoLabel" runat="server" Text="Tipo"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="TipoDropDown" runat="server" Width="105px">
                    <asp:ListItem>Piezas</asp:ListItem>
                    <asp:ListItem>Servicios</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="ExistenciaLabel" runat="server" Text="Existencia"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="ExistenciaTextBox" runat="server" Height="16px" Width="43px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="CostoLabel" runat="server" Text="Costo"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="CostoTextBox" runat="server" Height="16px" Width="42px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="PrecioLabel" runat="server" Text="Precio"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="PrecioTextBox" runat="server" Width="51px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
&nbsp;<asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" Width="81px" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
            &nbsp;&nbsp;&nbsp;
                </td>
        </tr>
    </table>
</asp:Content>
