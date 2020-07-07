namespace Inicio
{
    partial class AddProf
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
            this.profIDtxt = new System.Windows.Forms.TextBox();
            this.profNomtxt = new System.Windows.Forms.TextBox();
            this.proAddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.asigClavelab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profIDtxt
            // 
            this.profIDtxt.Location = new System.Drawing.Point(248, 111);
            this.profIDtxt.Name = "profIDtxt";
            this.profIDtxt.Size = new System.Drawing.Size(282, 20);
            this.profIDtxt.TabIndex = 2;
            this.profIDtxt.TextChanged += new System.EventHandler(this.profIDtxt_TextChanged);
            // 
            // profNomtxt
            // 
            this.profNomtxt.Location = new System.Drawing.Point(248, 181);
            this.profNomtxt.Name = "profNomtxt";
            this.profNomtxt.Size = new System.Drawing.Size(282, 20);
            this.profNomtxt.TabIndex = 3;
            this.profNomtxt.TextChanged += new System.EventHandler(this.profNomtxt_TextChanged);
            // 
            // proAddBtn
            // 
            this.proAddBtn.FlatAppearance.BorderSize = 0;
            this.proAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.proAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proAddBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.proAddBtn.Location = new System.Drawing.Point(324, 266);
            this.proAddBtn.Name = "proAddBtn";
            this.proAddBtn.Size = new System.Drawing.Size(75, 23);
            this.proAddBtn.TabIndex = 4;
            this.proAddBtn.Text = "Agregar";
            this.proAddBtn.UseVisualStyleBackColor = true;
            this.proAddBtn.Click += new System.EventHandler(this.proAddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(262, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Agregar Profesor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(128, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asigClavelab
            // 
            this.asigClavelab.AutoSize = true;
            this.asigClavelab.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.asigClavelab.Location = new System.Drawing.Point(128, 181);
            this.asigClavelab.Name = "asigClavelab";
            this.asigClavelab.Size = new System.Drawing.Size(73, 21);
            this.asigClavelab.TabIndex = 13;
            this.asigClavelab.Text = "Nombre";
            this.asigClavelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 422);
            this.Controls.Add(this.asigClavelab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proAddBtn);
            this.Controls.Add(this.profNomtxt);
            this.Controls.Add(this.profIDtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProf";
            this.Text = "AddProf";
            this.Load += new System.EventHandler(this.AddProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox profIDtxt;
        private System.Windows.Forms.TextBox profNomtxt;
        private System.Windows.Forms.Button proAddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label asigClavelab;
    }
}