namespace TwitterPost
{
    partial class FormTwitterPost
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.buttonPIN = new System.Windows.Forms.Button();
            this.buttonTweet = new System.Windows.Forms.Button();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.textBoxTweet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Location = new System.Drawing.Point(12, 12);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthorize.TabIndex = 0;
            this.buttonAuthorize.Text = "Twitter投稿";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            // 
            // buttonPIN
            // 
            this.buttonPIN.Location = new System.Drawing.Point(131, 41);
            this.buttonPIN.Name = "buttonPIN";
            this.buttonPIN.Size = new System.Drawing.Size(75, 23);
            this.buttonPIN.TabIndex = 1;
            this.buttonPIN.Text = "PIN入力";
            this.buttonPIN.UseVisualStyleBackColor = true;
            // 
            // buttonTweet
            // 
            this.buttonTweet.Location = new System.Drawing.Point(221, 277);
            this.buttonTweet.Name = "buttonTweet";
            this.buttonTweet.Size = new System.Drawing.Size(75, 23);
            this.buttonTweet.TabIndex = 2;
            this.buttonTweet.Text = "ツイート";
            this.buttonTweet.UseVisualStyleBackColor = true;
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(12, 41);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(100, 19);
            this.textBoxPIN.TabIndex = 3;
            // 
            // textBoxTweet
            // 
            this.textBoxTweet.Location = new System.Drawing.Point(12, 70);
            this.textBoxTweet.Multiline = true;
            this.textBoxTweet.Name = "textBoxTweet";
            this.textBoxTweet.Size = new System.Drawing.Size(284, 191);
            this.textBoxTweet.TabIndex = 4;
            // 
            // FormTwitterPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 348);
            this.Controls.Add(this.textBoxTweet);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.buttonTweet);
            this.Controls.Add(this.buttonPIN);
            this.Controls.Add(this.buttonAuthorize);
            this.Name = "FormTwitterPost";
            this.Text = "Twitter投稿";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.Button buttonPIN;
        private System.Windows.Forms.Button buttonTweet;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.TextBox textBoxTweet;
    }
}

