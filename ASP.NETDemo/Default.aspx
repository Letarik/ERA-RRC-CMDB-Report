﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Telerik.Reporting.Examples.CSharp.ASP.NETDemo.Default" %>

<%@ Register TagPrefix="telerik" Assembly="Telerik.ReportViewer.WebForms" Namespace="Telerik.ReportViewer.WebForms" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" id="html">
<head runat="server">
    <title>Telerik Report Viewer</title>
    <style type="text/css">			
		html#html, body#body, form#form1, div#content, center#center
		{	
			border: 0px solid black;
			padding: 0px;
			margin: 0px;
			height: 100%;
		}
    </style>
</head>
<body id="body">
    <form id="form1" runat="server">              
    <div id="content"><center id="center"><telerik:ReportViewer ID="ReportViewer1" runat="server"  style="border:1px solid #ccc;" 
			width="99%" height="99%"/></center></div>
    </form>
</body>
</html>
