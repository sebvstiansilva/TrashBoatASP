<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="DetalleContenedores.aspx.cs" Inherits="TrashBoatASP.DetalleContenedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle Contenedores</h1>
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-md-6 col-sm-12 mx-auto">
                <div class="mx-5 mb-5">
                    <label for="filtroDdl">Filtrar por Región:</label>
                    <asp:DropDownList 
                        AutoPostBack="true"
                        ID="filtroDdl"
                        runat="server"
                        OnSelectedIndexChanged="filtroDdl_SelectedIndexChanged"
                        CssClass="form-control" />
                </div>
                <asp:GridView 
                    AutoGenerateColumns="false"
                    EmptyDataText="No se han encontrado registro de contenedores."
                    runat="server"
                    ID="contenedoresGrid"
                    CssClass="table table-hover table-bordered table-dark">
                    <Columns>
                        <asp:BoundField HeaderText="Número de Serie" DataField="NumeroDeSerie" />
                        <asp:BoundField HeaderText="Región" DataField="Region" />
                        <asp:BoundField HeaderText="Sede" DataField="Sede.Nombre" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
