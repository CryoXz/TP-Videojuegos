<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="PRESENTACION.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title></title>
 
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['bar'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable(<%=ObtenerDatos()%>);

            var options = {
                chart: {
                    <% string fecha = DateTime.Today.Year.ToString(); %>
                    title: 'Ventas del <%=fecha%>',
                    subtitle: 'En pesos',
                }
            };

            var chart = new google.charts.Bar(document.getElementById('columnchart_material'));

            chart.draw(data, google.charts.Bar.convertOptions(options));
        }
    </script>
 
  </head>

<body>
    <form id="form1" runat="server">
        <div>
            <div id="columnchart_material" style="width: 1500px; height: 500px;"></div>
        </div>
    </form>
</body>
</html>
