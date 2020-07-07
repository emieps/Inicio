namespace Inicio
{
    partial class asigDel
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
            this.asigDelCalvelab = new System.Windows.Forms.Label();
            this.asigClaveDeltxt = new System.Windows.Forms.TextBox();
            this.asigDelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asigDelCalvelab
            // 
            this.asigDelCalvelab.AutoSize = true;
            this.asigDelCalvelab.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.asigDelCalvelab.Location = new System.Drawing.Point(227, 129);
            this.asigDelCalvelab.Name = "asigDelCalvelab";
            this.asigDelCalvelab.Size = new System.Drawing.Size(57, 21);
            this.asigDelCalvelab.TabIndex = 0;
            this.asigDelCalvelab.Text = "Clave";
            this.asigDelCalvelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asigClaveDeltxt
            // 
            this.asigClaveDeltxt.Location = new System.Drawing.Point(353, 132);
            this.asigClaveDeltxt.Name = "asigClaveDeltxt";
            this.asigClaveDeltxt.Size = new System.Drawing.Size(140, 20);
            this.asigClaveDeltxt.TabIndex = 1;
            this.asigClaveDeltxt.TextChanged += new System.EventHandler(this.asigClaveDeltxt_TextChanged);
            // 
            // asigDelbtn
            // 
            this.asigDelbtn.FlatAppearance.BorderSize = 0;
            this.asigDelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.asigDelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asigDelbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.asigDelbtn.Location = new System.Drawing.Point(309, 216);
            this.asigDelbtn.Name = "asigDelbtn";
            this.asigDelbtn.Size = new System.Drawing.Size(71, 22);
            this.asigDelbtn.TabIndex = 2;
            this.asigDelbtn.Text = "Eliminar ";
            this.asigDelbtn.UseVisualStyleBackColor = true;
            this.asigDelbtn.Click += new System.EventHandler(this.asigDelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(262, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eliminar Asignatura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // asigDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asigDelbtn);
            this.Controls.Add(this.asigClaveDeltxt);
            this.Controls.Add(this.asigDelCalvelab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "asigDel";
            this.Text = "asigDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asigDelCalvelab;
        private System.Windows.Forms.TextBox asigClaveDeltxt;
        private System.Windows.Forms.Button asigDelbtn;
        private System.Windows.Forms.Label label1;
    }
}