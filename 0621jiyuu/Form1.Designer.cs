namespace _0621jiyuu
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clearLabel = new System.Windows.Forms.Label();
            this.modoruButton = new System.Windows.Forms.Button();
            this.gmovLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(298, 161);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(275, 53);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "よけとるVC#";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(114, 33);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time: 0";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.leftLabel.Location = new System.Drawing.Point(702, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(132, 33);
            this.leftLabel.TabIndex = 1;
            this.leftLabel.Text = "残り: 0個";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(303, 335);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(271, 71);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "ゲームスタート！";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearLabel.Location = new System.Drawing.Point(318, 161);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(237, 53);
            this.clearLabel.TabIndex = 4;
            this.clearLabel.Text = "クリア！！";
            this.clearLabel.Visible = false;
            // 
            // modoruButton
            // 
            this.modoruButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modoruButton.Location = new System.Drawing.Point(303, 335);
            this.modoruButton.Name = "modoruButton";
            this.modoruButton.Size = new System.Drawing.Size(271, 71);
            this.modoruButton.TabIndex = 5;
            this.modoruButton.Text = "タイトルへ戻る";
            this.modoruButton.UseVisualStyleBackColor = true;
            this.modoruButton.Visible = false;
            this.modoruButton.Click += new System.EventHandler(this.modoruButton_Click);
            // 
            // gmovLabel
            // 
            this.gmovLabel.AutoSize = true;
            this.gmovLabel.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gmovLabel.Location = new System.Drawing.Point(280, 161);
            this.gmovLabel.Name = "gmovLabel";
            this.gmovLabel.Size = new System.Drawing.Size(324, 53);
            this.gmovLabel.TabIndex = 6;
            this.gmovLabel.Text = "ゲームオーバー";
            this.gmovLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.gmovLabel);
            this.Controls.Add(this.modoruButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button modoruButton;
        private System.Windows.Forms.Label gmovLabel;
    }
}

