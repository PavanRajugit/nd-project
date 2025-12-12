namespace CodingTest.UI
{
    partial class CellValueForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelValue = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 18);
            this.labelValue.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(46, 17);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOk.Location = new System.Drawing.Point(170, 70);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(80, 28);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += (s, e) => this.Close();
            // 
            // CellValueForm
            // 
            this.AcceptButton = this.buttonOk;
            this.CancelButton = this.buttonOk;
            this.ClientSize = new System.Drawing.Size(420, 110);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "CellValueForm";
            this.Text = "Cell Value";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}