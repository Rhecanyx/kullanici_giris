namespace giris
{
    partial class kullanici
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtKadi = new DevExpress.XtraEditors.TextEdit();
            this.txtSfre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGrs = new DevExpress.XtraEditors.SimpleButton();
            this.btnKpt = new DevExpress.XtraEditors.SimpleButton();
            this.txtSonuc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dxkontrol = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxkontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(171, 57);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(78)))));
            this.txtKadi.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtKadi.Properties.Appearance.Options.UseBackColor = true;
            this.txtKadi.Properties.Appearance.Options.UseForeColor = true;
            this.txtKadi.Size = new System.Drawing.Size(180, 20);
            this.txtKadi.TabIndex = 1;
            conditionValidationRule1.ErrorText = "Kullanıcı Adı Boş Geçilemez !";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxkontrol.SetValidationRule(this.txtKadi, conditionValidationRule1);
            // 
            // txtSfre
            // 
            this.txtSfre.Location = new System.Drawing.Point(171, 97);
            this.txtSfre.Name = "txtSfre";
            this.txtSfre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(78)))));
            this.txtSfre.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSfre.Properties.Appearance.Options.UseBackColor = true;
            this.txtSfre.Properties.Appearance.Options.UseForeColor = true;
            this.txtSfre.Size = new System.Drawing.Size(180, 20);
            this.txtSfre.TabIndex = 2;
            conditionValidationRule2.ErrorText = "Şifre Alanı Boş Geçilemez !";
            this.dxkontrol.SetValidationRule(this.txtSfre, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kullanıcı Adı ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Şifre ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(127, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(5, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = ":";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(127, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(5, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = ":";
            // 
            // btnGrs
            // 
            this.btnGrs.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(78)))));
            this.btnGrs.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrs.Appearance.Options.UseBackColor = true;
            this.btnGrs.Appearance.Options.UseFont = true;
            this.btnGrs.Location = new System.Drawing.Point(266, 155);
            this.btnGrs.Name = "btnGrs";
            this.btnGrs.Size = new System.Drawing.Size(85, 23);
            this.btnGrs.TabIndex = 7;
            this.btnGrs.Text = "Giriş";
            this.btnGrs.Click += new System.EventHandler(this.btnGrs_Click);
            // 
            // btnKpt
            // 
            this.btnKpt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(78)))));
            this.btnKpt.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKpt.Appearance.Options.UseBackColor = true;
            this.btnKpt.Appearance.Options.UseFont = true;
            this.btnKpt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKpt.Location = new System.Drawing.Point(171, 155);
            this.btnKpt.Name = "btnKpt";
            this.btnKpt.Size = new System.Drawing.Size(89, 23);
            this.btnKpt.TabIndex = 8;
            this.btnKpt.Text = "Kapat";
            this.btnKpt.Click += new System.EventHandler(this.btnKpt_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtSonuc.Appearance.Options.UseFont = true;
            this.txtSonuc.Appearance.Options.UseForeColor = true;
            this.txtSonuc.Location = new System.Drawing.Point(171, 194);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(0, 16);
            this.txtSonuc.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(357, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(8, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(357, 96);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(8, 16);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "*";
            // 
            // kullanici
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(78)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKpt;
            this.ClientSize = new System.Drawing.Size(407, 253);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnKpt);
            this.Controls.Add(this.btnGrs);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSfre);
            this.Controls.Add(this.txtKadi);
            this.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("kullanici.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rhecanxy Kullanıcı Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxkontrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtKadi;
        private DevExpress.XtraEditors.TextEdit txtSfre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnGrs;
        private DevExpress.XtraEditors.SimpleButton btnKpt;
        private DevExpress.XtraEditors.LabelControl txtSonuc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxkontrol;
    }
}

