namespace LoopingLabTask3
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
            this.listBoxCaloriesBurned = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCaloriesBurned
            // 
            this.listBoxCaloriesBurned.FormattingEnabled = true;
            this.listBoxCaloriesBurned.ItemHeight = 25;
            this.listBoxCaloriesBurned.Location = new System.Drawing.Point(128, 210);
            this.listBoxCaloriesBurned.Name = "listBoxCaloriesBurned";
            this.listBoxCaloriesBurned.Size = new System.Drawing.Size(652, 304);
            this.listBoxCaloriesBurned.TabIndex = 0;
            this.listBoxCaloriesBurned.SelectedIndexChanged += new System.EventHandler(this.listBoxCaloriesBurned_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 903);
            this.Controls.Add(this.listBoxCaloriesBurned);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCaloriesBurned;
    }
}

