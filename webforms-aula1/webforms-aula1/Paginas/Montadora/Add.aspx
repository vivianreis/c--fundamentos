<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="webforms_aula1.Paginas.Montadora.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h1>Montadora</h1>
        <h2>Cadastrar novas montadoras</h2>
    </div>
    <div class="content">
        <div class="pure-form pure-form-stacked">
            <fieldset>
                <legenda>Formulário de cadastro</legenda>

                <label for="email">Nome Montadora:</label>
                <asp:TextBox ID="txtNomeMontadora" runat="server" />
                <asp:Button ID="btnCadastrar" runat="server" CssClass="pure-button pure-button-primary" Text="Salvar" OnClick="btnCadastrar_Click" />

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1"
                    runat="server"
                    ErrorMessage="Campo obrigatório"
                    ControlToValidate="txtNomeMontadora"> 
                </asp:RequiredFieldValidator>

                <asp:Button ID="btnCancelar"
                    runat="server"
                    Text="Cancelar"
                    CausesValidation="false"
                    CssClass="pure-button button-error" />

                <asp:Button ID="btnAdicionar"
                    runat="server"
                    Text="Adicionar"
                    CausesValidation="false"
                    CssClass="pure-button button-secondary" OnClick="btnAdicionar_Click" />

            </fieldset>
        </div>

    </div>
</asp:Content>
