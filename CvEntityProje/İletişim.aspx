<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İletişim.aspx.cs" Inherits="CvEntityProje.İletişim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left: 30px; margin-right: 30px">
        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
            <th>MAİL</th>
            <th>KONU</th>
            <th>MESAJI GÖR</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %>  </td>
                    <td>  <%# Eval("ADSOYAD")%></td>
                    <td>  <%# Eval("MAİL")%></td>
                    <td>  <%# Eval("KONU")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "Mesajdetay.aspx?ID="+ Eval("ID") %>' CssClass="btn btn-warning" BackColor="#FF9999">Mesajı Görüntüle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
