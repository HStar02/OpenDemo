namespace EndDemo_02
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new Sunny.UI.UIPanel();
            this.grpImageShow = new Sunny.UI.UIGroupBox();
            this.grpRealTimeImage = new Sunny.UI.UIGroupBox();
            this.picRealTime = new System.Windows.Forms.PictureBox();
            this.grpWorkImage = new Sunny.UI.UIGroupBox();
            this.picWorkImage = new System.Windows.Forms.PictureBox();
            this.tabMain = new Sunny.UI.UITabControl();
            this.tabMotion = new System.Windows.Forms.TabPage();
            this.grpInitParam = new Sunny.UI.UIGroupBox();
            this.txtInitSpeed = new Sunny.UI.UITextBox();
            this.txtMaxSpeed = new Sunny.UI.UITextBox();
            this.txtAccTime = new Sunny.UI.UITextBox();
            this.txtDecTime = new Sunny.UI.UITextBox();
            this.txtSTime = new Sunny.UI.UITextBox();
            this.txtStopSpeed = new Sunny.UI.UITextBox();
            this.lblInitSpeed = new Sunny.UI.UILabel();
            this.lblMaxSpeed = new Sunny.UI.UILabel();
            this.lblAccTime = new Sunny.UI.UILabel();
            this.lblDecTime = new Sunny.UI.UILabel();
            this.lblSTime = new Sunny.UI.UILabel();
            this.lblStopSpeed = new Sunny.UI.UILabel();
            this.grpSpeedMode = new Sunny.UI.UIGroupBox();
            this.rdoSType = new Sunny.UI.UIRadioButton();
            this.rdoTType = new Sunny.UI.UIRadioButton();
            this.grpInterpTest = new Sunny.UI.UIGroupBox();
            this.lblInterpX = new Sunny.UI.UILabel();
            this.txtInterpX = new Sunny.UI.UITextBox();
            this.lblInterpY = new Sunny.UI.UILabel();
            this.txtInterpY = new Sunny.UI.UITextBox();
            this.lblInterpZ = new Sunny.UI.UILabel();
            this.txtInterpZ = new Sunny.UI.UITextBox();
            this.btnLineInterp = new Sunny.UI.UIButton();
            this.btnArcInterp = new Sunny.UI.UIButton();
            this.grpManual = new Sunny.UI.UIGroupBox();
            this.btnAxisUp1 = new Sunny.UI.UISymbolButton();
            this.btnAxisUp2 = new Sunny.UI.UISymbolButton();
            this.btnAxisLeft = new Sunny.UI.UISymbolButton();
            this.btnAxisStop = new Sunny.UI.UISymbolButton();
            this.btnAxisRight = new Sunny.UI.UISymbolButton();
            this.btnAxisDown1 = new Sunny.UI.UISymbolButton();
            this.btnAxisDown2 = new Sunny.UI.UISymbolButton();
            this.btnAxisStopHome = new Sunny.UI.UISymbolButton();
            this.btnAxisRotateCcw = new Sunny.UI.UISymbolButton();
            this.btnAxisRotateCw = new Sunny.UI.UISymbolButton();
            this.grpRecordPos = new Sunny.UI.UIGroupBox();
            this.btnRecord0 = new Sunny.UI.UIButton();
            this.btnRecord1 = new Sunny.UI.UIButton();
            this.btnRecord2 = new Sunny.UI.UIButton();
            this.btnRecord3 = new Sunny.UI.UIButton();
            this.btnRecord4 = new Sunny.UI.UIButton();
            this.btnRecord5 = new Sunny.UI.UIButton();
            this.btnRecord6 = new Sunny.UI.UIButton();
            this.btnRecord7 = new Sunny.UI.UIButton();
            this.btnRecord8 = new Sunny.UI.UIButton();
            this.grpControlCfg = new Sunny.UI.UIGroupBox();
            this.chkAxisX = new Sunny.UI.UICheckBox();
            this.chkAxisY = new Sunny.UI.UICheckBox();
            this.chkAxisZ = new Sunny.UI.UICheckBox();
            this.grpHomeSpeed = new Sunny.UI.UIGroupBox();
            this.rdoHomeSpeedLow = new Sunny.UI.UIRadioButton();
            this.rdoHomeSpeedHigh = new Sunny.UI.UIRadioButton();
            this.grpHomeDir = new Sunny.UI.UIGroupBox();
            this.rdoHomeDirPos = new Sunny.UI.UIRadioButton();
            this.rdoHomeDirNeg = new Sunny.UI.UIRadioButton();
            this.lblHomeMode = new Sunny.UI.UILabel();
            this.cmbHomeMode = new Sunny.UI.UIComboBox();
            this.btnHome = new Sunny.UI.UIButton();
            this.grpOnlineMove = new Sunny.UI.UIGroupBox();
            this.btnAbsPos = new Sunny.UI.UIButton();
            this.txtAbsPos = new Sunny.UI.UITextBox();
            this.btnChgSpeed = new Sunny.UI.UIButton();
            this.txtChgSpeed = new Sunny.UI.UITextBox();
            this.btnChgPos = new Sunny.UI.UIButton();
            this.txtChgPos = new Sunny.UI.UITextBox();
            this.grpOnlineOffset = new Sunny.UI.UIGroupBox();
            this.btnOffsetX = new Sunny.UI.UIButton();
            this.txtOffsetX = new Sunny.UI.UITextBox();
            this.btnOffsetY = new Sunny.UI.UIButton();
            this.txtOffsetY = new Sunny.UI.UITextBox();
            this.tabCalib = new System.Windows.Forms.TabPage();
            this.grpImageProc = new Sunny.UI.UIGroupBox();
            this.btnMoveToShot = new Sunny.UI.UIButton();
            this.btnFlowArrow1 = new Sunny.UI.UISymbolButton();
            this.btnCapture = new Sunny.UI.UIButton();
            this.btnFlowArrow2 = new Sunny.UI.UISymbolButton();
            this.btnExtractNine = new Sunny.UI.UIButton();
            this.btnFlowArrow3 = new Sunny.UI.UISymbolButton();
            this.btnStartCalib = new Sunny.UI.UIButton();
            this.btnFlowArrow4 = new Sunny.UI.UISymbolButton();
            this.btnSaveCalib = new Sunny.UI.UIButton();
            this.blkMean = new Sunny.UI.UIPanel();
            this.btnWriteMean = new Sunny.UI.UIButton();
            this.lblMeanCap = new Sunny.UI.UILabel();
            this.trbMean = new Sunny.UI.UITrackBar();
            this.txtMean = new Sunny.UI.UITextBox();
            this.blkDyn = new Sunny.UI.UIPanel();
            this.btnWriteDyn = new Sunny.UI.UIButton();
            this.lblDynCap = new Sunny.UI.UILabel();
            this.trbDyn = new Sunny.UI.UITrackBar();
            this.txtDyn = new Sunny.UI.UITextBox();
            this.blkAreaMax = new Sunny.UI.UIPanel();
            this.btnWriteAreaMax = new Sunny.UI.UIButton();
            this.lblAreaMaxCap = new Sunny.UI.UILabel();
            this.trbAreaMax = new Sunny.UI.UITrackBar();
            this.txtAreaMax = new Sunny.UI.UITextBox();
            this.blkAreaMin = new Sunny.UI.UIPanel();
            this.btnWriteAreaMin = new Sunny.UI.UIButton();
            this.lblAreaMinCap = new Sunny.UI.UILabel();
            this.trbAreaMin = new Sunny.UI.UITrackBar();
            this.txtAreaMin = new Sunny.UI.UITextBox();
            this.grpPixelCoord = new Sunny.UI.UIGroupBox();
            this.lblColHeader = new Sunny.UI.UILabel();
            this.lblRowHeader = new Sunny.UI.UILabel();
            this.lblPixPoint0 = new Sunny.UI.UILabel();
            this.txtPixCol0 = new Sunny.UI.UITextBox();
            this.txtPixRow0 = new Sunny.UI.UITextBox();
            this.lblPixPoint1 = new Sunny.UI.UILabel();
            this.txtPixCol1 = new Sunny.UI.UITextBox();
            this.txtPixRow1 = new Sunny.UI.UITextBox();
            this.lblPixPoint2 = new Sunny.UI.UILabel();
            this.txtPixCol2 = new Sunny.UI.UITextBox();
            this.txtPixRow2 = new Sunny.UI.UITextBox();
            this.lblPixPoint3 = new Sunny.UI.UILabel();
            this.txtPixCol3 = new Sunny.UI.UITextBox();
            this.txtPixRow3 = new Sunny.UI.UITextBox();
            this.lblPixPoint4 = new Sunny.UI.UILabel();
            this.txtPixCol4 = new Sunny.UI.UITextBox();
            this.txtPixRow4 = new Sunny.UI.UITextBox();
            this.lblPixPoint5 = new Sunny.UI.UILabel();
            this.txtPixCol5 = new Sunny.UI.UITextBox();
            this.txtPixRow5 = new Sunny.UI.UITextBox();
            this.lblPixPoint6 = new Sunny.UI.UILabel();
            this.txtPixCol6 = new Sunny.UI.UITextBox();
            this.txtPixRow6 = new Sunny.UI.UITextBox();
            this.lblPixPoint7 = new Sunny.UI.UILabel();
            this.txtPixCol7 = new Sunny.UI.UITextBox();
            this.txtPixRow7 = new Sunny.UI.UITextBox();
            this.lblPixPoint8 = new Sunny.UI.UILabel();
            this.txtPixCol8 = new Sunny.UI.UITextBox();
            this.txtPixRow8 = new Sunny.UI.UITextBox();
            this.btnSavePixel = new Sunny.UI.UIButton();
            this.btnReadPixel = new Sunny.UI.UIButton();
            this.grpRobotCoord = new Sunny.UI.UIGroupBox();
            this.lblXHeader = new Sunny.UI.UILabel();
            this.lblYHeader = new Sunny.UI.UILabel();
            this.lblRobotPoint0 = new Sunny.UI.UILabel();
            this.txtRobotX0 = new Sunny.UI.UITextBox();
            this.txtRobotY0 = new Sunny.UI.UITextBox();
            this.lblRobotPoint1 = new Sunny.UI.UILabel();
            this.txtRobotX1 = new Sunny.UI.UITextBox();
            this.txtRobotY1 = new Sunny.UI.UITextBox();
            this.lblRobotPoint2 = new Sunny.UI.UILabel();
            this.txtRobotX2 = new Sunny.UI.UITextBox();
            this.txtRobotY2 = new Sunny.UI.UITextBox();
            this.lblRobotPoint3 = new Sunny.UI.UILabel();
            this.txtRobotX3 = new Sunny.UI.UITextBox();
            this.txtRobotY3 = new Sunny.UI.UITextBox();
            this.lblRobotPoint4 = new Sunny.UI.UILabel();
            this.txtRobotX4 = new Sunny.UI.UITextBox();
            this.txtRobotY4 = new Sunny.UI.UITextBox();
            this.lblRobotPoint5 = new Sunny.UI.UILabel();
            this.txtRobotX5 = new Sunny.UI.UITextBox();
            this.txtRobotY5 = new Sunny.UI.UITextBox();
            this.lblRobotPoint6 = new Sunny.UI.UILabel();
            this.txtRobotX6 = new Sunny.UI.UITextBox();
            this.txtRobotY6 = new Sunny.UI.UITextBox();
            this.lblRobotPoint7 = new Sunny.UI.UILabel();
            this.txtRobotX7 = new Sunny.UI.UITextBox();
            this.txtRobotY7 = new Sunny.UI.UITextBox();
            this.lblRobotPoint8 = new Sunny.UI.UILabel();
            this.txtRobotX8 = new Sunny.UI.UITextBox();
            this.txtRobotY8 = new Sunny.UI.UITextBox();
            this.btnSaveRobot = new Sunny.UI.UIButton();
            this.btnReadRobot = new Sunny.UI.UIButton();
            this.tabLocate = new System.Windows.Forms.TabPage();
            this.grpLocateMode = new Sunny.UI.UIGroupBox();
            this.rdoBlobAnalysis = new Sunny.UI.UIRadioButton();
            this.rdoTemplateMatch = new Sunny.UI.UIRadioButton();
            this.pnlBlobParam = new Sunny.UI.UIPanel();
            this.blkMeanTh = new Sunny.UI.UIPanel();
            this.blkAreaMaxTh = new Sunny.UI.UIPanel();
            this.blkDynTh = new Sunny.UI.UIPanel();
            this.blkAreaMinTh = new Sunny.UI.UIPanel();
            this.trbMeanTh = new Sunny.UI.UITrackBar();
            this.txtMeanTh = new Sunny.UI.UITextBox();
            this.trbAreaMaxTh = new Sunny.UI.UITrackBar();
            this.txtAreaMaxTh = new Sunny.UI.UITextBox();
            this.rdoColorBlack = new Sunny.UI.UIRadioButton();
            this.trbDynTh = new Sunny.UI.UITrackBar();
            this.txtDynTh = new Sunny.UI.UITextBox();
            this.trbAreaMinTh = new Sunny.UI.UITrackBar();
            this.txtAreaMinTh = new Sunny.UI.UITextBox();
            this.rdoColorWhite = new Sunny.UI.UIRadioButton();
            this.pnlTemplateParam = new Sunny.UI.UIPanel();
            this.blkTplContrast = new Sunny.UI.UIPanel();
            this.blkProdContrast = new Sunny.UI.UIPanel();
            this.blkMinScore = new Sunny.UI.UIPanel();
            this.blkGreedy = new Sunny.UI.UIPanel();
            this.blkCover = new Sunny.UI.UIPanel();
            this.trbTplContrast = new Sunny.UI.UITrackBar();
            this.txtTplContrast = new Sunny.UI.UITextBox();
            this.trbProdContrast = new Sunny.UI.UITrackBar();
            this.txtProdContrast = new Sunny.UI.UITextBox();
            this.btnCreateTemplate = new Sunny.UI.UIButton();
            this.trbMinScore = new Sunny.UI.UITrackBar();
            this.txtMinScore = new Sunny.UI.UITextBox();
            this.chkAuto = new Sunny.UI.UICheckBox();
            this.lblMaterialCount = new Sunny.UI.UILabel();
            this.txtMaterialCount = new Sunny.UI.UITextBox();
            this.trbGreedy = new Sunny.UI.UITrackBar();
            this.txtGreedy = new Sunny.UI.UITextBox();
            this.trbCover = new Sunny.UI.UITrackBar();
            this.txtCover = new Sunny.UI.UITextBox();
            this.btnTemplateMatch = new Sunny.UI.UIButton();
            this.btnMoveToBase = new Sunny.UI.UIButton();
            this.btnFlowRight1 = new Sunny.UI.UISymbolButton();
            this.btnRecognize = new Sunny.UI.UIButton();
            this.btnFlowRight2 = new Sunny.UI.UISymbolButton();
            this.btnAnyGrab = new Sunny.UI.UIButton();
            this.tabTrace = new System.Windows.Forms.TabPage();
            this.rdoCollectContour = new Sunny.UI.UIRadioButton();
            this.rdoImportCad = new Sunny.UI.UIRadioButton();
            this.btnLoadImage = new Sunny.UI.UIButton();
            this.pnlContourA = new Sunny.UI.UIPanel();
            this.picContourA = new System.Windows.Forms.PictureBox();
            this.btnExtractContour = new Sunny.UI.UIButton();
            this.pnlContourB = new Sunny.UI.UIPanel();
            this.picContourB = new System.Windows.Forms.PictureBox();
            this.btnAutoDraw = new Sunny.UI.UIButton();
            this.tabIO = new System.Windows.Forms.TabPage();
            this.btnTestVacuum = new Sunny.UI.UIButton();
            this.grpAxisSignal = new Sunny.UI.UIGroupBox();
            this.lblSignal0 = new Sunny.UI.UILabel();
            this.lblSignal1 = new Sunny.UI.UILabel();
            this.lblSignal2 = new Sunny.UI.UILabel();
            this.lblSignal3 = new Sunny.UI.UILabel();
            this.lblSignal4 = new Sunny.UI.UILabel();
            this.lblSignal5 = new Sunny.UI.UILabel();
            this.lblSignal6 = new Sunny.UI.UILabel();
            this.lblSignal7 = new Sunny.UI.UILabel();
            this.lblAxisRowX = new Sunny.UI.UILabel();
            this.ledXAxis0 = new Sunny.UI.UIPanel();
            this.ledXAxis1 = new Sunny.UI.UIPanel();
            this.ledXAxis2 = new Sunny.UI.UIPanel();
            this.ledXAxis3 = new Sunny.UI.UIPanel();
            this.ledXAxis4 = new Sunny.UI.UIPanel();
            this.ledXAxis5 = new Sunny.UI.UIPanel();
            this.ledXAxis6 = new Sunny.UI.UIPanel();
            this.ledXAxis7 = new Sunny.UI.UIPanel();
            this.lblAxisRowY = new Sunny.UI.UILabel();
            this.ledYAxis0 = new Sunny.UI.UIPanel();
            this.ledYAxis1 = new Sunny.UI.UIPanel();
            this.ledYAxis2 = new Sunny.UI.UIPanel();
            this.ledYAxis3 = new Sunny.UI.UIPanel();
            this.ledYAxis4 = new Sunny.UI.UIPanel();
            this.ledYAxis5 = new Sunny.UI.UIPanel();
            this.ledYAxis6 = new Sunny.UI.UIPanel();
            this.ledYAxis7 = new Sunny.UI.UIPanel();
            this.lblAxisRowZ = new Sunny.UI.UILabel();
            this.ledZAxis0 = new Sunny.UI.UIPanel();
            this.ledZAxis1 = new Sunny.UI.UIPanel();
            this.ledZAxis2 = new Sunny.UI.UIPanel();
            this.ledZAxis3 = new Sunny.UI.UIPanel();
            this.ledZAxis4 = new Sunny.UI.UIPanel();
            this.ledZAxis5 = new Sunny.UI.UIPanel();
            this.ledZAxis6 = new Sunny.UI.UIPanel();
            this.ledZAxis7 = new Sunny.UI.UIPanel();
            this.lblAxisRowR = new Sunny.UI.UILabel();
            this.ledRAxis0 = new Sunny.UI.UIPanel();
            this.ledRAxis1 = new Sunny.UI.UIPanel();
            this.ledRAxis2 = new Sunny.UI.UIPanel();
            this.ledRAxis3 = new Sunny.UI.UIPanel();
            this.ledRAxis4 = new Sunny.UI.UIPanel();
            this.ledRAxis5 = new Sunny.UI.UIPanel();
            this.ledRAxis6 = new Sunny.UI.UIPanel();
            this.ledRAxis7 = new Sunny.UI.UIPanel();
            this.grpGeneralIn = new Sunny.UI.UIGroupBox();
            this.pnlIn1 = new Sunny.UI.UIPanel();
            this.lblIn0 = new Sunny.UI.UILabel();
            this.ledIn0 = new Sunny.UI.UIPanel();
            this.lblIn1 = new Sunny.UI.UILabel();
            this.ledIn1 = new Sunny.UI.UIPanel();
            this.lblIn2 = new Sunny.UI.UILabel();
            this.ledIn2 = new Sunny.UI.UIPanel();
            this.lblIn3 = new Sunny.UI.UILabel();
            this.ledIn3 = new Sunny.UI.UIPanel();
            this.pnlIn2 = new Sunny.UI.UIPanel();
            this.lblIn4 = new Sunny.UI.UILabel();
            this.ledIn4 = new Sunny.UI.UIPanel();
            this.lblIn5 = new Sunny.UI.UILabel();
            this.ledIn5 = new Sunny.UI.UIPanel();
            this.lblIn6 = new Sunny.UI.UILabel();
            this.ledIn6 = new Sunny.UI.UIPanel();
            this.lblIn7 = new Sunny.UI.UILabel();
            this.ledIn7 = new Sunny.UI.UIPanel();
            this.pnlIn3 = new Sunny.UI.UIPanel();
            this.lblIn8 = new Sunny.UI.UILabel();
            this.ledIn8 = new Sunny.UI.UIPanel();
            this.lblIn9 = new Sunny.UI.UILabel();
            this.ledIn9 = new Sunny.UI.UIPanel();
            this.lblIn10 = new Sunny.UI.UILabel();
            this.ledIn10 = new Sunny.UI.UIPanel();
            this.lblIn11 = new Sunny.UI.UILabel();
            this.ledIn11 = new Sunny.UI.UIPanel();
            this.pnlIn4 = new Sunny.UI.UIPanel();
            this.lblIn12 = new Sunny.UI.UILabel();
            this.ledIn12 = new Sunny.UI.UIPanel();
            this.lblIn13 = new Sunny.UI.UILabel();
            this.ledIn13 = new Sunny.UI.UIPanel();
            this.lblIn14 = new Sunny.UI.UILabel();
            this.ledIn14 = new Sunny.UI.UIPanel();
            this.lblIn15 = new Sunny.UI.UILabel();
            this.ledIn15 = new Sunny.UI.UIPanel();
            this.grpGeneralOut = new Sunny.UI.UIGroupBox();
            this.pnlOut1 = new Sunny.UI.UIPanel();
            this.lblOut0 = new Sunny.UI.UILabel();
            this.ledOut0 = new Sunny.UI.UIPanel();
            this.lblOut1 = new Sunny.UI.UILabel();
            this.ledOut1 = new Sunny.UI.UIPanel();
            this.lblOut2 = new Sunny.UI.UILabel();
            this.ledOut2 = new Sunny.UI.UIPanel();
            this.lblOut3 = new Sunny.UI.UILabel();
            this.ledOut3 = new Sunny.UI.UIPanel();
            this.pnlOut2 = new Sunny.UI.UIPanel();
            this.lblOut4 = new Sunny.UI.UILabel();
            this.ledOut4 = new Sunny.UI.UIPanel();
            this.lblOut5 = new Sunny.UI.UILabel();
            this.ledOut5 = new Sunny.UI.UIPanel();
            this.lblOut6 = new Sunny.UI.UILabel();
            this.ledOut6 = new Sunny.UI.UIPanel();
            this.lblOut7 = new Sunny.UI.UILabel();
            this.ledOut7 = new Sunny.UI.UIPanel();
            this.pnlOut3 = new Sunny.UI.UIPanel();
            this.lblOut8 = new Sunny.UI.UILabel();
            this.ledOut8 = new Sunny.UI.UIPanel();
            this.lblOut9 = new Sunny.UI.UILabel();
            this.ledOut9 = new Sunny.UI.UIPanel();
            this.lblOut10 = new Sunny.UI.UILabel();
            this.ledOut10 = new Sunny.UI.UIPanel();
            this.lblOut11 = new Sunny.UI.UILabel();
            this.ledOut11 = new Sunny.UI.UIPanel();
            this.pnlOut4 = new Sunny.UI.UIPanel();
            this.lblOut12 = new Sunny.UI.UILabel();
            this.ledOut12 = new Sunny.UI.UIPanel();
            this.lblOut13 = new Sunny.UI.UILabel();
            this.ledOut13 = new Sunny.UI.UIPanel();
            this.lblOut14 = new Sunny.UI.UILabel();
            this.ledOut14 = new Sunny.UI.UIPanel();
            this.lblOut15 = new Sunny.UI.UILabel();
            this.ledOut15 = new Sunny.UI.UIPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslAxisLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAxisLed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAxisPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft.SuspendLayout();
            this.grpImageShow.SuspendLayout();
            this.grpRealTimeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRealTime)).BeginInit();
            this.grpWorkImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkImage)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabMotion.SuspendLayout();
            this.grpInitParam.SuspendLayout();
            this.grpSpeedMode.SuspendLayout();
            this.grpInterpTest.SuspendLayout();
            this.grpManual.SuspendLayout();
            this.grpRecordPos.SuspendLayout();
            this.grpControlCfg.SuspendLayout();
            this.grpHomeSpeed.SuspendLayout();
            this.grpHomeDir.SuspendLayout();
            this.grpOnlineMove.SuspendLayout();
            this.grpOnlineOffset.SuspendLayout();
            this.tabCalib.SuspendLayout();
            this.grpImageProc.SuspendLayout();
            this.blkMean.SuspendLayout();
            this.blkDyn.SuspendLayout();
            this.blkAreaMax.SuspendLayout();
            this.blkAreaMin.SuspendLayout();
            this.grpPixelCoord.SuspendLayout();
            this.grpRobotCoord.SuspendLayout();
            this.tabLocate.SuspendLayout();
            this.grpLocateMode.SuspendLayout();
            this.pnlBlobParam.SuspendLayout();
            this.pnlTemplateParam.SuspendLayout();
            this.tabTrace.SuspendLayout();
            this.pnlContourA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContourA)).BeginInit();
            this.pnlContourB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContourB)).BeginInit();
            this.tabIO.SuspendLayout();
            this.grpAxisSignal.SuspendLayout();
            this.grpGeneralIn.SuspendLayout();
            this.pnlIn1.SuspendLayout();
            this.pnlIn2.SuspendLayout();
            this.pnlIn3.SuspendLayout();
            this.pnlIn4.SuspendLayout();
            this.grpGeneralOut.SuspendLayout();
            this.pnlOut1.SuspendLayout();
            this.pnlOut2.SuspendLayout();
            this.pnlOut3.SuspendLayout();
            this.pnlOut4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.Controls.Add(this.grpImageShow);
            this.pnlLeft.FillColor = System.Drawing.Color.White;
            this.pnlLeft.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlLeft.Location = new System.Drawing.Point(0, 40);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(500, 815);
            this.pnlLeft.TabIndex = 1;
            this.pnlLeft.Text = null;
            this.pnlLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpImageShow
            // 
            this.grpImageShow.Controls.Add(this.grpRealTimeImage);
            this.grpImageShow.Controls.Add(this.grpWorkImage);
            this.grpImageShow.FillColor = System.Drawing.Color.White;
            this.grpImageShow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpImageShow.Location = new System.Drawing.Point(4, 4);
            this.grpImageShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpImageShow.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpImageShow.Name = "grpImageShow";
            this.grpImageShow.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpImageShow.Size = new System.Drawing.Size(492, 807);
            this.grpImageShow.TabIndex = 2;
            this.grpImageShow.Text = "图像展示";
            this.grpImageShow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRealTimeImage
            // 
            this.grpRealTimeImage.Controls.Add(this.picRealTime);
            this.grpRealTimeImage.FillColor = System.Drawing.Color.White;
            this.grpRealTimeImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpRealTimeImage.Location = new System.Drawing.Point(6, 36);
            this.grpRealTimeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRealTimeImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpRealTimeImage.Name = "grpRealTimeImage";
            this.grpRealTimeImage.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpRealTimeImage.Size = new System.Drawing.Size(480, 370);
            this.grpRealTimeImage.TabIndex = 3;
            this.grpRealTimeImage.Text = "实时图像";
            this.grpRealTimeImage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRealTime
            // 
            this.picRealTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.picRealTime.Location = new System.Drawing.Point(4, 34);
            this.picRealTime.Name = "picRealTime";
            this.picRealTime.Size = new System.Drawing.Size(472, 332);
            this.picRealTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRealTime.TabIndex = 4;
            this.picRealTime.TabStop = false;
            // 
            // grpWorkImage
            // 
            this.grpWorkImage.Controls.Add(this.picWorkImage);
            this.grpWorkImage.FillColor = System.Drawing.Color.White;
            this.grpWorkImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpWorkImage.Location = new System.Drawing.Point(6, 412);
            this.grpWorkImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpWorkImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpWorkImage.Name = "grpWorkImage";
            this.grpWorkImage.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpWorkImage.Size = new System.Drawing.Size(480, 385);
            this.grpWorkImage.TabIndex = 5;
            this.grpWorkImage.Text = "作业图像";
            this.grpWorkImage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picWorkImage
            // 
            this.picWorkImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.picWorkImage.Location = new System.Drawing.Point(4, 34);
            this.picWorkImage.Name = "picWorkImage";
            this.picWorkImage.Size = new System.Drawing.Size(472, 351);
            this.picWorkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkImage.TabIndex = 6;
            this.picWorkImage.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabMotion);
            this.tabMain.Controls.Add(this.tabCalib);
            this.tabMain.Controls.Add(this.tabLocate);
            this.tabMain.Controls.Add(this.tabTrace);
            this.tabMain.Controls.Add(this.tabIO);
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMain.ItemSize = new System.Drawing.Size(150, 40);
            this.tabMain.Location = new System.Drawing.Point(500, 40);
            this.tabMain.MainPage = "";
            this.tabMain.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1204, 815);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tabMain.TabIndex = 7;
            this.tabMain.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tabMain.TabSelectedForeColor = System.Drawing.Color.White;
            this.tabMain.TabSelectedHighColor = System.Drawing.Color.White;
            this.tabMain.TabUnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tabMain.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tabMain.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabMotion
            // 
            this.tabMotion.BackColor = System.Drawing.Color.White;
            this.tabMotion.Controls.Add(this.grpInitParam);
            this.tabMotion.Controls.Add(this.grpSpeedMode);
            this.tabMotion.Controls.Add(this.grpInterpTest);
            this.tabMotion.Controls.Add(this.grpManual);
            this.tabMotion.Controls.Add(this.grpRecordPos);
            this.tabMotion.Controls.Add(this.grpControlCfg);
            this.tabMotion.Controls.Add(this.grpOnlineMove);
            this.tabMotion.Controls.Add(this.grpOnlineOffset);
            this.tabMotion.Location = new System.Drawing.Point(0, 40);
            this.tabMotion.Name = "tabMotion";
            this.tabMotion.Size = new System.Drawing.Size(1204, 775);
            this.tabMotion.TabIndex = 8;
            this.tabMotion.Text = "运动控制";
            // 
            // grpInitParam
            // 
            this.grpInitParam.Controls.Add(this.txtInitSpeed);
            this.grpInitParam.Controls.Add(this.txtMaxSpeed);
            this.grpInitParam.Controls.Add(this.txtAccTime);
            this.grpInitParam.Controls.Add(this.txtDecTime);
            this.grpInitParam.Controls.Add(this.txtSTime);
            this.grpInitParam.Controls.Add(this.txtStopSpeed);
            this.grpInitParam.Controls.Add(this.lblInitSpeed);
            this.grpInitParam.Controls.Add(this.lblMaxSpeed);
            this.grpInitParam.Controls.Add(this.lblAccTime);
            this.grpInitParam.Controls.Add(this.lblDecTime);
            this.grpInitParam.Controls.Add(this.lblSTime);
            this.grpInitParam.Controls.Add(this.lblStopSpeed);
            this.grpInitParam.FillColor = System.Drawing.Color.White;
            this.grpInitParam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpInitParam.Location = new System.Drawing.Point(8, 6);
            this.grpInitParam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInitParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpInitParam.Name = "grpInitParam";
            this.grpInitParam.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpInitParam.Size = new System.Drawing.Size(290, 305);
            this.grpInitParam.TabIndex = 14;
            this.grpInitParam.Text = "初始参数";
            this.grpInitParam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInitSpeed
            // 
            this.txtInitSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitSpeed.DoubleValue = 2500D;
            this.txtInitSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInitSpeed.IntValue = 2500;
            this.txtInitSpeed.Location = new System.Drawing.Point(140, 33);
            this.txtInitSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitSpeed.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInitSpeed.Name = "txtInitSpeed";
            this.txtInitSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.txtInitSpeed.ShowText = false;
            this.txtInitSpeed.Size = new System.Drawing.Size(128, 32);
            this.txtInitSpeed.TabIndex = 16;
            this.txtInitSpeed.Text = "2500";
            this.txtInitSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInitSpeed.Watermark = "";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxSpeed.DoubleValue = 2500D;
            this.txtMaxSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMaxSpeed.IntValue = 2500;
            this.txtMaxSpeed.Location = new System.Drawing.Point(140, 76);
            this.txtMaxSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxSpeed.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaxSpeed.ShowText = false;
            this.txtMaxSpeed.Size = new System.Drawing.Size(128, 32);
            this.txtMaxSpeed.TabIndex = 18;
            this.txtMaxSpeed.Text = "2500";
            this.txtMaxSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaxSpeed.Watermark = "";
            // 
            // txtAccTime
            // 
            this.txtAccTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccTime.DoubleValue = 0.1D;
            this.txtAccTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccTime.Location = new System.Drawing.Point(140, 119);
            this.txtAccTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccTime.Name = "txtAccTime";
            this.txtAccTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccTime.ShowText = false;
            this.txtAccTime.Size = new System.Drawing.Size(128, 32);
            this.txtAccTime.TabIndex = 20;
            this.txtAccTime.Text = "0.1";
            this.txtAccTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAccTime.Watermark = "";
            // 
            // txtDecTime
            // 
            this.txtDecTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDecTime.DoubleValue = 0.1D;
            this.txtDecTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDecTime.Location = new System.Drawing.Point(140, 162);
            this.txtDecTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDecTime.Name = "txtDecTime";
            this.txtDecTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtDecTime.ShowText = false;
            this.txtDecTime.Size = new System.Drawing.Size(128, 32);
            this.txtDecTime.TabIndex = 22;
            this.txtDecTime.Text = "0.1";
            this.txtDecTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDecTime.Watermark = "";
            // 
            // txtSTime
            // 
            this.txtSTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSTime.DoubleValue = 0.05D;
            this.txtSTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSTime.Location = new System.Drawing.Point(140, 205);
            this.txtSTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSTime.Name = "txtSTime";
            this.txtSTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtSTime.ShowText = false;
            this.txtSTime.Size = new System.Drawing.Size(128, 32);
            this.txtSTime.TabIndex = 24;
            this.txtSTime.Text = "0.05";
            this.txtSTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSTime.Watermark = "";
            // 
            // txtStopSpeed
            // 
            this.txtStopSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStopSpeed.DoubleValue = 2500D;
            this.txtStopSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStopSpeed.IntValue = 2500;
            this.txtStopSpeed.Location = new System.Drawing.Point(140, 248);
            this.txtStopSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStopSpeed.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtStopSpeed.Name = "txtStopSpeed";
            this.txtStopSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.txtStopSpeed.ShowText = false;
            this.txtStopSpeed.Size = new System.Drawing.Size(128, 32);
            this.txtStopSpeed.TabIndex = 26;
            this.txtStopSpeed.Text = "2500";
            this.txtStopSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStopSpeed.Watermark = "";
            // 
            // lblInitSpeed
            // 
            this.lblInitSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInitSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblInitSpeed.Location = new System.Drawing.Point(18, 36);
            this.lblInitSpeed.Name = "lblInitSpeed";
            this.lblInitSpeed.Size = new System.Drawing.Size(143, 29);
            this.lblInitSpeed.TabIndex = 15;
            this.lblInitSpeed.Text = "初始速度：";
            this.lblInitSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaxSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMaxSpeed.Location = new System.Drawing.Point(18, 79);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(143, 29);
            this.lblMaxSpeed.TabIndex = 17;
            this.lblMaxSpeed.Text = "最大速度：";
            this.lblMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccTime
            // 
            this.lblAccTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAccTime.Location = new System.Drawing.Point(18, 122);
            this.lblAccTime.Name = "lblAccTime";
            this.lblAccTime.Size = new System.Drawing.Size(143, 29);
            this.lblAccTime.TabIndex = 19;
            this.lblAccTime.Text = "加速时间：";
            this.lblAccTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDecTime
            // 
            this.lblDecTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDecTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDecTime.Location = new System.Drawing.Point(18, 165);
            this.lblDecTime.Name = "lblDecTime";
            this.lblDecTime.Size = new System.Drawing.Size(143, 29);
            this.lblDecTime.TabIndex = 21;
            this.lblDecTime.Text = "减速时间：";
            this.lblDecTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSTime
            // 
            this.lblSTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSTime.Location = new System.Drawing.Point(18, 208);
            this.lblSTime.Name = "lblSTime";
            this.lblSTime.Size = new System.Drawing.Size(144, 29);
            this.lblSTime.TabIndex = 23;
            this.lblSTime.Text = "S 段时间：";
            this.lblSTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStopSpeed
            // 
            this.lblStopSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStopSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblStopSpeed.Location = new System.Drawing.Point(18, 251);
            this.lblStopSpeed.Name = "lblStopSpeed";
            this.lblStopSpeed.Size = new System.Drawing.Size(143, 29);
            this.lblStopSpeed.TabIndex = 25;
            this.lblStopSpeed.Text = "停止速度：";
            this.lblStopSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSpeedMode
            // 
            this.grpSpeedMode.Controls.Add(this.rdoSType);
            this.grpSpeedMode.Controls.Add(this.rdoTType);
            this.grpSpeedMode.FillColor = System.Drawing.Color.White;
            this.grpSpeedMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpSpeedMode.Location = new System.Drawing.Point(8, 317);
            this.grpSpeedMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSpeedMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpSpeedMode.Name = "grpSpeedMode";
            this.grpSpeedMode.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpSpeedMode.Size = new System.Drawing.Size(290, 100);
            this.grpSpeedMode.TabIndex = 27;
            this.grpSpeedMode.Text = "速度控制方式";
            this.grpSpeedMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoSType
            // 
            this.rdoSType.Checked = true;
            this.rdoSType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoSType.Location = new System.Drawing.Point(26, 48);
            this.rdoSType.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoSType.Name = "rdoSType";
            this.rdoSType.Size = new System.Drawing.Size(100, 30);
            this.rdoSType.TabIndex = 28;
            this.rdoSType.Text = "S 型";
            // 
            // rdoTType
            // 
            this.rdoTType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoTType.Location = new System.Drawing.Point(160, 48);
            this.rdoTType.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoTType.Name = "rdoTType";
            this.rdoTType.Size = new System.Drawing.Size(100, 30);
            this.rdoTType.TabIndex = 29;
            this.rdoTType.Text = "T 型";
            // 
            // grpInterpTest
            // 
            this.grpInterpTest.Controls.Add(this.lblInterpX);
            this.grpInterpTest.Controls.Add(this.txtInterpX);
            this.grpInterpTest.Controls.Add(this.lblInterpY);
            this.grpInterpTest.Controls.Add(this.txtInterpY);
            this.grpInterpTest.Controls.Add(this.lblInterpZ);
            this.grpInterpTest.Controls.Add(this.txtInterpZ);
            this.grpInterpTest.Controls.Add(this.btnLineInterp);
            this.grpInterpTest.Controls.Add(this.btnArcInterp);
            this.grpInterpTest.FillColor = System.Drawing.Color.White;
            this.grpInterpTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpInterpTest.Location = new System.Drawing.Point(8, 423);
            this.grpInterpTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInterpTest.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpInterpTest.Name = "grpInterpTest";
            this.grpInterpTest.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpInterpTest.Size = new System.Drawing.Size(290, 347);
            this.grpInterpTest.TabIndex = 30;
            this.grpInterpTest.Text = "插补测试";
            this.grpInterpTest.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInterpX
            // 
            this.lblInterpX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInterpX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblInterpX.Location = new System.Drawing.Point(20, 40);
            this.lblInterpX.Name = "lblInterpX";
            this.lblInterpX.Size = new System.Drawing.Size(94, 29);
            this.lblInterpX.TabIndex = 31;
            this.lblInterpX.Text = "X 轴：";
            this.lblInterpX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInterpX
            // 
            this.txtInterpX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInterpX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInterpX.Location = new System.Drawing.Point(140, 38);
            this.txtInterpX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterpX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInterpX.Name = "txtInterpX";
            this.txtInterpX.Padding = new System.Windows.Forms.Padding(5);
            this.txtInterpX.ShowText = false;
            this.txtInterpX.Size = new System.Drawing.Size(128, 32);
            this.txtInterpX.TabIndex = 32;
            this.txtInterpX.Text = "0";
            this.txtInterpX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInterpX.Watermark = "";
            // 
            // lblInterpY
            // 
            this.lblInterpY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInterpY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblInterpY.Location = new System.Drawing.Point(20, 87);
            this.lblInterpY.Name = "lblInterpY";
            this.lblInterpY.Size = new System.Drawing.Size(94, 29);
            this.lblInterpY.TabIndex = 33;
            this.lblInterpY.Text = "Y 轴：";
            this.lblInterpY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInterpY
            // 
            this.txtInterpY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInterpY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInterpY.Location = new System.Drawing.Point(140, 85);
            this.txtInterpY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterpY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInterpY.Name = "txtInterpY";
            this.txtInterpY.Padding = new System.Windows.Forms.Padding(5);
            this.txtInterpY.ShowText = false;
            this.txtInterpY.Size = new System.Drawing.Size(128, 32);
            this.txtInterpY.TabIndex = 34;
            this.txtInterpY.Text = "0";
            this.txtInterpY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInterpY.Watermark = "";
            // 
            // lblInterpZ
            // 
            this.lblInterpZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInterpZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblInterpZ.Location = new System.Drawing.Point(20, 134);
            this.lblInterpZ.Name = "lblInterpZ";
            this.lblInterpZ.Size = new System.Drawing.Size(94, 29);
            this.lblInterpZ.TabIndex = 35;
            this.lblInterpZ.Text = "Z 轴：";
            this.lblInterpZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInterpZ
            // 
            this.txtInterpZ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInterpZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInterpZ.Location = new System.Drawing.Point(140, 132);
            this.txtInterpZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterpZ.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInterpZ.Name = "txtInterpZ";
            this.txtInterpZ.Padding = new System.Windows.Forms.Padding(5);
            this.txtInterpZ.ShowText = false;
            this.txtInterpZ.Size = new System.Drawing.Size(128, 32);
            this.txtInterpZ.TabIndex = 36;
            this.txtInterpZ.Text = "0";
            this.txtInterpZ.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInterpZ.Watermark = "";
            // 
            // btnLineInterp
            // 
            this.btnLineInterp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLineInterp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLineInterp.Location = new System.Drawing.Point(22, 250);
            this.btnLineInterp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLineInterp.Name = "btnLineInterp";
            this.btnLineInterp.Size = new System.Drawing.Size(120, 60);
            this.btnLineInterp.TabIndex = 37;
            this.btnLineInterp.Text = "直线插补";
            this.btnLineInterp.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnArcInterp
            // 
            this.btnArcInterp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArcInterp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnArcInterp.Location = new System.Drawing.Point(155, 250);
            this.btnArcInterp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnArcInterp.Name = "btnArcInterp";
            this.btnArcInterp.Size = new System.Drawing.Size(120, 60);
            this.btnArcInterp.TabIndex = 38;
            this.btnArcInterp.Text = "圆弧插补";
            this.btnArcInterp.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // grpManual
            // 
            this.grpManual.Controls.Add(this.btnAxisUp1);
            this.grpManual.Controls.Add(this.btnAxisUp2);
            this.grpManual.Controls.Add(this.btnAxisLeft);
            this.grpManual.Controls.Add(this.btnAxisStop);
            this.grpManual.Controls.Add(this.btnAxisRight);
            this.grpManual.Controls.Add(this.btnAxisDown1);
            this.grpManual.Controls.Add(this.btnAxisDown2);
            this.grpManual.Controls.Add(this.btnAxisStopHome);
            this.grpManual.Controls.Add(this.btnAxisRotateCcw);
            this.grpManual.Controls.Add(this.btnAxisRotateCw);
            this.grpManual.FillColor = System.Drawing.Color.White;
            this.grpManual.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpManual.Location = new System.Drawing.Point(302, 6);
            this.grpManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpManual.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpManual.Name = "grpManual";
            this.grpManual.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpManual.Size = new System.Drawing.Size(420, 411);
            this.grpManual.TabIndex = 39;
            this.grpManual.Text = "手动控制";
            this.grpManual.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAxisUp1
            // 
            this.btnAxisUp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisUp1.FillColor = System.Drawing.Color.White;
            this.btnAxisUp1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisUp1.Image = global::EndDemo_02.Properties.Resources.ArrowUp;
            this.btnAxisUp1.Location = new System.Drawing.Point(179, 40);
            this.btnAxisUp1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisUp1.Name = "btnAxisUp1";
            this.btnAxisUp1.RectColor = System.Drawing.Color.Silver;
            this.btnAxisUp1.Size = new System.Drawing.Size(62, 62);
            this.btnAxisUp1.TabIndex = 40;
            this.btnAxisUp1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisUp2
            // 
            this.btnAxisUp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisUp2.FillColor = System.Drawing.Color.White;
            this.btnAxisUp2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisUp2.Image = global::EndDemo_02.Properties.Resources.ArrowUp;
            this.btnAxisUp2.Location = new System.Drawing.Point(318, 40);
            this.btnAxisUp2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisUp2.Name = "btnAxisUp2";
            this.btnAxisUp2.RectColor = System.Drawing.Color.Silver;
            this.btnAxisUp2.Size = new System.Drawing.Size(62, 62);
            this.btnAxisUp2.TabIndex = 41;
            this.btnAxisUp2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisLeft
            // 
            this.btnAxisLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisLeft.FillColor = System.Drawing.Color.White;
            this.btnAxisLeft.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisLeft.Image = global::EndDemo_02.Properties.Resources.ArrowLeft;
            this.btnAxisLeft.Location = new System.Drawing.Point(40, 130);
            this.btnAxisLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisLeft.Name = "btnAxisLeft";
            this.btnAxisLeft.RectColor = System.Drawing.Color.Silver;
            this.btnAxisLeft.Size = new System.Drawing.Size(62, 62);
            this.btnAxisLeft.TabIndex = 42;
            this.btnAxisLeft.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisStop
            // 
            this.btnAxisStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisStop.FillColor = System.Drawing.Color.White;
            this.btnAxisStop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisStop.Image = global::EndDemo_02.Properties.Resources.BtnStop;
            this.btnAxisStop.Location = new System.Drawing.Point(176, 127);
            this.btnAxisStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisStop.Name = "btnAxisStop";
            this.btnAxisStop.RectColor = System.Drawing.Color.Silver;
            this.btnAxisStop.Size = new System.Drawing.Size(68, 68);
            this.btnAxisStop.TabIndex = 43;
            this.btnAxisStop.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisRight
            // 
            this.btnAxisRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisRight.FillColor = System.Drawing.Color.White;
            this.btnAxisRight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisRight.Image = global::EndDemo_02.Properties.Resources.ArrowRight;
            this.btnAxisRight.Location = new System.Drawing.Point(318, 130);
            this.btnAxisRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisRight.Name = "btnAxisRight";
            this.btnAxisRight.RectColor = System.Drawing.Color.Silver;
            this.btnAxisRight.Size = new System.Drawing.Size(62, 62);
            this.btnAxisRight.TabIndex = 44;
            this.btnAxisRight.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisDown1
            // 
            this.btnAxisDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisDown1.FillColor = System.Drawing.Color.White;
            this.btnAxisDown1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisDown1.Image = global::EndDemo_02.Properties.Resources.ArrowDown;
            this.btnAxisDown1.Location = new System.Drawing.Point(179, 220);
            this.btnAxisDown1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisDown1.Name = "btnAxisDown1";
            this.btnAxisDown1.RectColor = System.Drawing.Color.Silver;
            this.btnAxisDown1.Size = new System.Drawing.Size(62, 62);
            this.btnAxisDown1.TabIndex = 45;
            this.btnAxisDown1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisDown2
            // 
            this.btnAxisDown2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisDown2.FillColor = System.Drawing.Color.White;
            this.btnAxisDown2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisDown2.Image = global::EndDemo_02.Properties.Resources.ArrowDown;
            this.btnAxisDown2.Location = new System.Drawing.Point(318, 220);
            this.btnAxisDown2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisDown2.Name = "btnAxisDown2";
            this.btnAxisDown2.RectColor = System.Drawing.Color.Silver;
            this.btnAxisDown2.Size = new System.Drawing.Size(62, 62);
            this.btnAxisDown2.TabIndex = 46;
            this.btnAxisDown2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisStopHome
            // 
            this.btnAxisStopHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisStopHome.FillColor = System.Drawing.Color.White;
            this.btnAxisStopHome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisStopHome.Image = global::EndDemo_02.Properties.Resources.BtnStopAxis;
            this.btnAxisStopHome.Location = new System.Drawing.Point(40, 325);
            this.btnAxisStopHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisStopHome.Name = "btnAxisStopHome";
            this.btnAxisStopHome.RectColor = System.Drawing.Color.Silver;
            this.btnAxisStopHome.Size = new System.Drawing.Size(62, 62);
            this.btnAxisStopHome.TabIndex = 47;
            this.btnAxisStopHome.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisRotateCcw
            // 
            this.btnAxisRotateCcw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisRotateCcw.FillColor = System.Drawing.Color.White;
            this.btnAxisRotateCcw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisRotateCcw.Image = global::EndDemo_02.Properties.Resources.BtnRotateCcw;
            this.btnAxisRotateCcw.Location = new System.Drawing.Point(179, 325);
            this.btnAxisRotateCcw.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisRotateCcw.Name = "btnAxisRotateCcw";
            this.btnAxisRotateCcw.RectColor = System.Drawing.Color.Silver;
            this.btnAxisRotateCcw.Size = new System.Drawing.Size(62, 62);
            this.btnAxisRotateCcw.TabIndex = 48;
            this.btnAxisRotateCcw.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAxisRotateCw
            // 
            this.btnAxisRotateCw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAxisRotateCw.FillColor = System.Drawing.Color.White;
            this.btnAxisRotateCw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxisRotateCw.Image = global::EndDemo_02.Properties.Resources.BtnRotateCw;
            this.btnAxisRotateCw.Location = new System.Drawing.Point(318, 325);
            this.btnAxisRotateCw.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAxisRotateCw.Name = "btnAxisRotateCw";
            this.btnAxisRotateCw.RectColor = System.Drawing.Color.Silver;
            this.btnAxisRotateCw.Size = new System.Drawing.Size(62, 62);
            this.btnAxisRotateCw.TabIndex = 49;
            this.btnAxisRotateCw.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // grpRecordPos
            // 
            this.grpRecordPos.Controls.Add(this.btnRecord0);
            this.grpRecordPos.Controls.Add(this.btnRecord1);
            this.grpRecordPos.Controls.Add(this.btnRecord2);
            this.grpRecordPos.Controls.Add(this.btnRecord3);
            this.grpRecordPos.Controls.Add(this.btnRecord4);
            this.grpRecordPos.Controls.Add(this.btnRecord5);
            this.grpRecordPos.Controls.Add(this.btnRecord6);
            this.grpRecordPos.Controls.Add(this.btnRecord7);
            this.grpRecordPos.Controls.Add(this.btnRecord8);
            this.grpRecordPos.FillColor = System.Drawing.Color.White;
            this.grpRecordPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpRecordPos.Location = new System.Drawing.Point(302, 423);
            this.grpRecordPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRecordPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpRecordPos.Name = "grpRecordPos";
            this.grpRecordPos.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpRecordPos.Size = new System.Drawing.Size(420, 347);
            this.grpRecordPos.TabIndex = 50;
            this.grpRecordPos.Text = "记录机械手的位置";
            this.grpRecordPos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRecord0
            // 
            this.btnRecord0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord0.Location = new System.Drawing.Point(14, 61);
            this.btnRecord0.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord0.Name = "btnRecord0";
            this.btnRecord0.Size = new System.Drawing.Size(118, 76);
            this.btnRecord0.TabIndex = 51;
            this.btnRecord0.Text = "记录位置0";
            this.btnRecord0.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord1
            // 
            this.btnRecord1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord1.Location = new System.Drawing.Point(150, 61);
            this.btnRecord1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord1.Name = "btnRecord1";
            this.btnRecord1.Size = new System.Drawing.Size(118, 76);
            this.btnRecord1.TabIndex = 52;
            this.btnRecord1.Text = "记录位置1";
            this.btnRecord1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord2
            // 
            this.btnRecord2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord2.Location = new System.Drawing.Point(286, 61);
            this.btnRecord2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord2.Name = "btnRecord2";
            this.btnRecord2.Size = new System.Drawing.Size(118, 76);
            this.btnRecord2.TabIndex = 53;
            this.btnRecord2.Text = "记录位置2";
            this.btnRecord2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord3
            // 
            this.btnRecord3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord3.Location = new System.Drawing.Point(14, 148);
            this.btnRecord3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord3.Name = "btnRecord3";
            this.btnRecord3.Size = new System.Drawing.Size(118, 76);
            this.btnRecord3.TabIndex = 54;
            this.btnRecord3.Text = "记录位置3";
            this.btnRecord3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord4
            // 
            this.btnRecord4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord4.Location = new System.Drawing.Point(150, 148);
            this.btnRecord4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord4.Name = "btnRecord4";
            this.btnRecord4.Size = new System.Drawing.Size(118, 76);
            this.btnRecord4.TabIndex = 55;
            this.btnRecord4.Text = "记录位置4";
            this.btnRecord4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord5
            // 
            this.btnRecord5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord5.Location = new System.Drawing.Point(286, 148);
            this.btnRecord5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord5.Name = "btnRecord5";
            this.btnRecord5.Size = new System.Drawing.Size(118, 76);
            this.btnRecord5.TabIndex = 56;
            this.btnRecord5.Text = "记录位置5";
            this.btnRecord5.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord6
            // 
            this.btnRecord6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord6.Location = new System.Drawing.Point(14, 235);
            this.btnRecord6.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord6.Name = "btnRecord6";
            this.btnRecord6.Size = new System.Drawing.Size(118, 76);
            this.btnRecord6.TabIndex = 57;
            this.btnRecord6.Text = "记录位置6";
            this.btnRecord6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord7
            // 
            this.btnRecord7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord7.Location = new System.Drawing.Point(150, 235);
            this.btnRecord7.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord7.Name = "btnRecord7";
            this.btnRecord7.Size = new System.Drawing.Size(118, 76);
            this.btnRecord7.TabIndex = 58;
            this.btnRecord7.Text = "记录位置7";
            this.btnRecord7.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecord8
            // 
            this.btnRecord8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord8.Location = new System.Drawing.Point(286, 235);
            this.btnRecord8.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecord8.Name = "btnRecord8";
            this.btnRecord8.Size = new System.Drawing.Size(118, 76);
            this.btnRecord8.TabIndex = 59;
            this.btnRecord8.Text = "记录位置8";
            this.btnRecord8.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // grpControlCfg
            // 
            this.grpControlCfg.Controls.Add(this.chkAxisX);
            this.grpControlCfg.Controls.Add(this.chkAxisY);
            this.grpControlCfg.Controls.Add(this.chkAxisZ);
            this.grpControlCfg.Controls.Add(this.grpHomeSpeed);
            this.grpControlCfg.Controls.Add(this.grpHomeDir);
            this.grpControlCfg.Controls.Add(this.lblHomeMode);
            this.grpControlCfg.Controls.Add(this.cmbHomeMode);
            this.grpControlCfg.Controls.Add(this.btnHome);
            this.grpControlCfg.FillColor = System.Drawing.Color.White;
            this.grpControlCfg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpControlCfg.Location = new System.Drawing.Point(730, 6);
            this.grpControlCfg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpControlCfg.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpControlCfg.Name = "grpControlCfg";
            this.grpControlCfg.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpControlCfg.Size = new System.Drawing.Size(458, 330);
            this.grpControlCfg.TabIndex = 60;
            this.grpControlCfg.Text = "控制设置";
            this.grpControlCfg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAxisX
            // 
            this.chkAxisX.Checked = true;
            this.chkAxisX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAxisX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAxisX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkAxisX.Location = new System.Drawing.Point(28, 36);
            this.chkAxisX.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAxisX.Name = "chkAxisX";
            this.chkAxisX.Size = new System.Drawing.Size(90, 30);
            this.chkAxisX.TabIndex = 61;
            this.chkAxisX.Text = "X轴";
            // 
            // chkAxisY
            // 
            this.chkAxisY.Checked = true;
            this.chkAxisY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAxisY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAxisY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkAxisY.Location = new System.Drawing.Point(158, 36);
            this.chkAxisY.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAxisY.Name = "chkAxisY";
            this.chkAxisY.Size = new System.Drawing.Size(90, 30);
            this.chkAxisY.TabIndex = 62;
            this.chkAxisY.Text = "Y轴";
            // 
            // chkAxisZ
            // 
            this.chkAxisZ.Checked = true;
            this.chkAxisZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAxisZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAxisZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkAxisZ.Location = new System.Drawing.Point(288, 36);
            this.chkAxisZ.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAxisZ.Name = "chkAxisZ";
            this.chkAxisZ.Size = new System.Drawing.Size(90, 30);
            this.chkAxisZ.TabIndex = 63;
            this.chkAxisZ.Text = "Z轴";
            // 
            // grpHomeSpeed
            // 
            this.grpHomeSpeed.Controls.Add(this.rdoHomeSpeedLow);
            this.grpHomeSpeed.Controls.Add(this.rdoHomeSpeedHigh);
            this.grpHomeSpeed.FillColor = System.Drawing.Color.White;
            this.grpHomeSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpHomeSpeed.Location = new System.Drawing.Point(24, 78);
            this.grpHomeSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHomeSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpHomeSpeed.Name = "grpHomeSpeed";
            this.grpHomeSpeed.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpHomeSpeed.Size = new System.Drawing.Size(200, 92);
            this.grpHomeSpeed.TabIndex = 64;
            this.grpHomeSpeed.Text = "回原速度";
            this.grpHomeSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoHomeSpeedLow
            // 
            this.rdoHomeSpeedLow.Checked = true;
            this.rdoHomeSpeedLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHomeSpeedLow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoHomeSpeedLow.Location = new System.Drawing.Point(16, 44);
            this.rdoHomeSpeedLow.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoHomeSpeedLow.Name = "rdoHomeSpeedLow";
            this.rdoHomeSpeedLow.Size = new System.Drawing.Size(70, 30);
            this.rdoHomeSpeedLow.TabIndex = 65;
            this.rdoHomeSpeedLow.Text = "低";
            // 
            // rdoHomeSpeedHigh
            // 
            this.rdoHomeSpeedHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHomeSpeedHigh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoHomeSpeedHigh.Location = new System.Drawing.Point(105, 44);
            this.rdoHomeSpeedHigh.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoHomeSpeedHigh.Name = "rdoHomeSpeedHigh";
            this.rdoHomeSpeedHigh.Size = new System.Drawing.Size(70, 30);
            this.rdoHomeSpeedHigh.TabIndex = 66;
            this.rdoHomeSpeedHigh.Text = "高";
            // 
            // grpHomeDir
            // 
            this.grpHomeDir.Controls.Add(this.rdoHomeDirPos);
            this.grpHomeDir.Controls.Add(this.rdoHomeDirNeg);
            this.grpHomeDir.FillColor = System.Drawing.Color.White;
            this.grpHomeDir.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpHomeDir.Location = new System.Drawing.Point(240, 78);
            this.grpHomeDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHomeDir.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpHomeDir.Name = "grpHomeDir";
            this.grpHomeDir.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpHomeDir.Size = new System.Drawing.Size(212, 92);
            this.grpHomeDir.TabIndex = 67;
            this.grpHomeDir.Text = "回原方向";
            this.grpHomeDir.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoHomeDirPos
            // 
            this.rdoHomeDirPos.Checked = true;
            this.rdoHomeDirPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHomeDirPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoHomeDirPos.Location = new System.Drawing.Point(16, 44);
            this.rdoHomeDirPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoHomeDirPos.Name = "rdoHomeDirPos";
            this.rdoHomeDirPos.Size = new System.Drawing.Size(70, 30);
            this.rdoHomeDirPos.TabIndex = 68;
            this.rdoHomeDirPos.Text = "正";
            // 
            // rdoHomeDirNeg
            // 
            this.rdoHomeDirNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHomeDirNeg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoHomeDirNeg.Location = new System.Drawing.Point(110, 44);
            this.rdoHomeDirNeg.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoHomeDirNeg.Name = "rdoHomeDirNeg";
            this.rdoHomeDirNeg.Size = new System.Drawing.Size(70, 30);
            this.rdoHomeDirNeg.TabIndex = 69;
            this.rdoHomeDirNeg.Text = "负";
            // 
            // lblHomeMode
            // 
            this.lblHomeMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHomeMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblHomeMode.Location = new System.Drawing.Point(28, 186);
            this.lblHomeMode.Name = "lblHomeMode";
            this.lblHomeMode.Size = new System.Drawing.Size(98, 29);
            this.lblHomeMode.TabIndex = 70;
            this.lblHomeMode.Text = "回原模式：";
            this.lblHomeMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHomeMode
            // 
            this.cmbHomeMode.DataSource = null;
            this.cmbHomeMode.FillColor = System.Drawing.Color.White;
            this.cmbHomeMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHomeMode.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbHomeMode.Items.AddRange(new object[] {
            "一次回原",
            "二次回原",
            "三次回原"});
            this.cmbHomeMode.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbHomeMode.Location = new System.Drawing.Point(130, 184);
            this.cmbHomeMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHomeMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbHomeMode.Name = "cmbHomeMode";
            this.cmbHomeMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbHomeMode.Size = new System.Drawing.Size(318, 34);
            this.cmbHomeMode.SymbolSize = 24;
            this.cmbHomeMode.TabIndex = 71;
            this.cmbHomeMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbHomeMode.Watermark = "";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHome.Location = new System.Drawing.Point(26, 236);
            this.btnHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(424, 48);
            this.btnHome.TabIndex = 72;
            this.btnHome.Text = "回原点";
            this.btnHome.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // grpOnlineMove
            // 
            this.grpOnlineMove.Controls.Add(this.btnAbsPos);
            this.grpOnlineMove.Controls.Add(this.txtAbsPos);
            this.grpOnlineMove.Controls.Add(this.btnChgSpeed);
            this.grpOnlineMove.Controls.Add(this.txtChgSpeed);
            this.grpOnlineMove.Controls.Add(this.btnChgPos);
            this.grpOnlineMove.Controls.Add(this.txtChgPos);
            this.grpOnlineMove.FillColor = System.Drawing.Color.White;
            this.grpOnlineMove.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpOnlineMove.Location = new System.Drawing.Point(730, 348);
            this.grpOnlineMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOnlineMove.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpOnlineMove.Name = "grpOnlineMove";
            this.grpOnlineMove.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpOnlineMove.Size = new System.Drawing.Size(458, 238);
            this.grpOnlineMove.TabIndex = 73;
            this.grpOnlineMove.Text = "测试在线变速，在线变位";
            this.grpOnlineMove.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAbsPos
            // 
            this.btnAbsPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbsPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbsPos.Location = new System.Drawing.Point(20, 62);
            this.btnAbsPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAbsPos.Name = "btnAbsPos";
            this.btnAbsPos.Radius = 4;
            this.btnAbsPos.Size = new System.Drawing.Size(228, 34);
            this.btnAbsPos.TabIndex = 74;
            this.btnAbsPos.Text = "去绝对位置（X）：";
            this.btnAbsPos.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtAbsPos
            // 
            this.txtAbsPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbsPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAbsPos.Location = new System.Drawing.Point(279, 60);
            this.txtAbsPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAbsPos.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAbsPos.Name = "txtAbsPos";
            this.txtAbsPos.Padding = new System.Windows.Forms.Padding(5);
            this.txtAbsPos.ShowText = false;
            this.txtAbsPos.Size = new System.Drawing.Size(150, 32);
            this.txtAbsPos.TabIndex = 75;
            this.txtAbsPos.Text = "0";
            this.txtAbsPos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAbsPos.Watermark = "";
            // 
            // btnChgSpeed
            // 
            this.btnChgSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChgSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChgSpeed.Location = new System.Drawing.Point(20, 108);
            this.btnChgSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChgSpeed.Name = "btnChgSpeed";
            this.btnChgSpeed.Radius = 4;
            this.btnChgSpeed.Size = new System.Drawing.Size(228, 34);
            this.btnChgSpeed.TabIndex = 76;
            this.btnChgSpeed.Text = "在线变速（X）：";
            this.btnChgSpeed.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtChgSpeed
            // 
            this.txtChgSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChgSpeed.DoubleValue = 500D;
            this.txtChgSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtChgSpeed.IntValue = 500;
            this.txtChgSpeed.Location = new System.Drawing.Point(279, 106);
            this.txtChgSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChgSpeed.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtChgSpeed.Name = "txtChgSpeed";
            this.txtChgSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.txtChgSpeed.ShowText = false;
            this.txtChgSpeed.Size = new System.Drawing.Size(150, 32);
            this.txtChgSpeed.TabIndex = 77;
            this.txtChgSpeed.Text = "500";
            this.txtChgSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtChgSpeed.Watermark = "";
            // 
            // btnChgPos
            // 
            this.btnChgPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChgPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChgPos.Location = new System.Drawing.Point(20, 154);
            this.btnChgPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChgPos.Name = "btnChgPos";
            this.btnChgPos.Radius = 4;
            this.btnChgPos.Size = new System.Drawing.Size(228, 34);
            this.btnChgPos.TabIndex = 78;
            this.btnChgPos.Text = "在线换位（X）：";
            this.btnChgPos.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtChgPos
            // 
            this.txtChgPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChgPos.DoubleValue = 10000D;
            this.txtChgPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtChgPos.IntValue = 10000;
            this.txtChgPos.Location = new System.Drawing.Point(279, 152);
            this.txtChgPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChgPos.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtChgPos.Name = "txtChgPos";
            this.txtChgPos.Padding = new System.Windows.Forms.Padding(5);
            this.txtChgPos.ShowText = false;
            this.txtChgPos.Size = new System.Drawing.Size(150, 32);
            this.txtChgPos.TabIndex = 79;
            this.txtChgPos.Text = "10000";
            this.txtChgPos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtChgPos.Watermark = "";
            // 
            // grpOnlineOffset
            // 
            this.grpOnlineOffset.Controls.Add(this.btnOffsetX);
            this.grpOnlineOffset.Controls.Add(this.txtOffsetX);
            this.grpOnlineOffset.Controls.Add(this.btnOffsetY);
            this.grpOnlineOffset.Controls.Add(this.txtOffsetY);
            this.grpOnlineOffset.FillColor = System.Drawing.Color.White;
            this.grpOnlineOffset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpOnlineOffset.Location = new System.Drawing.Point(730, 599);
            this.grpOnlineOffset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOnlineOffset.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpOnlineOffset.Name = "grpOnlineOffset";
            this.grpOnlineOffset.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpOnlineOffset.Size = new System.Drawing.Size(458, 171);
            this.grpOnlineOffset.TabIndex = 80;
            this.grpOnlineOffset.Text = "测试在线变速，在线变位";
            this.grpOnlineOffset.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOffsetX
            // 
            this.btnOffsetX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOffsetX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOffsetX.Location = new System.Drawing.Point(20, 54);
            this.btnOffsetX.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOffsetX.Name = "btnOffsetX";
            this.btnOffsetX.Radius = 4;
            this.btnOffsetX.Size = new System.Drawing.Size(228, 34);
            this.btnOffsetX.TabIndex = 81;
            this.btnOffsetX.Text = "X轴偏移量";
            this.btnOffsetX.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtOffsetX
            // 
            this.txtOffsetX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOffsetX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOffsetX.Location = new System.Drawing.Point(279, 56);
            this.txtOffsetX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOffsetX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOffsetX.Name = "txtOffsetX";
            this.txtOffsetX.Padding = new System.Windows.Forms.Padding(5);
            this.txtOffsetX.ShowText = false;
            this.txtOffsetX.Size = new System.Drawing.Size(150, 32);
            this.txtOffsetX.TabIndex = 82;
            this.txtOffsetX.Text = "0";
            this.txtOffsetX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOffsetX.Watermark = "";
            // 
            // btnOffsetY
            // 
            this.btnOffsetY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOffsetY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOffsetY.Location = new System.Drawing.Point(20, 104);
            this.btnOffsetY.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOffsetY.Name = "btnOffsetY";
            this.btnOffsetY.Radius = 4;
            this.btnOffsetY.Size = new System.Drawing.Size(228, 34);
            this.btnOffsetY.TabIndex = 83;
            this.btnOffsetY.Text = "Y轴偏移量";
            this.btnOffsetY.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtOffsetY
            // 
            this.txtOffsetY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOffsetY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOffsetY.Location = new System.Drawing.Point(279, 106);
            this.txtOffsetY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOffsetY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOffsetY.Name = "txtOffsetY";
            this.txtOffsetY.Padding = new System.Windows.Forms.Padding(5);
            this.txtOffsetY.ShowText = false;
            this.txtOffsetY.Size = new System.Drawing.Size(150, 32);
            this.txtOffsetY.TabIndex = 84;
            this.txtOffsetY.Text = "0";
            this.txtOffsetY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOffsetY.Watermark = "";
            // 
            // tabCalib
            // 
            this.tabCalib.BackColor = System.Drawing.Color.White;
            this.tabCalib.Controls.Add(this.grpImageProc);
            this.tabCalib.Controls.Add(this.grpPixelCoord);
            this.tabCalib.Controls.Add(this.grpRobotCoord);
            this.tabCalib.Location = new System.Drawing.Point(0, 40);
            this.tabCalib.Name = "tabCalib";
            this.tabCalib.Size = new System.Drawing.Size(1204, 775);
            this.tabCalib.TabIndex = 9;
            this.tabCalib.Text = "手眼标定";
            // 
            // grpImageProc
            // 
            this.grpImageProc.Controls.Add(this.btnMoveToShot);
            this.grpImageProc.Controls.Add(this.btnFlowArrow1);
            this.grpImageProc.Controls.Add(this.btnCapture);
            this.grpImageProc.Controls.Add(this.btnFlowArrow2);
            this.grpImageProc.Controls.Add(this.btnExtractNine);
            this.grpImageProc.Controls.Add(this.btnFlowArrow3);
            this.grpImageProc.Controls.Add(this.btnStartCalib);
            this.grpImageProc.Controls.Add(this.btnFlowArrow4);
            this.grpImageProc.Controls.Add(this.btnSaveCalib);
            this.grpImageProc.Controls.Add(this.blkMean);
            this.grpImageProc.Controls.Add(this.blkDyn);
            this.grpImageProc.Controls.Add(this.blkAreaMax);
            this.grpImageProc.Controls.Add(this.blkAreaMin);
            this.grpImageProc.FillColor = System.Drawing.Color.White;
            this.grpImageProc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpImageProc.Location = new System.Drawing.Point(8, 6);
            this.grpImageProc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpImageProc.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpImageProc.Name = "grpImageProc";
            this.grpImageProc.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpImageProc.Size = new System.Drawing.Size(470, 758);
            this.grpImageProc.TabIndex = 85;
            this.grpImageProc.Text = "图像处理区域（像素坐标记录）";
            this.grpImageProc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMoveToShot
            // 
            this.btnMoveToShot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveToShot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoveToShot.Location = new System.Drawing.Point(28, 50);
            this.btnMoveToShot.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveToShot.Name = "btnMoveToShot";
            this.btnMoveToShot.Size = new System.Drawing.Size(180, 88);
            this.btnMoveToShot.TabIndex = 86;
            this.btnMoveToShot.Text = "运动到拍照位置";
            this.btnMoveToShot.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFlowArrow1
            // 
            this.btnFlowArrow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlowArrow1.FillColor = System.Drawing.Color.White;
            this.btnFlowArrow1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFlowArrow1.Image = global::EndDemo_02.Properties.Resources.ConnDown;
            this.btnFlowArrow1.Location = new System.Drawing.Point(102, 142);
            this.btnFlowArrow1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFlowArrow1.Name = "btnFlowArrow1";
            this.btnFlowArrow1.RectColor = System.Drawing.Color.Silver;
            this.btnFlowArrow1.Size = new System.Drawing.Size(32, 32);
            this.btnFlowArrow1.TabIndex = 87;
            this.btnFlowArrow1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnCapture
            // 
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapture.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCapture.Location = new System.Drawing.Point(28, 178);
            this.btnCapture.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(180, 88);
            this.btnCapture.TabIndex = 88;
            this.btnCapture.Text = "点击抓图";
            this.btnCapture.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFlowArrow2
            // 
            this.btnFlowArrow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlowArrow2.FillColor = System.Drawing.Color.White;
            this.btnFlowArrow2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFlowArrow2.Image = global::EndDemo_02.Properties.Resources.ConnDown;
            this.btnFlowArrow2.Location = new System.Drawing.Point(102, 270);
            this.btnFlowArrow2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFlowArrow2.Name = "btnFlowArrow2";
            this.btnFlowArrow2.RectColor = System.Drawing.Color.Silver;
            this.btnFlowArrow2.Size = new System.Drawing.Size(32, 32);
            this.btnFlowArrow2.TabIndex = 89;
            this.btnFlowArrow2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnExtractNine
            // 
            this.btnExtractNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtractNine.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExtractNine.Location = new System.Drawing.Point(28, 306);
            this.btnExtractNine.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExtractNine.Name = "btnExtractNine";
            this.btnExtractNine.Size = new System.Drawing.Size(180, 88);
            this.btnExtractNine.TabIndex = 90;
            this.btnExtractNine.Text = "提取九点坐标";
            this.btnExtractNine.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFlowArrow3
            // 
            this.btnFlowArrow3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlowArrow3.FillColor = System.Drawing.Color.White;
            this.btnFlowArrow3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFlowArrow3.Image = global::EndDemo_02.Properties.Resources.ConnDown;
            this.btnFlowArrow3.Location = new System.Drawing.Point(102, 398);
            this.btnFlowArrow3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFlowArrow3.Name = "btnFlowArrow3";
            this.btnFlowArrow3.RectColor = System.Drawing.Color.Silver;
            this.btnFlowArrow3.Size = new System.Drawing.Size(32, 32);
            this.btnFlowArrow3.TabIndex = 91;
            this.btnFlowArrow3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnStartCalib
            // 
            this.btnStartCalib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCalib.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCalib.Location = new System.Drawing.Point(28, 434);
            this.btnStartCalib.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStartCalib.Name = "btnStartCalib";
            this.btnStartCalib.Size = new System.Drawing.Size(180, 88);
            this.btnStartCalib.TabIndex = 92;
            this.btnStartCalib.Text = "开始标定";
            this.btnStartCalib.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFlowArrow4
            // 
            this.btnFlowArrow4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlowArrow4.FillColor = System.Drawing.Color.White;
            this.btnFlowArrow4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFlowArrow4.Image = global::EndDemo_02.Properties.Resources.ConnDown;
            this.btnFlowArrow4.Location = new System.Drawing.Point(102, 526);
            this.btnFlowArrow4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFlowArrow4.Name = "btnFlowArrow4";
            this.btnFlowArrow4.RectColor = System.Drawing.Color.Silver;
            this.btnFlowArrow4.Size = new System.Drawing.Size(32, 32);
            this.btnFlowArrow4.TabIndex = 93;
            this.btnFlowArrow4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnSaveCalib
            // 
            this.btnSaveCalib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCalib.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveCalib.Location = new System.Drawing.Point(28, 562);
            this.btnSaveCalib.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveCalib.Name = "btnSaveCalib";
            this.btnSaveCalib.Size = new System.Drawing.Size(180, 88);
            this.btnSaveCalib.TabIndex = 94;
            this.btnSaveCalib.Text = "保存标定结果";
            this.btnSaveCalib.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // blkMean
            // 
            this.blkMean.Controls.Add(this.btnWriteMean);
            this.blkMean.Controls.Add(this.lblMeanCap);
            this.blkMean.Controls.Add(this.trbMean);
            this.blkMean.Controls.Add(this.txtMean);
            this.blkMean.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkMean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkMean.Location = new System.Drawing.Point(222, 40);
            this.blkMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkMean.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkMean.Name = "blkMean";
            this.blkMean.Radius = 4;
            this.blkMean.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkMean.Size = new System.Drawing.Size(240, 138);
            this.blkMean.TabIndex = 95;
            this.blkMean.Text = null;
            this.blkMean.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWriteMean
            // 
            this.btnWriteMean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteMean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteMean.Location = new System.Drawing.Point(12, 96);
            this.btnWriteMean.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWriteMean.Name = "btnWriteMean";
            this.btnWriteMean.Size = new System.Drawing.Size(87, 38);
            this.btnWriteMean.TabIndex = 99;
            this.btnWriteMean.Text = "写入";
            this.btnWriteMean.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lblMeanCap
            // 
            this.lblMeanCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMeanCap.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMeanCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMeanCap.Location = new System.Drawing.Point(12, 14);
            this.lblMeanCap.Name = "lblMeanCap";
            this.lblMeanCap.Size = new System.Drawing.Size(110, 26);
            this.lblMeanCap.TabIndex = 96;
            this.lblMeanCap.Text = "均值阈值";
            this.lblMeanCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbMean
            // 
            this.trbMean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trbMean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbMean.Location = new System.Drawing.Point(12, 44);
            this.trbMean.Maximum = 500;
            this.trbMean.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbMean.Name = "trbMean";
            this.trbMean.Size = new System.Drawing.Size(216, 44);
            this.trbMean.TabIndex = 97;
            this.trbMean.Value = 300;
            // 
            // txtMean
            // 
            this.txtMean.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMean.DoubleValue = 300D;
            this.txtMean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMean.IntValue = 300;
            this.txtMean.Location = new System.Drawing.Point(110, 96);
            this.txtMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMean.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMean.Name = "txtMean";
            this.txtMean.Padding = new System.Windows.Forms.Padding(5);
            this.txtMean.ShowText = false;
            this.txtMean.Size = new System.Drawing.Size(116, 32);
            this.txtMean.TabIndex = 98;
            this.txtMean.Text = "300";
            this.txtMean.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMean.Watermark = "";
            // 
            // blkDyn
            // 
            this.blkDyn.Controls.Add(this.btnWriteDyn);
            this.blkDyn.Controls.Add(this.lblDynCap);
            this.blkDyn.Controls.Add(this.trbDyn);
            this.blkDyn.Controls.Add(this.txtDyn);
            this.blkDyn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkDyn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkDyn.Location = new System.Drawing.Point(222, 195);
            this.blkDyn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkDyn.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkDyn.Name = "blkDyn";
            this.blkDyn.Radius = 4;
            this.blkDyn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkDyn.Size = new System.Drawing.Size(240, 138);
            this.blkDyn.TabIndex = 99;
            this.blkDyn.Text = null;
            this.blkDyn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWriteDyn
            // 
            this.btnWriteDyn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteDyn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteDyn.Location = new System.Drawing.Point(12, 96);
            this.btnWriteDyn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWriteDyn.Name = "btnWriteDyn";
            this.btnWriteDyn.Size = new System.Drawing.Size(87, 38);
            this.btnWriteDyn.TabIndex = 99;
            this.btnWriteDyn.Text = "写入";
            this.btnWriteDyn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lblDynCap
            // 
            this.lblDynCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDynCap.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDynCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDynCap.Location = new System.Drawing.Point(12, 14);
            this.lblDynCap.Name = "lblDynCap";
            this.lblDynCap.Size = new System.Drawing.Size(110, 26);
            this.lblDynCap.TabIndex = 100;
            this.lblDynCap.Text = "动态阈值";
            this.lblDynCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbDyn
            // 
            this.trbDyn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trbDyn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbDyn.Location = new System.Drawing.Point(12, 44);
            this.trbDyn.Maximum = 30;
            this.trbDyn.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbDyn.Name = "trbDyn";
            this.trbDyn.Size = new System.Drawing.Size(216, 44);
            this.trbDyn.TabIndex = 101;
            this.trbDyn.Value = 10;
            // 
            // txtDyn
            // 
            this.txtDyn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDyn.DoubleValue = 10D;
            this.txtDyn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDyn.IntValue = 10;
            this.txtDyn.Location = new System.Drawing.Point(110, 96);
            this.txtDyn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDyn.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDyn.Name = "txtDyn";
            this.txtDyn.Padding = new System.Windows.Forms.Padding(5);
            this.txtDyn.ShowText = false;
            this.txtDyn.Size = new System.Drawing.Size(116, 32);
            this.txtDyn.TabIndex = 102;
            this.txtDyn.Text = "10";
            this.txtDyn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDyn.Watermark = "";
            // 
            // blkAreaMax
            // 
            this.blkAreaMax.Controls.Add(this.btnWriteAreaMax);
            this.blkAreaMax.Controls.Add(this.lblAreaMaxCap);
            this.blkAreaMax.Controls.Add(this.trbAreaMax);
            this.blkAreaMax.Controls.Add(this.txtAreaMax);
            this.blkAreaMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkAreaMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkAreaMax.Location = new System.Drawing.Point(222, 350);
            this.blkAreaMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkAreaMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkAreaMax.Name = "blkAreaMax";
            this.blkAreaMax.Radius = 4;
            this.blkAreaMax.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkAreaMax.Size = new System.Drawing.Size(240, 138);
            this.blkAreaMax.TabIndex = 103;
            this.blkAreaMax.Text = null;
            this.blkAreaMax.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWriteAreaMax
            // 
            this.btnWriteAreaMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteAreaMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteAreaMax.Location = new System.Drawing.Point(12, 96);
            this.btnWriteAreaMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWriteAreaMax.Name = "btnWriteAreaMax";
            this.btnWriteAreaMax.Size = new System.Drawing.Size(87, 38);
            this.btnWriteAreaMax.TabIndex = 99;
            this.btnWriteAreaMax.Text = "写入";
            this.btnWriteAreaMax.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lblAreaMaxCap
            // 
            this.lblAreaMaxCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAreaMaxCap.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAreaMaxCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAreaMaxCap.Location = new System.Drawing.Point(12, 14);
            this.lblAreaMaxCap.Name = "lblAreaMaxCap";
            this.lblAreaMaxCap.Size = new System.Drawing.Size(110, 26);
            this.lblAreaMaxCap.TabIndex = 104;
            this.lblAreaMaxCap.Text = "面积上限";
            this.lblAreaMaxCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbAreaMax
            // 
            this.trbAreaMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trbAreaMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbAreaMax.Location = new System.Drawing.Point(12, 44);
            this.trbAreaMax.Maximum = 15000000;
            this.trbAreaMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbAreaMax.Name = "trbAreaMax";
            this.trbAreaMax.Size = new System.Drawing.Size(216, 44);
            this.trbAreaMax.TabIndex = 105;
            this.trbAreaMax.Value = 9999999;
            // 
            // txtAreaMax
            // 
            this.txtAreaMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAreaMax.DoubleValue = 9999999D;
            this.txtAreaMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAreaMax.IntValue = 9999999;
            this.txtAreaMax.Location = new System.Drawing.Point(110, 96);
            this.txtAreaMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAreaMax.Name = "txtAreaMax";
            this.txtAreaMax.Padding = new System.Windows.Forms.Padding(5);
            this.txtAreaMax.ShowText = false;
            this.txtAreaMax.Size = new System.Drawing.Size(116, 32);
            this.txtAreaMax.TabIndex = 106;
            this.txtAreaMax.Text = "9999999";
            this.txtAreaMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAreaMax.Watermark = "";
            // 
            // blkAreaMin
            // 
            this.blkAreaMin.Controls.Add(this.btnWriteAreaMin);
            this.blkAreaMin.Controls.Add(this.lblAreaMinCap);
            this.blkAreaMin.Controls.Add(this.trbAreaMin);
            this.blkAreaMin.Controls.Add(this.txtAreaMin);
            this.blkAreaMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkAreaMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkAreaMin.Location = new System.Drawing.Point(222, 505);
            this.blkAreaMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkAreaMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkAreaMin.Name = "blkAreaMin";
            this.blkAreaMin.Radius = 4;
            this.blkAreaMin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkAreaMin.Size = new System.Drawing.Size(240, 138);
            this.blkAreaMin.TabIndex = 107;
            this.blkAreaMin.Text = null;
            this.blkAreaMin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWriteAreaMin
            // 
            this.btnWriteAreaMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteAreaMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteAreaMin.Location = new System.Drawing.Point(12, 96);
            this.btnWriteAreaMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWriteAreaMin.Name = "btnWriteAreaMin";
            this.btnWriteAreaMin.Size = new System.Drawing.Size(87, 38);
            this.btnWriteAreaMin.TabIndex = 99;
            this.btnWriteAreaMin.Text = "写入";
            this.btnWriteAreaMin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lblAreaMinCap
            // 
            this.lblAreaMinCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAreaMinCap.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAreaMinCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAreaMinCap.Location = new System.Drawing.Point(12, 14);
            this.lblAreaMinCap.Name = "lblAreaMinCap";
            this.lblAreaMinCap.Size = new System.Drawing.Size(110, 26);
            this.lblAreaMinCap.TabIndex = 108;
            this.lblAreaMinCap.Text = "面积下限";
            this.lblAreaMinCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbAreaMin
            // 
            this.trbAreaMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trbAreaMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbAreaMin.Location = new System.Drawing.Point(12, 44);
            this.trbAreaMin.Maximum = 6000;
            this.trbAreaMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbAreaMin.Name = "trbAreaMin";
            this.trbAreaMin.Size = new System.Drawing.Size(216, 44);
            this.trbAreaMin.TabIndex = 109;
            this.trbAreaMin.Value = 5000;
            // 
            // txtAreaMin
            // 
            this.txtAreaMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAreaMin.DoubleValue = 5000D;
            this.txtAreaMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAreaMin.IntValue = 5000;
            this.txtAreaMin.Location = new System.Drawing.Point(110, 96);
            this.txtAreaMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAreaMin.Name = "txtAreaMin";
            this.txtAreaMin.Padding = new System.Windows.Forms.Padding(5);
            this.txtAreaMin.ShowText = false;
            this.txtAreaMin.Size = new System.Drawing.Size(116, 32);
            this.txtAreaMin.TabIndex = 110;
            this.txtAreaMin.Text = "5000";
            this.txtAreaMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAreaMin.Watermark = "";
            // 
            // grpPixelCoord
            // 
            this.grpPixelCoord.Controls.Add(this.lblColHeader);
            this.grpPixelCoord.Controls.Add(this.lblRowHeader);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint0);
            this.grpPixelCoord.Controls.Add(this.txtPixCol0);
            this.grpPixelCoord.Controls.Add(this.txtPixRow0);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint1);
            this.grpPixelCoord.Controls.Add(this.txtPixCol1);
            this.grpPixelCoord.Controls.Add(this.txtPixRow1);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint2);
            this.grpPixelCoord.Controls.Add(this.txtPixCol2);
            this.grpPixelCoord.Controls.Add(this.txtPixRow2);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint3);
            this.grpPixelCoord.Controls.Add(this.txtPixCol3);
            this.grpPixelCoord.Controls.Add(this.txtPixRow3);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint4);
            this.grpPixelCoord.Controls.Add(this.txtPixCol4);
            this.grpPixelCoord.Controls.Add(this.txtPixRow4);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint5);
            this.grpPixelCoord.Controls.Add(this.txtPixCol5);
            this.grpPixelCoord.Controls.Add(this.txtPixRow5);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint6);
            this.grpPixelCoord.Controls.Add(this.txtPixCol6);
            this.grpPixelCoord.Controls.Add(this.txtPixRow6);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint7);
            this.grpPixelCoord.Controls.Add(this.txtPixCol7);
            this.grpPixelCoord.Controls.Add(this.txtPixRow7);
            this.grpPixelCoord.Controls.Add(this.lblPixPoint8);
            this.grpPixelCoord.Controls.Add(this.txtPixCol8);
            this.grpPixelCoord.Controls.Add(this.txtPixRow8);
            this.grpPixelCoord.Controls.Add(this.btnSavePixel);
            this.grpPixelCoord.Controls.Add(this.btnReadPixel);
            this.grpPixelCoord.FillColor = System.Drawing.Color.White;
            this.grpPixelCoord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpPixelCoord.Location = new System.Drawing.Point(486, 6);
            this.grpPixelCoord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPixelCoord.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpPixelCoord.Name = "grpPixelCoord";
            this.grpPixelCoord.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpPixelCoord.Size = new System.Drawing.Size(345, 758);
            this.grpPixelCoord.TabIndex = 111;
            this.grpPixelCoord.Text = "像素坐标";
            this.grpPixelCoord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColHeader
            // 
            this.lblColHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblColHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblColHeader.Location = new System.Drawing.Point(98, 34);
            this.lblColHeader.Name = "lblColHeader";
            this.lblColHeader.Size = new System.Drawing.Size(80, 24);
            this.lblColHeader.TabIndex = 112;
            this.lblColHeader.Text = "Column";
            this.lblColHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRowHeader
            // 
            this.lblRowHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRowHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRowHeader.Location = new System.Drawing.Point(196, 34);
            this.lblRowHeader.Name = "lblRowHeader";
            this.lblRowHeader.Size = new System.Drawing.Size(80, 24);
            this.lblRowHeader.TabIndex = 113;
            this.lblRowHeader.Text = "Row";
            this.lblRowHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPixPoint0
            // 
            this.lblPixPoint0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint0.Location = new System.Drawing.Point(16, 68);
            this.lblPixPoint0.Name = "lblPixPoint0";
            this.lblPixPoint0.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint0.TabIndex = 114;
            this.lblPixPoint0.Text = "0号点";
            this.lblPixPoint0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol0
            // 
            this.txtPixCol0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol0.Location = new System.Drawing.Point(98, 66);
            this.txtPixCol0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol0.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol0.Name = "txtPixCol0";
            this.txtPixCol0.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol0.ShowText = false;
            this.txtPixCol0.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol0.TabIndex = 115;
            this.txtPixCol0.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol0.Watermark = "";
            // 
            // txtPixRow0
            // 
            this.txtPixRow0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow0.Location = new System.Drawing.Point(196, 66);
            this.txtPixRow0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow0.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow0.Name = "txtPixRow0";
            this.txtPixRow0.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow0.ShowText = false;
            this.txtPixRow0.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow0.TabIndex = 116;
            this.txtPixRow0.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow0.Watermark = "";
            // 
            // lblPixPoint1
            // 
            this.lblPixPoint1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint1.Location = new System.Drawing.Point(16, 126);
            this.lblPixPoint1.Name = "lblPixPoint1";
            this.lblPixPoint1.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint1.TabIndex = 117;
            this.lblPixPoint1.Text = "1号点";
            this.lblPixPoint1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol1
            // 
            this.txtPixCol1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol1.Location = new System.Drawing.Point(98, 124);
            this.txtPixCol1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol1.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol1.Name = "txtPixCol1";
            this.txtPixCol1.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol1.ShowText = false;
            this.txtPixCol1.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol1.TabIndex = 118;
            this.txtPixCol1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol1.Watermark = "";
            // 
            // txtPixRow1
            // 
            this.txtPixRow1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow1.Location = new System.Drawing.Point(196, 124);
            this.txtPixRow1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow1.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow1.Name = "txtPixRow1";
            this.txtPixRow1.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow1.ShowText = false;
            this.txtPixRow1.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow1.TabIndex = 119;
            this.txtPixRow1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow1.Watermark = "";
            // 
            // lblPixPoint2
            // 
            this.lblPixPoint2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint2.Location = new System.Drawing.Point(16, 184);
            this.lblPixPoint2.Name = "lblPixPoint2";
            this.lblPixPoint2.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint2.TabIndex = 120;
            this.lblPixPoint2.Text = "2号点";
            this.lblPixPoint2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol2
            // 
            this.txtPixCol2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol2.Location = new System.Drawing.Point(98, 182);
            this.txtPixCol2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol2.Name = "txtPixCol2";
            this.txtPixCol2.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol2.ShowText = false;
            this.txtPixCol2.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol2.TabIndex = 121;
            this.txtPixCol2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol2.Watermark = "";
            // 
            // txtPixRow2
            // 
            this.txtPixRow2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow2.Location = new System.Drawing.Point(196, 182);
            this.txtPixRow2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow2.Name = "txtPixRow2";
            this.txtPixRow2.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow2.ShowText = false;
            this.txtPixRow2.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow2.TabIndex = 122;
            this.txtPixRow2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow2.Watermark = "";
            // 
            // lblPixPoint3
            // 
            this.lblPixPoint3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint3.Location = new System.Drawing.Point(16, 242);
            this.lblPixPoint3.Name = "lblPixPoint3";
            this.lblPixPoint3.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint3.TabIndex = 123;
            this.lblPixPoint3.Text = "3号点";
            this.lblPixPoint3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol3
            // 
            this.txtPixCol3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol3.Location = new System.Drawing.Point(98, 240);
            this.txtPixCol3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol3.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol3.Name = "txtPixCol3";
            this.txtPixCol3.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol3.ShowText = false;
            this.txtPixCol3.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol3.TabIndex = 124;
            this.txtPixCol3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol3.Watermark = "";
            // 
            // txtPixRow3
            // 
            this.txtPixRow3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow3.Location = new System.Drawing.Point(196, 240);
            this.txtPixRow3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow3.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow3.Name = "txtPixRow3";
            this.txtPixRow3.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow3.ShowText = false;
            this.txtPixRow3.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow3.TabIndex = 125;
            this.txtPixRow3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow3.Watermark = "";
            // 
            // lblPixPoint4
            // 
            this.lblPixPoint4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint4.Location = new System.Drawing.Point(16, 300);
            this.lblPixPoint4.Name = "lblPixPoint4";
            this.lblPixPoint4.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint4.TabIndex = 126;
            this.lblPixPoint4.Text = "4号点";
            this.lblPixPoint4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol4
            // 
            this.txtPixCol4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol4.Location = new System.Drawing.Point(98, 298);
            this.txtPixCol4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol4.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol4.Name = "txtPixCol4";
            this.txtPixCol4.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol4.ShowText = false;
            this.txtPixCol4.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol4.TabIndex = 127;
            this.txtPixCol4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol4.Watermark = "";
            // 
            // txtPixRow4
            // 
            this.txtPixRow4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow4.Location = new System.Drawing.Point(196, 298);
            this.txtPixRow4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow4.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow4.Name = "txtPixRow4";
            this.txtPixRow4.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow4.ShowText = false;
            this.txtPixRow4.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow4.TabIndex = 128;
            this.txtPixRow4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow4.Watermark = "";
            // 
            // lblPixPoint5
            // 
            this.lblPixPoint5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint5.Location = new System.Drawing.Point(16, 358);
            this.lblPixPoint5.Name = "lblPixPoint5";
            this.lblPixPoint5.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint5.TabIndex = 129;
            this.lblPixPoint5.Text = "5号点";
            this.lblPixPoint5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol5
            // 
            this.txtPixCol5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol5.Location = new System.Drawing.Point(98, 356);
            this.txtPixCol5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol5.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol5.Name = "txtPixCol5";
            this.txtPixCol5.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol5.ShowText = false;
            this.txtPixCol5.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol5.TabIndex = 130;
            this.txtPixCol5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol5.Watermark = "";
            // 
            // txtPixRow5
            // 
            this.txtPixRow5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow5.Location = new System.Drawing.Point(196, 356);
            this.txtPixRow5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow5.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow5.Name = "txtPixRow5";
            this.txtPixRow5.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow5.ShowText = false;
            this.txtPixRow5.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow5.TabIndex = 131;
            this.txtPixRow5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow5.Watermark = "";
            // 
            // lblPixPoint6
            // 
            this.lblPixPoint6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint6.Location = new System.Drawing.Point(16, 416);
            this.lblPixPoint6.Name = "lblPixPoint6";
            this.lblPixPoint6.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint6.TabIndex = 132;
            this.lblPixPoint6.Text = "6号点";
            this.lblPixPoint6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol6
            // 
            this.txtPixCol6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol6.Location = new System.Drawing.Point(98, 414);
            this.txtPixCol6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol6.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol6.Name = "txtPixCol6";
            this.txtPixCol6.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol6.ShowText = false;
            this.txtPixCol6.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol6.TabIndex = 133;
            this.txtPixCol6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol6.Watermark = "";
            // 
            // txtPixRow6
            // 
            this.txtPixRow6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow6.Location = new System.Drawing.Point(196, 414);
            this.txtPixRow6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow6.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow6.Name = "txtPixRow6";
            this.txtPixRow6.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow6.ShowText = false;
            this.txtPixRow6.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow6.TabIndex = 134;
            this.txtPixRow6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow6.Watermark = "";
            // 
            // lblPixPoint7
            // 
            this.lblPixPoint7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint7.Location = new System.Drawing.Point(16, 474);
            this.lblPixPoint7.Name = "lblPixPoint7";
            this.lblPixPoint7.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint7.TabIndex = 135;
            this.lblPixPoint7.Text = "7号点";
            this.lblPixPoint7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol7
            // 
            this.txtPixCol7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol7.Location = new System.Drawing.Point(98, 472);
            this.txtPixCol7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol7.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol7.Name = "txtPixCol7";
            this.txtPixCol7.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol7.ShowText = false;
            this.txtPixCol7.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol7.TabIndex = 136;
            this.txtPixCol7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol7.Watermark = "";
            // 
            // txtPixRow7
            // 
            this.txtPixRow7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow7.Location = new System.Drawing.Point(196, 472);
            this.txtPixRow7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow7.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow7.Name = "txtPixRow7";
            this.txtPixRow7.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow7.ShowText = false;
            this.txtPixRow7.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow7.TabIndex = 137;
            this.txtPixRow7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow7.Watermark = "";
            // 
            // lblPixPoint8
            // 
            this.lblPixPoint8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixPoint8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPixPoint8.Location = new System.Drawing.Point(16, 532);
            this.lblPixPoint8.Name = "lblPixPoint8";
            this.lblPixPoint8.Size = new System.Drawing.Size(74, 29);
            this.lblPixPoint8.TabIndex = 138;
            this.lblPixPoint8.Text = "8号点";
            this.lblPixPoint8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPixCol8
            // 
            this.txtPixCol8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixCol8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixCol8.Location = new System.Drawing.Point(98, 530);
            this.txtPixCol8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixCol8.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixCol8.Name = "txtPixCol8";
            this.txtPixCol8.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixCol8.ShowText = false;
            this.txtPixCol8.Size = new System.Drawing.Size(88, 32);
            this.txtPixCol8.TabIndex = 139;
            this.txtPixCol8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixCol8.Watermark = "";
            // 
            // txtPixRow8
            // 
            this.txtPixRow8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPixRow8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPixRow8.Location = new System.Drawing.Point(196, 530);
            this.txtPixRow8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixRow8.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPixRow8.Name = "txtPixRow8";
            this.txtPixRow8.Padding = new System.Windows.Forms.Padding(5);
            this.txtPixRow8.ShowText = false;
            this.txtPixRow8.Size = new System.Drawing.Size(88, 32);
            this.txtPixRow8.TabIndex = 140;
            this.txtPixRow8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPixRow8.Watermark = "";
            // 
            // btnSavePixel
            // 
            this.btnSavePixel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePixel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSavePixel.Location = new System.Drawing.Point(30, 586);
            this.btnSavePixel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSavePixel.Name = "btnSavePixel";
            this.btnSavePixel.Size = new System.Drawing.Size(110, 46);
            this.btnSavePixel.TabIndex = 141;
            this.btnSavePixel.Text = "保存位置";
            this.btnSavePixel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnReadPixel
            // 
            this.btnReadPixel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadPixel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadPixel.Location = new System.Drawing.Point(158, 586);
            this.btnReadPixel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReadPixel.Name = "btnReadPixel";
            this.btnReadPixel.Size = new System.Drawing.Size(110, 46);
            this.btnReadPixel.TabIndex = 142;
            this.btnReadPixel.Text = "读取位置";
            this.btnReadPixel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // grpRobotCoord
            // 
            this.grpRobotCoord.Controls.Add(this.lblXHeader);
            this.grpRobotCoord.Controls.Add(this.lblYHeader);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint0);
            this.grpRobotCoord.Controls.Add(this.txtRobotX0);
            this.grpRobotCoord.Controls.Add(this.txtRobotY0);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint1);
            this.grpRobotCoord.Controls.Add(this.txtRobotX1);
            this.grpRobotCoord.Controls.Add(this.txtRobotY1);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint2);
            this.grpRobotCoord.Controls.Add(this.txtRobotX2);
            this.grpRobotCoord.Controls.Add(this.txtRobotY2);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint3);
            this.grpRobotCoord.Controls.Add(this.txtRobotX3);
            this.grpRobotCoord.Controls.Add(this.txtRobotY3);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint4);
            this.grpRobotCoord.Controls.Add(this.txtRobotX4);
            this.grpRobotCoord.Controls.Add(this.txtRobotY4);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint5);
            this.grpRobotCoord.Controls.Add(this.txtRobotX5);
            this.grpRobotCoord.Controls.Add(this.txtRobotY5);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint6);
            this.grpRobotCoord.Controls.Add(this.txtRobotX6);
            this.grpRobotCoord.Controls.Add(this.txtRobotY6);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint7);
            this.grpRobotCoord.Controls.Add(this.txtRobotX7);
            this.grpRobotCoord.Controls.Add(this.txtRobotY7);
            this.grpRobotCoord.Controls.Add(this.lblRobotPoint8);
            this.grpRobotCoord.Controls.Add(this.txtRobotX8);
            this.grpRobotCoord.Controls.Add(this.txtRobotY8);
            this.grpRobotCoord.Controls.Add(this.btnSaveRobot);
            this.grpRobotCoord.Controls.Add(this.btnReadRobot);
            this.grpRobotCoord.FillColor = System.Drawing.Color.White;
            this.grpRobotCoord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpRobotCoord.Location = new System.Drawing.Point(839, 6);
            this.grpRobotCoord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRobotCoord.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpRobotCoord.Name = "grpRobotCoord";
            this.grpRobotCoord.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpRobotCoord.Size = new System.Drawing.Size(349, 758);
            this.grpRobotCoord.TabIndex = 143;
            this.grpRobotCoord.Text = "机械手坐标记录";
            this.grpRobotCoord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblXHeader
            // 
            this.lblXHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblXHeader.Location = new System.Drawing.Point(110, 36);
            this.lblXHeader.Name = "lblXHeader";
            this.lblXHeader.Size = new System.Drawing.Size(80, 24);
            this.lblXHeader.TabIndex = 144;
            this.lblXHeader.Text = "X坐标";
            this.lblXHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYHeader
            // 
            this.lblYHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblYHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblYHeader.Location = new System.Drawing.Point(222, 36);
            this.lblYHeader.Name = "lblYHeader";
            this.lblYHeader.Size = new System.Drawing.Size(80, 24);
            this.lblYHeader.TabIndex = 145;
            this.lblYHeader.Text = "Y坐标";
            this.lblYHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRobotPoint0
            // 
            this.lblRobotPoint0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint0.Location = new System.Drawing.Point(16, 68);
            this.lblRobotPoint0.Name = "lblRobotPoint0";
            this.lblRobotPoint0.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint0.TabIndex = 146;
            this.lblRobotPoint0.Text = "0号点";
            this.lblRobotPoint0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX0
            // 
            this.txtRobotX0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX0.Location = new System.Drawing.Point(110, 68);
            this.txtRobotX0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX0.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX0.Name = "txtRobotX0";
            this.txtRobotX0.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX0.ShowText = false;
            this.txtRobotX0.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX0.TabIndex = 147;
            this.txtRobotX0.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX0.Watermark = "";
            // 
            // txtRobotY0
            // 
            this.txtRobotY0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY0.Location = new System.Drawing.Point(222, 68);
            this.txtRobotY0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY0.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY0.Name = "txtRobotY0";
            this.txtRobotY0.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY0.ShowText = false;
            this.txtRobotY0.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY0.TabIndex = 148;
            this.txtRobotY0.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY0.Watermark = "";
            // 
            // lblRobotPoint1
            // 
            this.lblRobotPoint1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint1.Location = new System.Drawing.Point(16, 126);
            this.lblRobotPoint1.Name = "lblRobotPoint1";
            this.lblRobotPoint1.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint1.TabIndex = 149;
            this.lblRobotPoint1.Text = "1号点";
            this.lblRobotPoint1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX1
            // 
            this.txtRobotX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX1.Location = new System.Drawing.Point(110, 126);
            this.txtRobotX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX1.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX1.Name = "txtRobotX1";
            this.txtRobotX1.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX1.ShowText = false;
            this.txtRobotX1.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX1.TabIndex = 150;
            this.txtRobotX1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX1.Watermark = "";
            // 
            // txtRobotY1
            // 
            this.txtRobotY1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY1.Location = new System.Drawing.Point(222, 126);
            this.txtRobotY1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY1.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY1.Name = "txtRobotY1";
            this.txtRobotY1.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY1.ShowText = false;
            this.txtRobotY1.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY1.TabIndex = 151;
            this.txtRobotY1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY1.Watermark = "";
            // 
            // lblRobotPoint2
            // 
            this.lblRobotPoint2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint2.Location = new System.Drawing.Point(16, 184);
            this.lblRobotPoint2.Name = "lblRobotPoint2";
            this.lblRobotPoint2.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint2.TabIndex = 152;
            this.lblRobotPoint2.Text = "2号点";
            this.lblRobotPoint2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX2
            // 
            this.txtRobotX2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX2.Location = new System.Drawing.Point(110, 184);
            this.txtRobotX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX2.Name = "txtRobotX2";
            this.txtRobotX2.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX2.ShowText = false;
            this.txtRobotX2.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX2.TabIndex = 153;
            this.txtRobotX2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX2.Watermark = "";
            // 
            // txtRobotY2
            // 
            this.txtRobotY2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY2.Location = new System.Drawing.Point(222, 184);
            this.txtRobotY2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY2.Name = "txtRobotY2";
            this.txtRobotY2.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY2.ShowText = false;
            this.txtRobotY2.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY2.TabIndex = 154;
            this.txtRobotY2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY2.Watermark = "";
            // 
            // lblRobotPoint3
            // 
            this.lblRobotPoint3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint3.Location = new System.Drawing.Point(16, 242);
            this.lblRobotPoint3.Name = "lblRobotPoint3";
            this.lblRobotPoint3.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint3.TabIndex = 155;
            this.lblRobotPoint3.Text = "3号点";
            this.lblRobotPoint3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX3
            // 
            this.txtRobotX3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX3.Location = new System.Drawing.Point(110, 242);
            this.txtRobotX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX3.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX3.Name = "txtRobotX3";
            this.txtRobotX3.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX3.ShowText = false;
            this.txtRobotX3.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX3.TabIndex = 156;
            this.txtRobotX3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX3.Watermark = "";
            // 
            // txtRobotY3
            // 
            this.txtRobotY3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY3.Location = new System.Drawing.Point(222, 242);
            this.txtRobotY3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY3.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY3.Name = "txtRobotY3";
            this.txtRobotY3.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY3.ShowText = false;
            this.txtRobotY3.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY3.TabIndex = 157;
            this.txtRobotY3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY3.Watermark = "";
            // 
            // lblRobotPoint4
            // 
            this.lblRobotPoint4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint4.Location = new System.Drawing.Point(16, 300);
            this.lblRobotPoint4.Name = "lblRobotPoint4";
            this.lblRobotPoint4.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint4.TabIndex = 158;
            this.lblRobotPoint4.Text = "4号点";
            this.lblRobotPoint4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX4
            // 
            this.txtRobotX4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX4.Location = new System.Drawing.Point(110, 300);
            this.txtRobotX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX4.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX4.Name = "txtRobotX4";
            this.txtRobotX4.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX4.ShowText = false;
            this.txtRobotX4.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX4.TabIndex = 159;
            this.txtRobotX4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX4.Watermark = "";
            // 
            // txtRobotY4
            // 
            this.txtRobotY4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY4.Location = new System.Drawing.Point(222, 300);
            this.txtRobotY4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY4.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY4.Name = "txtRobotY4";
            this.txtRobotY4.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY4.ShowText = false;
            this.txtRobotY4.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY4.TabIndex = 160;
            this.txtRobotY4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY4.Watermark = "";
            // 
            // lblRobotPoint5
            // 
            this.lblRobotPoint5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint5.Location = new System.Drawing.Point(16, 358);
            this.lblRobotPoint5.Name = "lblRobotPoint5";
            this.lblRobotPoint5.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint5.TabIndex = 161;
            this.lblRobotPoint5.Text = "5号点";
            this.lblRobotPoint5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX5
            // 
            this.txtRobotX5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX5.Location = new System.Drawing.Point(110, 358);
            this.txtRobotX5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX5.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX5.Name = "txtRobotX5";
            this.txtRobotX5.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX5.ShowText = false;
            this.txtRobotX5.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX5.TabIndex = 162;
            this.txtRobotX5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX5.Watermark = "";
            // 
            // txtRobotY5
            // 
            this.txtRobotY5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY5.Location = new System.Drawing.Point(222, 358);
            this.txtRobotY5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY5.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY5.Name = "txtRobotY5";
            this.txtRobotY5.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY5.ShowText = false;
            this.txtRobotY5.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY5.TabIndex = 163;
            this.txtRobotY5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY5.Watermark = "";
            // 
            // lblRobotPoint6
            // 
            this.lblRobotPoint6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint6.Location = new System.Drawing.Point(16, 416);
            this.lblRobotPoint6.Name = "lblRobotPoint6";
            this.lblRobotPoint6.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint6.TabIndex = 164;
            this.lblRobotPoint6.Text = "6号点";
            this.lblRobotPoint6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX6
            // 
            this.txtRobotX6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX6.Location = new System.Drawing.Point(110, 416);
            this.txtRobotX6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX6.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX6.Name = "txtRobotX6";
            this.txtRobotX6.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX6.ShowText = false;
            this.txtRobotX6.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX6.TabIndex = 165;
            this.txtRobotX6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX6.Watermark = "";
            // 
            // txtRobotY6
            // 
            this.txtRobotY6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY6.Location = new System.Drawing.Point(222, 416);
            this.txtRobotY6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY6.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY6.Name = "txtRobotY6";
            this.txtRobotY6.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY6.ShowText = false;
            this.txtRobotY6.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY6.TabIndex = 166;
            this.txtRobotY6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY6.Watermark = "";
            // 
            // lblRobotPoint7
            // 
            this.lblRobotPoint7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint7.Location = new System.Drawing.Point(16, 474);
            this.lblRobotPoint7.Name = "lblRobotPoint7";
            this.lblRobotPoint7.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint7.TabIndex = 167;
            this.lblRobotPoint7.Text = "7号点";
            this.lblRobotPoint7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX7
            // 
            this.txtRobotX7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX7.Location = new System.Drawing.Point(110, 474);
            this.txtRobotX7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX7.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX7.Name = "txtRobotX7";
            this.txtRobotX7.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX7.ShowText = false;
            this.txtRobotX7.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX7.TabIndex = 168;
            this.txtRobotX7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX7.Watermark = "";
            // 
            // txtRobotY7
            // 
            this.txtRobotY7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY7.Location = new System.Drawing.Point(222, 474);
            this.txtRobotY7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY7.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY7.Name = "txtRobotY7";
            this.txtRobotY7.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY7.ShowText = false;
            this.txtRobotY7.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY7.TabIndex = 169;
            this.txtRobotY7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY7.Watermark = "";
            // 
            // lblRobotPoint8
            // 
            this.lblRobotPoint8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRobotPoint8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRobotPoint8.Location = new System.Drawing.Point(16, 532);
            this.lblRobotPoint8.Name = "lblRobotPoint8";
            this.lblRobotPoint8.Size = new System.Drawing.Size(74, 29);
            this.lblRobotPoint8.TabIndex = 170;
            this.lblRobotPoint8.Text = "8号点";
            this.lblRobotPoint8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRobotX8
            // 
            this.txtRobotX8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotX8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotX8.Location = new System.Drawing.Point(110, 532);
            this.txtRobotX8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotX8.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotX8.Name = "txtRobotX8";
            this.txtRobotX8.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotX8.ShowText = false;
            this.txtRobotX8.Size = new System.Drawing.Size(88, 32);
            this.txtRobotX8.TabIndex = 171;
            this.txtRobotX8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotX8.Watermark = "";
            // 
            // txtRobotY8
            // 
            this.txtRobotY8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobotY8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobotY8.Location = new System.Drawing.Point(222, 532);
            this.txtRobotY8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotY8.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobotY8.Name = "txtRobotY8";
            this.txtRobotY8.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobotY8.ShowText = false;
            this.txtRobotY8.Size = new System.Drawing.Size(88, 32);
            this.txtRobotY8.TabIndex = 172;
            this.txtRobotY8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobotY8.Watermark = "";
            // 
            // btnSaveRobot
            // 
            this.btnSaveRobot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveRobot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveRobot.Location = new System.Drawing.Point(30, 586);
            this.btnSaveRobot.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveRobot.Name = "btnSaveRobot";
            this.btnSaveRobot.Size = new System.Drawing.Size(110, 46);
            this.btnSaveRobot.TabIndex = 173;
            this.btnSaveRobot.Text = "保存位置";
            this.btnSaveRobot.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnReadRobot
            // 
            this.btnReadRobot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadRobot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadRobot.Location = new System.Drawing.Point(158, 586);
            this.btnReadRobot.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReadRobot.Name = "btnReadRobot";
            this.btnReadRobot.Size = new System.Drawing.Size(110, 46);
            this.btnReadRobot.TabIndex = 174;
            this.btnReadRobot.Text = "读取位置";
            this.btnReadRobot.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabLocate
            // 
            this.tabLocate.BackColor = System.Drawing.Color.White;
            this.tabLocate.Controls.Add(this.grpLocateMode);
            this.tabLocate.Controls.Add(this.pnlBlobParam);
            this.tabLocate.Controls.Add(this.pnlTemplateParam);
            this.tabLocate.Controls.Add(this.btnMoveToBase);
            this.tabLocate.Controls.Add(this.btnFlowRight1);
            this.tabLocate.Controls.Add(this.btnRecognize);
            this.tabLocate.Controls.Add(this.btnFlowRight2);
            this.tabLocate.Controls.Add(this.btnAnyGrab);
            this.tabLocate.Location = new System.Drawing.Point(0, 40);
            this.tabLocate.Name = "tabLocate";
            this.tabLocate.Size = new System.Drawing.Size(1204, 775);
            this.tabLocate.TabIndex = 10;
            this.tabLocate.Text = "多产品定位抓取";
            // 
            // grpLocateMode
            // 
            this.grpLocateMode.Controls.Add(this.rdoBlobAnalysis);
            this.grpLocateMode.Controls.Add(this.rdoTemplateMatch);
            this.grpLocateMode.FillColor = System.Drawing.Color.White;
            this.grpLocateMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpLocateMode.Location = new System.Drawing.Point(8, 6);
            this.grpLocateMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLocateMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpLocateMode.Name = "grpLocateMode";
            this.grpLocateMode.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpLocateMode.Size = new System.Drawing.Size(1180, 104);
            this.grpLocateMode.TabIndex = 175;
            this.grpLocateMode.Text = "定位模式";
            this.grpLocateMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoBlobAnalysis
            // 
            this.rdoBlobAnalysis.Checked = true;
            this.rdoBlobAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBlobAnalysis.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoBlobAnalysis.Location = new System.Drawing.Point(340, 44);
            this.rdoBlobAnalysis.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoBlobAnalysis.Name = "rdoBlobAnalysis";
            this.rdoBlobAnalysis.Size = new System.Drawing.Size(130, 30);
            this.rdoBlobAnalysis.TabIndex = 176;
            this.rdoBlobAnalysis.Text = "blob分析";
            // 
            // rdoTemplateMatch
            // 
            this.rdoTemplateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTemplateMatch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoTemplateMatch.Location = new System.Drawing.Point(520, 44);
            this.rdoTemplateMatch.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoTemplateMatch.Name = "rdoTemplateMatch";
            this.rdoTemplateMatch.Size = new System.Drawing.Size(130, 30);
            this.rdoTemplateMatch.TabIndex = 177;
            this.rdoTemplateMatch.Text = "模板匹配";
            // 
            // pnlBlobParam
            // 
            this.pnlBlobParam.Controls.Add(this.blkMeanTh);
            this.pnlBlobParam.Controls.Add(this.blkAreaMaxTh);
            this.pnlBlobParam.Controls.Add(this.blkDynTh);
            this.pnlBlobParam.Controls.Add(this.blkAreaMinTh);
            this.pnlBlobParam.Controls.Add(this.trbMeanTh);
            this.pnlBlobParam.Controls.Add(this.txtMeanTh);
            this.pnlBlobParam.Controls.Add(this.trbAreaMaxTh);
            this.pnlBlobParam.Controls.Add(this.txtAreaMaxTh);
            this.pnlBlobParam.Controls.Add(this.rdoColorBlack);
            this.pnlBlobParam.Controls.Add(this.trbDynTh);
            this.pnlBlobParam.Controls.Add(this.txtDynTh);
            this.pnlBlobParam.Controls.Add(this.trbAreaMinTh);
            this.pnlBlobParam.Controls.Add(this.txtAreaMinTh);
            this.pnlBlobParam.Controls.Add(this.rdoColorWhite);
            this.pnlBlobParam.FillColor = System.Drawing.Color.White;
            this.pnlBlobParam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlBlobParam.Location = new System.Drawing.Point(8, 118);
            this.pnlBlobParam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBlobParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlBlobParam.Name = "pnlBlobParam";
            this.pnlBlobParam.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlBlobParam.Size = new System.Drawing.Size(1180, 180);
            this.pnlBlobParam.TabIndex = 178;
            this.pnlBlobParam.Text = null;
            this.pnlBlobParam.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkMeanTh
            // 
            this.blkMeanTh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkMeanTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkMeanTh.Location = new System.Drawing.Point(24, 28);
            this.blkMeanTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkMeanTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkMeanTh.Name = "blkMeanTh";
            this.blkMeanTh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkMeanTh.Size = new System.Drawing.Size(100, 36);
            this.blkMeanTh.TabIndex = 179;
            this.blkMeanTh.Text = "均值阈值";
            this.blkMeanTh.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkAreaMaxTh
            // 
            this.blkAreaMaxTh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkAreaMaxTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkAreaMaxTh.Location = new System.Drawing.Point(456, 28);
            this.blkAreaMaxTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkAreaMaxTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkAreaMaxTh.Name = "blkAreaMaxTh";
            this.blkAreaMaxTh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkAreaMaxTh.Size = new System.Drawing.Size(100, 36);
            this.blkAreaMaxTh.TabIndex = 180;
            this.blkAreaMaxTh.Text = "面积上限";
            this.blkAreaMaxTh.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkDynTh
            // 
            this.blkDynTh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkDynTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkDynTh.Location = new System.Drawing.Point(24, 92);
            this.blkDynTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkDynTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkDynTh.Name = "blkDynTh";
            this.blkDynTh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkDynTh.Size = new System.Drawing.Size(100, 36);
            this.blkDynTh.TabIndex = 181;
            this.blkDynTh.Text = "动态阈值";
            this.blkDynTh.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkAreaMinTh
            // 
            this.blkAreaMinTh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkAreaMinTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkAreaMinTh.Location = new System.Drawing.Point(456, 92);
            this.blkAreaMinTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkAreaMinTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkAreaMinTh.Name = "blkAreaMinTh";
            this.blkAreaMinTh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkAreaMinTh.Size = new System.Drawing.Size(100, 36);
            this.blkAreaMinTh.TabIndex = 182;
            this.blkAreaMinTh.Text = "面积下限";
            this.blkAreaMinTh.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbMeanTh
            // 
            this.trbMeanTh.BackColor = System.Drawing.Color.White;
            this.trbMeanTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbMeanTh.Location = new System.Drawing.Point(134, 22);
            this.trbMeanTh.Maximum = 500;
            this.trbMeanTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbMeanTh.Name = "trbMeanTh";
            this.trbMeanTh.Size = new System.Drawing.Size(190, 46);
            this.trbMeanTh.TabIndex = 183;
            this.trbMeanTh.Value = 300;
            // 
            // txtMeanTh
            // 
            this.txtMeanTh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMeanTh.DoubleValue = 300D;
            this.txtMeanTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMeanTh.IntValue = 300;
            this.txtMeanTh.Location = new System.Drawing.Point(336, 28);
            this.txtMeanTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMeanTh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMeanTh.Name = "txtMeanTh";
            this.txtMeanTh.Padding = new System.Windows.Forms.Padding(5);
            this.txtMeanTh.ShowText = false;
            this.txtMeanTh.Size = new System.Drawing.Size(100, 32);
            this.txtMeanTh.TabIndex = 184;
            this.txtMeanTh.Text = "300";
            this.txtMeanTh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMeanTh.Watermark = "";
            // 
            // trbAreaMaxTh
            // 
            this.trbAreaMaxTh.BackColor = System.Drawing.Color.White;
            this.trbAreaMaxTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbAreaMaxTh.Location = new System.Drawing.Point(566, 22);
            this.trbAreaMaxTh.Maximum = 1500000000;
            this.trbAreaMaxTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbAreaMaxTh.Name = "trbAreaMaxTh";
            this.trbAreaMaxTh.Size = new System.Drawing.Size(190, 46);
            this.trbAreaMaxTh.TabIndex = 185;
            this.trbAreaMaxTh.Value = 999999999;
            // 
            // txtAreaMaxTh
            // 
            this.txtAreaMaxTh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAreaMaxTh.DoubleValue = 999999999D;
            this.txtAreaMaxTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAreaMaxTh.IntValue = 999999999;
            this.txtAreaMaxTh.Location = new System.Drawing.Point(768, 28);
            this.txtAreaMaxTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaMaxTh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAreaMaxTh.Name = "txtAreaMaxTh";
            this.txtAreaMaxTh.Padding = new System.Windows.Forms.Padding(5);
            this.txtAreaMaxTh.ShowText = false;
            this.txtAreaMaxTh.Size = new System.Drawing.Size(120, 32);
            this.txtAreaMaxTh.TabIndex = 186;
            this.txtAreaMaxTh.Text = "999999999";
            this.txtAreaMaxTh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAreaMaxTh.Watermark = "";
            // 
            // rdoColorBlack
            // 
            this.rdoColorBlack.Checked = true;
            this.rdoColorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoColorBlack.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoColorBlack.Location = new System.Drawing.Point(912, 28);
            this.rdoColorBlack.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoColorBlack.Name = "rdoColorBlack";
            this.rdoColorBlack.Size = new System.Drawing.Size(80, 30);
            this.rdoColorBlack.TabIndex = 187;
            this.rdoColorBlack.Text = "黑";
            // 
            // trbDynTh
            // 
            this.trbDynTh.BackColor = System.Drawing.Color.White;
            this.trbDynTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbDynTh.Location = new System.Drawing.Point(134, 86);
            this.trbDynTh.Maximum = 200;
            this.trbDynTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbDynTh.Name = "trbDynTh";
            this.trbDynTh.Size = new System.Drawing.Size(190, 46);
            this.trbDynTh.TabIndex = 188;
            this.trbDynTh.Value = 50;
            // 
            // txtDynTh
            // 
            this.txtDynTh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDynTh.DoubleValue = 50D;
            this.txtDynTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDynTh.IntValue = 50;
            this.txtDynTh.Location = new System.Drawing.Point(336, 92);
            this.txtDynTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDynTh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDynTh.Name = "txtDynTh";
            this.txtDynTh.Padding = new System.Windows.Forms.Padding(5);
            this.txtDynTh.ShowText = false;
            this.txtDynTh.Size = new System.Drawing.Size(100, 32);
            this.txtDynTh.TabIndex = 189;
            this.txtDynTh.Text = "50";
            this.txtDynTh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDynTh.Watermark = "";
            // 
            // trbAreaMinTh
            // 
            this.trbAreaMinTh.BackColor = System.Drawing.Color.White;
            this.trbAreaMinTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbAreaMinTh.Location = new System.Drawing.Point(566, 86);
            this.trbAreaMinTh.Maximum = 2000;
            this.trbAreaMinTh.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbAreaMinTh.Name = "trbAreaMinTh";
            this.trbAreaMinTh.Size = new System.Drawing.Size(190, 46);
            this.trbAreaMinTh.TabIndex = 190;
            this.trbAreaMinTh.Value = 500;
            // 
            // txtAreaMinTh
            // 
            this.txtAreaMinTh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAreaMinTh.DoubleValue = 500D;
            this.txtAreaMinTh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAreaMinTh.IntValue = 500;
            this.txtAreaMinTh.Location = new System.Drawing.Point(768, 92);
            this.txtAreaMinTh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaMinTh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAreaMinTh.Name = "txtAreaMinTh";
            this.txtAreaMinTh.Padding = new System.Windows.Forms.Padding(5);
            this.txtAreaMinTh.ShowText = false;
            this.txtAreaMinTh.Size = new System.Drawing.Size(120, 32);
            this.txtAreaMinTh.TabIndex = 191;
            this.txtAreaMinTh.Text = "500";
            this.txtAreaMinTh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAreaMinTh.Watermark = "";
            // 
            // rdoColorWhite
            // 
            this.rdoColorWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoColorWhite.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoColorWhite.Location = new System.Drawing.Point(912, 92);
            this.rdoColorWhite.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoColorWhite.Name = "rdoColorWhite";
            this.rdoColorWhite.Size = new System.Drawing.Size(80, 30);
            this.rdoColorWhite.TabIndex = 192;
            this.rdoColorWhite.Text = "白";
            // 
            // pnlTemplateParam
            // 
            this.pnlTemplateParam.Controls.Add(this.blkTplContrast);
            this.pnlTemplateParam.Controls.Add(this.blkProdContrast);
            this.pnlTemplateParam.Controls.Add(this.blkMinScore);
            this.pnlTemplateParam.Controls.Add(this.blkGreedy);
            this.pnlTemplateParam.Controls.Add(this.blkCover);
            this.pnlTemplateParam.Controls.Add(this.trbTplContrast);
            this.pnlTemplateParam.Controls.Add(this.txtTplContrast);
            this.pnlTemplateParam.Controls.Add(this.trbProdContrast);
            this.pnlTemplateParam.Controls.Add(this.txtProdContrast);
            this.pnlTemplateParam.Controls.Add(this.btnCreateTemplate);
            this.pnlTemplateParam.Controls.Add(this.trbMinScore);
            this.pnlTemplateParam.Controls.Add(this.txtMinScore);
            this.pnlTemplateParam.Controls.Add(this.chkAuto);
            this.pnlTemplateParam.Controls.Add(this.lblMaterialCount);
            this.pnlTemplateParam.Controls.Add(this.txtMaterialCount);
            this.pnlTemplateParam.Controls.Add(this.trbGreedy);
            this.pnlTemplateParam.Controls.Add(this.txtGreedy);
            this.pnlTemplateParam.Controls.Add(this.trbCover);
            this.pnlTemplateParam.Controls.Add(this.txtCover);
            this.pnlTemplateParam.Controls.Add(this.btnTemplateMatch);
            this.pnlTemplateParam.FillColor = System.Drawing.Color.White;
            this.pnlTemplateParam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlTemplateParam.Location = new System.Drawing.Point(8, 312);
            this.pnlTemplateParam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTemplateParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlTemplateParam.Name = "pnlTemplateParam";
            this.pnlTemplateParam.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlTemplateParam.Size = new System.Drawing.Size(1180, 255);
            this.pnlTemplateParam.TabIndex = 193;
            this.pnlTemplateParam.Text = null;
            this.pnlTemplateParam.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkTplContrast
            // 
            this.blkTplContrast.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkTplContrast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkTplContrast.Location = new System.Drawing.Point(24, 24);
            this.blkTplContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkTplContrast.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkTplContrast.Name = "blkTplContrast";
            this.blkTplContrast.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkTplContrast.Size = new System.Drawing.Size(110, 36);
            this.blkTplContrast.TabIndex = 194;
            this.blkTplContrast.Text = "模板对比度";
            this.blkTplContrast.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkProdContrast
            // 
            this.blkProdContrast.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkProdContrast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkProdContrast.Location = new System.Drawing.Point(428, 24);
            this.blkProdContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkProdContrast.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkProdContrast.Name = "blkProdContrast";
            this.blkProdContrast.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkProdContrast.Size = new System.Drawing.Size(138, 36);
            this.blkProdContrast.TabIndex = 195;
            this.blkProdContrast.Text = "产品对比度";
            this.blkProdContrast.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkMinScore
            // 
            this.blkMinScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkMinScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkMinScore.Location = new System.Drawing.Point(24, 92);
            this.blkMinScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkMinScore.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkMinScore.Name = "blkMinScore";
            this.blkMinScore.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkMinScore.Size = new System.Drawing.Size(110, 36);
            this.blkMinScore.TabIndex = 196;
            this.blkMinScore.Text = "最小得分";
            this.blkMinScore.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkGreedy
            // 
            this.blkGreedy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkGreedy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkGreedy.Location = new System.Drawing.Point(24, 160);
            this.blkGreedy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkGreedy.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkGreedy.Name = "blkGreedy";
            this.blkGreedy.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkGreedy.Size = new System.Drawing.Size(110, 36);
            this.blkGreedy.TabIndex = 197;
            this.blkGreedy.Text = "贪 婪 度";
            this.blkGreedy.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blkCover
            // 
            this.blkCover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blkCover.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blkCover.Location = new System.Drawing.Point(428, 160);
            this.blkCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blkCover.MinimumSize = new System.Drawing.Size(1, 1);
            this.blkCover.Name = "blkCover";
            this.blkCover.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blkCover.Size = new System.Drawing.Size(138, 36);
            this.blkCover.TabIndex = 198;
            this.blkCover.Text = "遮 盖 度";
            this.blkCover.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbTplContrast
            // 
            this.trbTplContrast.BackColor = System.Drawing.Color.White;
            this.trbTplContrast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbTplContrast.Location = new System.Drawing.Point(142, 18);
            this.trbTplContrast.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbTplContrast.Name = "trbTplContrast";
            this.trbTplContrast.Size = new System.Drawing.Size(180, 46);
            this.trbTplContrast.TabIndex = 199;
            this.trbTplContrast.Value = 40;
            // 
            // txtTplContrast
            // 
            this.txtTplContrast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTplContrast.DoubleValue = 40D;
            this.txtTplContrast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTplContrast.IntValue = 40;
            this.txtTplContrast.Location = new System.Drawing.Point(330, 24);
            this.txtTplContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTplContrast.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTplContrast.Name = "txtTplContrast";
            this.txtTplContrast.Padding = new System.Windows.Forms.Padding(5);
            this.txtTplContrast.ShowText = false;
            this.txtTplContrast.Size = new System.Drawing.Size(90, 32);
            this.txtTplContrast.TabIndex = 200;
            this.txtTplContrast.Text = "40";
            this.txtTplContrast.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTplContrast.Watermark = "";
            // 
            // trbProdContrast
            // 
            this.trbProdContrast.BackColor = System.Drawing.Color.White;
            this.trbProdContrast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbProdContrast.Location = new System.Drawing.Point(574, 18);
            this.trbProdContrast.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbProdContrast.Name = "trbProdContrast";
            this.trbProdContrast.Size = new System.Drawing.Size(180, 46);
            this.trbProdContrast.TabIndex = 201;
            this.trbProdContrast.Value = 20;
            // 
            // txtProdContrast
            // 
            this.txtProdContrast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdContrast.DoubleValue = 20D;
            this.txtProdContrast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProdContrast.IntValue = 20;
            this.txtProdContrast.Location = new System.Drawing.Point(762, 24);
            this.txtProdContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdContrast.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtProdContrast.Name = "txtProdContrast";
            this.txtProdContrast.Padding = new System.Windows.Forms.Padding(5);
            this.txtProdContrast.ShowText = false;
            this.txtProdContrast.Size = new System.Drawing.Size(90, 32);
            this.txtProdContrast.TabIndex = 202;
            this.txtProdContrast.Text = "20";
            this.txtProdContrast.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtProdContrast.Watermark = "";
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateTemplate.Location = new System.Drawing.Point(1010, 16);
            this.btnCreateTemplate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(120, 62);
            this.btnCreateTemplate.TabIndex = 203;
            this.btnCreateTemplate.Text = "创建模板";
            this.btnCreateTemplate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // trbMinScore
            // 
            this.trbMinScore.BackColor = System.Drawing.Color.White;
            this.trbMinScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbMinScore.Location = new System.Drawing.Point(142, 86);
            this.trbMinScore.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbMinScore.Name = "trbMinScore";
            this.trbMinScore.Size = new System.Drawing.Size(180, 46);
            this.trbMinScore.TabIndex = 204;
            this.trbMinScore.Value = 50;
            // 
            // txtMinScore
            // 
            this.txtMinScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinScore.DoubleValue = 0.5D;
            this.txtMinScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMinScore.Location = new System.Drawing.Point(330, 92);
            this.txtMinScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinScore.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMinScore.Name = "txtMinScore";
            this.txtMinScore.Padding = new System.Windows.Forms.Padding(5);
            this.txtMinScore.ShowText = false;
            this.txtMinScore.Size = new System.Drawing.Size(90, 32);
            this.txtMinScore.TabIndex = 205;
            this.txtMinScore.Text = "0.5";
            this.txtMinScore.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMinScore.Watermark = "";
            // 
            // chkAuto
            // 
            this.chkAuto.Checked = true;
            this.chkAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAuto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkAuto.Location = new System.Drawing.Point(466, 92);
            this.chkAuto.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(96, 30);
            this.chkAuto.TabIndex = 206;
            this.chkAuto.Text = "Auto";
            // 
            // lblMaterialCount
            // 
            this.lblMaterialCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaterialCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMaterialCount.Location = new System.Drawing.Point(572, 95);
            this.lblMaterialCount.Name = "lblMaterialCount";
            this.lblMaterialCount.Size = new System.Drawing.Size(175, 29);
            this.lblMaterialCount.TabIndex = 207;
            this.lblMaterialCount.Text = "共有几种物料：";
            this.lblMaterialCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaterialCount
            // 
            this.txtMaterialCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaterialCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMaterialCount.Location = new System.Drawing.Point(752, 92);
            this.txtMaterialCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialCount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaterialCount.Name = "txtMaterialCount";
            this.txtMaterialCount.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaterialCount.ShowText = false;
            this.txtMaterialCount.Size = new System.Drawing.Size(100, 32);
            this.txtMaterialCount.TabIndex = 208;
            this.txtMaterialCount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaterialCount.Watermark = "";
            // 
            // trbGreedy
            // 
            this.trbGreedy.BackColor = System.Drawing.Color.White;
            this.trbGreedy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbGreedy.Location = new System.Drawing.Point(142, 154);
            this.trbGreedy.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbGreedy.Name = "trbGreedy";
            this.trbGreedy.Size = new System.Drawing.Size(180, 46);
            this.trbGreedy.TabIndex = 209;
            this.trbGreedy.Value = 20;
            // 
            // txtGreedy
            // 
            this.txtGreedy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGreedy.DoubleValue = 0.2D;
            this.txtGreedy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGreedy.Location = new System.Drawing.Point(330, 160);
            this.txtGreedy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGreedy.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGreedy.Name = "txtGreedy";
            this.txtGreedy.Padding = new System.Windows.Forms.Padding(5);
            this.txtGreedy.ShowText = false;
            this.txtGreedy.Size = new System.Drawing.Size(90, 32);
            this.txtGreedy.TabIndex = 210;
            this.txtGreedy.Text = "0.2";
            this.txtGreedy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGreedy.Watermark = "";
            // 
            // trbCover
            // 
            this.trbCover.BackColor = System.Drawing.Color.White;
            this.trbCover.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trbCover.Location = new System.Drawing.Point(574, 154);
            this.trbCover.MinimumSize = new System.Drawing.Size(1, 1);
            this.trbCover.Name = "trbCover";
            this.trbCover.Size = new System.Drawing.Size(180, 46);
            this.trbCover.TabIndex = 211;
            this.trbCover.Value = 50;
            // 
            // txtCover
            // 
            this.txtCover.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCover.DoubleValue = 0.5D;
            this.txtCover.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCover.Location = new System.Drawing.Point(762, 160);
            this.txtCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCover.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCover.Name = "txtCover";
            this.txtCover.Padding = new System.Windows.Forms.Padding(5);
            this.txtCover.ShowText = false;
            this.txtCover.Size = new System.Drawing.Size(90, 32);
            this.txtCover.TabIndex = 212;
            this.txtCover.Text = "0.5";
            this.txtCover.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCover.Watermark = "";
            // 
            // btnTemplateMatch
            // 
            this.btnTemplateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemplateMatch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTemplateMatch.Location = new System.Drawing.Point(1010, 144);
            this.btnTemplateMatch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTemplateMatch.Name = "btnTemplateMatch";
            this.btnTemplateMatch.Size = new System.Drawing.Size(120, 62);
            this.btnTemplateMatch.TabIndex = 213;
            this.btnTemplateMatch.Text = "模板匹配";
            this.btnTemplateMatch.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnMoveToBase
            // 
            this.btnMoveToBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveToBase.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoveToBase.Location = new System.Drawing.Point(32, 610);
            this.btnMoveToBase.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveToBase.Name = "btnMoveToBase";
            this.btnMoveToBase.Size = new System.Drawing.Size(318, 100);
            this.btnMoveToBase.TabIndex = 214;
            this.btnMoveToBase.Text = "运动到基准位置";
            this.btnMoveToBase.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFlowRight1
            // 
            this.btnFlowRight1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlowRight1.FillColor = System.Drawing.Color.White;
            this.btnFlowRight1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFlowRight1.Image = global::EndDemo_02.Properties.Resources.ArrowRight;
            this.btnFlowRight1.Location = new System.Drawing.Point(360, 638);
            this.btnFlowRight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFlowRight1.Name = "btnFlowRight1";
            this.btnFlowRight1.RectColor = System.Drawing.Color.Silver;
            this.btnFlowRight1.Size = new System.Drawing.Size(60, 44);
            this.btnFlowRight1.TabIndex = 215;
            this.btnFlowRight1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecognize
            // 
            this.btnRecognize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecognize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecognize.Location = new System.Drawing.Point(426, 610);
            this.btnRecognize.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(364, 100);
            this.btnRecognize.TabIndex = 216;
            this.btnRecognize.Text = "识别目标";
            this.btnRecognize.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFlowRight2
            // 
            this.btnFlowRight2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlowRight2.FillColor = System.Drawing.Color.White;
            this.btnFlowRight2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFlowRight2.Image = global::EndDemo_02.Properties.Resources.ArrowRight;
            this.btnFlowRight2.Location = new System.Drawing.Point(800, 638);
            this.btnFlowRight2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFlowRight2.Name = "btnFlowRight2";
            this.btnFlowRight2.RectColor = System.Drawing.Color.Silver;
            this.btnFlowRight2.Size = new System.Drawing.Size(60, 44);
            this.btnFlowRight2.TabIndex = 217;
            this.btnFlowRight2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnAnyGrab
            // 
            this.btnAnyGrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnyGrab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAnyGrab.Location = new System.Drawing.Point(866, 610);
            this.btnAnyGrab.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAnyGrab.Name = "btnAnyGrab";
            this.btnAnyGrab.Size = new System.Drawing.Size(322, 100);
            this.btnAnyGrab.TabIndex = 218;
            this.btnAnyGrab.Text = "任意抓取摆放";
            this.btnAnyGrab.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabTrace
            // 
            this.tabTrace.BackColor = System.Drawing.Color.White;
            this.tabTrace.Controls.Add(this.rdoCollectContour);
            this.tabTrace.Controls.Add(this.rdoImportCad);
            this.tabTrace.Controls.Add(this.btnLoadImage);
            this.tabTrace.Controls.Add(this.pnlContourA);
            this.tabTrace.Controls.Add(this.btnExtractContour);
            this.tabTrace.Controls.Add(this.pnlContourB);
            this.tabTrace.Controls.Add(this.btnAutoDraw);
            this.tabTrace.Location = new System.Drawing.Point(0, 40);
            this.tabTrace.Name = "tabTrace";
            this.tabTrace.Size = new System.Drawing.Size(1204, 775);
            this.tabTrace.TabIndex = 11;
            this.tabTrace.Text = "循迹行走";
            // 
            // rdoCollectContour
            // 
            this.rdoCollectContour.Checked = true;
            this.rdoCollectContour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCollectContour.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoCollectContour.Location = new System.Drawing.Point(82, 349);
            this.rdoCollectContour.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoCollectContour.Name = "rdoCollectContour";
            this.rdoCollectContour.Size = new System.Drawing.Size(130, 30);
            this.rdoCollectContour.TabIndex = 219;
            this.rdoCollectContour.Text = "采集轮廓";
            // 
            // rdoImportCad
            // 
            this.rdoImportCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImportCad.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoImportCad.Location = new System.Drawing.Point(82, 472);
            this.rdoImportCad.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoImportCad.Name = "rdoImportCad";
            this.rdoImportCad.Size = new System.Drawing.Size(130, 30);
            this.rdoImportCad.TabIndex = 220;
            this.rdoImportCad.Text = "导入CAD";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadImage.Location = new System.Drawing.Point(479, 8);
            this.btnLoadImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(264, 115);
            this.btnLoadImage.TabIndex = 221;
            this.btnLoadImage.Text = "加载图像";
            this.btnLoadImage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // pnlContourA
            // 
            this.pnlContourA.Controls.Add(this.picContourA);
            this.pnlContourA.FillColor = System.Drawing.Color.White;
            this.pnlContourA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlContourA.Location = new System.Drawing.Point(525, 188);
            this.pnlContourA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContourA.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlContourA.Name = "pnlContourA";
            this.pnlContourA.Radius = 1;
            this.pnlContourA.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.pnlContourA.Size = new System.Drawing.Size(160, 78);
            this.pnlContourA.TabIndex = 222;
            this.pnlContourA.Text = null;
            this.pnlContourA.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picContourA
            // 
            this.picContourA.BackColor = System.Drawing.Color.White;
            this.picContourA.Image = global::EndDemo_02.Properties.Resources.ArrowFlowDown;
            this.picContourA.Location = new System.Drawing.Point(1, 1);
            this.picContourA.Name = "picContourA";
            this.picContourA.Size = new System.Drawing.Size(158, 76);
            this.picContourA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picContourA.TabIndex = 223;
            this.picContourA.TabStop = false;
            // 
            // btnExtractContour
            // 
            this.btnExtractContour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtractContour.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExtractContour.Location = new System.Drawing.Point(479, 334);
            this.btnExtractContour.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExtractContour.Name = "btnExtractContour";
            this.btnExtractContour.Size = new System.Drawing.Size(264, 114);
            this.btnExtractContour.TabIndex = 224;
            this.btnExtractContour.Text = "提取轮廓";
            this.btnExtractContour.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // pnlContourB
            // 
            this.pnlContourB.Controls.Add(this.picContourB);
            this.pnlContourB.FillColor = System.Drawing.Color.White;
            this.pnlContourB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlContourB.Location = new System.Drawing.Point(525, 529);
            this.pnlContourB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContourB.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlContourB.Name = "pnlContourB";
            this.pnlContourB.Radius = 1;
            this.pnlContourB.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.pnlContourB.Size = new System.Drawing.Size(160, 78);
            this.pnlContourB.TabIndex = 225;
            this.pnlContourB.Text = null;
            this.pnlContourB.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picContourB
            // 
            this.picContourB.BackColor = System.Drawing.Color.White;
            this.picContourB.Image = global::EndDemo_02.Properties.Resources.ArrowFlowDown;
            this.picContourB.Location = new System.Drawing.Point(1, 1);
            this.picContourB.Name = "picContourB";
            this.picContourB.Size = new System.Drawing.Size(158, 76);
            this.picContourB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picContourB.TabIndex = 226;
            this.picContourB.TabStop = false;
            // 
            // btnAutoDraw
            // 
            this.btnAutoDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoDraw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAutoDraw.Location = new System.Drawing.Point(479, 646);
            this.btnAutoDraw.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAutoDraw.Name = "btnAutoDraw";
            this.btnAutoDraw.Size = new System.Drawing.Size(264, 114);
            this.btnAutoDraw.TabIndex = 227;
            this.btnAutoDraw.Text = "自动绘制";
            this.btnAutoDraw.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabIO
            // 
            this.tabIO.BackColor = System.Drawing.Color.White;
            this.tabIO.Controls.Add(this.btnTestVacuum);
            this.tabIO.Controls.Add(this.grpAxisSignal);
            this.tabIO.Controls.Add(this.grpGeneralIn);
            this.tabIO.Controls.Add(this.grpGeneralOut);
            this.tabIO.Location = new System.Drawing.Point(0, 40);
            this.tabIO.Name = "tabIO";
            this.tabIO.Size = new System.Drawing.Size(1204, 775);
            this.tabIO.TabIndex = 12;
            this.tabIO.Text = "IO控制";
            // 
            // btnTestVacuum
            // 
            this.btnTestVacuum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestVacuum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTestVacuum.Location = new System.Drawing.Point(212, 647);
            this.btnTestVacuum.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTestVacuum.Name = "btnTestVacuum";
            this.btnTestVacuum.Size = new System.Drawing.Size(336, 114);
            this.btnTestVacuum.TabIndex = 348;
            this.btnTestVacuum.Text = "测试真空吸";
            this.btnTestVacuum.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // grpAxisSignal
            // 
            this.grpAxisSignal.Controls.Add(this.lblSignal0);
            this.grpAxisSignal.Controls.Add(this.lblSignal1);
            this.grpAxisSignal.Controls.Add(this.lblSignal2);
            this.grpAxisSignal.Controls.Add(this.lblSignal3);
            this.grpAxisSignal.Controls.Add(this.lblSignal4);
            this.grpAxisSignal.Controls.Add(this.lblSignal5);
            this.grpAxisSignal.Controls.Add(this.lblSignal6);
            this.grpAxisSignal.Controls.Add(this.lblSignal7);
            this.grpAxisSignal.Controls.Add(this.lblAxisRowX);
            this.grpAxisSignal.Controls.Add(this.ledXAxis0);
            this.grpAxisSignal.Controls.Add(this.ledXAxis1);
            this.grpAxisSignal.Controls.Add(this.ledXAxis2);
            this.grpAxisSignal.Controls.Add(this.ledXAxis3);
            this.grpAxisSignal.Controls.Add(this.ledXAxis4);
            this.grpAxisSignal.Controls.Add(this.ledXAxis5);
            this.grpAxisSignal.Controls.Add(this.ledXAxis6);
            this.grpAxisSignal.Controls.Add(this.ledXAxis7);
            this.grpAxisSignal.Controls.Add(this.lblAxisRowY);
            this.grpAxisSignal.Controls.Add(this.ledYAxis0);
            this.grpAxisSignal.Controls.Add(this.ledYAxis1);
            this.grpAxisSignal.Controls.Add(this.ledYAxis2);
            this.grpAxisSignal.Controls.Add(this.ledYAxis3);
            this.grpAxisSignal.Controls.Add(this.ledYAxis4);
            this.grpAxisSignal.Controls.Add(this.ledYAxis5);
            this.grpAxisSignal.Controls.Add(this.ledYAxis6);
            this.grpAxisSignal.Controls.Add(this.ledYAxis7);
            this.grpAxisSignal.Controls.Add(this.lblAxisRowZ);
            this.grpAxisSignal.Controls.Add(this.ledZAxis0);
            this.grpAxisSignal.Controls.Add(this.ledZAxis1);
            this.grpAxisSignal.Controls.Add(this.ledZAxis2);
            this.grpAxisSignal.Controls.Add(this.ledZAxis3);
            this.grpAxisSignal.Controls.Add(this.ledZAxis4);
            this.grpAxisSignal.Controls.Add(this.ledZAxis5);
            this.grpAxisSignal.Controls.Add(this.ledZAxis6);
            this.grpAxisSignal.Controls.Add(this.ledZAxis7);
            this.grpAxisSignal.Controls.Add(this.lblAxisRowR);
            this.grpAxisSignal.Controls.Add(this.ledRAxis0);
            this.grpAxisSignal.Controls.Add(this.ledRAxis1);
            this.grpAxisSignal.Controls.Add(this.ledRAxis2);
            this.grpAxisSignal.Controls.Add(this.ledRAxis3);
            this.grpAxisSignal.Controls.Add(this.ledRAxis4);
            this.grpAxisSignal.Controls.Add(this.ledRAxis5);
            this.grpAxisSignal.Controls.Add(this.ledRAxis6);
            this.grpAxisSignal.Controls.Add(this.ledRAxis7);
            this.grpAxisSignal.FillColor = System.Drawing.Color.White;
            this.grpAxisSignal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpAxisSignal.Location = new System.Drawing.Point(8, 6);
            this.grpAxisSignal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAxisSignal.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpAxisSignal.Name = "grpAxisSignal";
            this.grpAxisSignal.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpAxisSignal.Size = new System.Drawing.Size(1180, 230);
            this.grpAxisSignal.TabIndex = 228;
            this.grpAxisSignal.Text = "专有信号监控";
            this.grpAxisSignal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignal0
            // 
            this.lblSignal0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal0.Location = new System.Drawing.Point(150, 34);
            this.lblSignal0.Name = "lblSignal0";
            this.lblSignal0.Size = new System.Drawing.Size(60, 26);
            this.lblSignal0.TabIndex = 229;
            this.lblSignal0.Text = "EL+";
            this.lblSignal0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal1
            // 
            this.lblSignal1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal1.Location = new System.Drawing.Point(258, 34);
            this.lblSignal1.Name = "lblSignal1";
            this.lblSignal1.Size = new System.Drawing.Size(60, 26);
            this.lblSignal1.TabIndex = 230;
            this.lblSignal1.Text = "EL-";
            this.lblSignal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal2
            // 
            this.lblSignal2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal2.Location = new System.Drawing.Point(366, 34);
            this.lblSignal2.Name = "lblSignal2";
            this.lblSignal2.Size = new System.Drawing.Size(60, 26);
            this.lblSignal2.TabIndex = 231;
            this.lblSignal2.Text = "ORG";
            this.lblSignal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal3
            // 
            this.lblSignal3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal3.Location = new System.Drawing.Point(456, 34);
            this.lblSignal3.Name = "lblSignal3";
            this.lblSignal3.Size = new System.Drawing.Size(60, 26);
            this.lblSignal3.TabIndex = 232;
            this.lblSignal3.Text = "ALM";
            this.lblSignal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal4
            // 
            this.lblSignal4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal4.Location = new System.Drawing.Point(546, 34);
            this.lblSignal4.Name = "lblSignal4";
            this.lblSignal4.Size = new System.Drawing.Size(60, 26);
            this.lblSignal4.TabIndex = 233;
            this.lblSignal4.Text = "RDY";
            this.lblSignal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal5
            // 
            this.lblSignal5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal5.Location = new System.Drawing.Point(636, 34);
            this.lblSignal5.Name = "lblSignal5";
            this.lblSignal5.Size = new System.Drawing.Size(60, 26);
            this.lblSignal5.TabIndex = 234;
            this.lblSignal5.Text = "INP";
            this.lblSignal5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal6
            // 
            this.lblSignal6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal6.Location = new System.Drawing.Point(736, 34);
            this.lblSignal6.Name = "lblSignal6";
            this.lblSignal6.Size = new System.Drawing.Size(65, 26);
            this.lblSignal6.TabIndex = 235;
            this.lblSignal6.Text = "SEVON";
            this.lblSignal6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignal7
            // 
            this.lblSignal7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignal7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSignal7.Location = new System.Drawing.Point(866, 34);
            this.lblSignal7.Name = "lblSignal7";
            this.lblSignal7.Size = new System.Drawing.Size(60, 26);
            this.lblSignal7.TabIndex = 236;
            this.lblSignal7.Text = "ERC";
            this.lblSignal7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAxisRowX
            // 
            this.lblAxisRowX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAxisRowX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAxisRowX.Location = new System.Drawing.Point(34, 72);
            this.lblAxisRowX.Name = "lblAxisRowX";
            this.lblAxisRowX.Size = new System.Drawing.Size(101, 26);
            this.lblAxisRowX.TabIndex = 237;
            this.lblAxisRowX.Text = "X轴（0）";
            this.lblAxisRowX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledXAxis0
            // 
            this.ledXAxis0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis0.Location = new System.Drawing.Point(152, 74);
            this.ledXAxis0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis0.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis0.Name = "ledXAxis0";
            this.ledXAxis0.Radius = 3;
            this.ledXAxis0.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis0.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis0.TabIndex = 238;
            this.ledXAxis0.Text = null;
            this.ledXAxis0.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis1
            // 
            this.ledXAxis1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis1.Location = new System.Drawing.Point(260, 74);
            this.ledXAxis1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis1.Name = "ledXAxis1";
            this.ledXAxis1.Radius = 3;
            this.ledXAxis1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis1.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis1.TabIndex = 239;
            this.ledXAxis1.Text = null;
            this.ledXAxis1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis2
            // 
            this.ledXAxis2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis2.Location = new System.Drawing.Point(368, 74);
            this.ledXAxis2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis2.Name = "ledXAxis2";
            this.ledXAxis2.Radius = 3;
            this.ledXAxis2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis2.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis2.TabIndex = 240;
            this.ledXAxis2.Text = null;
            this.ledXAxis2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis3
            // 
            this.ledXAxis3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis3.Location = new System.Drawing.Point(458, 74);
            this.ledXAxis3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis3.Name = "ledXAxis3";
            this.ledXAxis3.Radius = 3;
            this.ledXAxis3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis3.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis3.TabIndex = 241;
            this.ledXAxis3.Text = null;
            this.ledXAxis3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis4
            // 
            this.ledXAxis4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis4.Location = new System.Drawing.Point(548, 74);
            this.ledXAxis4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis4.Name = "ledXAxis4";
            this.ledXAxis4.Radius = 3;
            this.ledXAxis4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis4.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis4.TabIndex = 242;
            this.ledXAxis4.Text = null;
            this.ledXAxis4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis5
            // 
            this.ledXAxis5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis5.Location = new System.Drawing.Point(638, 74);
            this.ledXAxis5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis5.Name = "ledXAxis5";
            this.ledXAxis5.Radius = 3;
            this.ledXAxis5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis5.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis5.TabIndex = 243;
            this.ledXAxis5.Text = null;
            this.ledXAxis5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis6
            // 
            this.ledXAxis6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis6.Location = new System.Drawing.Point(738, 74);
            this.ledXAxis6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis6.Name = "ledXAxis6";
            this.ledXAxis6.Radius = 3;
            this.ledXAxis6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis6.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis6.TabIndex = 244;
            this.ledXAxis6.Text = null;
            this.ledXAxis6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAxis7
            // 
            this.ledXAxis7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledXAxis7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledXAxis7.Location = new System.Drawing.Point(868, 74);
            this.ledXAxis7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledXAxis7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledXAxis7.Name = "ledXAxis7";
            this.ledXAxis7.Radius = 3;
            this.ledXAxis7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledXAxis7.Size = new System.Drawing.Size(56, 22);
            this.ledXAxis7.TabIndex = 245;
            this.ledXAxis7.Text = null;
            this.ledXAxis7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAxisRowY
            // 
            this.lblAxisRowY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAxisRowY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAxisRowY.Location = new System.Drawing.Point(34, 112);
            this.lblAxisRowY.Name = "lblAxisRowY";
            this.lblAxisRowY.Size = new System.Drawing.Size(101, 26);
            this.lblAxisRowY.TabIndex = 246;
            this.lblAxisRowY.Text = "Y轴（1）";
            this.lblAxisRowY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledYAxis0
            // 
            this.ledYAxis0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis0.Location = new System.Drawing.Point(152, 114);
            this.ledYAxis0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis0.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis0.Name = "ledYAxis0";
            this.ledYAxis0.Radius = 3;
            this.ledYAxis0.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis0.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis0.TabIndex = 247;
            this.ledYAxis0.Text = null;
            this.ledYAxis0.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis1
            // 
            this.ledYAxis1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis1.Location = new System.Drawing.Point(260, 114);
            this.ledYAxis1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis1.Name = "ledYAxis1";
            this.ledYAxis1.Radius = 3;
            this.ledYAxis1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis1.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis1.TabIndex = 248;
            this.ledYAxis1.Text = null;
            this.ledYAxis1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis2
            // 
            this.ledYAxis2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis2.Location = new System.Drawing.Point(368, 114);
            this.ledYAxis2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis2.Name = "ledYAxis2";
            this.ledYAxis2.Radius = 3;
            this.ledYAxis2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis2.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis2.TabIndex = 249;
            this.ledYAxis2.Text = null;
            this.ledYAxis2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis3
            // 
            this.ledYAxis3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis3.Location = new System.Drawing.Point(458, 114);
            this.ledYAxis3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis3.Name = "ledYAxis3";
            this.ledYAxis3.Radius = 3;
            this.ledYAxis3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis3.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis3.TabIndex = 250;
            this.ledYAxis3.Text = null;
            this.ledYAxis3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis4
            // 
            this.ledYAxis4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis4.Location = new System.Drawing.Point(548, 114);
            this.ledYAxis4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis4.Name = "ledYAxis4";
            this.ledYAxis4.Radius = 3;
            this.ledYAxis4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis4.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis4.TabIndex = 251;
            this.ledYAxis4.Text = null;
            this.ledYAxis4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis5
            // 
            this.ledYAxis5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis5.Location = new System.Drawing.Point(638, 114);
            this.ledYAxis5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis5.Name = "ledYAxis5";
            this.ledYAxis5.Radius = 3;
            this.ledYAxis5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis5.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis5.TabIndex = 252;
            this.ledYAxis5.Text = null;
            this.ledYAxis5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis6
            // 
            this.ledYAxis6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis6.Location = new System.Drawing.Point(738, 114);
            this.ledYAxis6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis6.Name = "ledYAxis6";
            this.ledYAxis6.Radius = 3;
            this.ledYAxis6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis6.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis6.TabIndex = 253;
            this.ledYAxis6.Text = null;
            this.ledYAxis6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledYAxis7
            // 
            this.ledYAxis7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledYAxis7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledYAxis7.Location = new System.Drawing.Point(868, 114);
            this.ledYAxis7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledYAxis7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledYAxis7.Name = "ledYAxis7";
            this.ledYAxis7.Radius = 3;
            this.ledYAxis7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledYAxis7.Size = new System.Drawing.Size(56, 22);
            this.ledYAxis7.TabIndex = 254;
            this.ledYAxis7.Text = null;
            this.ledYAxis7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAxisRowZ
            // 
            this.lblAxisRowZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAxisRowZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAxisRowZ.Location = new System.Drawing.Point(34, 152);
            this.lblAxisRowZ.Name = "lblAxisRowZ";
            this.lblAxisRowZ.Size = new System.Drawing.Size(101, 26);
            this.lblAxisRowZ.TabIndex = 255;
            this.lblAxisRowZ.Text = "Z轴（2）";
            this.lblAxisRowZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledZAxis0
            // 
            this.ledZAxis0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis0.Location = new System.Drawing.Point(152, 154);
            this.ledZAxis0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis0.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis0.Name = "ledZAxis0";
            this.ledZAxis0.Radius = 3;
            this.ledZAxis0.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis0.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis0.TabIndex = 256;
            this.ledZAxis0.Text = null;
            this.ledZAxis0.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis1
            // 
            this.ledZAxis1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis1.Location = new System.Drawing.Point(260, 154);
            this.ledZAxis1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis1.Name = "ledZAxis1";
            this.ledZAxis1.Radius = 3;
            this.ledZAxis1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis1.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis1.TabIndex = 257;
            this.ledZAxis1.Text = null;
            this.ledZAxis1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis2
            // 
            this.ledZAxis2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis2.Location = new System.Drawing.Point(368, 154);
            this.ledZAxis2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis2.Name = "ledZAxis2";
            this.ledZAxis2.Radius = 3;
            this.ledZAxis2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis2.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis2.TabIndex = 258;
            this.ledZAxis2.Text = null;
            this.ledZAxis2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis3
            // 
            this.ledZAxis3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis3.Location = new System.Drawing.Point(458, 154);
            this.ledZAxis3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis3.Name = "ledZAxis3";
            this.ledZAxis3.Radius = 3;
            this.ledZAxis3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis3.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis3.TabIndex = 259;
            this.ledZAxis3.Text = null;
            this.ledZAxis3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis4
            // 
            this.ledZAxis4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis4.Location = new System.Drawing.Point(548, 154);
            this.ledZAxis4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis4.Name = "ledZAxis4";
            this.ledZAxis4.Radius = 3;
            this.ledZAxis4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis4.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis4.TabIndex = 260;
            this.ledZAxis4.Text = null;
            this.ledZAxis4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis5
            // 
            this.ledZAxis5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis5.Location = new System.Drawing.Point(638, 154);
            this.ledZAxis5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis5.Name = "ledZAxis5";
            this.ledZAxis5.Radius = 3;
            this.ledZAxis5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis5.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis5.TabIndex = 261;
            this.ledZAxis5.Text = null;
            this.ledZAxis5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis6
            // 
            this.ledZAxis6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis6.Location = new System.Drawing.Point(738, 154);
            this.ledZAxis6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis6.Name = "ledZAxis6";
            this.ledZAxis6.Radius = 3;
            this.ledZAxis6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis6.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis6.TabIndex = 262;
            this.ledZAxis6.Text = null;
            this.ledZAxis6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZAxis7
            // 
            this.ledZAxis7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledZAxis7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledZAxis7.Location = new System.Drawing.Point(868, 154);
            this.ledZAxis7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledZAxis7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledZAxis7.Name = "ledZAxis7";
            this.ledZAxis7.Radius = 3;
            this.ledZAxis7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledZAxis7.Size = new System.Drawing.Size(56, 22);
            this.ledZAxis7.TabIndex = 263;
            this.ledZAxis7.Text = null;
            this.ledZAxis7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAxisRowR
            // 
            this.lblAxisRowR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAxisRowR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAxisRowR.Location = new System.Drawing.Point(34, 192);
            this.lblAxisRowR.Name = "lblAxisRowR";
            this.lblAxisRowR.Size = new System.Drawing.Size(101, 26);
            this.lblAxisRowR.TabIndex = 264;
            this.lblAxisRowR.Text = "R轴（3）";
            this.lblAxisRowR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledRAxis0
            // 
            this.ledRAxis0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis0.Location = new System.Drawing.Point(152, 194);
            this.ledRAxis0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis0.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis0.Name = "ledRAxis0";
            this.ledRAxis0.Radius = 3;
            this.ledRAxis0.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis0.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis0.TabIndex = 265;
            this.ledRAxis0.Text = null;
            this.ledRAxis0.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis1
            // 
            this.ledRAxis1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis1.Location = new System.Drawing.Point(260, 194);
            this.ledRAxis1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis1.Name = "ledRAxis1";
            this.ledRAxis1.Radius = 3;
            this.ledRAxis1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis1.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis1.TabIndex = 266;
            this.ledRAxis1.Text = null;
            this.ledRAxis1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis2
            // 
            this.ledRAxis2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis2.Location = new System.Drawing.Point(368, 194);
            this.ledRAxis2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis2.Name = "ledRAxis2";
            this.ledRAxis2.Radius = 3;
            this.ledRAxis2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis2.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis2.TabIndex = 267;
            this.ledRAxis2.Text = null;
            this.ledRAxis2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis3
            // 
            this.ledRAxis3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis3.Location = new System.Drawing.Point(458, 194);
            this.ledRAxis3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis3.Name = "ledRAxis3";
            this.ledRAxis3.Radius = 3;
            this.ledRAxis3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis3.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis3.TabIndex = 268;
            this.ledRAxis3.Text = null;
            this.ledRAxis3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis4
            // 
            this.ledRAxis4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis4.Location = new System.Drawing.Point(548, 194);
            this.ledRAxis4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis4.Name = "ledRAxis4";
            this.ledRAxis4.Radius = 3;
            this.ledRAxis4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis4.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis4.TabIndex = 269;
            this.ledRAxis4.Text = null;
            this.ledRAxis4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis5
            // 
            this.ledRAxis5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis5.Location = new System.Drawing.Point(638, 194);
            this.ledRAxis5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis5.Name = "ledRAxis5";
            this.ledRAxis5.Radius = 3;
            this.ledRAxis5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis5.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis5.TabIndex = 270;
            this.ledRAxis5.Text = null;
            this.ledRAxis5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis6
            // 
            this.ledRAxis6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis6.Location = new System.Drawing.Point(738, 194);
            this.ledRAxis6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis6.Name = "ledRAxis6";
            this.ledRAxis6.Radius = 3;
            this.ledRAxis6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis6.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis6.TabIndex = 271;
            this.ledRAxis6.Text = null;
            this.ledRAxis6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRAxis7
            // 
            this.ledRAxis7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledRAxis7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledRAxis7.Location = new System.Drawing.Point(868, 194);
            this.ledRAxis7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledRAxis7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledRAxis7.Name = "ledRAxis7";
            this.ledRAxis7.Radius = 3;
            this.ledRAxis7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledRAxis7.Size = new System.Drawing.Size(56, 22);
            this.ledRAxis7.TabIndex = 272;
            this.ledRAxis7.Text = null;
            this.ledRAxis7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpGeneralIn
            // 
            this.grpGeneralIn.Controls.Add(this.pnlIn1);
            this.grpGeneralIn.Controls.Add(this.pnlIn2);
            this.grpGeneralIn.Controls.Add(this.pnlIn3);
            this.grpGeneralIn.Controls.Add(this.pnlIn4);
            this.grpGeneralIn.FillColor = System.Drawing.Color.White;
            this.grpGeneralIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpGeneralIn.Location = new System.Drawing.Point(8, 242);
            this.grpGeneralIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGeneralIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpGeneralIn.Name = "grpGeneralIn";
            this.grpGeneralIn.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpGeneralIn.Size = new System.Drawing.Size(1180, 175);
            this.grpGeneralIn.TabIndex = 273;
            this.grpGeneralIn.Text = "通用输入信号";
            this.grpGeneralIn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlIn1
            // 
            this.pnlIn1.Controls.Add(this.lblIn0);
            this.pnlIn1.Controls.Add(this.ledIn0);
            this.pnlIn1.Controls.Add(this.lblIn1);
            this.pnlIn1.Controls.Add(this.ledIn1);
            this.pnlIn1.Controls.Add(this.lblIn2);
            this.pnlIn1.Controls.Add(this.ledIn2);
            this.pnlIn1.Controls.Add(this.lblIn3);
            this.pnlIn1.Controls.Add(this.ledIn3);
            this.pnlIn1.FillColor = System.Drawing.Color.White;
            this.pnlIn1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlIn1.Location = new System.Drawing.Point(7, 37);
            this.pnlIn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlIn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlIn1.Name = "pnlIn1";
            this.pnlIn1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlIn1.Size = new System.Drawing.Size(275, 130);
            this.pnlIn1.TabIndex = 274;
            this.pnlIn1.Text = null;
            this.pnlIn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn0
            // 
            this.lblIn0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn0.Location = new System.Drawing.Point(20, 8);
            this.lblIn0.Name = "lblIn0";
            this.lblIn0.Size = new System.Drawing.Size(40, 26);
            this.lblIn0.TabIndex = 275;
            this.lblIn0.Text = "0";
            this.lblIn0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn0
            // 
            this.ledIn0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn0.Location = new System.Drawing.Point(70, 10);
            this.ledIn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn0.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn0.Name = "ledIn0";
            this.ledIn0.Radius = 3;
            this.ledIn0.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn0.Size = new System.Drawing.Size(120, 22);
            this.ledIn0.TabIndex = 276;
            this.ledIn0.Text = null;
            this.ledIn0.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn1
            // 
            this.lblIn1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn1.Location = new System.Drawing.Point(20, 37);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(40, 26);
            this.lblIn1.TabIndex = 277;
            this.lblIn1.Text = "1";
            this.lblIn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn1
            // 
            this.ledIn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn1.Location = new System.Drawing.Point(70, 39);
            this.ledIn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn1.Name = "ledIn1";
            this.ledIn1.Radius = 3;
            this.ledIn1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn1.Size = new System.Drawing.Size(120, 22);
            this.ledIn1.TabIndex = 278;
            this.ledIn1.Text = null;
            this.ledIn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn2
            // 
            this.lblIn2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn2.Location = new System.Drawing.Point(20, 66);
            this.lblIn2.Name = "lblIn2";
            this.lblIn2.Size = new System.Drawing.Size(40, 26);
            this.lblIn2.TabIndex = 279;
            this.lblIn2.Text = "2";
            this.lblIn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn2
            // 
            this.ledIn2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn2.Location = new System.Drawing.Point(70, 68);
            this.ledIn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn2.Name = "ledIn2";
            this.ledIn2.Radius = 3;
            this.ledIn2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn2.Size = new System.Drawing.Size(120, 22);
            this.ledIn2.TabIndex = 280;
            this.ledIn2.Text = null;
            this.ledIn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn3
            // 
            this.lblIn3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn3.Location = new System.Drawing.Point(20, 95);
            this.lblIn3.Name = "lblIn3";
            this.lblIn3.Size = new System.Drawing.Size(40, 26);
            this.lblIn3.TabIndex = 281;
            this.lblIn3.Text = "3";
            this.lblIn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn3
            // 
            this.ledIn3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn3.Location = new System.Drawing.Point(70, 97);
            this.ledIn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn3.Name = "ledIn3";
            this.ledIn3.Radius = 3;
            this.ledIn3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn3.Size = new System.Drawing.Size(120, 22);
            this.ledIn3.TabIndex = 282;
            this.ledIn3.Text = null;
            this.ledIn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIn2
            // 
            this.pnlIn2.Controls.Add(this.lblIn4);
            this.pnlIn2.Controls.Add(this.ledIn4);
            this.pnlIn2.Controls.Add(this.lblIn5);
            this.pnlIn2.Controls.Add(this.ledIn5);
            this.pnlIn2.Controls.Add(this.lblIn6);
            this.pnlIn2.Controls.Add(this.ledIn6);
            this.pnlIn2.Controls.Add(this.lblIn7);
            this.pnlIn2.Controls.Add(this.ledIn7);
            this.pnlIn2.FillColor = System.Drawing.Color.White;
            this.pnlIn2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlIn2.Location = new System.Drawing.Point(302, 37);
            this.pnlIn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlIn2.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlIn2.Name = "pnlIn2";
            this.pnlIn2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlIn2.Size = new System.Drawing.Size(275, 130);
            this.pnlIn2.TabIndex = 283;
            this.pnlIn2.Text = null;
            this.pnlIn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn4
            // 
            this.lblIn4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn4.Location = new System.Drawing.Point(20, 8);
            this.lblIn4.Name = "lblIn4";
            this.lblIn4.Size = new System.Drawing.Size(40, 26);
            this.lblIn4.TabIndex = 284;
            this.lblIn4.Text = "4";
            this.lblIn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn4
            // 
            this.ledIn4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn4.Location = new System.Drawing.Point(70, 10);
            this.ledIn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn4.Name = "ledIn4";
            this.ledIn4.Radius = 3;
            this.ledIn4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn4.Size = new System.Drawing.Size(120, 22);
            this.ledIn4.TabIndex = 285;
            this.ledIn4.Text = null;
            this.ledIn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn5
            // 
            this.lblIn5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn5.Location = new System.Drawing.Point(20, 37);
            this.lblIn5.Name = "lblIn5";
            this.lblIn5.Size = new System.Drawing.Size(40, 26);
            this.lblIn5.TabIndex = 286;
            this.lblIn5.Text = "5";
            this.lblIn5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn5
            // 
            this.ledIn5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn5.Location = new System.Drawing.Point(70, 39);
            this.ledIn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn5.Name = "ledIn5";
            this.ledIn5.Radius = 3;
            this.ledIn5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn5.Size = new System.Drawing.Size(120, 22);
            this.ledIn5.TabIndex = 287;
            this.ledIn5.Text = null;
            this.ledIn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn6
            // 
            this.lblIn6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn6.Location = new System.Drawing.Point(20, 66);
            this.lblIn6.Name = "lblIn6";
            this.lblIn6.Size = new System.Drawing.Size(40, 26);
            this.lblIn6.TabIndex = 288;
            this.lblIn6.Text = "6";
            this.lblIn6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn6
            // 
            this.ledIn6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn6.Location = new System.Drawing.Point(70, 68);
            this.ledIn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn6.Name = "ledIn6";
            this.ledIn6.Radius = 3;
            this.ledIn6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn6.Size = new System.Drawing.Size(120, 22);
            this.ledIn6.TabIndex = 289;
            this.ledIn6.Text = null;
            this.ledIn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn7
            // 
            this.lblIn7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn7.Location = new System.Drawing.Point(20, 95);
            this.lblIn7.Name = "lblIn7";
            this.lblIn7.Size = new System.Drawing.Size(40, 26);
            this.lblIn7.TabIndex = 290;
            this.lblIn7.Text = "7";
            this.lblIn7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn7
            // 
            this.ledIn7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn7.Location = new System.Drawing.Point(70, 97);
            this.ledIn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn7.Name = "ledIn7";
            this.ledIn7.Radius = 3;
            this.ledIn7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn7.Size = new System.Drawing.Size(120, 22);
            this.ledIn7.TabIndex = 291;
            this.ledIn7.Text = null;
            this.ledIn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIn3
            // 
            this.pnlIn3.Controls.Add(this.lblIn8);
            this.pnlIn3.Controls.Add(this.ledIn8);
            this.pnlIn3.Controls.Add(this.lblIn9);
            this.pnlIn3.Controls.Add(this.ledIn9);
            this.pnlIn3.Controls.Add(this.lblIn10);
            this.pnlIn3.Controls.Add(this.ledIn10);
            this.pnlIn3.Controls.Add(this.lblIn11);
            this.pnlIn3.Controls.Add(this.ledIn11);
            this.pnlIn3.FillColor = System.Drawing.Color.White;
            this.pnlIn3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlIn3.Location = new System.Drawing.Point(597, 37);
            this.pnlIn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlIn3.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlIn3.Name = "pnlIn3";
            this.pnlIn3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlIn3.Size = new System.Drawing.Size(275, 130);
            this.pnlIn3.TabIndex = 292;
            this.pnlIn3.Text = null;
            this.pnlIn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn8
            // 
            this.lblIn8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn8.Location = new System.Drawing.Point(20, 8);
            this.lblIn8.Name = "lblIn8";
            this.lblIn8.Size = new System.Drawing.Size(40, 26);
            this.lblIn8.TabIndex = 293;
            this.lblIn8.Text = "8";
            this.lblIn8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn8
            // 
            this.ledIn8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn8.Location = new System.Drawing.Point(70, 10);
            this.ledIn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn8.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn8.Name = "ledIn8";
            this.ledIn8.Radius = 3;
            this.ledIn8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn8.Size = new System.Drawing.Size(120, 22);
            this.ledIn8.TabIndex = 294;
            this.ledIn8.Text = null;
            this.ledIn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn9
            // 
            this.lblIn9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn9.Location = new System.Drawing.Point(20, 37);
            this.lblIn9.Name = "lblIn9";
            this.lblIn9.Size = new System.Drawing.Size(40, 26);
            this.lblIn9.TabIndex = 295;
            this.lblIn9.Text = "9";
            this.lblIn9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn9
            // 
            this.ledIn9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn9.Location = new System.Drawing.Point(70, 39);
            this.ledIn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn9.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn9.Name = "ledIn9";
            this.ledIn9.Radius = 3;
            this.ledIn9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn9.Size = new System.Drawing.Size(120, 22);
            this.ledIn9.TabIndex = 296;
            this.ledIn9.Text = null;
            this.ledIn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn10
            // 
            this.lblIn10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn10.Location = new System.Drawing.Point(20, 66);
            this.lblIn10.Name = "lblIn10";
            this.lblIn10.Size = new System.Drawing.Size(40, 26);
            this.lblIn10.TabIndex = 297;
            this.lblIn10.Text = "10";
            this.lblIn10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn10
            // 
            this.ledIn10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn10.Location = new System.Drawing.Point(70, 68);
            this.ledIn10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn10.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn10.Name = "ledIn10";
            this.ledIn10.Radius = 3;
            this.ledIn10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn10.Size = new System.Drawing.Size(120, 22);
            this.ledIn10.TabIndex = 298;
            this.ledIn10.Text = null;
            this.ledIn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn11
            // 
            this.lblIn11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn11.Location = new System.Drawing.Point(20, 95);
            this.lblIn11.Name = "lblIn11";
            this.lblIn11.Size = new System.Drawing.Size(40, 26);
            this.lblIn11.TabIndex = 299;
            this.lblIn11.Text = "11";
            this.lblIn11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn11
            // 
            this.ledIn11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn11.Location = new System.Drawing.Point(70, 97);
            this.ledIn11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn11.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn11.Name = "ledIn11";
            this.ledIn11.Radius = 3;
            this.ledIn11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn11.Size = new System.Drawing.Size(120, 22);
            this.ledIn11.TabIndex = 300;
            this.ledIn11.Text = null;
            this.ledIn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIn4
            // 
            this.pnlIn4.Controls.Add(this.lblIn12);
            this.pnlIn4.Controls.Add(this.ledIn12);
            this.pnlIn4.Controls.Add(this.lblIn13);
            this.pnlIn4.Controls.Add(this.ledIn13);
            this.pnlIn4.Controls.Add(this.lblIn14);
            this.pnlIn4.Controls.Add(this.ledIn14);
            this.pnlIn4.Controls.Add(this.lblIn15);
            this.pnlIn4.Controls.Add(this.ledIn15);
            this.pnlIn4.FillColor = System.Drawing.Color.White;
            this.pnlIn4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlIn4.Location = new System.Drawing.Point(892, 37);
            this.pnlIn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlIn4.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlIn4.Name = "pnlIn4";
            this.pnlIn4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlIn4.Size = new System.Drawing.Size(275, 130);
            this.pnlIn4.TabIndex = 301;
            this.pnlIn4.Text = null;
            this.pnlIn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn12
            // 
            this.lblIn12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn12.Location = new System.Drawing.Point(20, 8);
            this.lblIn12.Name = "lblIn12";
            this.lblIn12.Size = new System.Drawing.Size(40, 26);
            this.lblIn12.TabIndex = 302;
            this.lblIn12.Text = "12";
            this.lblIn12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn12
            // 
            this.ledIn12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn12.Location = new System.Drawing.Point(70, 10);
            this.ledIn12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn12.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn12.Name = "ledIn12";
            this.ledIn12.Radius = 3;
            this.ledIn12.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn12.Size = new System.Drawing.Size(120, 22);
            this.ledIn12.TabIndex = 303;
            this.ledIn12.Text = null;
            this.ledIn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn13
            // 
            this.lblIn13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn13.Location = new System.Drawing.Point(20, 37);
            this.lblIn13.Name = "lblIn13";
            this.lblIn13.Size = new System.Drawing.Size(40, 26);
            this.lblIn13.TabIndex = 304;
            this.lblIn13.Text = "13";
            this.lblIn13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn13
            // 
            this.ledIn13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn13.Location = new System.Drawing.Point(70, 39);
            this.ledIn13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn13.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn13.Name = "ledIn13";
            this.ledIn13.Radius = 3;
            this.ledIn13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn13.Size = new System.Drawing.Size(120, 22);
            this.ledIn13.TabIndex = 305;
            this.ledIn13.Text = null;
            this.ledIn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn14
            // 
            this.lblIn14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn14.Location = new System.Drawing.Point(20, 66);
            this.lblIn14.Name = "lblIn14";
            this.lblIn14.Size = new System.Drawing.Size(40, 26);
            this.lblIn14.TabIndex = 306;
            this.lblIn14.Text = "14";
            this.lblIn14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn14
            // 
            this.ledIn14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn14.Location = new System.Drawing.Point(70, 68);
            this.ledIn14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn14.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn14.Name = "ledIn14";
            this.ledIn14.Radius = 3;
            this.ledIn14.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn14.Size = new System.Drawing.Size(120, 22);
            this.ledIn14.TabIndex = 307;
            this.ledIn14.Text = null;
            this.ledIn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn15
            // 
            this.lblIn15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIn15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIn15.Location = new System.Drawing.Point(20, 95);
            this.lblIn15.Name = "lblIn15";
            this.lblIn15.Size = new System.Drawing.Size(40, 26);
            this.lblIn15.TabIndex = 308;
            this.lblIn15.Text = "15";
            this.lblIn15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledIn15
            // 
            this.ledIn15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledIn15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIn15.Location = new System.Drawing.Point(70, 97);
            this.ledIn15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledIn15.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledIn15.Name = "ledIn15";
            this.ledIn15.Radius = 3;
            this.ledIn15.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledIn15.Size = new System.Drawing.Size(120, 22);
            this.ledIn15.TabIndex = 309;
            this.ledIn15.Text = null;
            this.ledIn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpGeneralOut
            // 
            this.grpGeneralOut.Controls.Add(this.pnlOut1);
            this.grpGeneralOut.Controls.Add(this.pnlOut2);
            this.grpGeneralOut.Controls.Add(this.pnlOut3);
            this.grpGeneralOut.Controls.Add(this.pnlOut4);
            this.grpGeneralOut.FillColor = System.Drawing.Color.White;
            this.grpGeneralOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpGeneralOut.Location = new System.Drawing.Point(8, 424);
            this.grpGeneralOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGeneralOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.grpGeneralOut.Name = "grpGeneralOut";
            this.grpGeneralOut.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grpGeneralOut.Size = new System.Drawing.Size(1180, 175);
            this.grpGeneralOut.TabIndex = 310;
            this.grpGeneralOut.Text = "通用输出信号";
            this.grpGeneralOut.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOut1
            // 
            this.pnlOut1.Controls.Add(this.lblOut0);
            this.pnlOut1.Controls.Add(this.ledOut0);
            this.pnlOut1.Controls.Add(this.lblOut1);
            this.pnlOut1.Controls.Add(this.ledOut1);
            this.pnlOut1.Controls.Add(this.lblOut2);
            this.pnlOut1.Controls.Add(this.ledOut2);
            this.pnlOut1.Controls.Add(this.lblOut3);
            this.pnlOut1.Controls.Add(this.ledOut3);
            this.pnlOut1.FillColor = System.Drawing.Color.White;
            this.pnlOut1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlOut1.Location = new System.Drawing.Point(7, 37);
            this.pnlOut1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOut1.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlOut1.Name = "pnlOut1";
            this.pnlOut1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlOut1.Size = new System.Drawing.Size(275, 130);
            this.pnlOut1.TabIndex = 311;
            this.pnlOut1.Text = null;
            this.pnlOut1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut0
            // 
            this.lblOut0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut0.Location = new System.Drawing.Point(20, 8);
            this.lblOut0.Name = "lblOut0";
            this.lblOut0.Size = new System.Drawing.Size(40, 26);
            this.lblOut0.TabIndex = 312;
            this.lblOut0.Text = "0";
            this.lblOut0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut0
            // 
            this.ledOut0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut0.Location = new System.Drawing.Point(70, 10);
            this.ledOut0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut0.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut0.Name = "ledOut0";
            this.ledOut0.Radius = 3;
            this.ledOut0.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut0.Size = new System.Drawing.Size(120, 22);
            this.ledOut0.TabIndex = 313;
            this.ledOut0.Text = null;
            this.ledOut0.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut1
            // 
            this.lblOut1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut1.Location = new System.Drawing.Point(20, 37);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(40, 26);
            this.lblOut1.TabIndex = 314;
            this.lblOut1.Text = "1";
            this.lblOut1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut1
            // 
            this.ledOut1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut1.Location = new System.Drawing.Point(70, 39);
            this.ledOut1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut1.Name = "ledOut1";
            this.ledOut1.Radius = 3;
            this.ledOut1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut1.Size = new System.Drawing.Size(120, 22);
            this.ledOut1.TabIndex = 315;
            this.ledOut1.Text = null;
            this.ledOut1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut2
            // 
            this.lblOut2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut2.Location = new System.Drawing.Point(20, 66);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(40, 26);
            this.lblOut2.TabIndex = 316;
            this.lblOut2.Text = "2";
            this.lblOut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut2
            // 
            this.ledOut2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut2.Location = new System.Drawing.Point(70, 68);
            this.ledOut2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut2.Name = "ledOut2";
            this.ledOut2.Radius = 3;
            this.ledOut2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut2.Size = new System.Drawing.Size(120, 22);
            this.ledOut2.TabIndex = 317;
            this.ledOut2.Text = null;
            this.ledOut2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut3
            // 
            this.lblOut3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut3.Location = new System.Drawing.Point(20, 95);
            this.lblOut3.Name = "lblOut3";
            this.lblOut3.Size = new System.Drawing.Size(40, 26);
            this.lblOut3.TabIndex = 318;
            this.lblOut3.Text = "3";
            this.lblOut3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut3
            // 
            this.ledOut3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut3.Location = new System.Drawing.Point(70, 97);
            this.ledOut3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut3.Name = "ledOut3";
            this.ledOut3.Radius = 3;
            this.ledOut3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut3.Size = new System.Drawing.Size(120, 22);
            this.ledOut3.TabIndex = 319;
            this.ledOut3.Text = null;
            this.ledOut3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOut2
            // 
            this.pnlOut2.Controls.Add(this.lblOut4);
            this.pnlOut2.Controls.Add(this.ledOut4);
            this.pnlOut2.Controls.Add(this.lblOut5);
            this.pnlOut2.Controls.Add(this.ledOut5);
            this.pnlOut2.Controls.Add(this.lblOut6);
            this.pnlOut2.Controls.Add(this.ledOut6);
            this.pnlOut2.Controls.Add(this.lblOut7);
            this.pnlOut2.Controls.Add(this.ledOut7);
            this.pnlOut2.FillColor = System.Drawing.Color.White;
            this.pnlOut2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlOut2.Location = new System.Drawing.Point(302, 37);
            this.pnlOut2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOut2.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlOut2.Name = "pnlOut2";
            this.pnlOut2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlOut2.Size = new System.Drawing.Size(275, 130);
            this.pnlOut2.TabIndex = 320;
            this.pnlOut2.Text = null;
            this.pnlOut2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut4
            // 
            this.lblOut4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut4.Location = new System.Drawing.Point(20, 8);
            this.lblOut4.Name = "lblOut4";
            this.lblOut4.Size = new System.Drawing.Size(40, 26);
            this.lblOut4.TabIndex = 321;
            this.lblOut4.Text = "4";
            this.lblOut4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut4
            // 
            this.ledOut4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut4.Location = new System.Drawing.Point(70, 10);
            this.ledOut4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut4.Name = "ledOut4";
            this.ledOut4.Radius = 3;
            this.ledOut4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut4.Size = new System.Drawing.Size(120, 22);
            this.ledOut4.TabIndex = 322;
            this.ledOut4.Text = null;
            this.ledOut4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut5
            // 
            this.lblOut5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut5.Location = new System.Drawing.Point(20, 37);
            this.lblOut5.Name = "lblOut5";
            this.lblOut5.Size = new System.Drawing.Size(40, 26);
            this.lblOut5.TabIndex = 323;
            this.lblOut5.Text = "5";
            this.lblOut5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut5
            // 
            this.ledOut5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut5.Location = new System.Drawing.Point(70, 39);
            this.ledOut5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut5.Name = "ledOut5";
            this.ledOut5.Radius = 3;
            this.ledOut5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut5.Size = new System.Drawing.Size(120, 22);
            this.ledOut5.TabIndex = 324;
            this.ledOut5.Text = null;
            this.ledOut5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut6
            // 
            this.lblOut6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut6.Location = new System.Drawing.Point(20, 66);
            this.lblOut6.Name = "lblOut6";
            this.lblOut6.Size = new System.Drawing.Size(40, 26);
            this.lblOut6.TabIndex = 325;
            this.lblOut6.Text = "6";
            this.lblOut6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut6
            // 
            this.ledOut6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut6.Location = new System.Drawing.Point(70, 68);
            this.ledOut6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut6.Name = "ledOut6";
            this.ledOut6.Radius = 3;
            this.ledOut6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut6.Size = new System.Drawing.Size(120, 22);
            this.ledOut6.TabIndex = 326;
            this.ledOut6.Text = null;
            this.ledOut6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut7
            // 
            this.lblOut7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut7.Location = new System.Drawing.Point(20, 95);
            this.lblOut7.Name = "lblOut7";
            this.lblOut7.Size = new System.Drawing.Size(40, 26);
            this.lblOut7.TabIndex = 327;
            this.lblOut7.Text = "7";
            this.lblOut7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut7
            // 
            this.ledOut7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut7.Location = new System.Drawing.Point(70, 97);
            this.ledOut7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut7.Name = "ledOut7";
            this.ledOut7.Radius = 3;
            this.ledOut7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut7.Size = new System.Drawing.Size(120, 22);
            this.ledOut7.TabIndex = 328;
            this.ledOut7.Text = null;
            this.ledOut7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOut3
            // 
            this.pnlOut3.Controls.Add(this.lblOut8);
            this.pnlOut3.Controls.Add(this.ledOut8);
            this.pnlOut3.Controls.Add(this.lblOut9);
            this.pnlOut3.Controls.Add(this.ledOut9);
            this.pnlOut3.Controls.Add(this.lblOut10);
            this.pnlOut3.Controls.Add(this.ledOut10);
            this.pnlOut3.Controls.Add(this.lblOut11);
            this.pnlOut3.Controls.Add(this.ledOut11);
            this.pnlOut3.FillColor = System.Drawing.Color.White;
            this.pnlOut3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlOut3.Location = new System.Drawing.Point(597, 37);
            this.pnlOut3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOut3.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlOut3.Name = "pnlOut3";
            this.pnlOut3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlOut3.Size = new System.Drawing.Size(275, 130);
            this.pnlOut3.TabIndex = 329;
            this.pnlOut3.Text = null;
            this.pnlOut3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut8
            // 
            this.lblOut8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut8.Location = new System.Drawing.Point(20, 8);
            this.lblOut8.Name = "lblOut8";
            this.lblOut8.Size = new System.Drawing.Size(40, 26);
            this.lblOut8.TabIndex = 330;
            this.lblOut8.Text = "8";
            this.lblOut8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut8
            // 
            this.ledOut8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut8.Location = new System.Drawing.Point(70, 10);
            this.ledOut8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut8.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut8.Name = "ledOut8";
            this.ledOut8.Radius = 3;
            this.ledOut8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut8.Size = new System.Drawing.Size(120, 22);
            this.ledOut8.TabIndex = 331;
            this.ledOut8.Text = null;
            this.ledOut8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut9
            // 
            this.lblOut9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut9.Location = new System.Drawing.Point(20, 37);
            this.lblOut9.Name = "lblOut9";
            this.lblOut9.Size = new System.Drawing.Size(40, 26);
            this.lblOut9.TabIndex = 332;
            this.lblOut9.Text = "9";
            this.lblOut9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut9
            // 
            this.ledOut9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut9.Location = new System.Drawing.Point(70, 39);
            this.ledOut9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut9.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut9.Name = "ledOut9";
            this.ledOut9.Radius = 3;
            this.ledOut9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut9.Size = new System.Drawing.Size(120, 22);
            this.ledOut9.TabIndex = 333;
            this.ledOut9.Text = null;
            this.ledOut9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut10
            // 
            this.lblOut10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut10.Location = new System.Drawing.Point(20, 66);
            this.lblOut10.Name = "lblOut10";
            this.lblOut10.Size = new System.Drawing.Size(40, 26);
            this.lblOut10.TabIndex = 334;
            this.lblOut10.Text = "10";
            this.lblOut10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut10
            // 
            this.ledOut10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut10.Location = new System.Drawing.Point(70, 68);
            this.ledOut10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut10.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut10.Name = "ledOut10";
            this.ledOut10.Radius = 3;
            this.ledOut10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut10.Size = new System.Drawing.Size(120, 22);
            this.ledOut10.TabIndex = 335;
            this.ledOut10.Text = null;
            this.ledOut10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut11
            // 
            this.lblOut11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut11.Location = new System.Drawing.Point(20, 95);
            this.lblOut11.Name = "lblOut11";
            this.lblOut11.Size = new System.Drawing.Size(40, 26);
            this.lblOut11.TabIndex = 336;
            this.lblOut11.Text = "11";
            this.lblOut11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut11
            // 
            this.ledOut11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut11.Location = new System.Drawing.Point(70, 97);
            this.ledOut11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut11.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut11.Name = "ledOut11";
            this.ledOut11.Radius = 3;
            this.ledOut11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut11.Size = new System.Drawing.Size(120, 22);
            this.ledOut11.TabIndex = 337;
            this.ledOut11.Text = null;
            this.ledOut11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOut4
            // 
            this.pnlOut4.Controls.Add(this.lblOut12);
            this.pnlOut4.Controls.Add(this.ledOut12);
            this.pnlOut4.Controls.Add(this.lblOut13);
            this.pnlOut4.Controls.Add(this.ledOut13);
            this.pnlOut4.Controls.Add(this.lblOut14);
            this.pnlOut4.Controls.Add(this.ledOut14);
            this.pnlOut4.Controls.Add(this.lblOut15);
            this.pnlOut4.Controls.Add(this.ledOut15);
            this.pnlOut4.FillColor = System.Drawing.Color.White;
            this.pnlOut4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlOut4.Location = new System.Drawing.Point(892, 37);
            this.pnlOut4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOut4.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlOut4.Name = "pnlOut4";
            this.pnlOut4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.pnlOut4.Size = new System.Drawing.Size(275, 130);
            this.pnlOut4.TabIndex = 338;
            this.pnlOut4.Text = null;
            this.pnlOut4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut12
            // 
            this.lblOut12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut12.Location = new System.Drawing.Point(20, 8);
            this.lblOut12.Name = "lblOut12";
            this.lblOut12.Size = new System.Drawing.Size(40, 26);
            this.lblOut12.TabIndex = 339;
            this.lblOut12.Text = "12";
            this.lblOut12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut12
            // 
            this.ledOut12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut12.Location = new System.Drawing.Point(70, 10);
            this.ledOut12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut12.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut12.Name = "ledOut12";
            this.ledOut12.Radius = 3;
            this.ledOut12.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut12.Size = new System.Drawing.Size(120, 22);
            this.ledOut12.TabIndex = 340;
            this.ledOut12.Text = null;
            this.ledOut12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut13
            // 
            this.lblOut13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut13.Location = new System.Drawing.Point(20, 37);
            this.lblOut13.Name = "lblOut13";
            this.lblOut13.Size = new System.Drawing.Size(40, 26);
            this.lblOut13.TabIndex = 341;
            this.lblOut13.Text = "13";
            this.lblOut13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut13
            // 
            this.ledOut13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut13.Location = new System.Drawing.Point(70, 39);
            this.ledOut13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut13.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut13.Name = "ledOut13";
            this.ledOut13.Radius = 3;
            this.ledOut13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut13.Size = new System.Drawing.Size(120, 22);
            this.ledOut13.TabIndex = 342;
            this.ledOut13.Text = null;
            this.ledOut13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut14
            // 
            this.lblOut14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut14.Location = new System.Drawing.Point(20, 66);
            this.lblOut14.Name = "lblOut14";
            this.lblOut14.Size = new System.Drawing.Size(40, 26);
            this.lblOut14.TabIndex = 343;
            this.lblOut14.Text = "14";
            this.lblOut14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut14
            // 
            this.ledOut14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut14.Location = new System.Drawing.Point(70, 68);
            this.ledOut14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut14.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut14.Name = "ledOut14";
            this.ledOut14.Radius = 3;
            this.ledOut14.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut14.Size = new System.Drawing.Size(120, 22);
            this.ledOut14.TabIndex = 344;
            this.ledOut14.Text = null;
            this.ledOut14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut15
            // 
            this.lblOut15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOut15.Location = new System.Drawing.Point(20, 95);
            this.lblOut15.Name = "lblOut15";
            this.lblOut15.Size = new System.Drawing.Size(40, 26);
            this.lblOut15.TabIndex = 345;
            this.lblOut15.Text = "15";
            this.lblOut15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledOut15
            // 
            this.ledOut15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.ledOut15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledOut15.Location = new System.Drawing.Point(70, 97);
            this.ledOut15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledOut15.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledOut15.Name = "ledOut15";
            this.ledOut15.Radius = 3;
            this.ledOut15.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ledOut15.Size = new System.Drawing.Size(120, 22);
            this.ledOut15.TabIndex = 346;
            this.ledOut15.Text = null;
            this.ledOut15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.statusStrip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAxisLink,
            this.tsslAxisLed,
            this.tsslAxisPos});
            this.statusStrip.Location = new System.Drawing.Point(0, 855);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1704, 36);
            this.statusStrip.TabIndex = 13;
            // 
            // tsslAxisLink
            // 
            this.tsslAxisLink.Margin = new System.Windows.Forms.Padding(12, 5, 0, 5);
            this.tsslAxisLink.Name = "tsslAxisLink";
            this.tsslAxisLink.Size = new System.Drawing.Size(130, 26);
            this.tsslAxisLink.Text = "轴卡连接：";
            // 
            // tsslAxisLed
            // 
            this.tsslAxisLed.AutoSize = false;
            this.tsslAxisLed.BackColor = System.Drawing.Color.Red;
            this.tsslAxisLed.Margin = new System.Windows.Forms.Padding(6, 6, 8, 6);
            this.tsslAxisLed.Name = "tsslAxisLed";
            this.tsslAxisLed.Size = new System.Drawing.Size(52, 24);
            // 
            // tsslAxisPos
            // 
            this.tsslAxisPos.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tsslAxisPos.Name = "tsslAxisPos";
            this.tsslAxisPos.Size = new System.Drawing.Size(418, 26);
            this.tsslAxisPos.Text = "X: 0.00  Y: 0.00  Z: 0.00  R: 0.00";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1704, 891);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "上位机视觉开发";
            this.ZoomScaleDisabled = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1704, 891);
            this.pnlLeft.ResumeLayout(false);
            this.grpImageShow.ResumeLayout(false);
            this.grpRealTimeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRealTime)).EndInit();
            this.grpWorkImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkImage)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabMotion.ResumeLayout(false);
            this.grpInitParam.ResumeLayout(false);
            this.grpSpeedMode.ResumeLayout(false);
            this.grpInterpTest.ResumeLayout(false);
            this.grpManual.ResumeLayout(false);
            this.grpRecordPos.ResumeLayout(false);
            this.grpControlCfg.ResumeLayout(false);
            this.grpHomeSpeed.ResumeLayout(false);
            this.grpHomeDir.ResumeLayout(false);
            this.grpOnlineMove.ResumeLayout(false);
            this.grpOnlineOffset.ResumeLayout(false);
            this.tabCalib.ResumeLayout(false);
            this.grpImageProc.ResumeLayout(false);
            this.blkMean.ResumeLayout(false);
            this.blkDyn.ResumeLayout(false);
            this.blkAreaMax.ResumeLayout(false);
            this.blkAreaMin.ResumeLayout(false);
            this.grpPixelCoord.ResumeLayout(false);
            this.grpRobotCoord.ResumeLayout(false);
            this.tabLocate.ResumeLayout(false);
            this.grpLocateMode.ResumeLayout(false);
            this.pnlBlobParam.ResumeLayout(false);
            this.pnlTemplateParam.ResumeLayout(false);
            this.tabTrace.ResumeLayout(false);
            this.pnlContourA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picContourA)).EndInit();
            this.pnlContourB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picContourB)).EndInit();
            this.tabIO.ResumeLayout(false);
            this.grpAxisSignal.ResumeLayout(false);
            this.grpGeneralIn.ResumeLayout(false);
            this.pnlIn1.ResumeLayout(false);
            this.pnlIn2.ResumeLayout(false);
            this.pnlIn3.ResumeLayout(false);
            this.pnlIn4.ResumeLayout(false);
            this.grpGeneralOut.ResumeLayout(false);
            this.pnlOut1.ResumeLayout(false);
            this.pnlOut2.ResumeLayout(false);
            this.pnlOut3.ResumeLayout(false);
            this.pnlOut4.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UIGroupBox grpImageShow;
        private Sunny.UI.UIGroupBox grpRealTimeImage;
        private System.Windows.Forms.PictureBox picRealTime;
        private Sunny.UI.UIGroupBox grpWorkImage;
        private System.Windows.Forms.PictureBox picWorkImage;
        private Sunny.UI.UITabControl tabMain;
        private System.Windows.Forms.TabPage tabMotion;
        private System.Windows.Forms.TabPage tabCalib;
        private System.Windows.Forms.TabPage tabLocate;
        private System.Windows.Forms.TabPage tabTrace;
        private System.Windows.Forms.TabPage tabIO;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslAxisLink;
        private System.Windows.Forms.ToolStripStatusLabel tsslAxisLed;
        private System.Windows.Forms.ToolStripStatusLabel tsslAxisPos;
        private Sunny.UI.UIGroupBox grpInitParam;
        private Sunny.UI.UILabel lblInitSpeed;
        private Sunny.UI.UITextBox txtInitSpeed;
        private Sunny.UI.UILabel lblMaxSpeed;
        private Sunny.UI.UITextBox txtMaxSpeed;
        private Sunny.UI.UILabel lblAccTime;
        private Sunny.UI.UITextBox txtAccTime;
        private Sunny.UI.UILabel lblDecTime;
        private Sunny.UI.UITextBox txtDecTime;
        private Sunny.UI.UILabel lblSTime;
        private Sunny.UI.UITextBox txtSTime;
        private Sunny.UI.UILabel lblStopSpeed;
        private Sunny.UI.UITextBox txtStopSpeed;
        private Sunny.UI.UIGroupBox grpSpeedMode;
        private Sunny.UI.UIRadioButton rdoSType;
        private Sunny.UI.UIRadioButton rdoTType;
        private Sunny.UI.UIGroupBox grpInterpTest;
        private Sunny.UI.UILabel lblInterpX;
        private Sunny.UI.UITextBox txtInterpX;
        private Sunny.UI.UILabel lblInterpY;
        private Sunny.UI.UITextBox txtInterpY;
        private Sunny.UI.UILabel lblInterpZ;
        private Sunny.UI.UITextBox txtInterpZ;
        private Sunny.UI.UIButton btnLineInterp;
        private Sunny.UI.UIButton btnArcInterp;
        private Sunny.UI.UIGroupBox grpManual;
        private Sunny.UI.UISymbolButton btnAxisUp1;
        private Sunny.UI.UISymbolButton btnAxisUp2;
        private Sunny.UI.UISymbolButton btnAxisLeft;
        private Sunny.UI.UISymbolButton btnAxisStop;
        private Sunny.UI.UISymbolButton btnAxisRight;
        private Sunny.UI.UISymbolButton btnAxisDown1;
        private Sunny.UI.UISymbolButton btnAxisDown2;
        private Sunny.UI.UISymbolButton btnAxisStopHome;
        private Sunny.UI.UISymbolButton btnAxisRotateCcw;
        private Sunny.UI.UISymbolButton btnAxisRotateCw;
        private Sunny.UI.UIGroupBox grpRecordPos;
        private Sunny.UI.UIButton btnRecord0;
        private Sunny.UI.UIButton btnRecord1;
        private Sunny.UI.UIButton btnRecord2;
        private Sunny.UI.UIButton btnRecord3;
        private Sunny.UI.UIButton btnRecord4;
        private Sunny.UI.UIButton btnRecord5;
        private Sunny.UI.UIButton btnRecord6;
        private Sunny.UI.UIButton btnRecord7;
        private Sunny.UI.UIButton btnRecord8;
        private Sunny.UI.UIGroupBox grpControlCfg;
        private Sunny.UI.UICheckBox chkAxisX;
        private Sunny.UI.UICheckBox chkAxisY;
        private Sunny.UI.UICheckBox chkAxisZ;
        private Sunny.UI.UIGroupBox grpHomeSpeed;
        private Sunny.UI.UIRadioButton rdoHomeSpeedLow;
        private Sunny.UI.UIRadioButton rdoHomeSpeedHigh;
        private Sunny.UI.UIGroupBox grpHomeDir;
        private Sunny.UI.UIRadioButton rdoHomeDirPos;
        private Sunny.UI.UIRadioButton rdoHomeDirNeg;
        private Sunny.UI.UILabel lblHomeMode;
        private Sunny.UI.UIComboBox cmbHomeMode;
        private Sunny.UI.UIButton btnHome;
        private Sunny.UI.UIGroupBox grpOnlineMove;
        private Sunny.UI.UIButton btnAbsPos;
        private Sunny.UI.UITextBox txtAbsPos;
        private Sunny.UI.UIButton btnChgSpeed;
        private Sunny.UI.UITextBox txtChgSpeed;
        private Sunny.UI.UIButton btnChgPos;
        private Sunny.UI.UITextBox txtChgPos;
        private Sunny.UI.UIGroupBox grpOnlineOffset;
        private Sunny.UI.UIButton btnOffsetX;
        private Sunny.UI.UITextBox txtOffsetX;
        private Sunny.UI.UIButton btnOffsetY;
        private Sunny.UI.UITextBox txtOffsetY;
        private Sunny.UI.UIGroupBox grpImageProc;
        private Sunny.UI.UIButton btnMoveToShot;
        private Sunny.UI.UISymbolButton btnFlowArrow1;
        private Sunny.UI.UIButton btnCapture;
        private Sunny.UI.UISymbolButton btnFlowArrow2;
        private Sunny.UI.UIButton btnExtractNine;
        private Sunny.UI.UISymbolButton btnFlowArrow3;
        private Sunny.UI.UIButton btnStartCalib;
        private Sunny.UI.UISymbolButton btnFlowArrow4;
        private Sunny.UI.UIButton btnSaveCalib;
        private Sunny.UI.UIPanel blkMean;
        private Sunny.UI.UILabel lblMeanCap;
        private Sunny.UI.UITrackBar trbMean;
        private Sunny.UI.UITextBox txtMean;
        private Sunny.UI.UIPanel blkDyn;
        private Sunny.UI.UILabel lblDynCap;
        private Sunny.UI.UITrackBar trbDyn;
        private Sunny.UI.UITextBox txtDyn;
        private Sunny.UI.UIPanel blkAreaMax;
        private Sunny.UI.UILabel lblAreaMaxCap;
        private Sunny.UI.UITrackBar trbAreaMax;
        private Sunny.UI.UITextBox txtAreaMax;
        private Sunny.UI.UIPanel blkAreaMin;
        private Sunny.UI.UILabel lblAreaMinCap;
        private Sunny.UI.UITrackBar trbAreaMin;
        private Sunny.UI.UITextBox txtAreaMin;
        private Sunny.UI.UIGroupBox grpPixelCoord;
        private Sunny.UI.UILabel lblColHeader;
        private Sunny.UI.UILabel lblRowHeader;
        private Sunny.UI.UILabel lblPixPoint0;
        private Sunny.UI.UITextBox txtPixCol0;
        private Sunny.UI.UITextBox txtPixRow0;
        private Sunny.UI.UILabel lblPixPoint1;
        private Sunny.UI.UITextBox txtPixCol1;
        private Sunny.UI.UITextBox txtPixRow1;
        private Sunny.UI.UILabel lblPixPoint2;
        private Sunny.UI.UITextBox txtPixCol2;
        private Sunny.UI.UITextBox txtPixRow2;
        private Sunny.UI.UILabel lblPixPoint3;
        private Sunny.UI.UITextBox txtPixCol3;
        private Sunny.UI.UITextBox txtPixRow3;
        private Sunny.UI.UILabel lblPixPoint4;
        private Sunny.UI.UITextBox txtPixCol4;
        private Sunny.UI.UITextBox txtPixRow4;
        private Sunny.UI.UILabel lblPixPoint5;
        private Sunny.UI.UITextBox txtPixCol5;
        private Sunny.UI.UITextBox txtPixRow5;
        private Sunny.UI.UILabel lblPixPoint6;
        private Sunny.UI.UITextBox txtPixCol6;
        private Sunny.UI.UITextBox txtPixRow6;
        private Sunny.UI.UILabel lblPixPoint7;
        private Sunny.UI.UITextBox txtPixCol7;
        private Sunny.UI.UITextBox txtPixRow7;
        private Sunny.UI.UILabel lblPixPoint8;
        private Sunny.UI.UITextBox txtPixCol8;
        private Sunny.UI.UITextBox txtPixRow8;
        private Sunny.UI.UIButton btnSavePixel;
        private Sunny.UI.UIButton btnReadPixel;
        private Sunny.UI.UIGroupBox grpRobotCoord;
        private Sunny.UI.UILabel lblXHeader;
        private Sunny.UI.UILabel lblYHeader;
        private Sunny.UI.UILabel lblRobotPoint0;
        private Sunny.UI.UITextBox txtRobotX0;
        private Sunny.UI.UITextBox txtRobotY0;
        private Sunny.UI.UILabel lblRobotPoint1;
        private Sunny.UI.UITextBox txtRobotX1;
        private Sunny.UI.UITextBox txtRobotY1;
        private Sunny.UI.UILabel lblRobotPoint2;
        private Sunny.UI.UITextBox txtRobotX2;
        private Sunny.UI.UITextBox txtRobotY2;
        private Sunny.UI.UILabel lblRobotPoint3;
        private Sunny.UI.UITextBox txtRobotX3;
        private Sunny.UI.UITextBox txtRobotY3;
        private Sunny.UI.UILabel lblRobotPoint4;
        private Sunny.UI.UITextBox txtRobotX4;
        private Sunny.UI.UITextBox txtRobotY4;
        private Sunny.UI.UILabel lblRobotPoint5;
        private Sunny.UI.UITextBox txtRobotX5;
        private Sunny.UI.UITextBox txtRobotY5;
        private Sunny.UI.UILabel lblRobotPoint6;
        private Sunny.UI.UITextBox txtRobotX6;
        private Sunny.UI.UITextBox txtRobotY6;
        private Sunny.UI.UILabel lblRobotPoint7;
        private Sunny.UI.UITextBox txtRobotX7;
        private Sunny.UI.UITextBox txtRobotY7;
        private Sunny.UI.UILabel lblRobotPoint8;
        private Sunny.UI.UITextBox txtRobotX8;
        private Sunny.UI.UITextBox txtRobotY8;
        private Sunny.UI.UIButton btnSaveRobot;
        private Sunny.UI.UIButton btnReadRobot;
        private Sunny.UI.UIGroupBox grpLocateMode;
        private Sunny.UI.UIRadioButton rdoBlobAnalysis;
        private Sunny.UI.UIRadioButton rdoTemplateMatch;
        private Sunny.UI.UIPanel pnlBlobParam;
        private Sunny.UI.UIPanel blkMeanTh;
        private Sunny.UI.UIPanel blkAreaMaxTh;
        private Sunny.UI.UIPanel blkDynTh;
        private Sunny.UI.UIPanel blkAreaMinTh;
        private Sunny.UI.UITrackBar trbMeanTh;
        private Sunny.UI.UITextBox txtMeanTh;
        private Sunny.UI.UITrackBar trbAreaMaxTh;
        private Sunny.UI.UITextBox txtAreaMaxTh;
        private Sunny.UI.UIRadioButton rdoColorBlack;
        private Sunny.UI.UITrackBar trbDynTh;
        private Sunny.UI.UITextBox txtDynTh;
        private Sunny.UI.UITrackBar trbAreaMinTh;
        private Sunny.UI.UITextBox txtAreaMinTh;
        private Sunny.UI.UIRadioButton rdoColorWhite;
        private Sunny.UI.UIPanel pnlTemplateParam;
        private Sunny.UI.UIPanel blkTplContrast;
        private Sunny.UI.UIPanel blkProdContrast;
        private Sunny.UI.UIPanel blkMinScore;
        private Sunny.UI.UIPanel blkGreedy;
        private Sunny.UI.UIPanel blkCover;
        private Sunny.UI.UITrackBar trbTplContrast;
        private Sunny.UI.UITextBox txtTplContrast;
        private Sunny.UI.UITrackBar trbProdContrast;
        private Sunny.UI.UITextBox txtProdContrast;
        private Sunny.UI.UIButton btnCreateTemplate;
        private Sunny.UI.UITrackBar trbMinScore;
        private Sunny.UI.UITextBox txtMinScore;
        private Sunny.UI.UICheckBox chkAuto;
        private Sunny.UI.UILabel lblMaterialCount;
        private Sunny.UI.UITextBox txtMaterialCount;
        private Sunny.UI.UITrackBar trbGreedy;
        private Sunny.UI.UITextBox txtGreedy;
        private Sunny.UI.UITrackBar trbCover;
        private Sunny.UI.UITextBox txtCover;
        private Sunny.UI.UIButton btnTemplateMatch;
        private Sunny.UI.UIButton btnMoveToBase;
        private Sunny.UI.UISymbolButton btnFlowRight1;
        private Sunny.UI.UIButton btnRecognize;
        private Sunny.UI.UISymbolButton btnFlowRight2;
        private Sunny.UI.UIButton btnAnyGrab;
        private Sunny.UI.UIRadioButton rdoCollectContour;
        private Sunny.UI.UIRadioButton rdoImportCad;
        private Sunny.UI.UIButton btnLoadImage;
        private Sunny.UI.UIPanel pnlContourA;
        private System.Windows.Forms.PictureBox picContourA;
        private Sunny.UI.UIButton btnExtractContour;
        private Sunny.UI.UIPanel pnlContourB;
        private System.Windows.Forms.PictureBox picContourB;
        private Sunny.UI.UIButton btnAutoDraw;
        private Sunny.UI.UIGroupBox grpAxisSignal;
        private Sunny.UI.UILabel lblSignal0;
        private Sunny.UI.UILabel lblSignal1;
        private Sunny.UI.UILabel lblSignal2;
        private Sunny.UI.UILabel lblSignal3;
        private Sunny.UI.UILabel lblSignal4;
        private Sunny.UI.UILabel lblSignal5;
        private Sunny.UI.UILabel lblSignal6;
        private Sunny.UI.UILabel lblSignal7;
        private Sunny.UI.UILabel lblAxisRowX;
        private Sunny.UI.UIPanel ledXAxis0;
        private Sunny.UI.UIPanel ledXAxis1;
        private Sunny.UI.UIPanel ledXAxis2;
        private Sunny.UI.UIPanel ledXAxis3;
        private Sunny.UI.UIPanel ledXAxis4;
        private Sunny.UI.UIPanel ledXAxis5;
        private Sunny.UI.UIPanel ledXAxis6;
        private Sunny.UI.UIPanel ledXAxis7;
        private Sunny.UI.UILabel lblAxisRowY;
        private Sunny.UI.UIPanel ledYAxis0;
        private Sunny.UI.UIPanel ledYAxis1;
        private Sunny.UI.UIPanel ledYAxis2;
        private Sunny.UI.UIPanel ledYAxis3;
        private Sunny.UI.UIPanel ledYAxis4;
        private Sunny.UI.UIPanel ledYAxis5;
        private Sunny.UI.UIPanel ledYAxis6;
        private Sunny.UI.UIPanel ledYAxis7;
        private Sunny.UI.UILabel lblAxisRowZ;
        private Sunny.UI.UIPanel ledZAxis0;
        private Sunny.UI.UIPanel ledZAxis1;
        private Sunny.UI.UIPanel ledZAxis2;
        private Sunny.UI.UIPanel ledZAxis3;
        private Sunny.UI.UIPanel ledZAxis4;
        private Sunny.UI.UIPanel ledZAxis5;
        private Sunny.UI.UIPanel ledZAxis6;
        private Sunny.UI.UIPanel ledZAxis7;
        private Sunny.UI.UILabel lblAxisRowR;
        private Sunny.UI.UIPanel ledRAxis0;
        private Sunny.UI.UIPanel ledRAxis1;
        private Sunny.UI.UIPanel ledRAxis2;
        private Sunny.UI.UIPanel ledRAxis3;
        private Sunny.UI.UIPanel ledRAxis4;
        private Sunny.UI.UIPanel ledRAxis5;
        private Sunny.UI.UIPanel ledRAxis6;
        private Sunny.UI.UIPanel ledRAxis7;
        private Sunny.UI.UIGroupBox grpGeneralIn;
        private Sunny.UI.UIPanel pnlIn1;
        private Sunny.UI.UILabel lblIn0;
        private Sunny.UI.UIPanel ledIn0;
        private Sunny.UI.UILabel lblIn1;
        private Sunny.UI.UIPanel ledIn1;
        private Sunny.UI.UILabel lblIn2;
        private Sunny.UI.UIPanel ledIn2;
        private Sunny.UI.UILabel lblIn3;
        private Sunny.UI.UIPanel ledIn3;
        private Sunny.UI.UIPanel pnlIn2;
        private Sunny.UI.UILabel lblIn4;
        private Sunny.UI.UIPanel ledIn4;
        private Sunny.UI.UILabel lblIn5;
        private Sunny.UI.UIPanel ledIn5;
        private Sunny.UI.UILabel lblIn6;
        private Sunny.UI.UIPanel ledIn6;
        private Sunny.UI.UILabel lblIn7;
        private Sunny.UI.UIPanel ledIn7;
        private Sunny.UI.UIPanel pnlIn3;
        private Sunny.UI.UILabel lblIn8;
        private Sunny.UI.UIPanel ledIn8;
        private Sunny.UI.UILabel lblIn9;
        private Sunny.UI.UIPanel ledIn9;
        private Sunny.UI.UILabel lblIn10;
        private Sunny.UI.UIPanel ledIn10;
        private Sunny.UI.UILabel lblIn11;
        private Sunny.UI.UIPanel ledIn11;
        private Sunny.UI.UIPanel pnlIn4;
        private Sunny.UI.UILabel lblIn12;
        private Sunny.UI.UIPanel ledIn12;
        private Sunny.UI.UILabel lblIn13;
        private Sunny.UI.UIPanel ledIn13;
        private Sunny.UI.UILabel lblIn14;
        private Sunny.UI.UIPanel ledIn14;
        private Sunny.UI.UILabel lblIn15;
        private Sunny.UI.UIPanel ledIn15;
        private Sunny.UI.UIGroupBox grpGeneralOut;
        private Sunny.UI.UIPanel pnlOut1;
        private Sunny.UI.UILabel lblOut0;
        private Sunny.UI.UIPanel ledOut0;
        private Sunny.UI.UILabel lblOut1;
        private Sunny.UI.UIPanel ledOut1;
        private Sunny.UI.UILabel lblOut2;
        private Sunny.UI.UIPanel ledOut2;
        private Sunny.UI.UILabel lblOut3;
        private Sunny.UI.UIPanel ledOut3;
        private Sunny.UI.UIPanel pnlOut2;
        private Sunny.UI.UILabel lblOut4;
        private Sunny.UI.UIPanel ledOut4;
        private Sunny.UI.UILabel lblOut5;
        private Sunny.UI.UIPanel ledOut5;
        private Sunny.UI.UILabel lblOut6;
        private Sunny.UI.UIPanel ledOut6;
        private Sunny.UI.UILabel lblOut7;
        private Sunny.UI.UIPanel ledOut7;
        private Sunny.UI.UIPanel pnlOut3;
        private Sunny.UI.UILabel lblOut8;
        private Sunny.UI.UIPanel ledOut8;
        private Sunny.UI.UILabel lblOut9;
        private Sunny.UI.UIPanel ledOut9;
        private Sunny.UI.UILabel lblOut10;
        private Sunny.UI.UIPanel ledOut10;
        private Sunny.UI.UILabel lblOut11;
        private Sunny.UI.UIPanel ledOut11;
        private Sunny.UI.UIPanel pnlOut4;
        private Sunny.UI.UILabel lblOut12;
        private Sunny.UI.UIPanel ledOut12;
        private Sunny.UI.UILabel lblOut13;
        private Sunny.UI.UIPanel ledOut13;
        private Sunny.UI.UILabel lblOut14;
        private Sunny.UI.UIPanel ledOut14;
        private Sunny.UI.UILabel lblOut15;
        private Sunny.UI.UIPanel ledOut15;
        private Sunny.UI.UIButton btnTestVacuum;
        private Sunny.UI.UIButton btnWriteMean;
        private Sunny.UI.UIButton btnWriteDyn;
        private Sunny.UI.UIButton btnWriteAreaMax;
        private Sunny.UI.UIButton btnWriteAreaMin;
    }
}
