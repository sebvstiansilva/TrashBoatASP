<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarEstado.aspx.cs" Inherits="TrashBoatASP.AgregarEstado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 col-sm-12 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Registrar Estado</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="contenedoresDdl">Contenedor</label>
                        <!-- Ddl de contenedores-->
                        <asp:DropDownList ID="contenedoresDdl" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                            runat="server" 
                            ErrorMessage="Debe seleccionar un contenedor." 
                            ControlToValidate="contenedoresDdl" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="fechaLectura">Fecha de Lectura:</label>
                        <!-- Calendario-->
                        <asp:Calendar ID="fechaLectura" runat="server"></asp:Calendar>
                        <asp:CustomValidator ID="fechaLecturaValidator" runat="server" ErrorMessage="Debe seleccionar una fecha"
                            OnServerValidate="fechaLecturaValidator_ServerValidate" CssClass="text-danger"></asp:CustomValidator>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="horaTxt">Hora de Lectura:</label>
                                <asp:TextBox ID="horaTxt" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:CustomValidator ID="horaValidator" runat="server" ErrorMessage="Debe ingresar una hora correcta<br>"
                                    OnServerValidate="horaValidator_ServerValidate" CssClass="text-danger" ValidateEmptyText="true"></asp:CustomValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ErrorMessage="Debe ingresar un numero" ControlToValidate="horaTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col">
                                <label for="minutosTxt">Minutos de Lectura:</label>
                                <asp:TextBox ID="minutosTxt" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:CustomValidator ID="minutoValidator" ValidateEmptyText="true" runat="server" ErrorMessage="Debe ingresar un minuto correcto<br>"
                                    OnServerValidate="minutoValidator_ServerValidate" CssClass="text-danger"></asp:CustomValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ErrorMessage="Debe ingresar un numero" ControlToValidate="minutosTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="nivelLlenadoTxt">Nivel de llenado:</label>
                        <asp:TextBox ID="nivelLlenadoTxt" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:CustomValidator ID="nivelValidator" runat="server" ErrorMessage="Debe ingresar un número correcto" 
                            OnServerValidate="nivelValidator_ServerValidate"
                            CssClass="text-danger"></asp:CustomValidator>
                    </div>
                    <div class="form-group">
                        <label for="tipoDdl">Tipo de Estado:</label>
                        <asp:DropDownList ID="tipoDdl" runat="server" CssClass="form-control">
                            <asp:ListItem Value="1" Text="Cerca del Límite"></asp:ListItem>
                            <asp:ListItem Value="0" Text="OK"></asp:ListItem>
                            <asp:ListItem Value="-1" Text="ERROR"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="card-footer">
                    <asp:Button ID="registrarEstadoBtn" runat="server"
                        Onclick="registrarEstadoBtn_Click"
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
