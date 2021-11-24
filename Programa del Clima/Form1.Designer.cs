namespace Programa_del_Clima
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Check = new System.Windows.Forms.Button();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Act = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Max = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Min = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BTN_Check
            // 
            this.BTN_Check.Location = new System.Drawing.Point(122, 179);
            this.BTN_Check.Name = "BTN_Check";
            this.BTN_Check.Size = new System.Drawing.Size(139, 21);
            this.BTN_Check.TabIndex = 0;
            this.BTN_Check.Text = "Revisa el Clima";
            this.BTN_Check.UseVisualStyleBackColor = true;
            this.BTN_Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(122, 97);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(325, 21);
            this.CB_City.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona una ciudad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(125, 251);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Minima";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(267, 251);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Maxima";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(431, 251);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Actual";
            // 
            // Lbl_Act
            // 
            this.Lbl_Act.AutoSize = true;
            this.Lbl_Act.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lbl_Act.Location = new System.Drawing.Point(441, 288);
            this.Lbl_Act.Name = "Lbl_Act";
            this.Lbl_Act.Size = new System.Drawing.Size(37, 25);
            this.Lbl_Act.TabIndex = 8;
            this.Lbl_Act.Text = "00°";
            // 
            // Lbl_Max
            // 
            this.Lbl_Max.AutoSize = true;
            this.Lbl_Max.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lbl_Max.Location = new System.Drawing.Point(277, 288);
            this.Lbl_Max.Name = "Lbl_Max";
            this.Lbl_Max.Size = new System.Drawing.Size(37, 25);
            this.Lbl_Max.TabIndex = 7;
            this.Lbl_Max.Text = "00°";
            // 
            // Lbl_Min
            // 
            this.Lbl_Min.AutoSize = true;
            this.Lbl_Min.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lbl_Min.Location = new System.Drawing.Point(135, 288);
            this.Lbl_Min.Name = "Lbl_Min";
            this.Lbl_Min.Size = new System.Drawing.Size(37, 25);
            this.Lbl_Min.TabIndex = 6;
            this.Lbl_Min.Text = "00°";
            this.Lbl_Min.Click += new System.EventHandler(this.Lbl_Min_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Act);
            this.Controls.Add(this.Lbl_Max);
            this.Controls.Add(this.Lbl_Min);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.BTN_Check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Check;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Lbl_Act;
        private MetroFramework.Controls.MetroLabel Lbl_Max;
        private MetroFramework.Controls.MetroLabel Lbl_Min;
    }
}

