namespace Examen_DW
{
    partial class frmRespaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRespaldo));
            this.advancedWizard1 = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.advancedWizardPage3 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtRTipo = new System.Windows.Forms.TextBox();
            this.txtRUbicacion = new System.Windows.Forms.TextBox();
            this.txtRDir = new System.Windows.Forms.TextBox();
            this.txtRUsuario = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedWizardPage2 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.advancedWizardPage1 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.btnProbar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.advancedWizard1.SuspendLayout();
            this.advancedWizardPage3.SuspendLayout();
            this.advancedWizardPage2.SuspendLayout();
            this.advancedWizardPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedWizard1
            // 
            this.advancedWizard1.BackButtonEnabled = true;
            this.advancedWizard1.BackButtonText = "< Back";
            this.advancedWizard1.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.advancedWizard1.ButtonsVisible = true;
            this.advancedWizard1.CancelButtonText = "&Cancel";
            this.advancedWizard1.Controls.Add(this.advancedWizardPage3);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage2);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage1);
            this.advancedWizard1.CurrentPageIsFinishPage = false;
            this.advancedWizard1.FinishButton = true;
            this.advancedWizard1.FinishButtonEnabled = true;
            this.advancedWizard1.FinishButtonText = "&Finish";
            this.advancedWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.advancedWizard1.HelpButton = true;
            this.advancedWizard1.HelpButtonText = "&Help";
            this.advancedWizard1.Location = new System.Drawing.Point(12, 12);
            this.advancedWizard1.Name = "advancedWizard1";
            this.advancedWizard1.NextButtonEnabled = false;
            this.advancedWizard1.NextButtonText = "Next >";
            this.advancedWizard1.ProcessKeys = false;
            this.advancedWizard1.Size = new System.Drawing.Size(719, 361);
            this.advancedWizard1.TabIndex = 0;
            this.advancedWizard1.TouchScreen = false;
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage1);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage2);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage3);
            this.advancedWizard1.Next += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardEventArgs>(this.advancedWizard1_Next);
            this.advancedWizard1.Finish += new System.EventHandler(this.advancedWizard1_Finish);
            // 
            // advancedWizardPage3
            // 
            this.advancedWizardPage3.Controls.Add(this.txtResultado);
            this.advancedWizardPage3.Controls.Add(this.txtRTipo);
            this.advancedWizardPage3.Controls.Add(this.txtRUbicacion);
            this.advancedWizardPage3.Controls.Add(this.txtRDir);
            this.advancedWizardPage3.Controls.Add(this.txtRUsuario);
            this.advancedWizardPage3.Controls.Add(this.lblResultado);
            this.advancedWizardPage3.Controls.Add(this.label9);
            this.advancedWizardPage3.Controls.Add(this.label8);
            this.advancedWizardPage3.Controls.Add(this.label7);
            this.advancedWizardPage3.Controls.Add(this.label6);
            this.advancedWizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage3.Header = true;
            this.advancedWizardPage3.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage3.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage3.HeaderImage")));
            this.advancedWizardPage3.HeaderImageVisible = true;
            this.advancedWizardPage3.HeaderTitle = "Confirmando Datos";
            this.advancedWizardPage3.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage3.Name = "advancedWizardPage3";
            this.advancedWizardPage3.PreviousPage = 1;
            this.advancedWizardPage3.Size = new System.Drawing.Size(719, 321);
            this.advancedWizardPage3.SubTitle = "Verifique los datos antes de continuar con Finalizar";
            this.advancedWizardPage3.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage3.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(272, 255);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(339, 22);
            this.txtResultado.TabIndex = 10;
            // 
            // txtRTipo
            // 
            this.txtRTipo.Enabled = false;
            this.txtRTipo.Location = new System.Drawing.Point(272, 218);
            this.txtRTipo.Name = "txtRTipo";
            this.txtRTipo.Size = new System.Drawing.Size(339, 22);
            this.txtRTipo.TabIndex = 9;
            // 
            // txtRUbicacion
            // 
            this.txtRUbicacion.Enabled = false;
            this.txtRUbicacion.Location = new System.Drawing.Point(272, 180);
            this.txtRUbicacion.Name = "txtRUbicacion";
            this.txtRUbicacion.Size = new System.Drawing.Size(339, 22);
            this.txtRUbicacion.TabIndex = 8;
            // 
            // txtRDir
            // 
            this.txtRDir.Enabled = false;
            this.txtRDir.Location = new System.Drawing.Point(272, 136);
            this.txtRDir.Name = "txtRDir";
            this.txtRDir.Size = new System.Drawing.Size(339, 22);
            this.txtRDir.TabIndex = 7;
            // 
            // txtRUsuario
            // 
            this.txtRUsuario.Enabled = false;
            this.txtRUsuario.Location = new System.Drawing.Point(272, 94);
            this.txtRUsuario.Name = "txtRUsuario";
            this.txtRUsuario.Size = new System.Drawing.Size(339, 22);
            this.txtRUsuario.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(79, 258);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tipo de Respaldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ubicacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre de directorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usuario";
            // 
            // advancedWizardPage2
            // 
            this.advancedWizardPage2.Controls.Add(this.label5);
            this.advancedWizardPage2.Controls.Add(this.comboBox2);
            this.advancedWizardPage2.Controls.Add(this.label4);
            this.advancedWizardPage2.Controls.Add(this.comboBox1);
            this.advancedWizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage2.Header = true;
            this.advancedWizardPage2.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage2.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage2.HeaderImage")));
            this.advancedWizardPage2.HeaderImageVisible = true;
            this.advancedWizardPage2.HeaderTitle = "Tipo de Respaldo";
            this.advancedWizardPage2.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage2.Name = "advancedWizardPage2";
            this.advancedWizardPage2.PreviousPage = 0;
            this.advancedWizardPage2.Size = new System.Drawing.Size(719, 321);
            this.advancedWizardPage2.SubTitle = "";
            this.advancedWizardPage2.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage2.TabIndex = 2;
            this.advancedWizardPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.advancedWizardPage2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(293, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Respaldo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Completo",
            "Esquema",
            "Tabla especifica"});
            this.comboBox1.Location = new System.Drawing.Point(293, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // advancedWizardPage1
            // 
            this.advancedWizardPage1.Controls.Add(this.btnProbar);
            this.advancedWizardPage1.Controls.Add(this.label3);
            this.advancedWizardPage1.Controls.Add(this.label2);
            this.advancedWizardPage1.Controls.Add(this.label1);
            this.advancedWizardPage1.Controls.Add(this.button1);
            this.advancedWizardPage1.Controls.Add(this.txtNombre);
            this.advancedWizardPage1.Controls.Add(this.txtPassword);
            this.advancedWizardPage1.Controls.Add(this.txtUsuario);
            this.advancedWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage1.Header = true;
            this.advancedWizardPage1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage1.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage1.HeaderImage")));
            this.advancedWizardPage1.HeaderImageVisible = true;
            this.advancedWizardPage1.HeaderTitle = "Creacion de directory";
            this.advancedWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage1.Name = "advancedWizardPage1";
            this.advancedWizardPage1.PreviousPage = 0;
            this.advancedWizardPage1.Size = new System.Drawing.Size(719, 321);
            this.advancedWizardPage1.SubTitle = "";
            this.advancedWizardPage1.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage1.TabIndex = 1;
            this.advancedWizardPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.advancedWizardPage1_Paint);
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(435, 123);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(153, 54);
            this.btnProbar.TabIndex = 8;
            this.btnProbar.Text = "Probar conexion";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de directorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ubicacion del Directorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(272, 176);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(272, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(272, 95);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // frmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 385);
            this.Controls.Add(this.advancedWizard1);
            this.Name = "frmRespaldo";
            this.Text = "frmRespaldo";
            this.Load += new System.EventHandler(this.frmRespaldo_Load);
            this.advancedWizard1.ResumeLayout(false);
            this.advancedWizardPage3.ResumeLayout(false);
            this.advancedWizardPage3.PerformLayout();
            this.advancedWizardPage2.ResumeLayout(false);
            this.advancedWizardPage2.PerformLayout();
            this.advancedWizardPage1.ResumeLayout(false);
            this.advancedWizardPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard advancedWizard1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtRTipo;
        private System.Windows.Forms.TextBox txtRUbicacion;
        private System.Windows.Forms.TextBox txtRDir;
        private System.Windows.Forms.TextBox txtRUsuario;
    }
}