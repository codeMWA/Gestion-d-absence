
namespace IstaForm.Principal.Controls
{
    partial class absenceControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idStagiaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jourAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jourJst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModfier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.nbrJours = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaDateTimePicker2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.joursJust = new Guna.UI.WinForms.GunaTextBox();
            this.just = new Guna.UI.WinForms.GunaTextBox();
            this.joursAbs = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.NomComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.label10 = new System.Windows.Forms.Label();
            this.PrenomComboBox = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherché par :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Groupe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStagiaire,
            this.jourAbs,
            this.dateAbsence,
            this.dateFin,
            this.justifi,
            this.jourJst,
            this.btnModfier,
            this.btnSupprimer});
            this.dataGridView1.Location = new System.Drawing.Point(4, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 211);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // idStagiaire
            // 
            this.idStagiaire.HeaderText = "id";
            this.idStagiaire.Name = "idStagiaire";
            this.idStagiaire.Width = 84;
            // 
            // jourAbs
            // 
            this.jourAbs.HeaderText = "Jours d\'absences";
            this.jourAbs.Name = "jourAbs";
            this.jourAbs.Width = 85;
            // 
            // dateAbsence
            // 
            this.dateAbsence.HeaderText = "Date debut";
            this.dateAbsence.Name = "dateAbsence";
            this.dateAbsence.Width = 84;
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Date fin";
            this.dateFin.Name = "dateFin";
            this.dateFin.Width = 84;
            // 
            // justifi
            // 
            this.justifi.HeaderText = "Justification ";
            this.justifi.Name = "justifi";
            this.justifi.Width = 84;
            // 
            // jourJst
            // 
            this.jourJst.HeaderText = "Jours justifiés ";
            this.jourJst.Name = "jourJst";
            // 
            // btnModfier
            // 
            this.btnModfier.HeaderText = "";
            this.btnModfier.Name = "btnModfier";
            this.btnModfier.Text = "Modifier";
            this.btnModfier.UseColumnTextForButtonValue = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "";
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total jours d\'absences :";
            // 
            // nbrJours
            // 
            this.nbrJours.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nbrJours.AutoSize = true;
            this.nbrJours.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrJours.ForeColor = System.Drawing.Color.DarkBlue;
            this.nbrJours.Location = new System.Drawing.Point(733, 230);
            this.nbrJours.Name = "nbrJours";
            this.nbrJours.Size = new System.Drawing.Size(137, 39);
            this.nbrJours.TabIndex = 7;
            this.nbrJours.Text = "Nombre";
            this.nbrJours.Visible = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.gunaDateTimePicker2);
            this.gunaGroupBox1.Controls.Add(this.label9);
            this.gunaGroupBox1.Controls.Add(this.gunaDateTimePicker1);
            this.gunaGroupBox1.Controls.Add(this.label8);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.gunaButton2);
            this.gunaGroupBox1.Controls.Add(this.gunaButton1);
            this.gunaGroupBox1.Controls.Add(this.joursJust);
            this.gunaGroupBox1.Controls.Add(this.just);
            this.gunaGroupBox1.Controls.Add(this.joursAbs);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Navy;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 345);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(957, 242);
            this.gunaGroupBox1.TabIndex = 8;
            this.gunaGroupBox1.Text = "Gestion des absences";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaDateTimePicker2
            // 
            this.gunaDateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaDateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker2.BorderColor = System.Drawing.Color.Gray;
            this.gunaDateTimePicker2.CustomFormat = null;
            this.gunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gunaDateTimePicker2.Location = new System.Drawing.Point(624, 143);
            this.gunaDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker2.Name = "gunaDateTimePicker2";
            this.gunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Radius = 8;
            this.gunaDateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaDateTimePicker2.Size = new System.Drawing.Size(195, 31);
            this.gunaDateTimePicker2.TabIndex = 12;
            this.gunaDateTimePicker2.Text = "11/04/2022";
            this.gunaDateTimePicker2.Value = new System.DateTime(2022, 4, 11, 14, 42, 45, 445);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(515, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Date fin :";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Gray;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(140, 143);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 8;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(195, 31);
            this.gunaDateTimePicker1.TabIndex = 10;
            this.gunaDateTimePicker1.Text = "04/04/2022";
            this.gunaDateTimePicker1.Value = new System.DateTime(2022, 4, 4, 16, 55, 1, 129);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(706, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Jours justifiés :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(324, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Justification :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date debut :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jours d\'absences :";
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Gray;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(496, 199);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 8;
            this.gunaButton2.Size = new System.Drawing.Size(159, 30);
            this.gunaButton2.TabIndex = 5;
            this.gunaButton2.Text = "Modifier";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Gray;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(241, 199);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 8;
            this.gunaButton1.Size = new System.Drawing.Size(159, 30);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Ajouter";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // joursJust
            // 
            this.joursJust.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.joursJust.BackColor = System.Drawing.Color.Transparent;
            this.joursJust.BaseColor = System.Drawing.SystemColors.Control;
            this.joursJust.BorderColor = System.Drawing.Color.Gray;
            this.joursJust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.joursJust.FocusedBaseColor = System.Drawing.Color.White;
            this.joursJust.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.joursJust.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.joursJust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.joursJust.Location = new System.Drawing.Point(814, 74);
            this.joursJust.Name = "joursJust";
            this.joursJust.PasswordChar = '\0';
            this.joursJust.Radius = 8;
            this.joursJust.SelectedText = "";
            this.joursJust.Size = new System.Drawing.Size(103, 26);
            this.joursJust.TabIndex = 3;
            // 
            // just
            // 
            this.just.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.just.BackColor = System.Drawing.Color.Transparent;
            this.just.BaseColor = System.Drawing.SystemColors.Control;
            this.just.BorderColor = System.Drawing.Color.Gray;
            this.just.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.just.FocusedBaseColor = System.Drawing.Color.White;
            this.just.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.just.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.just.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.just.Location = new System.Drawing.Point(427, 74);
            this.just.Name = "just";
            this.just.PasswordChar = '\0';
            this.just.Radius = 8;
            this.just.SelectedText = "";
            this.just.Size = new System.Drawing.Size(210, 30);
            this.just.TabIndex = 2;
            // 
            // joursAbs
            // 
            this.joursAbs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.joursAbs.BackColor = System.Drawing.Color.Transparent;
            this.joursAbs.BaseColor = System.Drawing.SystemColors.Control;
            this.joursAbs.BorderColor = System.Drawing.Color.Gray;
            this.joursAbs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.joursAbs.FocusedBaseColor = System.Drawing.Color.White;
            this.joursAbs.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.joursAbs.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.joursAbs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.joursAbs.Location = new System.Drawing.Point(140, 74);
            this.joursAbs.Name = "joursAbs";
            this.joursAbs.PasswordChar = '\0';
            this.joursAbs.Radius = 8;
            this.joursAbs.SelectedText = "";
            this.joursAbs.Size = new System.Drawing.Size(103, 26);
            this.joursAbs.TabIndex = 1;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(146, 76);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 8;
            this.gunaComboBox1.Size = new System.Drawing.Size(170, 26);
            this.gunaComboBox1.TabIndex = 11;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged_1);
            // 
            // NomComboBox
            // 
            this.NomComboBox.BackColor = System.Drawing.Color.Transparent;
            this.NomComboBox.BaseColor = System.Drawing.SystemColors.Control;
            this.NomComboBox.BorderColor = System.Drawing.Color.Black;
            this.NomComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.NomComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NomComboBox.ForeColor = System.Drawing.Color.Black;
            this.NomComboBox.FormattingEnabled = true;
            this.NomComboBox.Location = new System.Drawing.Point(422, 77);
            this.NomComboBox.Name = "NomComboBox";
            this.NomComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NomComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.NomComboBox.Radius = 8;
            this.NomComboBox.Size = new System.Drawing.Size(170, 26);
            this.NomComboBox.TabIndex = 12;
            this.NomComboBox.SelectedIndexChanged += new System.EventHandler(this.NomComboBox_SelectedIndexChanged);
            // 
            // gunaButton3
            // 
            this.gunaButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton3.Animated = true;
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::IstaForm.Properties.Resources._5919711c2d2accce1615685b7b5128cc;
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(55, 55);
            this.gunaButton3.Location = new System.Drawing.Point(910, 0);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = global::IstaForm.Properties.Resources._5919711c2d2accce1615685b7b5128cc;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 6;
            this.gunaButton3.Size = new System.Drawing.Size(47, 46);
            this.gunaButton3.TabIndex = 13;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(654, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Prenom :";
            // 
            // PrenomComboBox
            // 
            this.PrenomComboBox.BackColor = System.Drawing.Color.Transparent;
            this.PrenomComboBox.BaseColor = System.Drawing.SystemColors.Control;
            this.PrenomComboBox.BorderColor = System.Drawing.Color.Black;
            this.PrenomComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PrenomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrenomComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.PrenomComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PrenomComboBox.ForeColor = System.Drawing.Color.Black;
            this.PrenomComboBox.FormattingEnabled = true;
            this.PrenomComboBox.Location = new System.Drawing.Point(732, 76);
            this.PrenomComboBox.Name = "PrenomComboBox";
            this.PrenomComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PrenomComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.PrenomComboBox.Radius = 8;
            this.PrenomComboBox.Size = new System.Drawing.Size(170, 26);
            this.PrenomComboBox.TabIndex = 15;
            this.PrenomComboBox.SelectedIndexChanged += new System.EventHandler(this.PrenomComboBox_SelectedIndexChanged);
            // 
            // absenceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrenomComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.NomComboBox);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.nbrJours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "absenceControl";
            this.Size = new System.Drawing.Size(957, 587);
            this.Load += new System.EventHandler(this.absenceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nbrJours;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox joursJust;
        private Guna.UI.WinForms.GunaTextBox just;
        private Guna.UI.WinForms.GunaTextBox joursAbs;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaComboBox NomComboBox;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStagiaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn jourAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn justifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn jourJst;
        private System.Windows.Forms.DataGridViewButtonColumn btnModfier;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox PrenomComboBox;
    }
}
