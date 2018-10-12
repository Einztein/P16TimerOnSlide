namespace P16TimerOnSlide
{
    partial class RibCon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibCon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Mode = this.Factory.CreateRibbonGroup();
            this.buttonModeTimer = this.Factory.CreateRibbonButton();
            this.buttonModeStop = this.Factory.CreateRibbonButton();
            this.groupTimer = this.Factory.CreateRibbonGroup();
            this.groupStop = this.Factory.CreateRibbonGroup();
            this.tab1.SuspendLayout();
            this.Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.Mode);
            this.tab1.Groups.Add(this.groupTimer);
            this.tab1.Groups.Add(this.groupStop);
            this.tab1.Label = "TimerOnSlide";
            this.tab1.Name = "tab1";
            // 
            // Mode
            // 
            this.Mode.Items.Add(this.buttonModeTimer);
            this.Mode.Items.Add(this.buttonModeStop);
            this.Mode.Label = "Mode";
            this.Mode.Name = "Mode";
            // 
            // buttonModeTimer
            // 
            this.buttonModeTimer.Label = "Timer";
            this.buttonModeTimer.Name = "buttonModeTimer";
            this.buttonModeTimer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonModeTimer_Click);
            // 
            // buttonModeStop
            // 
            this.buttonModeStop.Label = "StopWatch";
            this.buttonModeStop.Name = "buttonModeStop";
            this.buttonModeStop.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonModeStop_Click);
            // 
            // groupTimer
            // 
            this.groupTimer.Label = "Timer";
            this.groupTimer.Name = "groupTimer";
            this.groupTimer.Visible = false;
            // 
            // groupStop
            // 
            this.groupStop.Label = "StopWatch";
            this.groupStop.Name = "groupStop";
            this.groupStop.Visible = false;
            // 
            // RibCon
            // 
            this.Name = "RibCon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibCon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Mode.ResumeLayout(false);
            this.Mode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Mode;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonModeTimer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonModeStop;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupTimer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupStop;
    }

    partial class ThisRibbonCollection
    {
        internal RibCon RibCon
        {
            get { return this.GetRibbon<RibCon>(); }
        }
    }
}
