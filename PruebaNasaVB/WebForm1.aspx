<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="PruebaNasaVB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Top 3 Meteoritos</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 270px;
            width: 397px;
        }
        .auto-style2 {
            width: 38%;
            margin-left: 10px;
        }
        .margenes {
            margin-left: 10px;
            margin-right:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Image ID="Image1" runat="server" Height="222px" Width="282px" ImageUrl="~/NASA_logo.png.png"/><br /><br />
            </center>
            
            <asp:Label ID="Label1" runat="server" Text="Introduce el numero de días"></asp:Label>
        </div>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" class="margenes" Width="181px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Obtener" />
        </p>
        
        <table class="auto-style2">
        <tr>
            <td>
                <asp:Panel ID="top1" runat="server" Visible="false">
            <div class="auto-style1" id="div1">
            <asp:Label ID="Label14" runat="server" Text="Top 1" Font-Bold="True" Font-Size="16pt" Height="50px"></asp:Label><br/>
            <asp:Label ID="Label15" runat="server" Text="Nombre" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorn1" runat="server" Text="Valor de nombre" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label17" runat="server" Text="Diametro" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valord1" runat="server" Text="Valor de diametro" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label19" runat="server" Text="Velocidad" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorv1" runat="server" Text="Valor de velocidad" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label21" runat="server" Text="Fecha" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorf1" runat="server" Text="Valor de fecha" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label23" runat="server" Text="Planeta" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorp1" runat="server" Text="Valor de planeta" Height="40px"></asp:Label><br/>
            </div>
                </asp:Panel>
                 
            </td>
            <td>
                <asp:Panel ID="top2" runat="server" Visible="false">
                    <div class="auto-style1" id="div2">
            <asp:Label ID="Label25" runat="server" Text="Top 2" Font-Bold="True" Font-Size="16pt" Height="50px"></asp:Label><br/>
            <asp:Label ID="Label26" runat="server" Text="Nombre" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorn2" runat="server" Text="Valor de nombre" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label28" runat="server" Text="Diametro" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valord2" runat="server" Text="Valor de diametro" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label30" runat="server" Text="Velocidad" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorv2" runat="server" Text="Valor de velocidad" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label32" runat="server" Text="Fecha" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorf2" runat="server" Text="Valor de fecha" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label34" runat="server" Text="Planeta" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorp2" runat="server" Text="Valor de planeta" Height="40px"></asp:Label><br/>
        </div>
                </asp:Panel>
                 
            </td>
            <td>
                <asp:Panel ID="top3" runat="server" Visible="false">
                    <div class="auto-style1">
            <asp:Label ID="Label36" runat="server" Text="Top 3" Font-Bold="True" Font-Size="16pt" Height="50px"></asp:Label><br/>
            <asp:Label ID="Label37" runat="server" Text="Nombre" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorn3" runat="server" Text="Valor de nombre" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label39" runat="server" Text="Diametro" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valord3" runat="server" Text="Valor de diametro" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label41" runat="server" Text="Velocidad" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorv3" runat="server" Text="Valor de velocidad" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label43" runat="server" Text="Fecha" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorf3" runat="server" Text="Valor de fecha" Height="40px"></asp:Label><br/>
            <asp:Label ID="Label45" runat="server" Text="Planeta" Height="40px" Width="120px"></asp:Label>
            <asp:Label ID="valorp3" runat="server" Text="Valor de planeta" Height="40px"></asp:Label><br/>
        </div>
                </asp:Panel>
                
            </td>
        </tr>
        
    </table>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Submit" class="margenes" Visible="False" Width="110px" BackColor="Black" ForeColor="White"/>
            <asp:Button ID="Button3" runat="server" Text="Mostrar datos" CssClass="btn-dark" Visible="False" Width="144px" /><br />
            <asp:Label ID="Label46" runat="server" Text="Errores" Font-Bold="True" ForeColor="#FF3300" Visible="False" class="margenes"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="nombre" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="93px" Visible="False" Width="454px" class="margenes">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" ReadOnly="True" SortExpression="nombre" />
                    <asp:BoundField DataField="diametro" HeaderText="diametro" SortExpression="diametro" />
                    <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                    <asp:BoundField DataField="velocidad" HeaderText="velocidad" SortExpression="velocidad" />
                    <asp:BoundField DataField="planeta" HeaderText="planeta" SortExpression="planeta" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Meteoritos %>" SelectCommand="SELECT * FROM [Meteoro]"></asp:SqlDataSource>
        </p>
        
        
    </form>
    
    
</body>
</html>
