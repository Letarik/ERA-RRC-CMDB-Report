namespace Telerik.Reporting.Examples.CSharp.ASP.NETDemo
{
    using System;
    using Telerik.Reporting.Examples.CSharp;
    
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                TypeReportSource reportSource = new TypeReportSource();
                reportSource.TypeName = typeof(ReportCatalog).AssemblyQualifiedName;
                this.ReportViewer1.ReportSource = reportSource;
            }
		}
	}
}