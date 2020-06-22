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
                    </div>
                    <div class="form-group">
                        <label for="fechaLectura">Fecha de Lectura:</label>
                        <!-- Calendario-->
                        <asp:Calendar ID="fechaLectura" runat="server"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="horaTxt">Hora de Lectura:</label>
                                <asp:TextBox ID="horaTxt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col">
                                <label for="minutosTxt">Minutos de Lectura:</label>
                                <asp:TextBox ID="minutosTxt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="nivelLlenadoTxt">Nivel de llenado:</label>
                        <asp:TextBox ID="nivelLlenadoTxt" runat="server" CssClass="form-control"></asp:TextBox>
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
