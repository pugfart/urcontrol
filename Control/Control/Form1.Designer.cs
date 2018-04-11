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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.movementdata = new System.Windows.Forms.DataGridView();
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
            this.showjointsdegree = new System.Windows.Forms.Label();
            this.showaxisposition = new System.Windows.Forms.Label();
            this.MoveJ = new System.Windows.Forms.Button();
            this.MoveL = new System.Windows.Forms.Button();
            this.startthread = new System.Windows.Forms.Button();
            this.stopthread = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.showjointsradian = new System.Windows.Forms.Label();
            this.showspeedpercent = new System.Windows.Forms.Label();
            this.deleterow = new System.Windows.Forms.Button();
            this.j1degree = new System.Windows.Forms.Label();
            this.j2degree = new System.Windows.Forms.Label();
            this.j3degree = new System.Windows.Forms.Label();
            this.j4degree = new System.Windows.Forms.Label();
            this.j5degree = new System.Windows.Forms.Label();
            this.j6degree = new System.Windows.Forms.Label();
            this.tcprz = new System.Windows.Forms.Label();
            this.tcpry = new System.Windows.Forms.Label();
            this.tcprx = new System.Windows.Forms.Label();
            this.tcpz = new System.Windows.Forms.Label();
            this.tcpy = new System.Windows.Forms.Label();
            this.tcpx = new System.Windows.Forms.Label();
            this.j6radian = new System.Windows.Forms.Label();
            this.j5radian = new System.Windows.Forms.Label();
            this.j4radian = new System.Windows.Forms.Label();
            this.j3radian = new System.Windows.Forms.Label();
            this.j2radian = new System.Windows.Forms.Label();
            this.j1radian = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementdata)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_bt
            // 
            this.connect_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect_bt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.IPaddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IPaddress_MouseClick);
            this.IPaddress.TextChanged += new System.EventHandler(this.IPaddress_TextChanged);
            // 
            // disconnect_bt
            // 
            this.disconnect_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnect_bt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.disconnect_bt.Location = new System.Drawing.Point(20, 58);
            this.disconnect_bt.Name = "disconnect_bt";
            this.disconnect_bt.Size = new System.Drawing.Size(120, 40);
            this.disconnect_bt.TabIndex = 2;
            this.disconnect_bt.Text = "Disconnect";
            this.disconnect_bt.UseVisualStyleBackColor = true;
            this.disconnect_bt.Click += new System.EventHandler(this.disconnect_bt_Click_1);
            // 
            // J1plus
            // 
            this.J1plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J1plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J1plus.Location = new System.Drawing.Point(20, 466);
            this.J1plus.Name = "J1plus";
            this.J1plus.Size = new System.Drawing.Size(75, 35);
            this.J1plus.TabIndex = 3;
            this.J1plus.Text = "J1+";
            this.J1plus.UseVisualStyleBackColor = true;
            this.J1plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J1plus_MouseDown_1);
            this.J1plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J1plus_MouseUp);
            // 
            // J1minus
            // 
            this.J1minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J1minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J1minus.Location = new System.Drawing.Point(101, 466);
            this.J1minus.Name = "J1minus";
            this.J1minus.Size = new System.Drawing.Size(75, 35);
            this.J1minus.TabIndex = 4;
            this.J1minus.Text = "J1-";
            this.J1minus.UseVisualStyleBackColor = true;
            this.J1minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J1minus_MouseDown);
            this.J1minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J1minus_MouseUp);
            // 
            // J2plus
            // 
            this.J2plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J2plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J2plus.Location = new System.Drawing.Point(20, 514);
            this.J2plus.Name = "J2plus";
            this.J2plus.Size = new System.Drawing.Size(75, 35);
            this.J2plus.TabIndex = 5;
            this.J2plus.Text = "J2+";
            this.J2plus.UseVisualStyleBackColor = true;
            this.J2plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J2plus_MouseDown);
            this.J2plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J2plus_MouseUp);
            // 
            // J2minus
            // 
            this.J2minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J2minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J2minus.Location = new System.Drawing.Point(101, 514);
            this.J2minus.Name = "J2minus";
            this.J2minus.Size = new System.Drawing.Size(75, 35);
            this.J2minus.TabIndex = 6;
            this.J2minus.Text = "J2-";
            this.J2minus.UseVisualStyleBackColor = true;
            this.J2minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J2minus_MouseDown);
            this.J2minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J2minus_MouseUp);
            // 
            // J3plus
            // 
            this.J3plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J3plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J3plus.Location = new System.Drawing.Point(20, 562);
            this.J3plus.Name = "J3plus";
            this.J3plus.Size = new System.Drawing.Size(75, 35);
            this.J3plus.TabIndex = 7;
            this.J3plus.Text = "J3+";
            this.J3plus.UseVisualStyleBackColor = true;
            this.J3plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J3plus_MouseDown);
            this.J3plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J3plus_MouseUp);
            // 
            // J3minus
            // 
            this.J3minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J3minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J3minus.Location = new System.Drawing.Point(101, 562);
            this.J3minus.Name = "J3minus";
            this.J3minus.Size = new System.Drawing.Size(75, 35);
            this.J3minus.TabIndex = 8;
            this.J3minus.Text = "J3-";
            this.J3minus.UseVisualStyleBackColor = true;
            this.J3minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J3minus_MouseDown);
            this.J3minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J3minus_MouseUp);
            // 
            // J4plus
            // 
            this.J4plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J4plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J4plus.Location = new System.Drawing.Point(20, 610);
            this.J4plus.Name = "J4plus";
            this.J4plus.Size = new System.Drawing.Size(75, 35);
            this.J4plus.TabIndex = 9;
            this.J4plus.Text = "J4+";
            this.J4plus.UseVisualStyleBackColor = true;
            this.J4plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J4plus_MouseDown);
            this.J4plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J4plus_MouseUp);
            // 
            // J4minus
            // 
            this.J4minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J4minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J4minus.Location = new System.Drawing.Point(101, 610);
            this.J4minus.Name = "J4minus";
            this.J4minus.Size = new System.Drawing.Size(75, 35);
            this.J4minus.TabIndex = 10;
            this.J4minus.Text = "J4-";
            this.J4minus.UseVisualStyleBackColor = true;
            this.J4minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J4minus_MouseDown);
            this.J4minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J4minus_MouseUp);
            // 
            // J5plus
            // 
            this.J5plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J5plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J5plus.Location = new System.Drawing.Point(20, 658);
            this.J5plus.Name = "J5plus";
            this.J5plus.Size = new System.Drawing.Size(75, 35);
            this.J5plus.TabIndex = 11;
            this.J5plus.Text = "J5+";
            this.J5plus.UseVisualStyleBackColor = true;
            this.J5plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J5plus_MouseDown);
            this.J5plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J5plus_MouseUp);
            // 
            // J5minus
            // 
            this.J5minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J5minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J5minus.Location = new System.Drawing.Point(101, 658);
            this.J5minus.Name = "J5minus";
            this.J5minus.Size = new System.Drawing.Size(75, 35);
            this.J5minus.TabIndex = 12;
            this.J5minus.Text = "J5-";
            this.J5minus.UseVisualStyleBackColor = true;
            this.J5minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J5minus_MouseDown);
            this.J5minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J5minus_MouseUp);
            // 
            // J6plus
            // 
            this.J6plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J6plus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J6plus.Location = new System.Drawing.Point(20, 706);
            this.J6plus.Name = "J6plus";
            this.J6plus.Size = new System.Drawing.Size(75, 35);
            this.J6plus.TabIndex = 13;
            this.J6plus.Text = "J6+";
            this.J6plus.UseVisualStyleBackColor = true;
            this.J6plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J6plus_MouseDown);
            this.J6plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J6plus_MouseUp);
            // 
            // J6minus
            // 
            this.J6minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J6minus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J6minus.Location = new System.Drawing.Point(101, 706);
            this.J6minus.Name = "J6minus";
            this.J6minus.Size = new System.Drawing.Size(75, 35);
            this.J6minus.TabIndex = 14;
            this.J6minus.Text = "J6-";
            this.J6minus.UseVisualStyleBackColor = true;
            this.J6minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J6minus_MouseDown);
            this.J6minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J6minus_MouseUp);
            // 
            // Xplus
            // 
            this.Xplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Xplus.Location = new System.Drawing.Point(216, 466);
            this.Xplus.Name = "Xplus";
            this.Xplus.Size = new System.Drawing.Size(75, 35);
            this.Xplus.TabIndex = 15;
            this.Xplus.Text = "X+";
            this.Xplus.UseVisualStyleBackColor = true;
            // 
            // Xminus
            // 
            this.Xminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Xminus.Location = new System.Drawing.Point(297, 466);
            this.Xminus.Name = "Xminus";
            this.Xminus.Size = new System.Drawing.Size(75, 35);
            this.Xminus.TabIndex = 16;
            this.Xminus.Text = "X-";
            this.Xminus.UseVisualStyleBackColor = true;
            // 
            // Yplus
            // 
            this.Yplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Yplus.Location = new System.Drawing.Point(216, 514);
            this.Yplus.Name = "Yplus";
            this.Yplus.Size = new System.Drawing.Size(75, 35);
            this.Yplus.TabIndex = 17;
            this.Yplus.Text = "Y+";
            this.Yplus.UseVisualStyleBackColor = true;
            // 
            // Yminus
            // 
            this.Yminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Yminus.Location = new System.Drawing.Point(297, 514);
            this.Yminus.Name = "Yminus";
            this.Yminus.Size = new System.Drawing.Size(75, 35);
            this.Yminus.TabIndex = 18;
            this.Yminus.Text = "Y-";
            this.Yminus.UseVisualStyleBackColor = true;
            // 
            // Zplus
            // 
            this.Zplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Zplus.Location = new System.Drawing.Point(216, 562);
            this.Zplus.Name = "Zplus";
            this.Zplus.Size = new System.Drawing.Size(75, 35);
            this.Zplus.TabIndex = 19;
            this.Zplus.Text = "Z+";
            this.Zplus.UseVisualStyleBackColor = true;
            // 
            // Zminus
            // 
            this.Zminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Zminus.Location = new System.Drawing.Point(297, 562);
            this.Zminus.Name = "Zminus";
            this.Zminus.Size = new System.Drawing.Size(75, 35);
            this.Zminus.TabIndex = 20;
            this.Zminus.Text = "Z-";
            this.Zminus.UseVisualStyleBackColor = true;
            // 
            // RXplus
            // 
            this.RXplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RXplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RXplus.Location = new System.Drawing.Point(216, 610);
            this.RXplus.Name = "RXplus";
            this.RXplus.Size = new System.Drawing.Size(75, 35);
            this.RXplus.TabIndex = 21;
            this.RXplus.Text = "Rx+";
            this.RXplus.UseVisualStyleBackColor = true;
            // 
            // RXminus
            // 
            this.RXminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RXminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RXminus.Location = new System.Drawing.Point(297, 610);
            this.RXminus.Name = "RXminus";
            this.RXminus.Size = new System.Drawing.Size(75, 35);
            this.RXminus.TabIndex = 22;
            this.RXminus.Text = "Rx-";
            this.RXminus.UseVisualStyleBackColor = true;
            // 
            // RYplus
            // 
            this.RYplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RYplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RYplus.Location = new System.Drawing.Point(216, 658);
            this.RYplus.Name = "RYplus";
            this.RYplus.Size = new System.Drawing.Size(75, 35);
            this.RYplus.TabIndex = 23;
            this.RYplus.Text = "Ry+";
            this.RYplus.UseVisualStyleBackColor = true;
            // 
            // RYminus
            // 
            this.RYminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RYminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RYminus.Location = new System.Drawing.Point(297, 658);
            this.RYminus.Name = "RYminus";
            this.RYminus.Size = new System.Drawing.Size(75, 35);
            this.RYminus.TabIndex = 24;
            this.RYminus.Text = "Ry-";
            this.RYminus.UseVisualStyleBackColor = true;
            // 
            // RZplus
            // 
            this.RZplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RZplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RZplus.Location = new System.Drawing.Point(216, 706);
            this.RZplus.Name = "RZplus";
            this.RZplus.Size = new System.Drawing.Size(75, 35);
            this.RZplus.TabIndex = 25;
            this.RZplus.Text = "Rz+";
            this.RZplus.UseVisualStyleBackColor = true;
            // 
            // RZminus
            // 
            this.RZminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RZminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RZminus.Location = new System.Drawing.Point(297, 706);
            this.RZminus.Name = "RZminus";
            this.RZminus.Size = new System.Drawing.Size(75, 35);
            this.RZminus.TabIndex = 26;
            this.RZminus.Text = "Rz-";
            this.RZminus.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.Speed.AutoSize = false;
            this.Speed.Location = new System.Drawing.Point(393, 482);
            this.Speed.Minimum = 1;
            this.Speed.Name = "Speed";
            this.Speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Speed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Speed.Size = new System.Drawing.Size(56, 259);
            this.Speed.TabIndex = 27;
            this.Speed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Speed.Value = 1;
            this.Speed.Scroll += new System.EventHandler(this.Speed_Scroll);
            // 
            // movementdata
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movementdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.movementdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movementdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.movementdata.Location = new System.Drawing.Point(20, 113);
            this.movementdata.Name = "movementdata";
            this.movementdata.RowTemplate.Height = 27;
            this.movementdata.Size = new System.Drawing.Size(1096, 337);
            this.movementdata.TabIndex = 28;
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
            this.start_thread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_thread.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start_thread.Location = new System.Drawing.Point(146, 58);
            this.start_thread.Name = "start_thread";
            this.start_thread.Size = new System.Drawing.Size(120, 40);
            this.start_thread.TabIndex = 29;
            this.start_thread.Text = "Start Thread";
            this.start_thread.UseVisualStyleBackColor = true;
            this.start_thread.Click += new System.EventHandler(this.start_thread_Click);
            // 
            // stop_thread
            // 
            this.stop_thread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_thread.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stop_thread.Location = new System.Drawing.Point(272, 58);
            this.stop_thread.Name = "stop_thread";
            this.stop_thread.Size = new System.Drawing.Size(120, 40);
            this.stop_thread.TabIndex = 30;
            this.stop_thread.Text = "Stop Thread";
            this.stop_thread.UseVisualStyleBackColor = true;
            this.stop_thread.Click += new System.EventHandler(this.stop_thread_Click);
            // 
            // showjointsdegree
            // 
            this.showjointsdegree.AutoSize = true;
            this.showjointsdegree.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showjointsdegree.Location = new System.Drawing.Point(614, 468);
            this.showjointsdegree.Name = "showjointsdegree";
            this.showjointsdegree.Size = new System.Drawing.Size(78, 22);
            this.showjointsdegree.TabIndex = 37;
            this.showjointsdegree.Text = "各軸角度";
            // 
            // showaxisposition
            // 
            this.showaxisposition.AutoSize = true;
            this.showaxisposition.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showaxisposition.Location = new System.Drawing.Point(722, 468);
            this.showaxisposition.Name = "showaxisposition";
            this.showaxisposition.Size = new System.Drawing.Size(78, 22);
            this.showaxisposition.TabIndex = 44;
            this.showaxisposition.Text = "立體座標";
            // 
            // MoveJ
            // 
            this.MoveJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveJ.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveJ.Location = new System.Drawing.Point(481, 466);
            this.MoveJ.Name = "MoveJ";
            this.MoveJ.Size = new System.Drawing.Size(85, 35);
            this.MoveJ.TabIndex = 45;
            this.MoveJ.Text = "MoveJ";
            this.MoveJ.UseVisualStyleBackColor = true;
            this.MoveJ.Click += new System.EventHandler(this.MoveJ_Click);
            // 
            // MoveL
            // 
            this.MoveL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveL.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveL.Location = new System.Drawing.Point(481, 514);
            this.MoveL.Name = "MoveL";
            this.MoveL.Size = new System.Drawing.Size(85, 35);
            this.MoveL.TabIndex = 46;
            this.MoveL.Text = "MoveL";
            this.MoveL.UseVisualStyleBackColor = true;
            this.MoveL.Click += new System.EventHandler(this.MoveL_Click);
            // 
            // startthread
            // 
            this.startthread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startthread.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startthread.Location = new System.Drawing.Point(618, 58);
            this.startthread.Name = "startthread";
            this.startthread.Size = new System.Drawing.Size(120, 40);
            this.startthread.TabIndex = 47;
            this.startthread.Text = "執行";
            this.startthread.UseVisualStyleBackColor = true;
            // 
            // stopthread
            // 
            this.stopthread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopthread.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopthread.Location = new System.Drawing.Point(744, 58);
            this.stopthread.Name = "stopthread";
            this.stopthread.Size = new System.Drawing.Size(120, 40);
            this.stopthread.TabIndex = 48;
            this.stopthread.Text = "停止";
            this.stopthread.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clear.Location = new System.Drawing.Point(870, 58);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 40);
            this.clear.TabIndex = 49;
            this.clear.Text = "清空列表";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // showjointsradian
            // 
            this.showjointsradian.AutoSize = true;
            this.showjointsradian.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showjointsradian.Location = new System.Drawing.Point(830, 468);
            this.showjointsradian.Name = "showjointsradian";
            this.showjointsradian.Size = new System.Drawing.Size(78, 22);
            this.showjointsradian.TabIndex = 56;
            this.showjointsradian.Text = "各軸徑度";
            // 
            // showspeedpercent
            // 
            this.showspeedpercent.AutoSize = true;
            this.showspeedpercent.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showspeedpercent.Location = new System.Drawing.Point(412, 470);
            this.showspeedpercent.Name = "showspeedpercent";
            this.showspeedpercent.Size = new System.Drawing.Size(18, 19);
            this.showspeedpercent.TabIndex = 57;
            this.showspeedpercent.Text = "1";
            this.showspeedpercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleterow
            // 
            this.deleterow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleterow.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleterow.Location = new System.Drawing.Point(996, 58);
            this.deleterow.Name = "deleterow";
            this.deleterow.Size = new System.Drawing.Size(120, 40);
            this.deleterow.TabIndex = 58;
            this.deleterow.Text = "刪除列表";
            this.deleterow.UseVisualStyleBackColor = true;
            // 
            // j1degree
            // 
            this.j1degree.BackColor = System.Drawing.Color.White;
            this.j1degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j1degree.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j1degree.Location = new System.Drawing.Point(616, 501);
            this.j1degree.Name = "j1degree";
            this.j1degree.Size = new System.Drawing.Size(75, 30);
            this.j1degree.TabIndex = 59;
            this.j1degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j2degree
            // 
            this.j2degree.BackColor = System.Drawing.Color.White;
            this.j2degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j2degree.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j2degree.Location = new System.Drawing.Point(616, 542);
            this.j2degree.Name = "j2degree";
            this.j2degree.Size = new System.Drawing.Size(75, 30);
            this.j2degree.TabIndex = 61;
            this.j2degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j3degree
            // 
            this.j3degree.BackColor = System.Drawing.Color.White;
            this.j3degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j3degree.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j3degree.Location = new System.Drawing.Point(616, 583);
            this.j3degree.Name = "j3degree";
            this.j3degree.Size = new System.Drawing.Size(75, 30);
            this.j3degree.TabIndex = 62;
            this.j3degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j4degree
            // 
            this.j4degree.BackColor = System.Drawing.Color.White;
            this.j4degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j4degree.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j4degree.Location = new System.Drawing.Point(616, 624);
            this.j4degree.Name = "j4degree";
            this.j4degree.Size = new System.Drawing.Size(75, 30);
            this.j4degree.TabIndex = 63;
            this.j4degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j5degree
            // 
            this.j5degree.BackColor = System.Drawing.Color.White;
            this.j5degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j5degree.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j5degree.Location = new System.Drawing.Point(616, 665);
            this.j5degree.Name = "j5degree";
            this.j5degree.Size = new System.Drawing.Size(75, 30);
            this.j5degree.TabIndex = 64;
            this.j5degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j6degree
            // 
            this.j6degree.BackColor = System.Drawing.Color.White;
            this.j6degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j6degree.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j6degree.Location = new System.Drawing.Point(616, 706);
            this.j6degree.Name = "j6degree";
            this.j6degree.Size = new System.Drawing.Size(75, 30);
            this.j6degree.TabIndex = 65;
            this.j6degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcprz
            // 
            this.tcprz.BackColor = System.Drawing.Color.White;
            this.tcprz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcprz.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tcprz.Location = new System.Drawing.Point(724, 706);
            this.tcprz.Name = "tcprz";
            this.tcprz.Size = new System.Drawing.Size(75, 30);
            this.tcprz.TabIndex = 71;
            this.tcprz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcpry
            // 
            this.tcpry.BackColor = System.Drawing.Color.White;
            this.tcpry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcpry.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tcpry.Location = new System.Drawing.Point(724, 665);
            this.tcpry.Name = "tcpry";
            this.tcpry.Size = new System.Drawing.Size(75, 30);
            this.tcpry.TabIndex = 70;
            this.tcpry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcprx
            // 
            this.tcprx.BackColor = System.Drawing.Color.White;
            this.tcprx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcprx.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tcprx.Location = new System.Drawing.Point(724, 624);
            this.tcprx.Name = "tcprx";
            this.tcprx.Size = new System.Drawing.Size(75, 30);
            this.tcprx.TabIndex = 69;
            this.tcprx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcpz
            // 
            this.tcpz.BackColor = System.Drawing.Color.White;
            this.tcpz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcpz.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tcpz.Location = new System.Drawing.Point(724, 583);
            this.tcpz.Name = "tcpz";
            this.tcpz.Size = new System.Drawing.Size(75, 30);
            this.tcpz.TabIndex = 68;
            this.tcpz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcpy
            // 
            this.tcpy.BackColor = System.Drawing.Color.White;
            this.tcpy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcpy.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tcpy.Location = new System.Drawing.Point(724, 542);
            this.tcpy.Name = "tcpy";
            this.tcpy.Size = new System.Drawing.Size(75, 30);
            this.tcpy.TabIndex = 67;
            this.tcpy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcpx
            // 
            this.tcpx.BackColor = System.Drawing.Color.White;
            this.tcpx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcpx.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tcpx.Location = new System.Drawing.Point(724, 501);
            this.tcpx.Name = "tcpx";
            this.tcpx.Size = new System.Drawing.Size(75, 30);
            this.tcpx.TabIndex = 66;
            this.tcpx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j6radian
            // 
            this.j6radian.BackColor = System.Drawing.Color.White;
            this.j6radian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j6radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j6radian.Location = new System.Drawing.Point(832, 706);
            this.j6radian.Name = "j6radian";
            this.j6radian.Size = new System.Drawing.Size(75, 30);
            this.j6radian.TabIndex = 77;
            this.j6radian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j5radian
            // 
            this.j5radian.BackColor = System.Drawing.Color.White;
            this.j5radian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j5radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j5radian.Location = new System.Drawing.Point(832, 665);
            this.j5radian.Name = "j5radian";
            this.j5radian.Size = new System.Drawing.Size(75, 30);
            this.j5radian.TabIndex = 76;
            this.j5radian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j4radian
            // 
            this.j4radian.BackColor = System.Drawing.Color.White;
            this.j4radian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j4radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j4radian.Location = new System.Drawing.Point(832, 624);
            this.j4radian.Name = "j4radian";
            this.j4radian.Size = new System.Drawing.Size(75, 30);
            this.j4radian.TabIndex = 75;
            this.j4radian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j3radian
            // 
            this.j3radian.BackColor = System.Drawing.Color.White;
            this.j3radian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j3radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j3radian.Location = new System.Drawing.Point(832, 583);
            this.j3radian.Name = "j3radian";
            this.j3radian.Size = new System.Drawing.Size(75, 30);
            this.j3radian.TabIndex = 74;
            this.j3radian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j2radian
            // 
            this.j2radian.BackColor = System.Drawing.Color.White;
            this.j2radian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j2radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j2radian.Location = new System.Drawing.Point(832, 542);
            this.j2radian.Name = "j2radian";
            this.j2radian.Size = new System.Drawing.Size(75, 30);
            this.j2radian.TabIndex = 73;
            this.j2radian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // j1radian
            // 
            this.j1radian.BackColor = System.Drawing.Color.White;
            this.j1radian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.j1radian.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.j1radian.Location = new System.Drawing.Point(832, 501);
            this.j1radian.Name = "j1radian";
            this.j1radian.Size = new System.Drawing.Size(75, 30);
            this.j1radian.TabIndex = 78;
            this.j1radian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.j1radian);
            this.Controls.Add(this.j6radian);
            this.Controls.Add(this.j5radian);
            this.Controls.Add(this.j4radian);
            this.Controls.Add(this.j3radian);
            this.Controls.Add(this.j2radian);
            this.Controls.Add(this.tcprz);
            this.Controls.Add(this.tcpry);
            this.Controls.Add(this.tcprx);
            this.Controls.Add(this.tcpz);
            this.Controls.Add(this.tcpy);
            this.Controls.Add(this.tcpx);
            this.Controls.Add(this.j6degree);
            this.Controls.Add(this.j5degree);
            this.Controls.Add(this.j4degree);
            this.Controls.Add(this.j3degree);
            this.Controls.Add(this.j2degree);
            this.Controls.Add(this.j1degree);
            this.Controls.Add(this.deleterow);
            this.Controls.Add(this.showspeedpercent);
            this.Controls.Add(this.showjointsradian);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.stopthread);
            this.Controls.Add(this.startthread);
            this.Controls.Add(this.MoveL);
            this.Controls.Add(this.MoveJ);
            this.Controls.Add(this.showaxisposition);
            this.Controls.Add(this.showjointsdegree);
            this.Controls.Add(this.stop_thread);
            this.Controls.Add(this.start_thread);
            this.Controls.Add(this.movementdata);
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
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementdata)).EndInit();
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
        private System.Windows.Forms.DataGridView movementdata;
        private System.Windows.Forms.Button start_thread;
        private System.Windows.Forms.Button stop_thread;
        private System.Windows.Forms.Label showjointsdegree;
        private System.Windows.Forms.Label showaxisposition;
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
        private System.Windows.Forms.Label showjointsradian;
        private System.Windows.Forms.Label showspeedpercent;
        private System.Windows.Forms.Button deleterow;
        private System.Windows.Forms.Label j1degree;
        private System.Windows.Forms.Label j2degree;
        private System.Windows.Forms.Label j3degree;
        private System.Windows.Forms.Label j4degree;
        private System.Windows.Forms.Label j5degree;
        private System.Windows.Forms.Label j6degree;
        private System.Windows.Forms.Label tcprz;
        private System.Windows.Forms.Label tcpry;
        private System.Windows.Forms.Label tcprx;
        private System.Windows.Forms.Label tcpz;
        private System.Windows.Forms.Label tcpy;
        private System.Windows.Forms.Label tcpx;
        private System.Windows.Forms.Label j6radian;
        private System.Windows.Forms.Label j5radian;
        private System.Windows.Forms.Label j4radian;
        private System.Windows.Forms.Label j3radian;
        private System.Windows.Forms.Label j2radian;
        private System.Windows.Forms.Label j1radian;
        private System.Windows.Forms.Label label1;
    }
}

