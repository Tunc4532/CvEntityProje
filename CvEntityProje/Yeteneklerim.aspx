﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvEntityProje.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left:30px; margin-right:30px">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td>
                        <%# Eval("ID") %>
                    </td>
                    <td>
                         <%# Eval("YETENEK")%>
                    </td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "Yeteneksil.aspx?ID="+ Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "Yetenekgüncelle.aspx?ID="+ Eval("ID") %>' CssClass="btn btn-success">Güncelle</asp:HyperLink>  </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="Yeniyetenek.aspx" class="btn btn-primary" style="margin-left:30px">Yetenek Ekle</a>




</asp:Content>
