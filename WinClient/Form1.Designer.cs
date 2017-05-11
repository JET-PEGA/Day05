namespace WinClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPost = new System.Windows.Forms.ToolStripButton();
            this.btnGet = new System.Windows.Forms.ToolStripButton();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPost,
            this.btnGet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1151, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPost
            // 
            this.btnPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(66, 35);
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGet
            // 
            this.btnGet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGet.Image = ((System.Drawing.Image)(resources.GetObject("btnGet.Image")));
            this.btnGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(58, 35);
            this.btnGet.Text = "Get";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Location = new System.Drawing.Point(0, 38);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(1151, 808);
            this.txtResponse.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 846);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPost;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.ToolStripButton btnGet;
    }
}

