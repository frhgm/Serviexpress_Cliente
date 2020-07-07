<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CapaPresentacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <img src="Content/taller.jpg" class="fondo" alt="Imagen taller">

    <div class="row home divServicio">
        <div class="col-md-3">
            <a>Cambio de aceite</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
        </div>
        <div class="col-md-3">
            <a>Reemplazo Filtros</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
        </div>
        <div class="col-md-3">
            <a>Servicio total</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
        </div>
        <div class="col-md-3">
            <a>Neumaticos de nieve</a>
            <p>
                Agende con nosotros este servicio en una variedad de horarios
            </p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <a class="btn btn-dark btn-block" href="/ReservarHora.aspx">Agendar</a>
        </div>
    </div>

</asp:Content>