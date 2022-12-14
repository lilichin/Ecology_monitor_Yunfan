namespace Yunfan
{
    partial class Yunfan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yunfan));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl2 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Extract_Values_to_Points = new System.Windows.Forms.TabPage();
            this.Extract_Multi_Values_to_Points = new System.Windows.Forms.TabPage();
            this.Extract_by_Attributes = new System.Windows.Forms.TabPage();
            this.Test = new System.Windows.Forms.TabPage();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl1);
            this.splitContainer1.Panel1.Controls.Add(this.axLicenseControl2);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl1);
            // 
            // axTOCControl1
            // 
            resources.ApplyResources(this.axTOCControl1, "axTOCControl1");
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            // 
            // axLicenseControl2
            // 
            resources.ApplyResources(this.axLicenseControl2, "axLicenseControl2");
            this.axLicenseControl2.Name = "axLicenseControl2";
            this.axLicenseControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl2.OcxState")));
            // 
            // axMapControl1
            // 
            resources.ApplyResources(this.axMapControl1, "axMapControl1");
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            // 
            // axLicenseControl1
            // 
            resources.ApplyResources(this.axLicenseControl1, "axLicenseControl1");
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.Extract_Values_to_Points);
            this.tabControl1.Controls.Add(this.Extract_Multi_Values_to_Points);
            this.tabControl1.Controls.Add(this.Extract_by_Attributes);
            this.tabControl1.Controls.Add(this.Test);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Extract_Values_to_Points
            // 
            resources.ApplyResources(this.Extract_Values_to_Points, "Extract_Values_to_Points");
            this.Extract_Values_to_Points.Name = "Extract_Values_to_Points";
            this.Extract_Values_to_Points.UseVisualStyleBackColor = true;
            // 
            // Extract_Multi_Values_to_Points
            // 
            resources.ApplyResources(this.Extract_Multi_Values_to_Points, "Extract_Multi_Values_to_Points");
            this.Extract_Multi_Values_to_Points.Name = "Extract_Multi_Values_to_Points";
            this.Extract_Multi_Values_to_Points.UseVisualStyleBackColor = true;
            // 
            // Extract_by_Attributes
            // 
            resources.ApplyResources(this.Extract_by_Attributes, "Extract_by_Attributes");
            this.Extract_by_Attributes.Name = "Extract_by_Attributes";
            this.Extract_by_Attributes.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            resources.ApplyResources(this.Test, "Test");
            this.Test.Controls.Add(this.axToolbarControl1);
            this.Test.Name = "Test";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // axToolbarControl1
            // 
            resources.ApplyResources(this.axToolbarControl1, "axToolbarControl1");
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            // 
            // Yunfan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.Name = "Yunfan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Extract_Values_to_Points;
        private System.Windows.Forms.TabPage Extract_Multi_Values_to_Points;
        private System.Windows.Forms.TabPage Extract_by_Attributes;
        private System.Windows.Forms.TabPage Test;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl2;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
    }
}

