namespace Inicio
{
    partial class asigAdd
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
            this.asigClavelab = new System.Windows.Forms.Label();
            this.asigClavetxt = new System.Windows.Forms.TextBox();
            this.asigNomlab = new System.Windows.Forms.Label();
            this.asigNomtxt = new System.Windows.Forms.TextBox();
            this.asigCreditlab = new System.Windows.Forms.Label();
            this.asigCredittxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asigAddbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // asigClavelab
            // 
            this.asigClavelab.AutoSize = true;
            this.asigClavelab.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.asigClavelab.Location = new System.Drawing.Point(128, 111);
            this.asigClavelab.Name = "asigClavelab";
            this.asigClavelab.Size = new System.Drawing.Size(57, 21);
            this.asigClavelab.TabIndex = 0;
            this.asigClavelab.Text = "Clave";
            this.asigClavelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.asigClavelab.Click += new System.EventHandler(this.asigClavelab_Click);
            // 
            // asigClavetxt
            // 
            this.asigClavetxt.Location = new System.Drawing.Point(248, 111);
            this.asigClavetxt.Name = "asigClavetxt";
            this.asigClavetxt.Size = new System.Drawing.Size(282, 20);
            this.asigClavetxt.TabIndex = 1;
            this.asigClavetxt.TextChanged += new System.EventHandler(this.asigClavetxt_TextChanged);
            // 
            // asigNomlab
            // 
            this.asigNomlab.AutoSize = true;
            this.asigNomlab.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.asigNomlab.Location = new System.Drawing.Point(128, 181);
            this.asigNomlab.Name = "asigNomlab";
            this.asigNomlab.Size = new System.Drawing.Size(73, 21);
            this.asigNomlab.TabIndex = 2;
            this.asigNomlab.Text = "Nombre";
            this.asigNomlab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // asigNomtxt
            // 
            this.asigNomtxt.Location = new System.Drawing.Point(248, 181);
            this.asigNomtxt.Name = "asigNomtxt";
            this.asigNomtxt.Size = new System.Drawing.Size(282, 20);
            this.asigNomtxt.TabIndex = 3;
            this.asigNomtxt.TextChanged += new System.EventHandler(this.asigNomtxt_TextChanged);
            // 
            // asigCreditlab
            // 
            this.asigCreditlab.AutoSize = true;
            this.asigCreditlab.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.asigCreditlab.Location = new System.Drawing.Point(128, 252);
            this.asigCreditlab.Name = "asigCreditlab";
            this.asigCreditlab.Size = new System.Drawing.Size(75, 21);
            this.asigCreditlab.TabIndex = 4;
            this.asigCreditlab.Text = "Creditos";
            this.asigCreditlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asigCredittxt
            // 
            this.asigCredittxt.Location = new System.Drawing.Point(248, 252);
            this.asigCredittxt.Name = "asigCredittxt";
            this.asigCredittxt.Size = new System.Drawing.Size(282, 20);
            this.asigCredittxt.TabIndex = 5;
            this.asigCredittxt.TextChanged += new System.EventHandler(this.asigCredittxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(262, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar Asignatura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // asigAddbtn
            // 
            this.asigAddbtn.FlatAppearance.BorderSize = 0;
            this.asigAddbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.asigAddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asigAddbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.asigAddbtn.Location = new System.Drawing.Point(324, 310);
            this.asigAddbtn.Name = "asigAddbtn";
            this.asigAddbtn.Size = new System.Drawing.Size(80, 24);
            this.asigAddbtn.TabIndex = 6;
            this.asigAddbtn.Text = "Agregar";
            this.asigAddbtn.UseVisualStyleBackColor = true;
            this.asigAddbtn.Click += new System.EventHandler(this.asigAddbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.asigAddbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.asigCredittxt);
            this.panel1.Controls.Add(this.asigCreditlab);
            this.panel1.Controls.Add(this.asigNomtxt);
            this.panel1.Controls.Add(this.asigNomlab);
            this.panel1.Controls.Add(this.asigClavetxt);
            this.panel1.Controls.Add(this.asigClavelab);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 356);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // asigAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 422);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "asigAdd";
            this.Text = "asigAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label asigClavelab;
        private System.Windows.Forms.TextBox asigClavetxt;
        private System.Windows.Forms.Label asigNomlab;
        private System.Windows.Forms.TextBox asigNomtxt;
        private System.Windows.Forms.Label asigCreditlab;
        private System.Windows.Forms.TextBox asigCredittxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button asigAddbtn;
        private System.Windows.Forms.Panel panel1;
    }
}