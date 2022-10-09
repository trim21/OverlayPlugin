namespace RainbowMage.OverlayPlugin.Overlays
{
    partial class LabelOverlayConfigPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelOverlayConfigPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMiniParseVisible = new System.Windows.Forms.CheckBox();
            this.checkMiniParseClickthru = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkEnableGlobalHotkey = new System.Windows.Forms.CheckBox();
            this.textGlobalHotkey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkLock = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCopyUpdateScript = new System.Windows.Forms.Button();
            this.buttonOpenDevTools = new System.Windows.Forms.Button();
            this.buttonReloadBrowser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkHTML = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkMiniParseVisible, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkMiniParseClickthru, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkEnableGlobalHotkey, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textGlobalHotkey, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkLock, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.checkHTML, 1, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // checkMiniParseVisible
            // 
            resources.ApplyResources(this.checkMiniParseVisible, "checkMiniParseVisible");
            this.checkMiniParseVisible.Name = "checkMiniParseVisible";
            this.checkMiniParseVisible.UseVisualStyleBackColor = true;
            this.checkMiniParseVisible.CheckedChanged += new System.EventHandler(this.checkWindowVisible_CheckedChanged);
            // 
            // checkMiniParseClickthru
            // 
            resources.ApplyResources(this.checkMiniParseClickthru, "checkMiniParseClickthru");
            this.checkMiniParseClickthru.Name = "checkMiniParseClickthru";
            this.checkMiniParseClickthru.UseVisualStyleBackColor = true;
            this.checkMiniParseClickthru.CheckedChanged += new System.EventHandler(this.checkMouseClickthru_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // checkEnableGlobalHotkey
            // 
            resources.ApplyResources(this.checkEnableGlobalHotkey, "checkEnableGlobalHotkey");
            this.checkEnableGlobalHotkey.Name = "checkEnableGlobalHotkey";
            this.checkEnableGlobalHotkey.UseVisualStyleBackColor = true;
            this.checkEnableGlobalHotkey.CheckedChanged += new System.EventHandler(this.checkBoxEnableGlobalHotkey_CheckedChanged);
            // 
            // textGlobalHotkey
            // 
            resources.ApplyResources(this.textGlobalHotkey, "textGlobalHotkey");
            this.textGlobalHotkey.Name = "textGlobalHotkey";
            this.textGlobalHotkey.Enter += new System.EventHandler(this.textGlobalHotkey_Enter);
            this.textGlobalHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textGlobalHotkey_KeyDown);
            this.textGlobalHotkey.Leave += new System.EventHandler(this.textGlobalHotkey_Leave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // checkLock
            // 
            resources.ApplyResources(this.checkLock, "checkLock");
            this.checkLock.Name = "checkLock";
            this.checkLock.UseVisualStyleBackColor = true;
            this.checkLock.CheckedChanged += new System.EventHandler(this.checkLock_CheckedChanged);
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonCopyUpdateScript, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonOpenDevTools, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonReloadBrowser, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // buttonCopyUpdateScript
            // 
            resources.ApplyResources(this.buttonCopyUpdateScript, "buttonCopyUpdateScript");
            this.buttonCopyUpdateScript.Name = "buttonCopyUpdateScript";
            this.buttonCopyUpdateScript.UseVisualStyleBackColor = true;
            this.buttonCopyUpdateScript.Click += new System.EventHandler(this.buttonCopyActXiv_Click);
            // 
            // buttonOpenDevTools
            // 
            resources.ApplyResources(this.buttonOpenDevTools, "buttonOpenDevTools");
            this.buttonOpenDevTools.Name = "buttonOpenDevTools";
            this.buttonOpenDevTools.UseVisualStyleBackColor = true;
            this.buttonOpenDevTools.Click += new System.EventHandler(this.buttonOpenDevTools_Click);
            this.buttonOpenDevTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOpenDevTools_RClick);
            // 
            // buttonReloadBrowser
            // 
            resources.ApplyResources(this.buttonReloadBrowser, "buttonReloadBrowser");
            this.buttonReloadBrowser.Name = "buttonReloadBrowser";
            this.buttonReloadBrowser.UseVisualStyleBackColor = true;
            this.buttonReloadBrowser.Click += new System.EventHandler(this.buttonReloadBrowser_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.textUrl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelectFile, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // textUrl
            // 
            resources.ApplyResources(this.textUrl, "textUrl");
            this.textUrl.Name = "textUrl";
            this.textUrl.Leave += new System.EventHandler(this.textUrl_Leave);
            // 
            // buttonSelectFile
            // 
            resources.ApplyResources(this.buttonSelectFile, "buttonSelectFile");
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // checkHTML
            // 
            resources.ApplyResources(this.checkHTML, "checkHTML");
            this.checkHTML.Name = "checkHTML";
            this.checkHTML.UseVisualStyleBackColor = true;
            this.checkHTML.CheckedChanged += new System.EventHandler(this.checkHTML_CheckedChanged);
            // 
            // LabelOverlayConfigPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LabelOverlayConfigPanel";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkMiniParseVisible;
        private System.Windows.Forms.CheckBox checkMiniParseClickthru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkEnableGlobalHotkey;
        private System.Windows.Forms.TextBox textGlobalHotkey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkLock;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonReloadBrowser;
        private System.Windows.Forms.Button buttonOpenDevTools;
        private System.Windows.Forms.Button buttonCopyUpdateScript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkHTML;
    }
}
