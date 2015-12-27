<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pastas.aspx.cs" Inherits="ArqTransfer.WebForms.Pastas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>    
    <table width="100%">
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                           <asp:Button ID="btnNovaPasta" runat="server" Text="Criar Pasta" 
                                onclick="btnNovaPasta_Click" /> 
                        </td>
                        <td>
                            <asp:Label ID="lblNomePasta" runat="server" Text="Pasta:" CssClass="bold" Visible="false" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtNomePasta" runat="server" MaxLength="255" CssClass="textEntry" Width="200px"  Visible="false"/>
                        </td>
                        <td>
                            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Visible="false" 
                                onclick="btnSalvar_Click" /> 
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="false" 
                                onclick="btnCancelar_Click" /> 
                        </td>                        
                    </tr>
                </table>
            </td>
        </tr>						
		<tr>
			<td>					
			    <asp:Label ID="lblMsg" runat="server" CssClass="failureNotification" /> 
			</td>
		</tr>
        <tr><td align=left>
            <asp:GridView ID="gdvItens" runat="server" AutoGenerateColumns="False" 
                GridLines="Horizontal" ShowHeader="False" 
                onrowdatabound="gdvItens_RowDataBound" onrowcommand="gdvItens_RowCommand" OnSelectedIndexChanged="gdvItens_SelectedIndexChanged1">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="imgPastaArquivo" runat="server" CausesValidation="false" 
                                CommandName="PastaArquivo" CommandArgument="<%# Container.DataItemIndex %>" 
                                ImageUrl="~/Images/folder.png" />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" Width="20px" />
                    </asp:TemplateField>                                       
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkPastaArquivo" runat="server" CausesValidation="false" 
                                CommandName="PastaArquivo" CommandArgument="<%# Container.DataItemIndex %>" 
                                Text='<%# Eval("Nome") %>'></asp:LinkButton>
                        </ItemTemplate>
                        <ItemStyle Width="100%" />
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="imgDelete" runat="server" CausesValidation="false" 
                                CommandName="Excluir" CommandArgument="<%# Container.DataItemIndex %>"
                                ImageUrl="~/Images/delete.png" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td></tr>
        <tr>
        <td>
            <table>
                <tr><td>
                    <asp:Label ID="lblUpload" runat="server" Text="Upload:" CssClass="bold"/>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="600" />
                    </td>
                    <td>                                
                        <asp:Button ID="btnUpload" runat="server" Height="22px" onclick="btnUpload_Click" Text="Upload" Width="60px" />
                    </td>
                </tr>                           
            </table>
        </td>
        </tr>
    </table>
    </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnUpload" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
