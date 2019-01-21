namespace PopularMoviesTMDb
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showTopRatedBtn = new System.Windows.Forms.Button();
            this.showPopularBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resultBoxLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showTopRatedBtn
            // 
            this.showTopRatedBtn.Location = new System.Drawing.Point(176, 152);
            this.showTopRatedBtn.Name = "showTopRatedBtn";
            this.showTopRatedBtn.Size = new System.Drawing.Size(136, 49);
            this.showTopRatedBtn.TabIndex = 3;
            this.showTopRatedBtn.Text = "Show top rated movies";
            this.showTopRatedBtn.UseVisualStyleBackColor = true;
            this.showTopRatedBtn.Click += new System.EventHandler(this.showTopRatedBtn_Click);
            // 
            // showPopularBtn
            // 
            this.showPopularBtn.Location = new System.Drawing.Point(21, 152);
            this.showPopularBtn.Name = "showPopularBtn";
            this.showPopularBtn.Size = new System.Drawing.Size(136, 49);
            this.showPopularBtn.TabIndex = 4;
            this.showPopularBtn.Text = "Show popular movies";
            this.showPopularBtn.UseVisualStyleBackColor = true;
            this.showPopularBtn.Click += new System.EventHandler(this.showPopularBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(21, 235);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(467, 203);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // resultBoxLabel
            // 
            this.resultBoxLabel.AutoSize = true;
            this.resultBoxLabel.Location = new System.Drawing.Point(21, 212);
            this.resultBoxLabel.Name = "resultBoxLabel";
            this.resultBoxLabel.Size = new System.Drawing.Size(125, 20);
            this.resultBoxLabel.TabIndex = 7;
            this.resultBoxLabel.Text = "Selected movies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Welcome to Show TMDb movies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select movies to show by clicking a button";
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(17, 55);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(331, 20);
            this.apiKeyLabel.TabIndex = 12;
            this.apiKeyLabel.Text = "To show movies you need to enter an API Key";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(21, 78);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(291, 26);
            this.apiKeyTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultBoxLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.showPopularBtn);
            this.Controls.Add(this.showTopRatedBtn);
            this.Name = "Form1";
            this.Text = "Show TMDb movies - an app by Malin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showTopRatedBtn;
        private System.Windows.Forms.Button showPopularBtn;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label resultBoxLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
    }
}

