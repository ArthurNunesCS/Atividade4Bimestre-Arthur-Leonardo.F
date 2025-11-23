namespace Atividade4Bimestre_Arthur_Leonardo.F
{
    partial class frmarea
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
            this.txtareacomodo = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtcomodo = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.lblcomodo = new System.Windows.Forms.Label();
            this.txtareatotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtareacomodo
            // 
            this.txtareacomodo.Location = new System.Drawing.Point(639, 113);
            this.txtareacomodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtareacomodo.Multiline = true;
            this.txtareacomodo.Name = "txtareacomodo";
            this.txtareacomodo.ReadOnly = true;
            this.txtareacomodo.Size = new System.Drawing.Size(136, 21);
            this.txtareacomodo.TabIndex = 17;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(513, 117);
            this.lblresult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(121, 13);
            this.lblresult.TabIndex = 16;
            this.lblresult.Text = "A área do cômodo é de:";
            // 
            // txtcomodo
            // 
            this.txtcomodo.Location = new System.Drawing.Point(281, 115);
            this.txtcomodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcomodo.Name = "txtcomodo";
            this.txtcomodo.Size = new System.Drawing.Size(105, 20);
            this.txtcomodo.TabIndex = 15;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(563, 381);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 41);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(203, 217);
            this.btndowhile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(75, 56);
            this.btndowhile.TabIndex = 13;
            this.btndowhile.Text = "Calcular com DoWhile";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(203, 303);
            this.btnfor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 41);
            this.btnfor.TabIndex = 12;
            this.btnfor.Text = "Calcular com For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(383, 381);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 41);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(203, 381);
            this.btnwhile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 41);
            this.btnwhile.TabIndex = 10;
            this.btnwhile.Text = "Calcular com While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // lblcomodo
            // 
            this.lblcomodo.AutoSize = true;
            this.lblcomodo.Location = new System.Drawing.Point(75, 117);
            this.lblcomodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcomodo.Name = "lblcomodo";
            this.lblcomodo.Size = new System.Drawing.Size(203, 13);
            this.lblcomodo.TabIndex = 9;
            this.lblcomodo.Text = "Digite quantos cômodos sua casa possui:";
            this.lblcomodo.Click += new System.EventHandler(this.lblnumero_Click);
            // 
            // txtareatotal
            // 
            this.txtareatotal.Location = new System.Drawing.Point(639, 158);
            this.txtareatotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtareatotal.Multiline = true;
            this.txtareatotal.Name = "txtareatotal";
            this.txtareatotal.ReadOnly = true;
            this.txtareatotal.Size = new System.Drawing.Size(136, 21);
            this.txtareatotal.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "A área total da casa é de:";
            // 
            // frmarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.ControlBox = false;
            this.Controls.Add(this.txtareatotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtareacomodo);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtcomodo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.lblcomodo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtareacomodo;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtcomodo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Label lblcomodo;
        private System.Windows.Forms.TextBox txtareatotal;
        private System.Windows.Forms.Label label1;
    }
}