<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarEstados.aspx.cs" Inherits="TrashBoatASP.MostrarEstados" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Mostrar Lecturas</h1>
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-md-6 col-sm-12 mx-auto">
                <%--<div class="mx-5 mb-5">
                    <label for="filtroContenedorDdl">Filtrar por Contenedor:</label>
                    <asp:DropDownList 
                        AutoPostBack="true"
                        ID="filtroContenedorDdl"
                        runat="server"
                        OnSelectedIndexChanged="filtroContenedorDdl_SelectedIndexChanged"
                        CssClass="form-control" />
                </div>--%>
                <asp:Chart ID="Chart1" runat="server" Width="500px" DataSourceID="ObjectDataSource1">
                    <Series>
                        <asp:Series Name="Series1" ChartType="Spline" XValueMember="FechaLectura" YValueMembers="NivelDeLlenado"></asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
                <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="GetAll" TypeName="TrashBoatModel.DAL.EstadoDAL">
                </asp:ObjectDataSource>
            </div>
        </div>
    </div>
</asp:Content>
