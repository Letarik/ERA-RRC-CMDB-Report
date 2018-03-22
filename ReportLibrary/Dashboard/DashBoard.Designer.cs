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
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
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
            Telerik.Reporting.NumericalScale numericalScale8 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale8 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup15 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup16 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup1 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphTitle graphTitle1 = new Telerik.Reporting.GraphTitle();
            Telerik.Reporting.NumericalScale numericalScale1 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale1 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup2 = new Telerik.Reporting.GraphGroup();
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
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.panel3 = new Telerik.Reporting.Panel();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.testresultDataSource = new Telerik.Reporting.SqlDataSource();
            this.SummeryTestResult = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
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
            this.quaryareaDataSource = new Telerik.Reporting.SqlDataSource();
            this.graphAxis13 = new Telerik.Reporting.GraphAxis();
            this.graphAxis14 = new Telerik.Reporting.GraphAxis();
            this.polarCoordinateSystem4 = new Telerik.Reporting.PolarCoordinateSystem();
            this.barSeries7 = new Telerik.Reporting.BarSeries();
            this.panel1 = new Telerik.Reporting.Panel();
            this.txtQuaryArea = new Telerik.Reporting.TextBox();
            this.graph1 = new Telerik.Reporting.Graph();
            this.graphAxis15 = new Telerik.Reporting.GraphAxis();
            this.graphAxis16 = new Telerik.Reporting.GraphAxis();
            this.barSeries8 = new Telerik.Reporting.BarSeries();
            this.polarCoordinateSystem5 = new Telerik.Reporting.PolarCoordinateSystem();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(27.937503814697266D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox4.StyleName = "Solstice.TableHeader";
            this.textBox4.Value = "Road Sections";
            // 
            // textBox7
            // 
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(26.879161834716797D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox7.StyleName = "Solstice.TableHeader";
            this.textBox7.Value = "Quarry Area";
            // 
            // textBox8
            // 
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(27.408340454101562D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox8.StyleName = "Solstice.TableHeader";
            this.textBox8.Value = "Purpose of Material";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox9.StyleName = "Solstice.TableHeader";
            this.textBox9.Value = "Eatimated_Quantiy";
            // 
            // textBox10
            // 
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox10.StyleName = "Solstice.TableHeader";
            this.textBox10.Value = "Chanage";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(4.5000004768371582D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel3,
            this.SummeryTestResult,
            this.panel1,
            this.txtQuaryArea});
            this.detail.Name = "detail";
            this.detail.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(5D);
            // 
            // textBox3
            // 
            this.textBox3.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.599960327148438D), Telerik.Reporting.Drawing.Unit.Inch(0.36000001430511475D));
            this.textBox3.Style.BorderColor.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(57)))), ((int)(((byte)(27)))));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.textBox3.TocText = "Top 5 Performing Agents";
            this.textBox3.Value = "Construction Material Reports";
            // 
            // panel3
            // 
            this.panel3.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.panel3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D), Telerik.Reporting.Drawing.Unit.Inch(0.43992128968238831D));
            this.panel3.Name = "panel3";
            this.panel3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.8190512657165527D), Telerik.Reporting.Drawing.Unit.Inch(1.4600790739059448D));
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(27.9375D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(26.8791561126709D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(27.408334732055664D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(19.999998092651367D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(19.999998092651367D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(5D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox12);
            this.table1.Body.SetCellContent(0, 1, this.textBox13);
            this.table1.Body.SetCellContent(0, 2, this.textBox14);
            this.table1.Body.SetCellContent(0, 3, this.textBox15);
            this.table1.Body.SetCellContent(0, 4, this.textBox16);
            tableGroup1.Name = "road_Section";
            tableGroup1.ReportItem = this.textBox4;
            tableGroup2.Name = "quarry_Area";
            tableGroup2.ReportItem = this.textBox7;
            tableGroup3.Name = "purpose_of_Material";
            tableGroup3.ReportItem = this.textBox8;
            tableGroup4.Name = "eatimated_Quantiy";
            tableGroup4.ReportItem = this.textBox9;
            tableGroup5.Name = "chanage";
            tableGroup5.ReportItem = this.textBox10;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.ColumnGroups.Add(tableGroup5);
            this.table1.DataSource = this.testresultDataSource;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox12,
            this.textBox13,
            this.textBox14,
            this.textBox15,
            this.textBox16,
            this.textBox4,
            this.textBox7,
            this.textBox8,
            this.textBox9,
            this.textBox10});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.table1.Name = "table1";
            tableGroup6.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup6.Name = "detail";
            this.table1.RowGroups.Add(tableGroup6);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(122.22499084472656D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.table1.StyleName = "Solstice.TableNormal";
            // 
            // textBox12
            // 
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(27.937503814697266D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox12.StyleName = "Solstice.TableBody";
            this.textBox12.Value = "= Fields.Road_Section";
            // 
            // textBox13
            // 
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(26.879161834716797D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox13.StyleName = "Solstice.TableBody";
            this.textBox13.Value = "= Fields.Quarry_Area";
            // 
            // textBox14
            // 
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(27.408340454101562D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox14.StyleName = "Solstice.TableBody";
            this.textBox14.Value = "= Fields.Purpose_of_Material";
            // 
            // textBox15
            // 
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox15.StyleName = "Solstice.TableBody";
            this.textBox15.Value = "= Fields.Eatimated_Quantiy";
            // 
            // textBox16
            // 
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox16.StyleName = "Solstice.TableBody";
            this.textBox16.Value = "= Fields.Chanage";
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
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4895833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0.17708373069763184D));
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.1999999284744263D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel5,
            this.textBox3});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            this.reportHeaderSection1.Style.Visible = true;
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
            this.panel5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.599960327148438D), Telerik.Reporting.Drawing.Unit.Mm(20.3179988861084D));
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
            this.shape5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.592678070068359D), Telerik.Reporting.Drawing.Unit.Point(3.75D));
            this.shape5.Stretch = true;
            this.shape5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.shape5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.shape5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(3D);
            this.shape5.Style.Color = System.Drawing.Color.Transparent;
            // 
            // textBox6
            // 
            this.textBox6.Anchoring = Telerik.Reporting.AnchoringStyles.Right;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4499998092651367D), Telerik.Reporting.Drawing.Unit.Inch(0.22485215961933136D));
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
            this.graphAxis1.Scale = numericalScale2;
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
            categoryScale2.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale2.SpacingSlotCount = 0D;
            this.graphAxis2.Scale = categoryScale2;
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
            graphGroup3.Name = "categoryGroup";
            this.barSeries2.CategoryGroup = graphGroup3;
            this.barSeries2.CoordinateSystem = this.polarCoordinateSystem1;
            this.barSeries2.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries2.DataPointLabelStyle.Visible = false;
            this.barSeries2.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries2.DataPointStyle.Visible = true;
            this.barSeries2.LegendItem.Value = "= Fields.SalesPersonFullName";
            graphGroup4.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup4.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.SalesPersonFullName"));
            graphGroup4.Name = "SalesPersonGroup";
            graphGroup4.Sortings.Add(new Telerik.Reporting.Sorting("= Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Desc));
            this.barSeries2.SeriesGroup = graphGroup4;
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
            this.graphAxis3.Scale = numericalScale3;
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
            categoryScale3.SpacingSlotCount = 0.4D;
            this.graphAxis4.Scale = categoryScale3;
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
            graphGroup5.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup5.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.SalesPersonFullName"));
            graphGroup5.Label = "= Fields.SalesPersonFullName";
            graphGroup5.Name = "SalesPersonGroup";
            graphGroup5.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries1.CategoryGroup = graphGroup5;
            this.barSeries1.CoordinateSystem = this.cartesianCoordinateSystem1;
            this.barSeries1.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries1.DataPointLabelStyle.Visible = false;
            this.barSeries1.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries1.DataPointStyle.Visible = true;
            this.barSeries1.LegendItem.Value = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup6.Groupings.Add(new Telerik.Reporting.Grouping("= Quarter(Fields.OrderDate)"));
            graphGroup6.Label = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup6.Name = "OrderDate.QuarterGroup";
            graphGroup6.Sortings.Add(new Telerik.Reporting.Sorting("= Quarter(Fields.OrderDate)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries1.SeriesGroup = graphGroup6;
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
            this.graphAxis5.Scale = numericalScale4;
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
            categoryScale4.SpacingSlotCount = 0.4D;
            this.graphAxis6.Scale = categoryScale4;
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
            graphGroup7.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup7.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.StoreName"));
            graphGroup7.Name = "ProductNameGroup";
            graphGroup7.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries3.CategoryGroup = graphGroup7;
            this.barSeries3.CoordinateSystem = this.cartesianCoordinateSystem2;
            this.barSeries3.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries3.DataPointLabelStyle.Visible = false;
            this.barSeries3.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries3.DataPointStyle.Visible = true;
            this.barSeries3.LegendItem.Value = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup8.Groupings.Add(new Telerik.Reporting.Grouping("= Quarter(Fields.OrderDate)"));
            graphGroup8.Label = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup8.Name = "OrderDate.QuarterGroup";
            graphGroup8.Sortings.Add(new Telerik.Reporting.Sorting("= Quarter(Fields.OrderDate)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries3.SeriesGroup = graphGroup8;
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
            this.graphAxis7.Scale = numericalScale5;
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
            categoryScale5.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale5.SpacingSlotCount = 0D;
            this.graphAxis8.Scale = categoryScale5;
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
            graphGroup9.Name = "categoryGroup";
            this.barSeries4.CategoryGroup = graphGroup9;
            this.barSeries4.CoordinateSystem = this.polarCoordinateSystem2;
            this.barSeries4.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries4.DataPointLabelStyle.Visible = false;
            this.barSeries4.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries4.DataPointStyle.Visible = true;
            this.barSeries4.LegendItem.Value = "= Fields.StoreName";
            graphGroup10.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup10.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.StoreName"));
            graphGroup10.Name = "ProductStoreGroup";
            graphGroup10.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Desc));
            this.barSeries4.SeriesGroup = graphGroup10;
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
            this.graphAxis11.Scale = numericalScale6;
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
            categoryScale6.SpacingSlotCount = 0.4D;
            this.graphAxis12.Scale = categoryScale6;
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
            graphGroup11.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup11.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.ProductName"));
            graphGroup11.Name = "ProductNameGroup";
            graphGroup11.Sortings.Add(new Telerik.Reporting.Sorting("=Sum(Fields.LineTotal)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries6.CategoryGroup = graphGroup11;
            this.barSeries6.CoordinateSystem = this.cartesianCoordinateSystem3;
            this.barSeries6.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries6.DataPointLabelStyle.Visible = false;
            this.barSeries6.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries6.DataPointStyle.Visible = true;
            this.barSeries6.LegendItem.Value = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup12.Groupings.Add(new Telerik.Reporting.Grouping("= Quarter(Fields.OrderDate)"));
            graphGroup12.Label = "=\'Q\' + Quarter(Fields.OrderDate)";
            graphGroup12.Name = "OrderDate.QuarterGroup";
            graphGroup12.Sortings.Add(new Telerik.Reporting.Sorting("= Quarter(Fields.OrderDate)", Telerik.Reporting.SortDirection.Asc));
            this.barSeries6.SeriesGroup = graphGroup12;
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
            this.graphAxis9.Scale = numericalScale7;
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
            categoryScale7.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale7.SpacingSlotCount = 0D;
            this.graphAxis10.Scale = categoryScale7;
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
            graphGroup13.Name = "categoryGroup";
            this.barSeries5.CategoryGroup = graphGroup13;
            this.barSeries5.CoordinateSystem = this.polarCoordinateSystem3;
            this.barSeries5.DataPointLabel = "=Sum(Fields.LineTotal)";
            this.barSeries5.DataPointLabelStyle.Visible = false;
            this.barSeries5.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries5.DataPointStyle.Visible = true;
            this.barSeries5.LegendItem.Value = "=Fields.ProductName";
            graphGroup14.Filters.Add(new Telerik.Reporting.Filter("=Sum(Fields.LineTotal)", Telerik.Reporting.FilterOperator.TopN, "=5"));
            graphGroup14.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.ProductName"));
            graphGroup14.Name = "ProductNameGroup";
            graphGroup14.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.ProductName", Telerik.Reporting.SortDirection.Asc));
            this.barSeries5.SeriesGroup = graphGroup14;
            this.barSeries5.ToolTip.Text = "=Format(\'Total: ${0:N2} K\', Sum(Fields.LineTotal))";
            this.barSeries5.ToolTip.Title = "=Fields.ProductName";
            this.barSeries5.X = "=Sum(Fields.LineTotal)";
            // 
            // quaryareaDataSource
            // 
            this.quaryareaDataSource.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.quaryareaDataSource.Name = "quaryareaDataSource";
            this.quaryareaDataSource.SelectCommand = "SELECT        Location.Road_Section, Summary_Report.Quarry_Area\r\nFROM            " +
    "Location INNER JOIN\r\n                         Summary_Report ON Location.ID = Su" +
    "mmary_Report.Location_ID";
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
            this.graphAxis13.Scale = numericalScale8;
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
            categoryScale8.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale8.SpacingSlotCount = 0D;
            this.graphAxis14.Scale = categoryScale8;
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
            graphGroup15.Name = "categoryGroup";
            this.barSeries7.CategoryGroup = graphGroup15;
            this.barSeries7.CoordinateSystem = this.polarCoordinateSystem4;
            this.barSeries7.DataPointLabelStyle.Visible = false;
            this.barSeries7.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries7.DataPointStyle.Visible = true;
            this.barSeries7.LegendItem.Value = "= Fields.Road_Section";
            this.barSeries7.SeriesGroup = graphGroup16;
            // 
            // panel1
            // 
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.graph1});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(127D), Telerik.Reporting.Drawing.Unit.Mm(11.17400074005127D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(4.0600395202636719D));
            // 
            // txtQuaryArea
            // 
            this.txtQuaryArea.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5D), Telerik.Reporting.Drawing.Unit.Inch(0.13992126286029816D));
            this.txtQuaryArea.Name = "txtQuaryArea";
            this.txtQuaryArea.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.txtQuaryArea.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.txtQuaryArea.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(100D);
            this.txtQuaryArea.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.txtQuaryArea.StyleName = "legend";
            this.txtQuaryArea.Value = "Quary Area";
            // 
            // graph1
            // 
            graphGroup1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Quarry_Area"));
            graphGroup1.Name = "quarry_AreaGroup";
            graphGroup1.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Quarry_Area", Telerik.Reporting.SortDirection.Asc));
            this.graph1.CategoryGroups.Add(graphGroup1);
            this.graph1.CoordinateSystems.Add(this.polarCoordinateSystem5);
            this.graph1.DataSource = this.quaryareaDataSource;
            this.graph1.Legend.IsInsidePlotArea = false;
            this.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray;
            this.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(2.5399935245513916D), Telerik.Reporting.Drawing.Unit.Mm(2.5399975776672363D));
            this.graph1.Name = "graph1";
            this.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph1.Series.Add(this.barSeries8);
            this.graph1.SeriesGroups.Add(graphGroup2);
            this.graph1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(132.07998657226563D), Telerik.Reporting.Drawing.Unit.Mm(98.046005249023438D));
            this.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            graphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter;
            graphTitle1.Style.LineColor = System.Drawing.Color.LightGray;
            graphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            graphTitle1.Text = "Road Section";
            this.graph1.Titles.Add(graphTitle1);
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
            this.graphAxis15.Scale = numericalScale1;
            this.graphAxis15.Style.Visible = false;
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
            categoryScale1.PositionMode = Telerik.Reporting.AxisPositionMode.OnTicks;
            categoryScale1.SpacingSlotCount = 0D;
            this.graphAxis16.Scale = categoryScale1;
            this.graphAxis16.Style.Visible = false;
            // 
            // barSeries8
            // 
            this.barSeries8.ArrangeByAxis = this.graphAxis16;
            this.barSeries8.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            this.barSeries8.CategoryGroup = graphGroup1;
            this.barSeries8.CoordinateSystem = this.polarCoordinateSystem5;
            this.barSeries8.DataPointLabel = "= Count(Fields.Road_Section) / CDbl(Exec(\'graph1\', Count(Fields.Road_Section)))";
            this.barSeries8.DataPointLabelFormat = "{0:P}";
            this.barSeries8.DataPointLabelStyle.Visible = false;
            this.barSeries8.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.barSeries8.DataPointStyle.Visible = true;
            this.barSeries8.LegendItem.Value = "= Fields.Road_Section";
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Road_Section"));
            graphGroup2.Name = "road_SectionGroup";
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Road_Section", Telerik.Reporting.SortDirection.Asc));
            this.barSeries8.SeriesGroup = graphGroup2;
            this.barSeries8.ToolTip.Text = "= Format(\'{0:P}\', Count(Fields.Road_Section) / CDbl(Exec(\'graph1\', Count(Fields.R" +
    "oad_Section))))";
            this.barSeries8.ToolTip.Title = "= Fields.Road_Section";
            this.barSeries8.Y = "= Count(Fields.Road_Section)";
            // 
            // polarCoordinateSystem5
            // 
            this.polarCoordinateSystem5.AngularAxis = this.graphAxis16;
            this.polarCoordinateSystem5.Name = "polarCoordinateSystem5";
            this.polarCoordinateSystem5.RadialAxis = this.graphAxis15;
            // 
            // Dashboard
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail,
            this.reportHeaderSection1});
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
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5,
            styleRule6,
            styleRule7});
            this.TocText = "Dashboard";
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(10.59999942779541D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox5;
        private ReportHeaderSection reportHeaderSection1;
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
        private Reporting.Panel panel3;
        private Reporting.TextBox SummeryTestResult;
        private Table table1;
        private Reporting.TextBox textBox12;
        private Reporting.TextBox textBox13;
        private Reporting.TextBox textBox14;
        private Reporting.TextBox textBox15;
        private Reporting.TextBox textBox16;
        private Reporting.TextBox textBox4;
        private Reporting.TextBox textBox7;
        private Reporting.TextBox textBox8;
        private Reporting.TextBox textBox9;
        private Reporting.TextBox textBox10;
        private Reporting.Panel panel1;
        private Reporting.TextBox txtQuaryArea;
        private Graph graph1;
        private GraphAxis graphAxis15;
        private GraphAxis graphAxis16;
        private PolarCoordinateSystem polarCoordinateSystem5;
        private BarSeries barSeries8;
    }
}