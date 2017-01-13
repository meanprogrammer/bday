﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BdayWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <h2>Birthday Randomizer</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <label for="TextBox1"></label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-6">
                 <label for="TextBox2"></label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
