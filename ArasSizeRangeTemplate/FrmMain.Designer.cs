namespace ArasSizeRangeTemplate
{
    partial class FrmMain
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
            this.pan_Result = new System.Windows.Forms.Panel();
            this.txt_AML = new System.Windows.Forms.TextBox();
            this.pan_Collar = new System.Windows.Forms.Panel();
            this.pan_SizeRangeType = new System.Windows.Forms.Panel();
            this.radio_CollarSleeve = new System.Windows.Forms.RadioButton();
            this.radio_Collar = new System.Windows.Forms.RadioButton();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.pan_Result.SuspendLayout();
            this.pan_SizeRangeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_Result
            // 
            this.pan_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Result.Controls.Add(this.txt_AML);
            this.pan_Result.Location = new System.Drawing.Point(12, 326);
            this.pan_Result.Name = "pan_Result";
            this.pan_Result.Size = new System.Drawing.Size(634, 174);
            this.pan_Result.TabIndex = 0;
            // 
            // txt_AML
            // 
            this.txt_AML.Location = new System.Drawing.Point(3, 6);
            this.txt_AML.Multiline = true;
            this.txt_AML.Name = "txt_AML";
            this.txt_AML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_AML.Size = new System.Drawing.Size(624, 156);
            this.txt_AML.TabIndex = 3;
            this.txt_AML.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AML_KeyPress);
            // 
            // pan_Collar
            // 
            this.pan_Collar.AutoScroll = true;
            this.pan_Collar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Collar.Location = new System.Drawing.Point(12, 70);
            this.pan_Collar.Name = "pan_Collar";
            this.pan_Collar.Size = new System.Drawing.Size(633, 249);
            this.pan_Collar.TabIndex = 1;
            // 
            // pan_SizeRangeType
            // 
            this.pan_SizeRangeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_SizeRangeType.Controls.Add(this.radio_CollarSleeve);
            this.pan_SizeRangeType.Controls.Add(this.radio_Collar);
            this.pan_SizeRangeType.Controls.Add(this.btn_Start);
            this.pan_SizeRangeType.Controls.Add(this.btn_Restart);
            this.pan_SizeRangeType.Location = new System.Drawing.Point(12, 12);
            this.pan_SizeRangeType.Name = "pan_SizeRangeType";
            this.pan_SizeRangeType.Size = new System.Drawing.Size(633, 52);
            this.pan_SizeRangeType.TabIndex = 2;
            // 
            // radio_CollarSleeve
            // 
            this.radio_CollarSleeve.AutoSize = true;
            this.radio_CollarSleeve.Checked = true;
            this.radio_CollarSleeve.Location = new System.Drawing.Point(105, 15);
            this.radio_CollarSleeve.Name = "radio_CollarSleeve";
            this.radio_CollarSleeve.Size = new System.Drawing.Size(101, 16);
            this.radio_CollarSleeve.TabIndex = 1;
            this.radio_CollarSleeve.TabStop = true;
            this.radio_CollarSleeve.Text = "Collar/Sleeve";
            this.radio_CollarSleeve.UseVisualStyleBackColor = true;
            // 
            // radio_Collar
            // 
            this.radio_Collar.AutoSize = true;
            this.radio_Collar.Location = new System.Drawing.Point(21, 15);
            this.radio_Collar.Name = "radio_Collar";
            this.radio_Collar.Size = new System.Drawing.Size(59, 16);
            this.radio_Collar.TabIndex = 1;
            this.radio_Collar.Text = "Collar";
            this.radio_Collar.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(519, 15);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(425, 15);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 23);
            this.btn_Restart.TabIndex = 0;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 508);
            this.Controls.Add(this.pan_SizeRangeType);
            this.Controls.Add(this.pan_Collar);
            this.Controls.Add(this.pan_Result);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Aras Size Range Template V1.0";
            this.pan_Result.ResumeLayout(false);
            this.pan_Result.PerformLayout();
            this.pan_SizeRangeType.ResumeLayout(false);
            this.pan_SizeRangeType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_Result;
        private System.Windows.Forms.TextBox txt_AML;
        private System.Windows.Forms.Panel pan_Collar;
        private System.Windows.Forms.Panel pan_SizeRangeType;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.RadioButton radio_CollarSleeve;
        private System.Windows.Forms.RadioButton radio_Collar;
        private System.Windows.Forms.Button btn_Start;
    }
}

