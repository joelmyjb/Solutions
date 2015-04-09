<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="ConsultaTiposEquipos.aspx.cs" Inherits="ProyectoFinalAII.Consultas.ConsultaTiposEquipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                &nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="131px">
                    <asp:ListItem>Descripcion</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="BuscarText" runat="server" Width="225px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click1" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="ConsultaGridView" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="622px">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdEquipo" DataNavigateUrlFormatString="/Registros/RegistroTiposEquipos.aspx?IdEquipo={0}" Text="Editar" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
