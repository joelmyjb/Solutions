<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="ConsultaPagoTecnico.aspx.cs" Inherits="ProyectoFinalAII.Consultas.ConsultaPagoTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>&nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="106px">
                <asp:ListItem>IdPagoTecnico</asp:ListItem>
                <asp:ListItem>IdTecnico</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="BuscarText" runat="server" Width="225px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click1" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="ConsultaGridView" runat="server">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdPagoTecnico" DataNavigateUrlFormatString="/Registros/RegistroPagoTecnico.aspx?IdPagoTecnico={0}" Text="Editar" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
