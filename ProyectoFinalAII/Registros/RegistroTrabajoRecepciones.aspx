<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="RegistroTrabajoRecepciones.aspx.cs" Inherits="ProyectoFinalAII.Registros.RegistroTrabajoRecepciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 297px;
        }
        .auto-style3 {
    }
    .auto-style4 {
        width: 299px;
    }
    .auto-style5 {
        width: 306px;
    }
    .auto-style6 {
        width: 93px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="IdLabel" runat="server" Text="IdTrabajoRecepcion" Visible="False"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="IdRecepcionTextBox" runat="server" BackColor="White" Width="56px" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="IdRecepcionLabel" runat="server" Text="IdRecepcion"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="IdRecepcionDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="IdArticuloLabel" runat="server" Text="IdArticulo"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="IdArticuloDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="IdTecnicoLabel" runat="server" Text="IdTecnico"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="IdTecnicoDropDownList" runat="server" Width="158px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="IdUsuarioLabel" runat="server" Text="IdUsuario"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="UsuarioDropDownList" runat="server" Width="149px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="PrecioLabel" runat="server" Text="Precio"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="PrecioTextBox" runat="server" BackColor="White" Width="93px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="CostoLabel" runat="server" Text="Costo"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="CostoTextBox" runat="server" BackColor="White" Width="89px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">
                <asp:CheckBox ID="esPago" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="MensajeLabel" runat="server" Text="Mensaje:"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Registros" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="NuevoButton" runat="server" OnClick="Button1_Click" Text="Nuevo" Width="135px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;
                <asp:Button ID="GuardarButton" runat="server" ForeColor="Black" OnClick="SaveButton_Click" Text="Guardar" Width="88px" />
                &nbsp;
                <asp:Button ID="EliminarButton" runat="server" ForeColor="Black" OnClick="DeleteButton_Click" Text="Eliminar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
