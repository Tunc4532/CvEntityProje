<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yetenekgüncelle.aspx.cs" Inherits="CvEntityProje.Yetenekgüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4  Style="margin-left: 620px"> Yetenek Güncelleme Sayfası</h4>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek..."></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Yeteneği Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />

</asp:Content>
