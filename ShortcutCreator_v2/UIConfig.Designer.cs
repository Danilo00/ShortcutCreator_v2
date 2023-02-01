
namespace ShortcutCreator_v2
{
    partial class UIConfig
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIConfig));
            this.gb_shortcut = new System.Windows.Forms.GroupBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn_browserPath = new System.Windows.Forms.Button();
            this.btn_iconFileName = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.txt_iconName = new System.Windows.Forms.TextBox();
            this.lbl_iconFileName = new System.Windows.Forms.Label();
            this.txt_browserPath = new System.Windows.Forms.TextBox();
            this.lbl_browserPath = new System.Windows.Forms.Label();
            this.lbl_linkName = new System.Windows.Forms.Label();
            this.txt_linkName = new System.Windows.Forms.TextBox();
            this.btn_up = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.PictureBox();
            this.btn_shortcutGenerator = new System.Windows.Forms.Button();
            this.lbl_sign = new System.Windows.Forms.Label();
            this.btnExportImport = new System.Windows.Forms.Button();
            this.btnUpdateConfig = new System.Windows.Forms.Button();
            this.gb_shortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_shortcut
            // 
            this.gb_shortcut.BackColor = System.Drawing.Color.Cornsilk;
            this.gb_shortcut.Controls.Add(this.btnPlus);
            this.gb_shortcut.Controls.Add(this.btnUpdateConfig);
            this.gb_shortcut.Controls.Add(this.btn_browserPath);
            this.gb_shortcut.Controls.Add(this.btn_iconFileName);
            this.gb_shortcut.Controls.Add(this.txt_url);
            this.gb_shortcut.Controls.Add(this.lbl_url);
            this.gb_shortcut.Controls.Add(this.txt_iconName);
            this.gb_shortcut.Controls.Add(this.lbl_iconFileName);
            this.gb_shortcut.Controls.Add(this.txt_browserPath);
            this.gb_shortcut.Controls.Add(this.lbl_browserPath);
            this.gb_shortcut.Controls.Add(this.lbl_linkName);
            this.gb_shortcut.Controls.Add(this.txt_linkName);
            this.gb_shortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_shortcut.Location = new System.Drawing.Point(17, 16);
            this.gb_shortcut.Margin = new System.Windows.Forms.Padding(4);
            this.gb_shortcut.Name = "gb_shortcut";
            this.gb_shortcut.Padding = new System.Windows.Forms.Padding(4);
            this.gb_shortcut.Size = new System.Drawing.Size(542, 160);
            this.gb_shortcut.TabIndex = 0;
            this.gb_shortcut.TabStop = false;
            this.gb_shortcut.Text = "Shortcut 1";
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(486, 106);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 37);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.bnt_plus_Click);
            // 
            // btn_browserPath
            // 
            this.btn_browserPath.Location = new System.Drawing.Point(493, 69);
            this.btn_browserPath.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browserPath.Name = "btn_browserPath";
            this.btn_browserPath.Size = new System.Drawing.Size(37, 28);
            this.btn_browserPath.TabIndex = 5;
            this.btn_browserPath.Text = "...";
            this.btn_browserPath.UseVisualStyleBackColor = true;
            this.btn_browserPath.Click += new System.EventHandler(this.btn_browserPath_Click);
            // 
            // btn_iconFileName
            // 
            this.btn_iconFileName.Location = new System.Drawing.Point(493, 26);
            this.btn_iconFileName.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iconFileName.Name = "btn_iconFileName";
            this.btn_iconFileName.Size = new System.Drawing.Size(37, 28);
            this.btn_iconFileName.TabIndex = 2;
            this.btn_iconFileName.Text = "...";
            this.btn_iconFileName.UseVisualStyleBackColor = true;
            this.btn_iconFileName.Click += new System.EventHandler(this.btn_iconFileName_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(95, 75);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(132, 22);
            this.txt_url.TabIndex = 3;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(9, 79);
            this.lbl_url.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(28, 13);
            this.lbl_url.TabIndex = 6;
            this.lbl_url.Text = "URL";
            // 
            // txt_iconName
            // 
            this.txt_iconName.Location = new System.Drawing.Point(352, 28);
            this.txt_iconName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_iconName.Name = "txt_iconName";
            this.txt_iconName.Size = new System.Drawing.Size(132, 22);
            this.txt_iconName.TabIndex = 1;
            // 
            // lbl_iconFileName
            // 
            this.lbl_iconFileName.AutoSize = true;
            this.lbl_iconFileName.Location = new System.Drawing.Point(247, 32);
            this.lbl_iconFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iconFileName.Name = "lbl_iconFileName";
            this.lbl_iconFileName.Size = new System.Drawing.Size(63, 13);
            this.lbl_iconFileName.TabIndex = 4;
            this.lbl_iconFileName.Text = "Icon Name";
            // 
            // txt_browserPath
            // 
            this.txt_browserPath.Location = new System.Drawing.Point(352, 71);
            this.txt_browserPath.Margin = new System.Windows.Forms.Padding(4);
            this.txt_browserPath.Name = "txt_browserPath";
            this.txt_browserPath.Size = new System.Drawing.Size(132, 22);
            this.txt_browserPath.TabIndex = 4;
            // 
            // lbl_browserPath
            // 
            this.lbl_browserPath.AutoSize = true;
            this.lbl_browserPath.Location = new System.Drawing.Point(247, 75);
            this.lbl_browserPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_browserPath.Name = "lbl_browserPath";
            this.lbl_browserPath.Size = new System.Drawing.Size(76, 13);
            this.lbl_browserPath.TabIndex = 2;
            this.lbl_browserPath.Text = "Browser Path";
            // 
            // lbl_linkName
            // 
            this.lbl_linkName.AutoSize = true;
            this.lbl_linkName.Location = new System.Drawing.Point(9, 32);
            this.lbl_linkName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_linkName.Name = "lbl_linkName";
            this.lbl_linkName.Size = new System.Drawing.Size(63, 13);
            this.lbl_linkName.TabIndex = 1;
            this.lbl_linkName.Text = "Link Name";
            // 
            // txt_linkName
            // 
            this.txt_linkName.Location = new System.Drawing.Point(95, 28);
            this.txt_linkName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_linkName.Name = "txt_linkName";
            this.txt_linkName.Size = new System.Drawing.Size(132, 22);
            this.txt_linkName.TabIndex = 0;
            // 
            // btn_up
            // 
            this.btn_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_up.Image")));
            this.btn_up.Location = new System.Drawing.Point(528, 187);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(19, 19);
            this.btn_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_up.TabIndex = 1;
            this.btn_up.TabStop = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
            this.btn_down.Location = new System.Drawing.Point(528, 212);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(20, 19);
            this.btn_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_down.TabIndex = 2;
            this.btn_down.TabStop = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_shortcutGenerator
            // 
            this.btn_shortcutGenerator.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shortcutGenerator.Location = new System.Drawing.Point(393, 187);
            this.btn_shortcutGenerator.Name = "btn_shortcutGenerator";
            this.btn_shortcutGenerator.Size = new System.Drawing.Size(129, 44);
            this.btn_shortcutGenerator.TabIndex = 8;
            this.btn_shortcutGenerator.Text = "CREATE MY SHORTCUTS";
            this.btn_shortcutGenerator.UseVisualStyleBackColor = true;
            this.btn_shortcutGenerator.Click += new System.EventHandler(this.btn_shortcutGenerator_Click);
            // 
            // lbl_sign
            // 
            this.lbl_sign.AutoSize = true;
            this.lbl_sign.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sign.Location = new System.Drawing.Point(14, 180);
            this.lbl_sign.Name = "lbl_sign";
            this.lbl_sign.Size = new System.Drawing.Size(141, 15);
            this.lbl_sign.TabIndex = 4;
            this.lbl_sign.Text = "https://github.com/danilo00";
            // 
            // btnExportImport
            // 
            this.btnExportImport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportImport.Location = new System.Drawing.Point(12, 198);
            this.btnExportImport.Name = "btnExportImport";
            this.btnExportImport.Size = new System.Drawing.Size(182, 33);
            this.btnExportImport.TabIndex = 7;
            this.btnExportImport.Text = "Export/Import";
            this.btnExportImport.UseVisualStyleBackColor = true;
            this.btnExportImport.Click += new System.EventHandler(this.btnExportImport_Click);
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.Location = new System.Drawing.Point(302, 108);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(178, 34);
            this.btnUpdateConfig.TabIndex = 6;
            this.btnUpdateConfig.Text = "INSERT/UPDATE";
            this.btnUpdateConfig.UseVisualStyleBackColor = true;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnUpdateConfig_Click);
            // 
            // UIConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(598, 250);
            this.Controls.Add(this.btnExportImport);
            this.Controls.Add(this.lbl_sign);
            this.Controls.Add(this.btn_shortcutGenerator);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.gb_shortcut);
            this.Controls.Add(this.btn_up);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UIConfig";
            this.Text = "ShorcuteCreator by DC";
            this.Load += new System.EventHandler(this.UIConfig_Load);
            this.gb_shortcut.ResumeLayout(false);
            this.gb_shortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_shortcut;
        private System.Windows.Forms.Button btn_browserPath;
        private System.Windows.Forms.Button btn_iconFileName;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox txt_iconName;
        private System.Windows.Forms.Label lbl_iconFileName;
        private System.Windows.Forms.TextBox txt_browserPath;
        private System.Windows.Forms.Label lbl_browserPath;
        private System.Windows.Forms.Label lbl_linkName;
        private System.Windows.Forms.TextBox txt_linkName;
        private System.Windows.Forms.PictureBox btn_up;
        private System.Windows.Forms.PictureBox btn_down;
        private System.Windows.Forms.Button btn_shortcutGenerator;
        private System.Windows.Forms.Label lbl_sign;
        private System.Windows.Forms.Button btnExportImport;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnUpdateConfig;
    }
}

