namespace hippodrome
{
    partial class Fgeneral
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
            this.tabCourse = new System.Windows.Forms.TabPage();
            this.totalDistance = new System.Windows.Forms.TextBox();
            this.gbDetailCourse = new System.Windows.Forms.GroupBox();
            this.btSupprimerCourse = new System.Windows.Forms.Button();
            this.btModifierCourse = new System.Windows.Forms.Button();
            this.btAjoutCourse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbHippodrome = new System.Windows.Forms.TextBox();
            this.tbIdCourse = new System.Windows.Forms.TextBox();
            this.dgCourses = new System.Windows.Forms.DataGridView();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabCheval = new System.Windows.Forms.TabPage();
            this.IdCheval = new System.Windows.Forms.GroupBox();
            this.NbGains = new System.Windows.Forms.Label();
            this.NbGainsTxt = new System.Windows.Forms.TextBox();
            this.NomProprio = new System.Windows.Forms.Label();
            this.NomProprioTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NomChe = new System.Windows.Forms.Label();
            this.DateNais = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SexeTxt = new System.Windows.Forms.TextBox();
            this.DateNaisTxt = new System.Windows.Forms.TextBox();
            this.NomChevalTxt = new System.Windows.Forms.TextBox();
            this.IdChevalTxt = new System.Windows.Forms.TextBox();
            this.dgChevaux = new System.Windows.Forms.DataGridView();
            this.Participants = new System.Windows.Forms.TabPage();
            this.totalParticipants = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IdLaPlaceTxt = new System.Windows.Forms.TextBox();
            this.IdLeDriverTxt = new System.Windows.Forms.TextBox();
            this.IdLaCourse = new System.Windows.Forms.TextBox();
            this.IdLeChevalTxt = new System.Windows.Forms.TextBox();
            this.dgParticipants = new System.Windows.Forms.DataGridView();
            this.Hippodromes = new System.Windows.Forms.TabPage();
            this.dgHippodromes = new System.Windows.Forms.DataGridView();
            this.tabNomsChevaux = new System.Windows.Forms.TabPage();
            this.dgNomsChevaux = new System.Windows.Forms.DataGridView();
            this.tabResultats = new System.Windows.Forms.TabPage();
            this.cbChoixCourse = new System.Windows.Forms.ComboBox();
            this.btnResultat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.IdRecherche = new System.Windows.Forms.TextBox();
            this.dgResultats = new System.Windows.Forms.DataGridView();
            this.tabCourse.SuspendLayout();
            this.gbDetailCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabCheval.SuspendLayout();
            this.IdCheval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChevaux)).BeginInit();
            this.Participants.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParticipants)).BeginInit();
            this.Hippodromes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHippodromes)).BeginInit();
            this.tabNomsChevaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNomsChevaux)).BeginInit();
            this.tabResultats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.totalDistance);
            this.tabCourse.Controls.Add(this.gbDetailCourse);
            this.tabCourse.Controls.Add(this.dgCourses);
            this.tabCourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCourse.Location = new System.Drawing.Point(4, 28);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourse.Size = new System.Drawing.Size(1043, 472);
            this.tabCourse.TabIndex = 1;
            this.tabCourse.Text = "Les courses";
            this.tabCourse.UseVisualStyleBackColor = true;
            this.tabCourse.Enter += new System.EventHandler(this.tabCourse_Enter);
            // 
            // totalDistance
            // 
            this.totalDistance.Location = new System.Drawing.Point(470, 399);
            this.totalDistance.Name = "totalDistance";
            this.totalDistance.Size = new System.Drawing.Size(108, 27);
            this.totalDistance.TabIndex = 2;
            // 
            // gbDetailCourse
            // 
            this.gbDetailCourse.Controls.Add(this.btSupprimerCourse);
            this.gbDetailCourse.Controls.Add(this.btModifierCourse);
            this.gbDetailCourse.Controls.Add(this.btAjoutCourse);
            this.gbDetailCourse.Controls.Add(this.label8);
            this.gbDetailCourse.Controls.Add(this.label7);
            this.gbDetailCourse.Controls.Add(this.label6);
            this.gbDetailCourse.Controls.Add(this.label5);
            this.gbDetailCourse.Controls.Add(this.tbDistance);
            this.gbDetailCourse.Controls.Add(this.tbDate);
            this.gbDetailCourse.Controls.Add(this.tbHippodrome);
            this.gbDetailCourse.Controls.Add(this.tbIdCourse);
            this.gbDetailCourse.Location = new System.Drawing.Point(606, 50);
            this.gbDetailCourse.Name = "gbDetailCourse";
            this.gbDetailCourse.Size = new System.Drawing.Size(313, 343);
            this.gbDetailCourse.TabIndex = 1;
            this.gbDetailCourse.TabStop = false;
            this.gbDetailCourse.Text = "Détail course";
            // 
            // btSupprimerCourse
            // 
            this.btSupprimerCourse.Location = new System.Drawing.Point(217, 274);
            this.btSupprimerCourse.Name = "btSupprimerCourse";
            this.btSupprimerCourse.Size = new System.Drawing.Size(96, 39);
            this.btSupprimerCourse.TabIndex = 10;
            this.btSupprimerCourse.Text = "&Supprimer";
            this.btSupprimerCourse.UseVisualStyleBackColor = true;
            // 
            // btModifierCourse
            // 
            this.btModifierCourse.Location = new System.Drawing.Point(113, 274);
            this.btModifierCourse.Name = "btModifierCourse";
            this.btModifierCourse.Size = new System.Drawing.Size(92, 38);
            this.btModifierCourse.TabIndex = 9;
            this.btModifierCourse.Text = "Modifier";
            this.btModifierCourse.UseVisualStyleBackColor = true;
            this.btModifierCourse.Click += new System.EventHandler(this.btModifierCourse_Click);
            // 
            // btAjoutCourse
            // 
            this.btAjoutCourse.Location = new System.Drawing.Point(11, 274);
            this.btAjoutCourse.Name = "btAjoutCourse";
            this.btAjoutCourse.Size = new System.Drawing.Size(96, 39);
            this.btAjoutCourse.TabIndex = 8;
            this.btAjoutCourse.Text = "&Ajouter";
            this.btAjoutCourse.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hippodrome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "id course";
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(121, 204);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(108, 27);
            this.tbDistance.TabIndex = 3;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(121, 149);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(108, 27);
            this.tbDate.TabIndex = 2;
            // 
            // tbHippodrome
            // 
            this.tbHippodrome.Location = new System.Drawing.Point(121, 91);
            this.tbHippodrome.Name = "tbHippodrome";
            this.tbHippodrome.Size = new System.Drawing.Size(108, 27);
            this.tbHippodrome.TabIndex = 1;
            // 
            // tbIdCourse
            // 
            this.tbIdCourse.Location = new System.Drawing.Point(121, 35);
            this.tbIdCourse.Name = "tbIdCourse";
            this.tbIdCourse.Size = new System.Drawing.Size(108, 27);
            this.tbIdCourse.TabIndex = 0;
            // 
            // dgCourses
            // 
            this.dgCourses.AllowUserToAddRows = false;
            this.dgCourses.AllowUserToDeleteRows = false;
            this.dgCourses.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourses.Location = new System.Drawing.Point(30, 48);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.ReadOnly = true;
            this.dgCourses.Size = new System.Drawing.Size(548, 345);
            this.dgCourses.TabIndex = 0;
            this.dgCourses.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourses_RowEnter);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabCheval);
            this.tabGeneral.Controls.Add(this.tabCourse);
            this.tabGeneral.Controls.Add(this.Participants);
            this.tabGeneral.Controls.Add(this.Hippodromes);
            this.tabGeneral.Controls.Add(this.tabNomsChevaux);
            this.tabGeneral.Controls.Add(this.tabResultats);
            this.tabGeneral.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeneral.Location = new System.Drawing.Point(4, 5);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1051, 504);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Enter += new System.EventHandler(this.tabGeneral_Enter);
            // 
            // tabCheval
            // 
            this.tabCheval.Controls.Add(this.IdCheval);
            this.tabCheval.Controls.Add(this.dgChevaux);
            this.tabCheval.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCheval.Location = new System.Drawing.Point(4, 28);
            this.tabCheval.Name = "tabCheval";
            this.tabCheval.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheval.Size = new System.Drawing.Size(1043, 472);
            this.tabCheval.TabIndex = 0;
            this.tabCheval.Text = "Les chevaux";
            this.tabCheval.UseVisualStyleBackColor = true;
            this.tabCheval.Enter += new System.EventHandler(this.tabCheval_Enter);
            // 
            // IdCheval
            // 
            this.IdCheval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IdCheval.Controls.Add(this.NbGains);
            this.IdCheval.Controls.Add(this.NbGainsTxt);
            this.IdCheval.Controls.Add(this.NomProprio);
            this.IdCheval.Controls.Add(this.NomProprioTxt);
            this.IdCheval.Controls.Add(this.button1);
            this.IdCheval.Controls.Add(this.button2);
            this.IdCheval.Controls.Add(this.button3);
            this.IdCheval.Controls.Add(this.NomChe);
            this.IdCheval.Controls.Add(this.DateNais);
            this.IdCheval.Controls.Add(this.Sexe);
            this.IdCheval.Controls.Add(this.label4);
            this.IdCheval.Controls.Add(this.SexeTxt);
            this.IdCheval.Controls.Add(this.DateNaisTxt);
            this.IdCheval.Controls.Add(this.NomChevalTxt);
            this.IdCheval.Controls.Add(this.IdChevalTxt);
            this.IdCheval.Location = new System.Drawing.Point(653, 66);
            this.IdCheval.Name = "IdCheval";
            this.IdCheval.Size = new System.Drawing.Size(313, 343);
            this.IdCheval.TabIndex = 3;
            this.IdCheval.TabStop = false;
            this.IdCheval.Text = "Détail course";
            // 
            // NbGains
            // 
            this.NbGains.AutoSize = true;
            this.NbGains.Location = new System.Drawing.Point(19, 202);
            this.NbGains.Name = "NbGains";
            this.NbGains.Size = new System.Drawing.Size(101, 19);
            this.NbGains.TabIndex = 14;
            this.NbGains.Text = "Nombre Gains";
            // 
            // NbGainsTxt
            // 
            this.NbGainsTxt.Location = new System.Drawing.Point(147, 202);
            this.NbGainsTxt.Name = "NbGainsTxt";
            this.NbGainsTxt.Size = new System.Drawing.Size(108, 27);
            this.NbGainsTxt.TabIndex = 13;
            // 
            // NomProprio
            // 
            this.NomProprio.AutoSize = true;
            this.NomProprio.Location = new System.Drawing.Point(19, 169);
            this.NomProprio.Name = "NomProprio";
            this.NomProprio.Size = new System.Drawing.Size(89, 19);
            this.NomProprio.TabIndex = 12;
            this.NomProprio.Text = "Nom Proprio";
            // 
            // NomProprioTxt
            // 
            this.NomProprioTxt.Location = new System.Drawing.Point(147, 169);
            this.NomProprioTxt.Name = "NomProprioTxt";
            this.NomProprioTxt.Size = new System.Drawing.Size(108, 27);
            this.NomProprioTxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "&Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NomChe
            // 
            this.NomChe.AutoSize = true;
            this.NomChe.Location = new System.Drawing.Point(19, 68);
            this.NomChe.Name = "NomChe";
            this.NomChe.Size = new System.Drawing.Size(87, 19);
            this.NomChe.TabIndex = 7;
            this.NomChe.Text = "Nom Cheval";
            // 
            // DateNais
            // 
            this.DateNais.AutoSize = true;
            this.DateNais.Location = new System.Drawing.Point(19, 103);
            this.DateNais.Name = "DateNais";
            this.DateNais.Size = new System.Drawing.Size(111, 19);
            this.DateNais.TabIndex = 6;
            this.DateNais.Text = "Date Naissance";
            // 
            // Sexe
            // 
            this.Sexe.AutoSize = true;
            this.Sexe.Location = new System.Drawing.Point(19, 136);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(39, 19);
            this.Sexe.TabIndex = 5;
            this.Sexe.Text = "Sexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "IdCheval";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SexeTxt
            // 
            this.SexeTxt.Location = new System.Drawing.Point(147, 136);
            this.SexeTxt.Name = "SexeTxt";
            this.SexeTxt.Size = new System.Drawing.Size(108, 27);
            this.SexeTxt.TabIndex = 3;
            // 
            // DateNaisTxt
            // 
            this.DateNaisTxt.Location = new System.Drawing.Point(147, 103);
            this.DateNaisTxt.Name = "DateNaisTxt";
            this.DateNaisTxt.Size = new System.Drawing.Size(108, 27);
            this.DateNaisTxt.TabIndex = 2;
            // 
            // NomChevalTxt
            // 
            this.NomChevalTxt.Location = new System.Drawing.Point(147, 70);
            this.NomChevalTxt.Name = "NomChevalTxt";
            this.NomChevalTxt.Size = new System.Drawing.Size(108, 27);
            this.NomChevalTxt.TabIndex = 1;
            // 
            // IdChevalTxt
            // 
            this.IdChevalTxt.Location = new System.Drawing.Point(147, 37);
            this.IdChevalTxt.Name = "IdChevalTxt";
            this.IdChevalTxt.Size = new System.Drawing.Size(108, 27);
            this.IdChevalTxt.TabIndex = 0;
            // 
            // dgChevaux
            // 
            this.dgChevaux.AllowUserToAddRows = false;
            this.dgChevaux.AllowUserToDeleteRows = false;
            this.dgChevaux.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgChevaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChevaux.Location = new System.Drawing.Point(77, 64);
            this.dgChevaux.Name = "dgChevaux";
            this.dgChevaux.ReadOnly = true;
            this.dgChevaux.Size = new System.Drawing.Size(548, 345);
            this.dgChevaux.TabIndex = 2;
            this.dgChevaux.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChevaux_RowEnter);
            // 
            // Participants
            // 
            this.Participants.Controls.Add(this.totalParticipants);
            this.Participants.Controls.Add(this.groupBox1);
            this.Participants.Controls.Add(this.dgParticipants);
            this.Participants.Location = new System.Drawing.Point(4, 28);
            this.Participants.Name = "Participants";
            this.Participants.Size = new System.Drawing.Size(1043, 472);
            this.Participants.TabIndex = 0;
            this.Participants.Text = "Participants";
            this.Participants.UseVisualStyleBackColor = true;
            this.Participants.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // totalParticipants
            // 
            this.totalParticipants.Location = new System.Drawing.Point(517, 415);
            this.totalParticipants.Name = "totalParticipants";
            this.totalParticipants.Size = new System.Drawing.Size(108, 27);
            this.totalParticipants.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IdLaPlaceTxt);
            this.groupBox1.Controls.Add(this.IdLeDriverTxt);
            this.groupBox1.Controls.Add(this.IdLaCourse);
            this.groupBox1.Controls.Add(this.IdLeChevalTxt);
            this.groupBox1.Location = new System.Drawing.Point(653, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 343);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail course";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "&Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(113, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Modifier";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 39);
            this.button6.TabIndex = 8;
            this.button6.Text = "&Ajouter";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Place";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Id Cheval";
            // 
            // IdLaPlaceTxt
            // 
            this.IdLaPlaceTxt.Location = new System.Drawing.Point(121, 204);
            this.IdLaPlaceTxt.Name = "IdLaPlaceTxt";
            this.IdLaPlaceTxt.Size = new System.Drawing.Size(108, 27);
            this.IdLaPlaceTxt.TabIndex = 3;
            // 
            // IdLeDriverTxt
            // 
            this.IdLeDriverTxt.Location = new System.Drawing.Point(121, 149);
            this.IdLeDriverTxt.Name = "IdLeDriverTxt";
            this.IdLeDriverTxt.Size = new System.Drawing.Size(108, 27);
            this.IdLeDriverTxt.TabIndex = 2;
            // 
            // IdLaCourse
            // 
            this.IdLaCourse.Location = new System.Drawing.Point(121, 91);
            this.IdLaCourse.Name = "IdLaCourse";
            this.IdLaCourse.Size = new System.Drawing.Size(108, 27);
            this.IdLaCourse.TabIndex = 1;
            // 
            // IdLeChevalTxt
            // 
            this.IdLeChevalTxt.Location = new System.Drawing.Point(121, 35);
            this.IdLeChevalTxt.Name = "IdLeChevalTxt";
            this.IdLeChevalTxt.Size = new System.Drawing.Size(108, 27);
            this.IdLeChevalTxt.TabIndex = 0;
            // 
            // dgParticipants
            // 
            this.dgParticipants.AllowUserToAddRows = false;
            this.dgParticipants.AllowUserToDeleteRows = false;
            this.dgParticipants.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParticipants.Location = new System.Drawing.Point(77, 64);
            this.dgParticipants.Name = "dgParticipants";
            this.dgParticipants.ReadOnly = true;
            this.dgParticipants.Size = new System.Drawing.Size(548, 345);
            this.dgParticipants.TabIndex = 2;
            this.dgParticipants.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgParticipants_RowEnter);
            // 
            // Hippodromes
            // 
            this.Hippodromes.Controls.Add(this.dgHippodromes);
            this.Hippodromes.Location = new System.Drawing.Point(4, 28);
            this.Hippodromes.Name = "Hippodromes";
            this.Hippodromes.Padding = new System.Windows.Forms.Padding(3);
            this.Hippodromes.Size = new System.Drawing.Size(1043, 472);
            this.Hippodromes.TabIndex = 2;
            this.Hippodromes.Text = "Hippodromes";
            this.Hippodromes.UseVisualStyleBackColor = true;
            this.Hippodromes.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dgHippodromes
            // 
            this.dgHippodromes.AllowUserToAddRows = false;
            this.dgHippodromes.AllowUserToDeleteRows = false;
            this.dgHippodromes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgHippodromes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHippodromes.Location = new System.Drawing.Point(247, 64);
            this.dgHippodromes.Name = "dgHippodromes";
            this.dgHippodromes.ReadOnly = true;
            this.dgHippodromes.Size = new System.Drawing.Size(548, 345);
            this.dgHippodromes.TabIndex = 3;
            // 
            // tabNomsChevaux
            // 
            this.tabNomsChevaux.Controls.Add(this.dgNomsChevaux);
            this.tabNomsChevaux.Location = new System.Drawing.Point(4, 28);
            this.tabNomsChevaux.Name = "tabNomsChevaux";
            this.tabNomsChevaux.Padding = new System.Windows.Forms.Padding(3);
            this.tabNomsChevaux.Size = new System.Drawing.Size(1043, 472);
            this.tabNomsChevaux.TabIndex = 3;
            this.tabNomsChevaux.Text = "Noms Chevaux";
            this.tabNomsChevaux.UseVisualStyleBackColor = true;
            this.tabNomsChevaux.Enter += new System.EventHandler(this.tabNomsChevaux_Enter);
            // 
            // dgNomsChevaux
            // 
            this.dgNomsChevaux.AllowUserToAddRows = false;
            this.dgNomsChevaux.AllowUserToDeleteRows = false;
            this.dgNomsChevaux.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgNomsChevaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNomsChevaux.Location = new System.Drawing.Point(247, 64);
            this.dgNomsChevaux.Name = "dgNomsChevaux";
            this.dgNomsChevaux.ReadOnly = true;
            this.dgNomsChevaux.Size = new System.Drawing.Size(548, 345);
            this.dgNomsChevaux.TabIndex = 4;
            // 
            // tabResultats
            // 
            this.tabResultats.Controls.Add(this.cbChoixCourse);
            this.tabResultats.Controls.Add(this.btnResultat);
            this.tabResultats.Controls.Add(this.label10);
            this.tabResultats.Controls.Add(this.IdRecherche);
            this.tabResultats.Controls.Add(this.dgResultats);
            this.tabResultats.Location = new System.Drawing.Point(4, 28);
            this.tabResultats.Name = "tabResultats";
            this.tabResultats.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultats.Size = new System.Drawing.Size(1043, 472);
            this.tabResultats.TabIndex = 4;
            this.tabResultats.Text = "Resultats";
            this.tabResultats.UseVisualStyleBackColor = true;
            // 
            // cbChoixCourse
            // 
            this.cbChoixCourse.FormattingEnabled = true;
            this.cbChoixCourse.Location = new System.Drawing.Point(903, 138);
            this.cbChoixCourse.Name = "cbChoixCourse";
            this.cbChoixCourse.Size = new System.Drawing.Size(121, 27);
            this.cbChoixCourse.TabIndex = 11;
            this.cbChoixCourse.SelectedIndexChanged += new System.EventHandler(this.cbChoixCourse_SelectedIndexChanged);
            this.cbChoixCourse.Enter += new System.EventHandler(this.cbChoixCourse_Enter);
            // 
            // btnResultat
            // 
            this.btnResultat.Location = new System.Drawing.Point(805, 230);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(96, 39);
            this.btnResultat.TabIndex = 10;
            this.btnResultat.Text = "Rechercher";
            this.btnResultat.UseVisualStyleBackColor = true;
            this.btnResultat.Click += new System.EventHandler(this.btnResultat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(801, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Id Course";
            // 
            // IdRecherche
            // 
            this.IdRecherche.Location = new System.Drawing.Point(903, 197);
            this.IdRecherche.Name = "IdRecherche";
            this.IdRecherche.Size = new System.Drawing.Size(108, 27);
            this.IdRecherche.TabIndex = 8;
            // 
            // dgResultats
            // 
            this.dgResultats.AllowUserToAddRows = false;
            this.dgResultats.AllowUserToDeleteRows = false;
            this.dgResultats.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultats.Location = new System.Drawing.Point(247, 64);
            this.dgResultats.Name = "dgResultats";
            this.dgResultats.ReadOnly = true;
            this.dgResultats.Size = new System.Drawing.Size(548, 345);
            this.dgResultats.TabIndex = 5;
            // 
            // Fgeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 511);
            this.Controls.Add(this.tabGeneral);
            this.Name = "Fgeneral";
            this.Text = "Fgeneral";
            this.Load += new System.EventHandler(this.Fgeneral_Load);
            this.tabCourse.ResumeLayout(false);
            this.tabCourse.PerformLayout();
            this.gbDetailCourse.ResumeLayout(false);
            this.gbDetailCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.tabCheval.ResumeLayout(false);
            this.IdCheval.ResumeLayout(false);
            this.IdCheval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChevaux)).EndInit();
            this.Participants.ResumeLayout(false);
            this.Participants.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParticipants)).EndInit();
            this.Hippodromes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHippodromes)).EndInit();
            this.tabNomsChevaux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNomsChevaux)).EndInit();
            this.tabResultats.ResumeLayout(false);
            this.tabResultats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCourse;
        private System.Windows.Forms.GroupBox gbDetailCourse;
        private System.Windows.Forms.Button btSupprimerCourse;
        private System.Windows.Forms.Button btModifierCourse;
        private System.Windows.Forms.Button btAjoutCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbHippodrome;
        private System.Windows.Forms.TextBox tbIdCourse;
        private System.Windows.Forms.DataGridView dgCourses;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabCheval;
        private System.Windows.Forms.GroupBox IdCheval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label NomChe;
        private System.Windows.Forms.Label DateNais;
        private System.Windows.Forms.Label Sexe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SexeTxt;
        private System.Windows.Forms.TextBox DateNaisTxt;
        private System.Windows.Forms.TextBox NomChevalTxt;
        private System.Windows.Forms.TextBox IdChevalTxt;
        private System.Windows.Forms.DataGridView dgChevaux;
        private System.Windows.Forms.Label NbGains;
        private System.Windows.Forms.TextBox NbGainsTxt;
        private System.Windows.Forms.Label NomProprio;
        private System.Windows.Forms.TextBox NomProprioTxt;
        private System.Windows.Forms.TabPage Participants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IdLaPlaceTxt;
        private System.Windows.Forms.TextBox IdLeDriverTxt;
        private System.Windows.Forms.TextBox IdLaCourse;
        private System.Windows.Forms.TextBox IdLeChevalTxt;
        private System.Windows.Forms.DataGridView dgParticipants;
        private System.Windows.Forms.TabPage Hippodromes;
        private System.Windows.Forms.DataGridView dgHippodromes;
        private System.Windows.Forms.TabPage tabNomsChevaux;
        private System.Windows.Forms.DataGridView dgNomsChevaux;
        private System.Windows.Forms.TabPage tabResultats;
        private System.Windows.Forms.Button btnResultat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdRecherche;
        private System.Windows.Forms.DataGridView dgResultats;
        private System.Windows.Forms.ComboBox cbChoixCourse;
        private System.Windows.Forms.TextBox totalDistance;
        private System.Windows.Forms.TextBox totalParticipants;
    }
}