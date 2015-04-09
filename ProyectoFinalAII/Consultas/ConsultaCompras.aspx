<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="ConsultaCompras.aspx.cs" Inherits="ProyectoFinalAII.Consultas.ConsultaCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>&nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="95px">
                <asp:ListItem>IdUsuario</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="BuscarText" runat="server" Width="225px"></asp:TextBox>
                &nbsp;a
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click1" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="ConsultaGridView" runat="server">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdCompra" DataNavigateUrlFormatString="/Registros/RegistroCompras.aspx?IdCompra={0}" Text="Editar" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
