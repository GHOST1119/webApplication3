<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication3.account.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Profile</h1>
        <br />
        <div class="row">
            <div class="col-sm-4" style="background-color: lavender;">
                <br />
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="name">Name:</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtname" placeholder="Enter Name" name="name">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="Lphone">Landline Phone:</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="txtLphone" placeholder="Enter Landline Phone" name="Lphone">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="address">Address:</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="txtaddress" placeholder="Enter Address" name="address">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="Ptype">Person Type:</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="txtPtype" placeholder="Enter Person Type" name="Ptype">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="Cname">Company Name:</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="txtCname" placeholder="Enter Company Name" name="Cname">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="Afield">Activity Field:</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="txtAfield" placeholder="Enter Activity Field" name="Afield">
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <button type="submit" class="btn btn-default">Submit</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-4" style="background-color: lavenderblush; text-align: center">
                <br />
                <div>
                    <img src="../img/favorite.png" class="img-circle" alt="Cinque Terre" width="304" height="236">
                </div>
                <br />
                <div>
                    <span style="font-size:large" class="label label-primary">username</span><br />
                    <br />
                    <span style="font-size:large" class="label label-primary">email</span><br />
                    <br />
                    <span style="font-size:large" class="label label-primary">phone</span>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
