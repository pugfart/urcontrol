namespace Control
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.connect_bt = new System.Windows.Forms.Button();
            this.IPaddress = new System.Windows.Forms.TextBox();
            this.disconnect_bt = new System.Windows.Forms.Button();
            this.J1plus = new System.Windows.Forms.Button();
            this.J1minus = new System.Windows.Forms.Button();
            this.J2plus = new System.Windows.Forms.Button();
            this.J2minus = new System.Windows.Forms.Button();
            this.J3plus = new System.Windows.Forms.Button();
            this.J3minus = new System.Windows.Forms.Button();
            this.J4plus = new System.Windows.Forms.Button();
            this.J4minus = new System.Windows.Forms.Button();
            this.J5plus = new System.Windows.Forms.Button();
            this.J5minus = new System.Windows.Forms.Button();
            this.J6plus = new System.Windows.Forms.Button();
            this.J6minus = new System.Windows.Forms.Button();
            this.Xplus = new System.Windows.Forms.Button();
            this.Xminus = new System.Windows.Forms.Button();
            this.Yplus = new System.Windows.Forms.Button();
            this.Yminus = new System.Windows.Forms.Button();
            this.Zplus = new System.Windows.Forms.Button();
            this.Zminus = new System.Windows.Forms.Button();
            this.RXplus = new System.Windows.Forms.Button();
            this.RXminus = new System.Windows.Forms.Button();
            this.RYplus = new System.Windows.Forms.Button();
            this.RYminus = new System.Windows.Forms.Button();
            this.RZplus = new System.Windows.Forms.Button();
            this.RZminus = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.TrackBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Movement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_thread = new System.Windows.Forms.Button();
            this.stop_thread = new System.Windows.Forms.Button();
            this.tbJ1 = new System.Windows.Forms.TextBox();
            this.tbJ6 = new System.Windows.Forms.TextBox();
            this.tbJ5 = new System.Windows.Forms.TextBox();
            this.tbJ4 = new System.Windows.Forms.TextBox();
            this.tbJ3 = new System.Windows.Forms.TextBox();
            this.tbJ2 = new System.Windows.Forms.TextBox();
            this.showjoints = new System.Windows.Forms.Label();
            this.showaxisposition = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbRx = new System.Windows.Forms.TextBox();
            this.tbRy = new System.Windows.Forms.TextBox();
            this.tbRz = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.MoveJ = new System.Windows.Forms.Button();
            this.MoveL = new System.Windows.Forms.Button();
            this.startthread = new System.Windows.Forms.Button();
            this.stopthread = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJ2Radian = new System.Windows.Forms.TextBox();
            this.tbJ3Radian = new System.Windows.Forms.TextBox();
            this.tbJ4Radian = new System.Windows.Forms.TextBox();
            this.tbJ5Radian = new System.Windows.Forms.TextBox();
            this.tbJ6Radian = new System.Windows.Forms.TextBox();
            this.tbJ1Radian = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_bt
            // 
            this.connect_bt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connect_bt.Location = new System.Drawing.Point(20, 12);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(120, 40);
            this.connect_bt.TabIndex = 0;
            this.connect_bt.Text = "Connect";
            this.connect_bt.UseVisualStyleBackColor = true;
            this.connect_bt.Click += new System.EventHandler(this.connect_bt_Click);
            // 
            // IPaddress
            // 
            this.IPaddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IPaddress.Location = new System.Drawing.Point(146, 20);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(120, 27);
            this.IPaddress.TabIndex = 1;
            this.IPaddress.Text = "輸入手臂IP位址";
            this.IPaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disconnect_bt
            // 
            this.disconnect_bt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.disconnect_bt.Location = new System.Drawing.Point(20, 58);
            this.disconnect_bt.Name = "disconnect_bt";
            this.disconnect_bt.Size = new System.Drawing.Size(120, 40);
            this.disconnect_bt.TabIndex = 2;
            this.disconnect_bt.Text = "Disconnect";
            this.disconnect_bt.UseVisualStyleBackColor = true;
            // 
            // J1plus
            // 
            this.J1plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J1plus.Location = new System.Drawing.Point(20, 466);
            this.J1plus.Name = "J1plus";
            this.J1plus.Size = new System.Drawing.Size(75, 35);
            this.J1plus.TabIndex = 3;
            this.J1plus.Text = "J1+";
            this.J1plus.UseVisualStyleBackColor = true;
            this.J1plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J1plus_MouseUp);
            // 
            // J1minus
            // 
            this.J1minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J1minus.Location = new System.Drawing.Point(101, 466);
            this.J1minus.Name = "J1minus";
            this.J1minus.Size = new System.Drawing.Size(75, 35);
            this.J1minus.TabIndex = 4;
            this.J1minus.Text = "J1-";
            this.J1minus.UseVisualStyleBackColor = true;
            // 
            // J2plus
            // 
            this.J2plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J2plus.Location = new System.Drawing.Point(20, 514);
            this.J2plus.Name = "J2plus";
            this.J2plus.Size = new System.Drawing.Size(75, 35);
            this.J2plus.TabIndex = 5;
            this.J2plus.Text = "J2+";
            this.J2plus.UseVisualStyleBackColor = true;
            // 
            // J2minus
            // 
            this.J2minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J2minus.Location = new System.Drawing.Point(101, 514);
            this.J2minus.Name = "J2minus";
            this.J2minus.Size = new System.Drawing.Size(75, 35);
            this.J2minus.TabIndex = 6;
            this.J2minus.Text = "J2-";
            this.J2minus.UseVisualStyleBackColor = true;
            // 
            // J3plus
            // 
            this.J3plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J3plus.Location = new System.Drawing.Point(20, 562);
            this.J3plus.Name = "J3plus";
            this.J3plus.Size = new System.Drawing.Size(75, 35);
            this.J3plus.TabIndex = 7;
            this.J3plus.Text = "J3+";
            this.J3plus.UseVisualStyleBackColor = true;
            // 
            // J3minus
            // 
            this.J3minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J3minus.Location = new System.Drawing.Point(101, 562);
            this.J3minus.Name = "J3minus";
            this.J3minus.Size = new System.Drawing.Size(75, 35);
            this.J3minus.TabIndex = 8;
            this.J3minus.Text = "J3-";
            this.J3minus.UseVisualStyleBackColor = true;
            // 
            // J4plus
            // 
            this.J4plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J4plus.Location = new System.Drawing.Point(20, 610);
            this.J4plus.Name = "J4plus";
            this.J4plus.Size = new System.Drawing.Size(75, 35);
            this.J4plus.TabIndex = 9;
            this.J4plus.Text = "J4+";
            this.J4plus.UseVisualStyleBackColor = true;
            // 
            // J4minus
            // 
            this.J4minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J4minus.Location = new System.Drawing.Point(101, 610);
            this.J4minus.Name = "J4minus";
            this.J4minus.Size = new System.Drawing.Size(75, 35);
            this.J4minus.TabIndex = 10;
            this.J4minus.Text = "J4-";
            this.J4minus.UseVisualStyleBackColor = true;
            // 
            // J5plus
            // 
            this.J5plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J5plus.Location = new System.Drawing.Point(20, 658);
            this.J5plus.Name = "J5plus";
            this.J5plus.Size = new System.Drawing.Size(75, 35);
            this.J5plus.TabIndex = 11;
            this.J5plus.Text = "J5+";
            this.J5plus.UseVisualStyleBackColor = true;
            // 
            // J5minus
            // 
            this.J5minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J5minus.Location = new System.Drawing.Point(101, 658);
            this.J5minus.Name = "J5minus";
            this.J5minus.Size = new System.Drawing.Size(75, 35);
            this.J5minus.TabIndex = 12;
            this.J5minus.Text = "J5-";
            this.J5minus.UseVisualStyleBackColor = true;
            // 
            // J6plus
            // 
            this.J6plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J6plus.Location = new System.Drawing.Point(20, 706);
            this.J6plus.Name = "J6plus";
            this.J6plus.Size = new System.Drawing.Size(75, 35);
            this.J6plus.TabIndex = 13;
            this.J6plus.Text = "J6+";
            this.J6plus.UseVisualStyleBackColor = true;
            // 
            // J6minus
            // 
            this.J6minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J6minus.Location = new System.Drawing.Point(101, 706);
            this.J6minus.Name = "J6minus";
            this.J6minus.Size = new System.Drawing.Size(75, 35);
            this.J6minus.TabIndex = 14;
            this.J6minus.Text = "J6-";
            this.J6minus.UseVisualStyleBackColor = true;
            // 
            // Xplus
            // 
            this.Xplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Xplus.Location = new System.Drawing.Point(216, 466);
            this.Xplus.Name = "Xplus";
            this.Xplus.Size = new System.Drawing.Size(75, 35);
            this.Xplus.TabIndex = 15;
            this.Xplus.Text = "X+";
            this.Xplus.UseVisualStyleBackColor = true;
            // 
            // Xminus
            // 
            this.Xminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Xminus.Location = new System.Drawing.Point(297, 466);
            this.Xminus.Name = "Xminus";
            this.Xminus.Size = new System.Drawing.Size(75, 35);
            this.Xminus.TabIndex = 16;
            this.Xminus.Text = "X-";
            this.Xminus.UseVisualStyleBackColor = true;
            // 
            // Yplus
            // 
            this.Yplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Yplus.Location = new System.Drawing.Point(216, 514);
            this.Yplus.Name = "Yplus";
            this.Yplus.Size = new System.Drawing.Size(75, 35);
            this.Yplus.TabIndex = 17;
            this.Yplus.Text = "Y+";
            this.Yplus.UseVisualStyleBackColor = true;
            // 
            // Yminus
            // 
            this.Yminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Yminus.Location = new System.Drawing.Point(297, 514);
            this.Yminus.Name = "Yminus";
            this.Yminus.Size = new System.Drawing.Size(75, 35);
            this.Yminus.TabIndex = 18;
            this.Yminus.Text = "Y-";
            this.Yminus.UseVisualStyleBackColor = true;
            // 
            // Zplus
            // 
            this.Zplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Zplus.Location = new System.Drawing.Point(216, 562);
            this.Zplus.Name = "Zplus";
            this.Zplus.Size = new System.Drawing.Size(75, 35);
            this.Zplus.TabIndex = 19;
            this.Zplus.Text = "Z+";
            this.Zplus.UseVisualStyleBackColor = true;
            // 
            // Zminus
            // 
            this.Zminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Zminus.Location = new System.Drawing.Point(297, 562);
            this.Zminus.Name = "Zminus";
            this.Zminus.Size = new System.Drawing.Size(75, 35);
            this.Zminus.TabIndex = 20;
            this.Zminus.Text = "Z-";
            this.Zminus.UseVisualStyleBackColor = true;
            // 
            // RXplus
            // 
            this.RXplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RXplus.Location = new System.Drawing.Point(216, 610);
            this.RXplus.Name = "RXplus";
            this.RXplus.Size = new System.Drawing.Size(75, 35);
            this.RXplus.TabIndex = 21;
            this.RXplus.Text = "Rx+";
            this.RXplus.UseVisualStyleBackColor = true;
            // 
            // RXminus
            // 
            this.RXminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RXminus.Location = new System.Drawing.Point(297, 610);
            this.RXminus.Name = "RXminus";
            this.RXminus.Size = new System.Drawing.Size(75, 35);
            this.RXminus.TabIndex = 22;
            this.RXminus.Text = "Rx-";
            this.RXminus.UseVisualStyleBackColor = true;
            // 
            // RYplus
            // 
            this.RYplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RYplus.Location = new System.Drawing.Point(216, 658);
            this.RYplus.Name = "RYplus";
            this.RYplus.Size = new System.Drawing.Size(75, 35);
            this.RYplus.TabIndex = 23;
            this.RYplus.Text = "Ry+";
            this.RYplus.UseVisualStyleBackColor = true;
            // 
            // RYminus
            // 
            this.RYminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RYminus.Location = new System.Drawing.Point(297, 658);
            this.RYminus.Name = "RYminus";
            this.RYminus.Size = new System.Drawing.Size(75, 35);
            this.RYminus.TabIndex = 24;
            this.RYminus.Text = "Ry-";
            this.RYminus.UseVisualStyleBackColor = true;
            // 
            // RZplus
            // 
            this.RZplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RZplus.Location = new System.Drawing.Point(216, 706);
            this.RZplus.Name = "RZplus";
            this.RZplus.Size = new System.Drawing.Size(75, 35);
            this.RZplus.TabIndex = 25;
            this.RZplus.Text = "Rz+";
            this.RZplus.UseVisualStyleBackColor = true;
            // 
            // RZminus
            // 
            this.RZminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RZminus.Location = new System.Drawing.Point(297, 706);
            this.RZminus.Name = "RZminus";
            this.RZminus.Size = new System.Drawing.Size(75, 35);
            this.RZminus.TabIndex = 26;
            this.RZminus.Text = "Rz-";
            this.RZminus.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(397, 466);
            this.Speed.Name = "Speed";
            this.Speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Speed.Size = new System.Drawing.Size(56, 275);
            this.Speed.TabIndex = 27;
            this.Speed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movement,
            this.J1,
            this.J2,
            this.J3,
            this.J4,
            this.J5,
            this.J6,
            this.X,
            this.Y,
            this.Z,
            this.Rx,
            this.Ry,
            this.Rz});
            this.dataGridView1.Location = new System.Drawing.Point(20, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1348, 337);
            this.dataGridView1.TabIndex = 28;
            // 
            // Movement
            // 
            this.Movement.HeaderText = "Movement";
            this.Movement.Name = "Movement";
            this.Movement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Movement.Width = 80;
            // 
            // J1
            // 
            this.J1.HeaderText = "J1";
            this.J1.Name = "J1";
            this.J1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.J1.Width = 80;
            // 
            // J2
            // 
            this.J2.HeaderText = "J2";
            this.J2.Name = "J2";
            this.J2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.J2.Width = 80;
            // 
            // J3
            // 
            this.J3.HeaderText = "J3";
            this.J3.Name = "J3";
            this.J3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.J3.Width = 80;
            // 
            // J4
            // 
            this.J4.HeaderText = "J4";
            this.J4.Name = "J4";
            this.J4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.J4.Width = 80;
            // 
            // J5
            // 
            this.J5.HeaderText = "J5";
            this.J5.Name = "J5";
            this.J5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.J5.Width = 80;
            // 
            // J6
            // 
            this.J6.HeaderText = "J6";
            this.J6.Name = "J6";
            this.J6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.J6.Width = 80;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.X.Width = 80;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y.Width = 80;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            this.Z.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Z.Width = 80;
            // 
            // Rx
            // 
            this.Rx.HeaderText = "Rx";
            this.Rx.Name = "Rx";
            this.Rx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Rx.Width = 80;
            // 
            // Ry
            // 
            this.Ry.HeaderText = "Ry";
            this.Ry.Name = "Ry";
            this.Ry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ry.Width = 80;
            // 
            // Rz
            // 
            this.Rz.HeaderText = "Rz";
            this.Rz.Name = "Rz";
            this.Rz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Rz.Width = 80;
            // 
            // start_thread
            // 
            this.start_thread.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start_thread.Location = new System.Drawing.Point(146, 58);
            this.start_thread.Name = "start_thread";
            this.start_thread.Size = new System.Drawing.Size(120, 40);
            this.start_thread.TabIndex = 29;
            this.start_thread.Text = "Start Thread";
            this.start_thread.UseVisualStyleBackColor = true;
            // 
            // stop_thread
            // 
            this.stop_thread.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stop_thread.Location = new System.Drawing.Point(272, 58);
            this.stop_thread.Name = "stop_thread";
            this.stop_thread.Size = new System.Drawing.Size(120, 40);
            this.stop_thread.TabIndex = 30;
            this.stop_thread.Text = "Stop Thread";
            this.stop_thread.UseVisualStyleBackColor = true;
            this.stop_thread.Click += new System.EventHandler(this.stop_thread_Click);
            // 
            // tbJ1
            // 
            this.tbJ1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ1.Location = new System.Drawing.Point(590, 497);
            this.tbJ1.Name = "tbJ1";
            this.tbJ1.Size = new System.Drawing.Size(100, 27);
            this.tbJ1.TabIndex = 31;
            // 
            // tbJ6
            // 
            this.tbJ6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ6.Location = new System.Drawing.Point(590, 702);
            this.tbJ6.Name = "tbJ6";
            this.tbJ6.Size = new System.Drawing.Size(100, 27);
            this.tbJ6.TabIndex = 32;
            // 
            // tbJ5
            // 
            this.tbJ5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ5.Location = new System.Drawing.Point(590, 661);
            this.tbJ5.Name = "tbJ5";
            this.tbJ5.Size = new System.Drawing.Size(100, 27);
            this.tbJ5.TabIndex = 33;
            // 
            // tbJ4
            // 
            this.tbJ4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ4.Location = new System.Drawing.Point(590, 620);
            this.tbJ4.Name = "tbJ4";
            this.tbJ4.Size = new System.Drawing.Size(100, 27);
            this.tbJ4.TabIndex = 34;
            // 
            // tbJ3
            // 
            this.tbJ3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ3.Location = new System.Drawing.Point(590, 579);
            this.tbJ3.Name = "tbJ3";
            this.tbJ3.Size = new System.Drawing.Size(100, 27);
            this.tbJ3.TabIndex = 35;
            // 
            // tbJ2
            // 
            this.tbJ2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ2.Location = new System.Drawing.Point(590, 538);
            this.tbJ2.Name = "tbJ2";
            this.tbJ2.Size = new System.Drawing.Size(100, 27);
            this.tbJ2.TabIndex = 36;
            // 
            // showjoints
            // 
            this.showjoints.AutoSize = true;
            this.showjoints.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showjoints.Location = new System.Drawing.Point(601, 466);
            this.showjoints.Name = "showjoints";
            this.showjoints.Size = new System.Drawing.Size(78, 22);
            this.showjoints.TabIndex = 37;
            this.showjoints.Text = "各軸角度";
            // 
            // showaxisposition
            // 
            this.showaxisposition.AutoSize = true;
            this.showaxisposition.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showaxisposition.Location = new System.Drawing.Point(720, 466);
            this.showaxisposition.Name = "showaxisposition";
            this.showaxisposition.Size = new System.Drawing.Size(78, 22);
            this.showaxisposition.TabIndex = 44;
            this.showaxisposition.Text = "立體座標";
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbY.Location = new System.Drawing.Point(709, 538);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 27);
            this.tbY.TabIndex = 43;
            // 
            // tbZ
            // 
            this.tbZ.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbZ.Location = new System.Drawing.Point(709, 579);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(100, 27);
            this.tbZ.TabIndex = 42;
            // 
            // tbRx
            // 
            this.tbRx.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbRx.Location = new System.Drawing.Point(709, 620);
            this.tbRx.Name = "tbRx";
            this.tbRx.Size = new System.Drawing.Size(100, 27);
            this.tbRx.TabIndex = 41;
            // 
            // tbRy
            // 
            this.tbRy.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbRy.Location = new System.Drawing.Point(709, 661);
            this.tbRy.Name = "tbRy";
            this.tbRy.Size = new System.Drawing.Size(100, 27);
            this.tbRy.TabIndex = 40;
            // 
            // tbRz
            // 
            this.tbRz.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbRz.Location = new System.Drawing.Point(709, 702);
            this.tbRz.Name = "tbRz";
            this.tbRz.Size = new System.Drawing.Size(100, 27);
            this.tbRz.TabIndex = 39;
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbX.Location = new System.Drawing.Point(709, 497);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 27);
            this.tbX.TabIndex = 38;
            // 
            // MoveJ
            // 
            this.MoveJ.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveJ.Location = new System.Drawing.Point(481, 466);
            this.MoveJ.Name = "MoveJ";
            this.MoveJ.Size = new System.Drawing.Size(75, 35);
            this.MoveJ.TabIndex = 45;
            this.MoveJ.Text = "MoveJ";
            this.MoveJ.UseVisualStyleBackColor = true;
            // 
            // MoveL
            // 
            this.MoveL.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveL.Location = new System.Drawing.Point(481, 514);
            this.MoveL.Name = "MoveL";
            this.MoveL.Size = new System.Drawing.Size(75, 35);
            this.MoveL.TabIndex = 46;
            this.MoveL.Text = "MoveL";
            this.MoveL.UseVisualStyleBackColor = true;
            // 
            // startthread
            // 
            this.startthread.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startthread.Location = new System.Drawing.Point(996, 58);
            this.startthread.Name = "startthread";
            this.startthread.Size = new System.Drawing.Size(120, 40);
            this.startthread.TabIndex = 47;
            this.startthread.Text = "執行";
            this.startthread.UseVisualStyleBackColor = true;
            // 
            // stopthread
            // 
            this.stopthread.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopthread.Location = new System.Drawing.Point(1122, 59);
            this.stopthread.Name = "stopthread";
            this.stopthread.Size = new System.Drawing.Size(120, 40);
            this.stopthread.TabIndex = 48;
            this.stopthread.Text = "停止";
            this.stopthread.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clear.Location = new System.Drawing.Point(1248, 59);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 40);
            this.clear.TabIndex = 49;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(841, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "各軸徑度";
            // 
            // tbJ2Radian
            // 
            this.tbJ2Radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ2Radian.Location = new System.Drawing.Point(830, 538);
            this.tbJ2Radian.Name = "tbJ2Radian";
            this.tbJ2Radian.Size = new System.Drawing.Size(100, 27);
            this.tbJ2Radian.TabIndex = 55;
            // 
            // tbJ3Radian
            // 
            this.tbJ3Radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ3Radian.Location = new System.Drawing.Point(830, 579);
            this.tbJ3Radian.Name = "tbJ3Radian";
            this.tbJ3Radian.Size = new System.Drawing.Size(100, 27);
            this.tbJ3Radian.TabIndex = 54;
            // 
            // tbJ4Radian
            // 
            this.tbJ4Radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ4Radian.Location = new System.Drawing.Point(830, 620);
            this.tbJ4Radian.Name = "tbJ4Radian";
            this.tbJ4Radian.Size = new System.Drawing.Size(100, 27);
            this.tbJ4Radian.TabIndex = 53;
            // 
            // tbJ5Radian
            // 
            this.tbJ5Radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ5Radian.Location = new System.Drawing.Point(830, 661);
            this.tbJ5Radian.Name = "tbJ5Radian";
            this.tbJ5Radian.Size = new System.Drawing.Size(100, 27);
            this.tbJ5Radian.TabIndex = 52;
            // 
            // tbJ6Radian
            // 
            this.tbJ6Radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ6Radian.Location = new System.Drawing.Point(830, 702);
            this.tbJ6Radian.Name = "tbJ6Radian";
            this.tbJ6Radian.Size = new System.Drawing.Size(100, 27);
            this.tbJ6Radian.TabIndex = 51;
            // 
            // tbJ1Radian
            // 
            this.tbJ1Radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbJ1Radian.Location = new System.Drawing.Point(830, 497);
            this.tbJ1Radian.Name = "tbJ1Radian";
            this.tbJ1Radian.Size = new System.Drawing.Size(100, 27);
            this.tbJ1Radian.TabIndex = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJ2Radian);
            this.Controls.Add(this.tbJ3Radian);
            this.Controls.Add(this.tbJ4Radian);
            this.Controls.Add(this.tbJ5Radian);
            this.Controls.Add(this.tbJ6Radian);
            this.Controls.Add(this.tbJ1Radian);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.stopthread);
            this.Controls.Add(this.startthread);
            this.Controls.Add(this.MoveL);
            this.Controls.Add(this.MoveJ);
            this.Controls.Add(this.showaxisposition);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbRx);
            this.Controls.Add(this.tbRy);
            this.Controls.Add(this.tbRz);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.showjoints);
            this.Controls.Add(this.tbJ2);
            this.Controls.Add(this.tbJ3);
            this.Controls.Add(this.tbJ4);
            this.Controls.Add(this.tbJ5);
            this.Controls.Add(this.tbJ6);
            this.Controls.Add(this.tbJ1);
            this.Controls.Add(this.stop_thread);
            this.Controls.Add(this.start_thread);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.RZminus);
            this.Controls.Add(this.RZplus);
            this.Controls.Add(this.RYminus);
            this.Controls.Add(this.RYplus);
            this.Controls.Add(this.RXminus);
            this.Controls.Add(this.RXplus);
            this.Controls.Add(this.Zminus);
            this.Controls.Add(this.Zplus);
            this.Controls.Add(this.Yminus);
            this.Controls.Add(this.Yplus);
            this.Controls.Add(this.Xminus);
            this.Controls.Add(this.Xplus);
            this.Controls.Add(this.J6minus);
            this.Controls.Add(this.J6plus);
            this.Controls.Add(this.J5minus);
            this.Controls.Add(this.J5plus);
            this.Controls.Add(this.J4minus);
            this.Controls.Add(this.J4plus);
            this.Controls.Add(this.J3minus);
            this.Controls.Add(this.J3plus);
            this.Controls.Add(this.J2minus);
            this.Controls.Add(this.J2plus);
            this.Controls.Add(this.J1minus);
            this.Controls.Add(this.J1plus);
            this.Controls.Add(this.disconnect_bt);
            this.Controls.Add(this.IPaddress);
            this.Controls.Add(this.connect_bt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_bt;
        private System.Windows.Forms.TextBox IPaddress;
        private System.Windows.Forms.Button disconnect_bt;
        private System.Windows.Forms.Button J1plus;
        private System.Windows.Forms.Button J1minus;
        private System.Windows.Forms.Button J2plus;
        private System.Windows.Forms.Button J2minus;
        private System.Windows.Forms.Button J3plus;
        private System.Windows.Forms.Button J3minus;
        private System.Windows.Forms.Button J4plus;
        private System.Windows.Forms.Button J4minus;
        private System.Windows.Forms.Button J5plus;
        private System.Windows.Forms.Button J5minus;
        private System.Windows.Forms.Button J6plus;
        private System.Windows.Forms.Button J6minus;
        private System.Windows.Forms.Button Xplus;
        private System.Windows.Forms.Button Xminus;
        private System.Windows.Forms.Button Yplus;
        private System.Windows.Forms.Button Yminus;
        private System.Windows.Forms.Button Zplus;
        private System.Windows.Forms.Button Zminus;
        private System.Windows.Forms.Button RXplus;
        private System.Windows.Forms.Button RXminus;
        private System.Windows.Forms.Button RYplus;
        private System.Windows.Forms.Button RYminus;
        private System.Windows.Forms.Button RZplus;
        private System.Windows.Forms.Button RZminus;
        private System.Windows.Forms.TrackBar Speed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button start_thread;
        private System.Windows.Forms.Button stop_thread;
        private System.Windows.Forms.TextBox tbJ1;
        private System.Windows.Forms.TextBox tbJ6;
        private System.Windows.Forms.TextBox tbJ5;
        private System.Windows.Forms.TextBox tbJ4;
        private System.Windows.Forms.TextBox tbJ3;
        private System.Windows.Forms.TextBox tbJ2;
        private System.Windows.Forms.Label showjoints;
        private System.Windows.Forms.Label showaxisposition;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbRx;
        private System.Windows.Forms.TextBox tbRy;
        private System.Windows.Forms.TextBox tbRz;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button MoveJ;
        private System.Windows.Forms.Button MoveL;
        private System.Windows.Forms.Button startthread;
        private System.Windows.Forms.Button stopthread;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movement;
        private System.Windows.Forms.DataGridViewTextBoxColumn J1;
        private System.Windows.Forms.DataGridViewTextBoxColumn J2;
        private System.Windows.Forms.DataGridViewTextBoxColumn J3;
        private System.Windows.Forms.DataGridViewTextBoxColumn J4;
        private System.Windows.Forms.DataGridViewTextBoxColumn J5;
        private System.Windows.Forms.DataGridViewTextBoxColumn J6;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJ2Radian;
        private System.Windows.Forms.TextBox tbJ3Radian;
        private System.Windows.Forms.TextBox tbJ4Radian;
        private System.Windows.Forms.TextBox tbJ5Radian;
        private System.Windows.Forms.TextBox tbJ6Radian;
        private System.Windows.Forms.TextBox tbJ1Radian;
    }
}

