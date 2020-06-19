<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarContenedor.aspx.cs" Inherits="TrashBoatASP.AgregarContenedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 col-md-6 col-sm-12 mx-auto">
            <div class="card card border-primary mb-3">
                <div class="card-header bg-dark text-white text-white" >
                    <h3>Agregar Contenedor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="numeroSerieTxt">Número de Serie: </label>
                        <asp:TextBox 
                            ID="numeroSerieTxt" 
                            runat="server" 
                            CssClass="form-control"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator 
                            ControlToValidate="numeroSerieTxt"
                            ID="numeroSerieValidator" 
                            runat="server" 
                            ErrorMessage="Debe ingresar un numero de serie"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="nivelLlenadoTxt">Nivel de llenado: </label>
                        <asp:TextBox
                            ID="nivelLlenadoTxt"
                            runat="server"
                            CssClass="form-control"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator
                            ControlToValidate="nivelLlenadoTxt"
                            ID="nivelLlenadoValidator"
                            runat="server"
                            ErrorMessage="Debe ingresar nivel de llenado"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="regionDdl">Region: </label>
                        <asp:DropDownList ID="regionDdl"
                             runat="server"
                            CssClass="form-control">
                            <asp:ListItem Value="Región Arica y Parinacota" Text="Región de Arica y Parinacota"></asp:ListItem>
                            <asp:ListItem Value="Región de Tarapacá" Text="Región de Tarapacá"></asp:ListItem>
                            <asp:ListItem Value="Región de Antofagasta" Text="Region de Antofagasta"></asp:ListItem>
                            <asp:ListItem Value="Región de Atacama" Text="Región de Atacama"></asp:ListItem>
                            <asp:ListItem Value="Región de Coquimbo" Text="Region de Coquimbo"></asp:ListItem>
                            <asp:ListItem Value="Región de Valparaíso" Text="Region de Valparaíso"></asp:ListItem>
                            <asp:ListItem Value="Región Metropolitana" Text="Region Metropolitana"></asp:ListItem>
                            <asp:ListItem Value="Región del Libertador Bernardo O'higgins" Text="Región del Libertador Bernardo O'higgins"></asp:ListItem>
                            <asp:ListItem Value="Región del Maule" Text="Region del Maule"></asp:ListItem>
                            <asp:ListItem Value="Región del Ñuble" Text="Region del Ñuble"></asp:ListItem>
                            <asp:ListItem Value="Región del Bio Bío" Text="Region del Bio Bío"></asp:ListItem>
                            <asp:ListItem Value="Región de la Araucanía" Text="Region de la Araucanía"></asp:ListItem>
                            <asp:ListItem Value="Región de los Ríos" Text="Region de los Ríos"></asp:ListItem>
                            <asp:ListItem Value="Región del los Lagos" Text="Region de los Lagos"></asp:ListItem>
                            <asp:ListItem Value="Región de Aysén del General Carlos Ibáñez del Campo" Text="Región de Aysén del General Carlos Ibáñez del Campo"></asp:ListItem>
                            <asp:ListItem Value="Región de Magallanes y de la Antártica Chilena" Text="Region de Magallanes y de la Antártica Chilena"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="sedeDdl">Sede: </label>
                        <asp:DropDownList ID="sedeDdl" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="estadoDdl">Estado: </label>
                        <asp:DropDownList ID="estadoDdl" runat="server" CssClass="form-control">
                            <asp:ListItem Value="1" Text="Cerca del Límite"></asp:ListItem>
                            <asp:ListItem Value="0" Text="OK"></asp:ListItem>
                            <asp:ListItem Value="-1" Text="ERROR"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="card-footer">
                    <asp:Button ID="registrarContenedorBtn" runat="server"
                        Onclick="registrarContenedorBtn_Click"
                        CssClass="btn btn-sm btn-primary float-right"
                        Text="Agregar" />
                    <asp:Button ID="limpiarBtn" runat="server"
                        CssClass="btn btn-sm btn-outline-primary float-right mr-2"
                        Text="Limpiar" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
