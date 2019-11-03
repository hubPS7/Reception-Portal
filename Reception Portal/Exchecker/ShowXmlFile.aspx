<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowXmlFile.aspx.cs" Inherits="Exchecker.ShowXmlFile" %>

<%@ Register src="CLocks.ascx" tagname="CLocks" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="content-language" content="cs" />
    <link href="css/screen.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <link href="css/Hiberniapage.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <meta http-equiv="refresh" content="30"/>
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div id="layout">
        <div id="header">
            <center>
                <img src="img/hibernia-networks-logo3.jpg" alt="Hibernia Networks Logo" longdesc="http://www.hibernianetworks.com"
                    style="position: relative; left: 2px; width: 150px; height: 69px; top: 5px;" />
            </center>
        </div>
        <center>
            <div id="main">
                <h2>
                    Welcome to International Exchange Centre</h2>
                <h4>
                    <asp:Label ID="ExchangeCentre" runat="server" Font-Size="XX-Large"></asp:Label></h4>
                <h2>
                    Ongoing Work:</h2>
                <h4>
                    <asp:Label ID="OnGoingWork" runat="server" Font-Size="XX-Large"></asp:Label>
                </h4>
                <h2>
                    Current Building Maintenance:</h2>
                <h4>
                    <asp:Label ID="CurrentBuldngMaintenance" runat="server" Font-Size="XX-Large"></asp:Label></h4>
              <uc1:CLocks ID="CLocks1" runat="server" />
            </div>
        </center>
    </div>
      <br />
        <br />
          <br />
            <br />
              <br />
    <div class="application-footer">
        <div class="application-footerleft">
            <ul>
                <li>© 2013&nbsp; <a href="http://www.hibernianetworks.com" target="_blank">Hibernia
                    Networks</a></ul>
        </div>
        <div class="application-footerright">
            <ul>
                <li>Support:</li>
                <li><a href="https://owa.hiberniaatlantic.com/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fowa.hiberniaatlantic.com%2fowa%2f"
                    target="_blank">Hibernia Web Mail</a></li>
            </ul>
        </div>
    </div>
    </form>
</body>
</html>
