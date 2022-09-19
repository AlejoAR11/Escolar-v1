namespace Proyecto_v1
{
    partial class Admin
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
            this.gbDirectivos = new System.Windows.Forms.GroupBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgDirectivos = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.errorProviderValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDirectivos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDirectivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDirectivos
            // 
            this.gbDirectivos.Controls.Add(this.txtContact);
            this.gbDirectivos.Controls.Add(this.label6);
            this.gbDirectivos.Controls.Add(this.panel1);
            this.gbDirectivos.Controls.Add(this.dvgDirectivos);
            this.gbDirectivos.Controls.Add(this.btnSave);
            this.gbDirectivos.Controls.Add(this.btnMod);
            this.gbDirectivos.Controls.Add(this.btnDel);
            this.gbDirectivos.Controls.Add(this.btnAdd);
            this.gbDirectivos.Location = new System.Drawing.Point(12, 75);
            this.gbDirectivos.Name = "gbDirectivos";
            this.gbDirectivos.Size = new System.Drawing.Size(288, 435);
            this.gbDirectivos.TabIndex = 0;
            this.gbDirectivos.TabStop = false;
            this.gbDirectivos.Text = "Directivos";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(56, 123);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(176, 20);
            this.txtContact.TabIndex = 3;
            this.txtContact.Text = "contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 161);
            this.panel1.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(50, 116);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(176, 20);
            this.textBox11.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(50, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(176, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(50, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dvgDirectivos
            // 
            this.dvgDirectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDirectivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnId,
            this.ColumnPassword,
            this.ColumnContact});
            this.dvgDirectivos.Location = new System.Drawing.Point(6, 208);
            this.dvgDirectivos.Name = "dvgDirectivos";
            this.dvgDirectivos.Size = new System.Drawing.Size(267, 129);
            this.dvgDirectivos.TabIndex = 9;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nombre";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Documento";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Contraseña";
            this.ColumnPassword.Name = "ColumnPassword";
            // 
            // ColumnContact
            // 
            this.ColumnContact.HeaderText = "Contacto";
            this.ColumnContact.Name = "ColumnContact";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(184, 362);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(67, 29);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(18, 397);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(67, 29);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(18, 31);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(66, 13);
            this.lbAdmin.TabIndex = 6;
            this.lbAdmin.Text = "Binevenido: ";
            // 
            // errorProviderValidar
            // 
            this.errorProviderValidar.ContainerControl = this;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 531);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.gbDirectivos);
            this.Name = "Admin";
            this.Text = "Admin Page";
            this.gbDirectivos.ResumeLayout(false);
            this.gbDirectivos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDirectivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDirectivos;
        private System.Windows.Forms.DataGridView dvgDirectivos;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.ErrorProvider errorProviderValidar;
    }
}