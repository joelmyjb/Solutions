<%@ Page Title="" Language="C#" MasterPageFile="~/ProyectoFinal.Master" AutoEventWireup="true" CodeBehind="ConsultaSuplidor.aspx.cs" Inherits="ProyectoFinalAII.Consultas.ConsultaSuplidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                &nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="131px">
                    <asp:ListItem>IdSuplidor</asp:ListItem>
                    <asp:ListItem>Nombres</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="BuscarText" runat="server" Width="225px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click1" style="height: 26px" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="ConsultaGridView" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="622px">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdSuplidor" DataNavigateUrlFormatString="/Registros/RegistroSuplidor.aspx?IdSuplidor={0}" Text="Editar" />
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
