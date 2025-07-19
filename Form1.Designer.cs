namespace C_Cadastro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldatanascimento = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.mskdatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.mskrg = new System.Windows.Forms.MaskedTextBox();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblsituação = new System.Windows.Forms.Label();
            this.rdboutros = new System.Windows.Forms.RadioButton();
            this.gpbgenero = new System.Windows.Forms.GroupBox();
            this.cbbestado = new System.Windows.Forms.ComboBox();
            this.cbbestadocivil = new System.Windows.Forms.ComboBox();
            this.btnimagem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbgenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(177, 40);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(63, 20);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(301, 40);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(45, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(181, 63);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(80, 22);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TabStop = false;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(305, 63);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(334, 22);
            this.txtnome.TabIndex = 2;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(177, 176);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(27, 20);
            this.lblrg.TabIndex = 5;
            this.lblrg.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estado Civil";
            // 
            // lbldatanascimento
            // 
            this.lbldatanascimento.AutoSize = true;
            this.lbldatanascimento.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatanascimento.Location = new System.Drawing.Point(397, 177);
            this.lbldatanascimento.Name = "lbldatanascimento";
            this.lbldatanascimento.Size = new System.Drawing.Size(144, 20);
            this.lbldatanascimento.TabIndex = 7;
            this.lbldatanascimento.Text = "Data Nascimento";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(23, 244);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(36, 20);
            this.lblcep.TabIndex = 8;
            this.lblcep.Text = "CEP";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(177, 244);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(81, 20);
            this.lblendereco.TabIndex = 9;
            this.lblendereco.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(172, 283);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(526, 22);
            this.txtendereco.TabIndex = 8;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(721, 283);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(63, 20);
            this.lblnumero.TabIndex = 11;
            this.lblnumero.Text = "Numero";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(23, 317);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(63, 20);
            this.lblbairro.TabIndex = 12;
            this.lblbairro.Text = "Bairro";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(177, 317);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(63, 20);
            this.lblcidade.TabIndex = 13;
            this.lblcidade.Text = "Cidade";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(25, 354);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(123, 22);
            this.txtbairro.TabIndex = 10;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(172, 354);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(165, 22);
            this.txtcidade.TabIndex = 11;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(368, 317);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(63, 20);
            this.lblestado.TabIndex = 16;
            this.lblestado.Text = "Estado";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(564, 317);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 20);
            this.lblemail.TabIndex = 17;
            this.lblemail.Text = "Email";
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(25, 283);
            this.mskcep.Mask = "00000-000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(112, 22);
            this.mskcep.TabIndex = 7;
            // 
            // mskdatanascimento
            // 
            this.mskdatanascimento.Location = new System.Drawing.Point(568, 174);
            this.mskdatanascimento.Mask = "00/00/0000";
            this.mskdatanascimento.Name = "mskdatanascimento";
            this.mskdatanascimento.Size = new System.Drawing.Size(116, 22);
            this.mskdatanascimento.TabIndex = 6;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(790, 283);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 22);
            this.txtnumero.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(568, 354);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(311, 22);
            this.txtemail.TabIndex = 13;
            // 
            // mskrg
            // 
            this.mskrg.Location = new System.Drawing.Point(218, 174);
            this.mskrg.Mask = "00000000-0";
            this.mskrg.Name = "mskrg";
            this.mskrg.Size = new System.Drawing.Size(119, 22);
            this.mskrg.TabIndex = 5;
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(25, 533);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(184, 52);
            this.btnfechar.TabIndex = 23;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(258, 533);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(184, 52);
            this.btnsalvar.TabIndex = 24;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(484, 533);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(184, 52);
            this.btnlimpar.TabIndex = 25;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.BackColor = System.Drawing.Color.White;
            this.rdbmasculino.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmasculino.Location = new System.Drawing.Point(6, 21);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(144, 24);
            this.rdbmasculino.TabIndex = 27;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rdbmasculino.UseVisualStyleBackColor = false;
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.BackColor = System.Drawing.Color.White;
            this.rdbfeminino.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfeminino.Location = new System.Drawing.Point(178, 21);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(102, 24);
            this.rdbfeminino.TabIndex = 28;
            this.rdbfeminino.TabStop = true;
            this.rdbfeminino.Text = "Feminino";
            this.rdbfeminino.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Celular";
            // 
            // mskcelular
            // 
            this.mskcelular.Location = new System.Drawing.Point(27, 429);
            this.mskcelular.Mask = "00-00000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(134, 22);
            this.mskcelular.TabIndex = 14;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(177, 118);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(36, 20);
            this.lblcpf.TabIndex = 32;
            this.lblcpf.Text = "CPF";
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(218, 118);
            this.mskcpf.Mask = "000000000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(156, 22);
            this.mskcpf.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(136, 477);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 24);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblsituação
            // 
            this.lblsituação.AutoSize = true;
            this.lblsituação.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituação.Location = new System.Drawing.Point(23, 478);
            this.lblsituação.Name = "lblsituação";
            this.lblsituação.Size = new System.Drawing.Size(81, 20);
            this.lblsituação.TabIndex = 35;
            this.lblsituação.Text = "Situação";
            // 
            // rdboutros
            // 
            this.rdboutros.AutoSize = true;
            this.rdboutros.BackColor = System.Drawing.Color.White;
            this.rdboutros.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdboutros.Location = new System.Drawing.Point(312, 21);
            this.rdboutros.Name = "rdboutros";
            this.rdboutros.Size = new System.Drawing.Size(84, 24);
            this.rdboutros.TabIndex = 38;
            this.rdboutros.TabStop = true;
            this.rdboutros.Text = "Outros";
            this.rdboutros.UseVisualStyleBackColor = false;
            // 
            // gpbgenero
            // 
            this.gpbgenero.Controls.Add(this.rdbmasculino);
            this.gpbgenero.Controls.Add(this.rdboutros);
            this.gpbgenero.Controls.Add(this.rdbfeminino);
            this.gpbgenero.Location = new System.Drawing.Point(645, 40);
            this.gpbgenero.Name = "gpbgenero";
            this.gpbgenero.Size = new System.Drawing.Size(408, 72);
            this.gpbgenero.TabIndex = 39;
            this.gpbgenero.TabStop = false;
            this.gpbgenero.Text = "Genero";
            // 
            // cbbestado
            // 
            this.cbbestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbestado.DropDownHeight = 210;
            this.cbbestado.FormattingEnabled = true;
            this.cbbestado.IntegralHeight = false;
            this.cbbestado.Items.AddRange(new object[] {
            "",
            "Acre\tAC",
            "Alagoas\tAL",
            "Amapá\tAP",
            "Amazonas AM",
            "Bahia\tBA",
            "Ceará\tCE",
            "Distrito Federal\tDF",
            "Espírito Santo\tES",
            "Goiás\tGO",
            "Maranhão\tMA",
            "Mato Grosso do Sul\tMS",
            "Mato Grosso\tMT",
            "Minas Gerais\tMG",
            "Pará\tPA",
            "Paraíba\tPB",
            "Paraná\tPR",
            "Pernambuco\tPE",
            "Piauí\tPI",
            "Rio de Janeiro\tRJ",
            "Rio Grande do Norte\tRN",
            "Rio Grande do Sul\tRS",
            "Rondônia\tRO",
            "Roraima\tRR",
            "Santa Catarina\tSC",
            "São Paulo\tSP",
            "Sergipe\tSE",
            "Tocantins\tTO"});
            this.cbbestado.Location = new System.Drawing.Point(372, 352);
            this.cbbestado.Name = "cbbestado";
            this.cbbestado.Size = new System.Drawing.Size(152, 24);
            this.cbbestado.Sorted = true;
            this.cbbestado.TabIndex = 12;
            // 
            // cbbestadocivil
            // 
            this.cbbestadocivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbestadocivil.FormattingEnabled = true;
            this.cbbestadocivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.cbbestadocivil.Location = new System.Drawing.Point(560, 120);
            this.cbbestadocivil.Name = "cbbestadocivil";
            this.cbbestadocivil.Size = new System.Drawing.Size(138, 24);
            this.cbbestadocivil.TabIndex = 4;
            // 
            // btnimagem
            // 
            this.btnimagem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnimagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimagem.Location = new System.Drawing.Point(12, 174);
            this.btnimagem.Name = "btnimagem";
            this.btnimagem.Size = new System.Drawing.Size(92, 29);
            this.btnimagem.TabIndex = 40;
            this.btnimagem.Text = "Imagem";
            this.btnimagem.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(110, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 41;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1325, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnimagem);
            this.Controls.Add(this.cbbestadocivil);
            this.Controls.Add(this.cbbestado);
            this.Controls.Add(this.gpbgenero);
            this.Controls.Add(this.lblsituação);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.mskcelular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.mskrg);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.mskdatanascimento);
            this.Controls.Add(this.mskcep);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lbldatanascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblcodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbgenero.ResumeLayout(false);
            this.gpbgenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldatanascimento;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.MaskedTextBox mskdatanascimento;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox mskrg;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskcelular;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblsituação;
        private System.Windows.Forms.RadioButton rdboutros;
        private System.Windows.Forms.GroupBox gpbgenero;
        private System.Windows.Forms.ComboBox cbbestado;
        private System.Windows.Forms.ComboBox cbbestadocivil;
        private System.Windows.Forms.Button btnimagem;
        private System.Windows.Forms.Button button1;
    }
}

