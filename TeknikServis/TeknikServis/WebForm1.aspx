<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TeknikServis.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ürün Seri No" Font-Size="X-Large" ForeColor="#000066"></asp:Label>
    &nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="199px" Font-Size="Smaller"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Ara" Width="136px" OnClick="Button1_Click" Height="32px" Font-Size="Large" ForeColor="#003399" CssClass="btn btn-warning" />


    <table class="table table-bordered";style="margin-top:15px">
        <tr >
           
            <th style="text-align: center">AÇIKLAMA</th>
            <th style="text-align: center">  TARİH</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
        <tr>
            <td><%# Eval("ACIKLAMA") %></td>
            <td><%# Eval("TARIH") %></td>
        </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
