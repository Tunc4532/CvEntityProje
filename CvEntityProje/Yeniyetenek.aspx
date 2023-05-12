<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeniyetenek.aspx.cs" Inherits="CvEntityProje.Yeniyetenek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4  Style="margin-left: 620px">Yeni Yetenek Ekleme Sayfası</h4>
    <br />

   <%-- <asp:Label ID="Label1" runat="server" Text="Yetenek Açıklama" Style="margin-left: 30px"></asp:Label>
    <br />--%>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yeteneğinizi Giriniz..."></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Yetenek Kaydet" CssClass="btn btn-info" OnClick="Button1_Click" />
</asp:Content>
