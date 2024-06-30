<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoGallery.aspx.cs" Inherits="PhotoGallery.PhotoGallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Photo Gallery</title>
    <style>
        .gallery-container {
            text-align: center;
            margin: 20px;
        }
        .gallery-image {
            max-width: 80%;
            max-height: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="gallery-container">
            <asp:Image ID="imgPhoto" runat="server" CssClass="gallery-image" />
            <br />
            <asp:Label ID="lblFileName" runat="server"></asp:Label>
            <br /><br />
            <asp:Button ID="btnFirst" runat="server" Text="First" OnClick="btnFirst_Click" />
            <asp:Button ID="btnPrevious" runat="server" Text="Previous" OnClick="btnPrevious_Click" />
            <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />
            <asp:Button ID="btnLast" runat="server" Text="Last" OnClick="btnLast_Click" />
        </div>
    </form>
</body>
</html>
