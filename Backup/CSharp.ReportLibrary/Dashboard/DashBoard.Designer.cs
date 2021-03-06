namespace Telerik.Reporting.Examples.CSharp
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    partial class Dashboard
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Telerik.Reporting.NumericalScale numericalScale1 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale1 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup1 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup2 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale2 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale2 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup3 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup4 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale3 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale3 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup5 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup6 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale4 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale4 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup7 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup8 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale5 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale5 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup9 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup10 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale6 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale6 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup11 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup12 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale7 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale7 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup13 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup14 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.CategoryScale categoryScale8 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.NumericalScale numericalScale8 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.NumericalScale numericalScale9 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule6 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector1 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule7 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector2 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule8 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule9 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector3 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule10 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector4 = new Telerik.Reporting.Drawing.DescendantSelector();
            this.detail = new Telerik.Reporting.DetailSection();
            this.testresultDataSource = new Telerik.Reporting.SqlDataSource();
            this.SummeryTestResult = new Telerik.Reporting.TextBox();
            this.quaryareaDataSource = new Telerik.Reporting.SqlDataSource();
            this.txtQuaryArea = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection = new Telerik.Reporting.ReportHeaderSection();
            this.panel5 = new Telerik.Reporting.Panel();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.shape5 = new Telerik.Reporting.Shape();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.graphAxis1 = new Telerik.Reporting.GraphAxis();
            this.graphAxis2 = new Telerik.Reporting.GraphAxis();
            this.polarCoordinateSystem1 = new Telerik.Reporting.PolarCoordinateSystem();
            this.barSeries2 = new Telerik.Reporting.BarSeries();
            this.graphAxis3 = new Telerik.Reporting.GraphAxis();
            this.graphAxis4 = new Telerik.Reporting.GraphAxis();
            this.cartesianCoordinateSystem1 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.barSeries1 = new Telerik.Reporting.BarSeries();
            this.graphAxis5 = new Telerik.Reporting.GraphAxis();
            this.graphAxis6 = new Telerik.Reporting.GraphAxis();
            this.cartesianCoordinateSystem2 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.barSeries3 = new Telerik.Reporting.BarSeries();
            this.graphAxis7 = new Telerik.Reporting.GraphAxis();
            this.graphAxis8 = new Telerik.Reporting.GraphAxis();
            this.polarCoordinateSystem2 = new Telerik.Reporting.PolarCoordinateSystem();
            this.barSeries4 = new Telerik.Reporting.BarSeries();
            this.graphAxis11 = new Telerik.Reporting.GraphAxis();
            this.graphAxis12 = new Telerik.Reporting.GraphAxis();
            this.cartesianCoordinateSystem3 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.barSeries6 = new Telerik.Reporting.BarSeries();
            this.graphAxis9 = new Telerik.Reporting.GraphAxis();
            this.graphAxis10 = new Telerik.Reporting.GraphAxis();
            this.polarCoordinateSystem3 = new Telerik.Reporting.PolarCoordinateSystem();
            this.barSeries5 = new Telerik.Reporting.BarSeries();
            this.graphAxis13 = new Telerik.Reporting.GraphAxis();
            this.graphAxis14 = new Telerik.Reporting.GraphAxis();
            this.polarCoordinateSystem4 = new Telerik.Reporting.PolarCoordinateSystem();
            this.barSeries7 = new Telerik.Reporting.BarSeries();
            this.graphAxis16 = new Telerik.Reporting.GraphAxis();
            this.graphAxis15 = new Telerik.Reporting.GraphAxis();
            this.polarCoordinateSystem5 = new Telerik.Reporting.PolarCoordinateSystem();
            this.graphAxis17 = new Telerik.Reporting.GraphAxis();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.SummeryTestResult,
            this.txtQuaryArea});
            this.detail.Name = "detail";
            // 
            // testresultDataSource
            // 
            this.testresultDataSource.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.testresultDataSource.Name = "testresultDataSource";
            this.testresultDataSource.SelectCommand = "SELECT        Purpose_of_Material, Road_Section, Quarry_Area, Chanage, Latitude, " +
    "Longtiude, Eatimated_Quantiy, Test_Result, Photo\r\nFROM            Summary_Report" +
    "_View";
            // 
            // SummeryTestResult
            // 
            this.SummeryTestResult.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D), Telerik.Reporting.Drawing.Unit.Inch(0.13992126286029816D));
            this.SummeryTestResult.Name = "SummeryTestResult";
            this.SummeryTestResult.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.8120079040527344D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.SummeryTestResult.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.SummeryTestResult.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(100D);
            this.SummeryTestResult.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.SummeryTestResult.StyleName = "legend";
            this.SummeryTestResult.Value = "Summery Test Result";
            // 
            // quaryareaDataSource
            // 
            this.quaryareaDataSource.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.quaryareaDataSource.Name = "quaryareaDataSource";
            this.quaryareaDataSource.SelectCommand = resources.GetString("quaryareaDataSource.SelectCommand");
            // 
            // txtQuaryArea
            // 
            this.txtQuaryArea.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5D), Telerik.Reporting.Drawing.Unit.Inch(0.13992126286029816D));
            this.txtQuaryArea.Name = "txtQuaryArea";
            this.txtQuaryArea.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.1000003814697266D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.txtQuaryArea.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.txtQuaryArea.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(100D);
            this.txtQuaryArea.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.txtQuaryArea.StyleName = "legend";
            this.txtQuaryArea.Value = "Quary Area";
            // 
            // textBox3
            // 
            this.textBox3.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.599921226501465D), Telerik.Reporting.Drawing.Unit.Inch(0.36000001430511475D));
            this.textBox3.Style.BorderColor.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(57)))), ((int)(((byte)(27)))));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.textBox3.TocText = "Top 5 Performing Agents";
            this.textBox3.Value = "Construction Material Reports";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4895833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0.17708373069763184D));
            // 
            // reportHeaderSection
            // 
            this.reportHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.1999999284744263D);
            this.reportHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel5,
            this.textBox3});
            this.reportHeaderSection.Name = "reportHeaderSection";
            this.reportHeaderSection.Style.Visible = true;
            // 
            // panel5
            // 
            this.panel5.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.panel5.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.shape5,
            this.textBox6});
            this.panel5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.panel5.Name = "panel5";
            this.panel5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.599921226501465D), Telerik.Reporting.Drawing.Unit.Mm(20.3179988861084D));
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2124595642089844D), Telerik.Reporting.Drawing.Unit.Inch(0.44492325186729431D));
            this.textBox1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(34D);
            this.textBox1.StyleName = "Header";
            this.textBox1.Value = "Ethiopian Roads Authority";
            // 
            // shape5
            // 
            this.shape5.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.shape5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0026791889686137438D), Telerik.Reporting.Drawing.Unit.Inch(0.60003942251205444D));
            this.shape5.Name = "shape5";
            this.shape5.ShapeType = new Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW);
            this.shape5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.592638969421387D), Telerik.Reporting.Drawing.Unit.Point(3.75D));
            this.shape5.Stretch = true;
            this.shape5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.shape5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.shape5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(3D);
            this.shape5.Style.Color = System.Drawing.Color.Transparent;
            // 
            // textBox6
            // 
            this.textBox6.Anchoring = Telerik.Reporting.AnchoringStyles.Right;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4499607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.22485215961933136D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1199996471405029D), Telerik.Reporting.Drawing.Unit.Inch(0.22011041641235352D));
            this.textBox6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(47)))), ((int)(((byte)(11)))));
            this.textBox6.Style.Font.Name = "Segoe UI";
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox6.Value = "[INTERNAL PURPOSES ONLY]";
            // 
            // graphAxis1
            // 
            this.graphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MajorGridLineStyle.Visible = false;
            this.graphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MinorGridLineStyle.Visible = false;
            this.graphAxis1.Name = "graphAxis1";
            this.graphAxis1.Scale = numericalScale1;
            this.graphAxis1.Style.Visible = false;
            // 
            // graphAxis2
            // 
            this.graphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MajorGridLineStyle.Visible = false;
            this.graphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.Visible = false;
            this.graphAxis2.Name = "graphAxis2";
            categoryScale1.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale1.SpacingSlotCount = 0D;
            this.graphAxis2.Scale = categoryScale1;
            this.graphAxis2.Style.Visible = false;
            // 
            // polarCoordinateSystem1
            // 
            this.polarCoordinateSystem1.AngularAxis = this.graphAxis1;
            this.polarCoordinateSystem1.Name = "polarCoordinateSystem1";
            this.polarCoordinateSystem1.RadialAxis = this.graphAxis2;
            // 
            // barSeries2
            // 
            this.barSeries2.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            graphGroup1.Name = "categoryGroup";
            this.barSeries2.CategoryGroup = graphGroup1;
            this.barSeries2.CoordinateSystem = this.polarCoordinateSystem1;
            this.barSeries2.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries2.DataPointLabelStyle.Visible = false;
            this.barSeries2.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries2.DataPointStyle.Visible = true;
            this.barSeries2.LegendItem.Value = "= Fields.SalesPersonFullName";
            graphGroup2.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.SalesPersonFullName"));
            graphGroup2.Name = "SalesPersonGroup";
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("= Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Desc));
            this.barSeries2.SeriesGroup = graphGroup2;
            this.barSeries2.ToolTip.Text = "=Format(\'Total: ${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries2.ToolTip.Title = "= Fields.SalesPersonFullName";
            this.barSeries2.X = "=Sum(Fields.LineTotal)";
            // 
            // graphAxis3
            // 
            this.graphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MajorGridLineStyle.Visible = false;
            this.graphAxis3.MajorTickMarkDisplayType = Telerik.Reporting.GraphAxisTickMarkDisplayType.Outside;
            this.graphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.Visible = false;
            this.graphAxis3.Name = "graphAxis3";
            this.graphAxis3.Scale = numericalScale2;
            this.graphAxis3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            // 
            // graphAxis4
            // 
            this.graphAxis4.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis4.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis4.MajorGridLineStyle.Visible = false;
            this.graphAxis4.MajorTickMarkDisplayType = Telerik.Reporting.GraphAxisTickMarkDisplayType.None;
            this.graphAxis4.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis4.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis4.MinorGridLineStyle.Visible = false;
            this.graphAxis4.Name = "graphAxis4";
            categoryScale2.SpacingSlotCount = 0.4D;
            this.graphAxis4.Scale = categoryScale2;
            this.graphAxis4.Size = Telerik.Reporting.Drawing.Unit.Inch(1.2999999523162842D);
            this.graphAxis4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.graphAxis4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.graphAxis4.Style.Visible = true;
            // 
            // cartesianCoordinateSystem1
            // 
            this.cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem1.XAxis = this.graphAxis3;
            this.cartesianCoordinateSystem1.YAxis = this.graphAxis4;
            // 
            // barSeries1
            // 
            this.barSeries1.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked;
            graphGroup3.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup3.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.SalesPersonFullName"));
            graphGroup3.Label = "= Fields.SalesPersonFullName";
            graphGroup3.Name = "SalesPersonGroup";
            graphGroup3.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries1.CategoryGroup = graphGroup3;
            this.barSeries1.CoordinateSystem = this.cartesianCoordinateSystem1;
            this.barSeries1.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries1.DataPointLabelStyle.Visible = false;
            this.barSeries1.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries1.DataPointStyle.Visible = true;
            this.barSeries1.LegendItem.Value = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup4.Groupings.Add(new Telerik.Reporting.Grouping("= Quarter(Fields.OrderDate)"));
            graphGroup4.Label = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup4.Name = "OrderDate.QuarterGroup";
            graphGroup4.Sortings.Add(new Telerik.Reporting.Sorting("= Quarter(Fields.OrderDate)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries1.SeriesGroup = graphGroup4;
            this.barSeries1.ToolTip.Text = "=Format(\'${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries1.ToolTip.Title = "=Format(\'Q{0} results for {1}\', Quarter(Fields.OrderDate), Fields.SalesPersonFull" +
    "Name)";
            this.barSeries1.X = "=Sum(Fields.LineTotal)";
            // 
            // graphAxis5
            // 
            this.graphAxis5.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis5.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis5.MajorGridLineStyle.Visible = false;
            this.graphAxis5.MajorTickMarkDisplayType = Telerik.Reporting.GraphAxisTickMarkDisplayType.Outside;
            this.graphAxis5.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis5.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis5.MinorGridLineStyle.Visible = false;
            this.graphAxis5.Name = "graphAxis3";
            this.graphAxis5.Scale = numericalScale3;
            this.graphAxis5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            // 
            // graphAxis6
            // 
            this.graphAxis6.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis6.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis6.MajorGridLineStyle.Visible = false;
            this.graphAxis6.MajorTickMarkDisplayType = Telerik.Reporting.GraphAxisTickMarkDisplayType.None;
            this.graphAxis6.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis6.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis6.MinorGridLineStyle.Visible = false;
            this.graphAxis6.Name = "graphAxis4";
            categoryScale3.SpacingSlotCount = 0.4D;
            this.graphAxis6.Scale = categoryScale3;
            this.graphAxis6.Size = Telerik.Reporting.Drawing.Unit.Inch(1.2999999523162842D);
            this.graphAxis6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.graphAxis6.Style.Visible = true;
            // 
            // cartesianCoordinateSystem2
            // 
            this.cartesianCoordinateSystem2.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem2.XAxis = this.graphAxis5;
            this.cartesianCoordinateSystem2.YAxis = this.graphAxis6;
            // 
            // barSeries3
            // 
            this.barSeries3.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked;
            graphGroup5.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup5.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.StoreName"));
            graphGroup5.Name = "ProductNameGroup";
            graphGroup5.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries3.CategoryGroup = graphGroup5;
            this.barSeries3.CoordinateSystem = this.cartesianCoordinateSystem2;
            this.barSeries3.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries3.DataPointLabelStyle.Visible = false;
            this.barSeries3.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries3.DataPointStyle.Visible = true;
            this.barSeries3.LegendItem.Value = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup6.Groupings.Add(new Telerik.Reporting.Grouping("= Quarter(Fields.OrderDate)"));
            graphGroup6.Label = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup6.Name = "OrderDate.QuarterGroup";
            graphGroup6.Sortings.Add(new Telerik.Reporting.Sorting("= Quarter(Fields.OrderDate)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries3.SeriesGroup = graphGroup6;
            this.barSeries3.ToolTip.Text = "=Format(\'${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries3.ToolTip.Title = "=Format(\'Q{0} results for {1}\', Quarter(Fields.OrderDate), Fields.StoreName)";
            this.barSeries3.X = "=Sum(Fields.LineTotal)";
            // 
            // graphAxis7
            // 
            this.graphAxis7.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis7.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis7.MajorGridLineStyle.Visible = false;
            this.graphAxis7.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis7.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis7.MinorGridLineStyle.Visible = false;
            this.graphAxis7.Name = "graphAxis1";
            this.graphAxis7.Scale = numericalScale4;
            this.graphAxis7.Style.Visible = false;
            // 
            // graphAxis8
            // 
            this.graphAxis8.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis8.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis8.MajorGridLineStyle.Visible = false;
            this.graphAxis8.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis8.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis8.MinorGridLineStyle.Visible = false;
            this.graphAxis8.Name = "graphAxis2";
            categoryScale4.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale4.SpacingSlotCount = 0D;
            this.graphAxis8.Scale = categoryScale4;
            this.graphAxis8.Style.Visible = false;
            // 
            // polarCoordinateSystem2
            // 
            this.polarCoordinateSystem2.AngularAxis = this.graphAxis7;
            this.polarCoordinateSystem2.Name = "polarCoordinateSystem1";
            this.polarCoordinateSystem2.RadialAxis = this.graphAxis8;
            // 
            // barSeries4
            // 
            this.barSeries4.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            graphGroup7.Name = "categoryGroup";
            this.barSeries4.CategoryGroup = graphGroup7;
            this.barSeries4.CoordinateSystem = this.polarCoordinateSystem2;
            this.barSeries4.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries4.DataPointLabelStyle.Visible = false;
            this.barSeries4.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries4.DataPointStyle.Visible = true;
            this.barSeries4.LegendItem.Value = "= Fields.StoreName";
            graphGroup8.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup8.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.StoreName"));
            graphGroup8.Name = "ProductStoreGroup";
            graphGroup8.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Desc));
            this.barSeries4.SeriesGroup = graphGroup8;
            this.barSeries4.ToolTip.Text = "=Format(\'Total: ${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries4.ToolTip.Title = "=Fields.StoreName";
            this.barSeries4.X = "=Sum(Fields.LineTotal)";
            // 
            // graphAxis11
            // 
            this.graphAxis11.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis11.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis11.MajorGridLineStyle.Visible = false;
            this.graphAxis11.MajorTickMarkDisplayType = Telerik.Reporting.GraphAxisTickMarkDisplayType.Outside;
            this.graphAxis11.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis11.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis11.MinorGridLineStyle.Visible = false;
            this.graphAxis11.Name = "graphAxis3";
            this.graphAxis11.Scale = numericalScale5;
            this.graphAxis11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.graphAxis11.TitlePlacement = Telerik.Reporting.GraphAxisTitlePlacement.Auto;
            // 
            // graphAxis12
            // 
            this.graphAxis12.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis12.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis12.MajorGridLineStyle.Visible = false;
            this.graphAxis12.MajorTickMarkDisplayType = Telerik.Reporting.GraphAxisTickMarkDisplayType.None;
            this.graphAxis12.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis12.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis12.MinorGridLineStyle.Visible = false;
            this.graphAxis12.Name = "graphAxis4";
            categoryScale5.SpacingSlotCount = 0.4D;
            this.graphAxis12.Scale = categoryScale5;
            this.graphAxis12.Size = Telerik.Reporting.Drawing.Unit.Inch(1.2999999523162842D);
            this.graphAxis12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.graphAxis12.Style.Visible = true;
            // 
            // cartesianCoordinateSystem3
            // 
            this.cartesianCoordinateSystem3.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem3.XAxis = this.graphAxis11;
            this.cartesianCoordinateSystem3.YAxis = this.graphAxis12;
            // 
            // barSeries6
            // 
            this.barSeries6.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked;
            graphGroup9.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup9.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.ProductName"));
            graphGroup9.Name = "ProductNameGroup";
            graphGroup9.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries6.CategoryGroup = graphGroup9;
            this.barSeries6.CoordinateSystem = this.cartesianCoordinateSystem3;
            this.barSeries6.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries6.DataPointLabelStyle.Visible = false;
            this.barSeries6.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries6.DataPointStyle.Visible = true;
            this.barSeries6.LegendItem.Value = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup10.Groupings.Add(new Telerik.Reporting.Grouping("= Quarter(Fields.OrderDate)"));
            graphGroup10.Label = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup10.Name = "OrderDate.QuarterGroup";
            graphGroup10.Sortings.Add(new Telerik.Reporting.Sorting("= Quarter(Fields.OrderDate)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries6.SeriesGroup = graphGroup10;
            this.barSeries6.ToolTip.Text = "=Format(\'${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries6.ToolTip.Title = "=Format(\'Q{0} results for {1}\', Quarter(Fields.OrderDate), Fields.ProductName)";
            this.barSeries6.X = "=Sum(Fields.LineTotal)";
            // 
            // graphAxis9
            // 
            this.graphAxis9.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis9.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis9.MajorGridLineStyle.Visible = false;
            this.graphAxis9.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis9.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis9.MinorGridLineStyle.Visible = false;
            this.graphAxis9.Name = "graphAxis1";
            this.graphAxis9.Scale = numericalScale6;
            this.graphAxis9.Style.Visible = false;
            // 
            // graphAxis10
            // 
            this.graphAxis10.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis10.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis10.MajorGridLineStyle.Visible = false;
            this.graphAxis10.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis10.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis10.MinorGridLineStyle.Visible = false;
            this.graphAxis10.Name = "graphAxis2";
            categoryScale6.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale6.SpacingSlotCount = 0D;
            this.graphAxis10.Scale = categoryScale6;
            this.graphAxis10.Style.Visible = false;
            // 
            // polarCoordinateSystem3
            // 
            this.polarCoordinateSystem3.AngularAxis = this.graphAxis9;
            this.polarCoordinateSystem3.Name = "polarCoordinateSystem1";
            this.polarCoordinateSystem3.RadialAxis = this.graphAxis10;
            // 
            // barSeries5
            // 
            this.barSeries5.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            graphGroup11.Name = "categoryGroup";
            this.barSeries5.CategoryGroup = graphGroup11;
            this.barSeries5.CoordinateSystem = this.polarCoordinateSystem3;
            this.barSeries5.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries5.DataPointLabelStyle.Visible = false;
            this.barSeries5.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries5.DataPointStyle.Visible = true;
            this.barSeries5.LegendItem.Value = "=Fields.ProductName";
            graphGroup12.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup12.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.ProductName"));
            graphGroup12.Name = "ProductNameGroup";
            graphGroup12.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.ProductName", Telerik.Reporting.SortDirection.Asc));
            this.barSeries5.SeriesGroup = graphGroup12;
            this.barSeries5.ToolTip.Text = "=Format(\'Total: ${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries5.ToolTip.Title = "=Fields.ProductName";
            this.barSeries5.X = "=Sum(Fields.LineTotal)";
            // 
            // graphAxis13
            // 
            this.graphAxis13.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis13.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis13.MajorGridLineStyle.Visible = false;
            this.graphAxis13.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis13.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis13.MinorGridLineStyle.Visible = false;
            this.graphAxis13.Name = "graphAxis1";
            this.graphAxis13.Scale = numericalScale7;
            this.graphAxis13.Style.Visible = false;
            // 
            // graphAxis14
            // 
            this.graphAxis14.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis14.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis14.MajorGridLineStyle.Visible = false;
            this.graphAxis14.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis14.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis14.MinorGridLineStyle.Visible = false;
            this.graphAxis14.Name = "graphAxis2";
            categoryScale7.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale7.SpacingSlotCount = 0D;
            this.graphAxis14.Scale = categoryScale7;
            this.graphAxis14.Style.Visible = false;
            // 
            // polarCoordinateSystem4
            // 
            this.polarCoordinateSystem4.AngularAxis = this.graphAxis13;
            this.polarCoordinateSystem4.Name = "polarCoordinateSystem1";
            this.polarCoordinateSystem4.RadialAxis = this.graphAxis14;
            // 
            // barSeries7
            // 
            this.barSeries7.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            graphGroup13.Name = "categoryGroup";
            this.barSeries7.CategoryGroup = graphGroup13;
            this.barSeries7.CoordinateSystem = this.polarCoordinateSystem4;
            this.barSeries7.DataPointLabelStyle.Visible = false;
            this.barSeries7.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries7.DataPointStyle.Visible = true;
            this.barSeries7.LegendItem.Value = "= Fields.Road_Section";
            this.barSeries7.SeriesGroup = graphGroup14;
            // 
            // graphAxis16
            // 
            this.graphAxis16.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis16.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis16.MajorGridLineStyle.Visible = false;
            this.graphAxis16.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis16.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis16.MinorGridLineStyle.Visible = false;
            this.graphAxis16.Name = "graphAxis16";
            categoryScale8.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale8.SpacingSlotCount = 0D;
            this.graphAxis16.Scale = categoryScale8;
            this.graphAxis16.Style.Visible = false;
            // 
            // graphAxis15
            // 
            this.graphAxis15.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis15.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis15.MajorGridLineStyle.Visible = false;
            this.graphAxis15.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis15.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis15.MinorGridLineStyle.Visible = false;
            this.graphAxis15.Name = "graphAxis15";
            this.graphAxis15.Scale = numericalScale8;
            this.graphAxis15.Style.Visible = false;
            // 
            // polarCoordinateSystem5
            // 
            this.polarCoordinateSystem5.AngularAxis = this.graphAxis16;
            this.polarCoordinateSystem5.Name = "polarCoordinateSystem5";
            this.polarCoordinateSystem5.RadialAxis = this.graphAxis15;
            // 
            // graphAxis17
            // 
            this.graphAxis17.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis17.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis17.MajorGridLineStyle.Visible = false;
            this.graphAxis17.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis17.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis17.MinorGridLineStyle.Visible = false;
            this.graphAxis17.Name = "graphAxis17";
            this.graphAxis17.Scale = numericalScale9;
            this.graphAxis17.Style.Visible = false;
            // 
            // Dashboard
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail,
            this.reportHeaderSection});
            this.Name = "Dashboard";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.AutoRefresh = true;
            reportParameter1.AvailableValues.DisplayMember = "Year";
            reportParameter1.AvailableValues.ValueMember = "Year";
            reportParameter1.Name = "ReportYear";
            reportParameter1.Text = "Sales for Year";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter1.Value = "=2001";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Header")});
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Name = "Segoe UI Light";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextBox))});
            styleRule3.Style.Font.Name = "Segoe UI Light";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(21D);
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("legend")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            styleRule4.Style.Font.Name = "Segoe UI Light";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Solstice.TableNormal")});
            styleRule5.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            styleRule5.Style.Font.Name = "Gill Sans MT";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Solstice.TableBody")});
            styleRule6.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector1});
            styleRule6.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            styleRule6.Style.Font.Name = "Gill Sans MT";
            styleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Solstice.TableHeader")});
            styleRule7.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector2});
            styleRule7.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(39)))), ((int)(((byte)(28)))));
            styleRule7.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            styleRule7.Style.Font.Name = "Gill Sans MT";
            styleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule8.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Aspect.TableNormal")});
            styleRule8.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule8.Style.Color = System.Drawing.Color.Black;
            styleRule8.Style.Font.Name = "Verdana";
            styleRule8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Aspect.TableBody")});
            styleRule9.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector3});
            styleRule9.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule9.Style.Font.Name = "Verdana";
            styleRule9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Aspect.TableHeader")});
            styleRule10.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector4});
            styleRule10.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            styleRule10.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule10.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            styleRule10.Style.Font.Name = "Verdana";
            styleRule10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5,
            styleRule6,
            styleRule7,
            styleRule8,
            styleRule9,
            styleRule10});
            this.TocText = "Dashboard";
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(10.599960327148438D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox5;
        private ReportHeaderSection reportHeaderSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox6;
        private Shape shape5;
        private Reporting.Panel panel5;
        private GraphAxis graphAxis1;
        private GraphAxis graphAxis2;
        private PolarCoordinateSystem polarCoordinateSystem1;
        private BarSeries barSeries2;
        private GraphAxis graphAxis3;
        private GraphAxis graphAxis4;
        private CartesianCoordinateSystem cartesianCoordinateSystem1;
        private BarSeries barSeries1;
        private GraphAxis graphAxis5;
        private GraphAxis graphAxis6;
        private CartesianCoordinateSystem cartesianCoordinateSystem2;
        private BarSeries barSeries3;
        private GraphAxis graphAxis7;
        private GraphAxis graphAxis8;
        private PolarCoordinateSystem polarCoordinateSystem2;
        private BarSeries barSeries4;
        private GraphAxis graphAxis11;
        private GraphAxis graphAxis12;
        private CartesianCoordinateSystem cartesianCoordinateSystem3;
        private BarSeries barSeries6;
        private GraphAxis graphAxis9;
        private GraphAxis graphAxis10;
        private PolarCoordinateSystem polarCoordinateSystem3;
        private BarSeries barSeries5;
        private SqlDataSource testresultDataSource;
        private SqlDataSource quaryareaDataSource;
        private GraphAxis graphAxis13;
        private GraphAxis graphAxis14;
        private PolarCoordinateSystem polarCoordinateSystem4;
        private BarSeries barSeries7;
        private Reporting.TextBox textBox3;
        private Reporting.TextBox SummeryTestResult;
        private Reporting.TextBox txtQuaryArea;
        private GraphAxis graphAxis16;
        private GraphAxis graphAxis15;
        private PolarCoordinateSystem polarCoordinateSystem5;
        private GraphAxis graphAxis17;
    }
}