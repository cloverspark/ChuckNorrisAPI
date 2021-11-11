namespace ChuckNorrisFormApp
{
    partial class jokesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JokesBtn = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.JokeContainer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JokesBtn
            // 
            this.JokesBtn.BackColor = System.Drawing.SystemColors.Info;
            this.JokesBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JokesBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.JokesBtn.Location = new System.Drawing.Point(13, 470);
            this.JokesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JokesBtn.Name = "JokesBtn";
            this.JokesBtn.Size = new System.Drawing.Size(750, 100);
            this.JokesBtn.TabIndex = 0;
            this.JokesBtn.Text = "Wheres the joke?";
            this.JokesBtn.UseVisualStyleBackColor = false;
            this.JokesBtn.Click += new System.EventHandler(this.JokesBtn_Click);
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryCB.ForeColor = System.Drawing.Color.Red;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(13, 85);
            this.categoryCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(750, 46);
            this.categoryCB.TabIndex = 1;
            this.categoryCB.Text = "Categories";
            // 
            // JokeContainer
            // 
            this.JokeContainer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JokeContainer.Location = new System.Drawing.Point(13, 136);
            this.JokeContainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JokeContainer.Name = "JokeContainer";
            this.JokeContainer.Size = new System.Drawing.Size(750, 300);
            this.JokeContainer.TabIndex = 2;
            this.JokeContainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 592);
            this.Controls.Add(this.JokeContainer);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.JokesBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private Button JokesBtn;
        private ComboBox categoryCB;
        private Label JokeContainer;
    }
}