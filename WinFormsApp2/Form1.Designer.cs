
namespace WinFormsApp2
{
    partial class Form1
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
            this.btnchon = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(56, 42);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(94, 29);
            this.btnchon.TabIndex = 0;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.Folder_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(186, 42);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(224, 27);
            this.txtFile.TabIndex = 1;
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Location = new System.Drawing.Point(186, 100);
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(224, 27);
            this.txtMaHoa.TabIndex = 2;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(56, 100);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(94, 29);
            this.btnMaHoa.TabIndex = 3;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.Mahoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.txtMaHoa);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnchon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.Button btnMaHoa;
    }
}

