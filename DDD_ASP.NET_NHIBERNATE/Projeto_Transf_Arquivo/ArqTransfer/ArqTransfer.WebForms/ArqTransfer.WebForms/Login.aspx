<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ArqTransfer.WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table width="100%" height="100%">
                <tr> 
                <td width="100%" align="center" valign="middle">
					<table>
						<tr>
							<td align="right">
								<asp:Label ID="lblUserEmail" runat="server"  Text="e-Mail:" CssClass="bold" />
							</td>
							<td>
								<asp:TextBox ID="txtUserEmail" runat="server" MaxLength="255" TabIndex="1" 
                                    class="textEntry" Width="200px" />
							</td>
						</tr>
						<tr>
							<td align="right">
								<asp:Label ID="lblUserPassword" runat="server" Text="Senha:" CssClass="bold" /> 
							</td>
							<td>
								<asp:TextBox ID="txtUserPassword" runat="server" MaxLength="255" TabIndex="2" TextMode="Password"
                                    class="passwordEntry" Width="200px"/>
							</td>
						</tr>
						<tr>
							<td align="right">
	
							</td>
						    <td align="right">
                                <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" TabIndex="3" 
                                    Text="Entrar" />
                            </td>
						</tr>
						<tr>
							<td colspan="2" valign="top" align="left">
							    <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
								    <ProgressTemplate><img src="Images/loading.gif" height="22" width="22" />Carregando...</ProgressTemplate>                                    
                                </asp:UpdateProgress>							
							</td>
						</tr>						
						<tr>
							<td colspan="2" valign="top" align="left">					
							    <asp:Label ID="lblMsg" runat="server" CssClass="failureNotification" /> 
							</td>
						</tr>
						</td></tr>
					</table>
				</table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
