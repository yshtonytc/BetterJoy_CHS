namespace BetterJoyForCemu {
    partial class SettingsGuide {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsGuide));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mysettings = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsinfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.git_add = new System.Windows.Forms.Button();
            this.xiyanblog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "选取设置: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "汉化: 曦颜XY  个人版本: 9.0_2021.12.27";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mysettings
            // 
            this.mysettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mysettings.FormattingEnabled = true;
            this.mysettings.Items.AddRange(new object[] {
            "**关于我**",
            "IP",
            "端口",
            "启用体感服务",
            "低频振动",
            "高频振动",
            "启用振动",
            "启用晃动输入",
            "晃动输入灵敏度",
            "晃动输入时间间隔",
            "交换AB键",
            "交换XY键",
            "允许手柄校准",
            "加速度传感器灵敏度",
            "陀螺仪敏感度",
            "摇杆1校准",
            "死区1",
            "摇杆2校准",
            "死区2",
            "陀螺仪模拟",
            "陀螺仪模拟敏感度",
            "清除影响设备",
            "清除白名单",
            "使用HIDG",
            "开启Home键LED灯",
            "使用渐进灯光",
            "陀螺仪使用Joycons或鼠标",
            "使用过滤的IMU",
            "AHRS_beta",
            "鼠标模拟陀螺仪敏感度X轴",
            "鼠标模拟陀螺仪敏感度Y轴",
            "摇杆陀螺仪敏感度X轴",
            "摇杆陀螺仪敏感度Y轴",
            "摇杆范围缩小参数",
            "通过按住或切换使用陀螺仪",
            "鼠标左陀螺仪",
            "鼠标拖动",
            "以XInput显示",
            "以DS4显示",
            "自动断开连接",
            "不使用时自动断开连接",
            "长按Home键断开连接",
            "双击改变Joycons方向",
            "不重复连接Joycons",
            "调试类型"});
            this.mysettings.Location = new System.Drawing.Point(126, 83);
            this.mysettings.Name = "mysettings";
            this.mysettings.Size = new System.Drawing.Size(346, 28);
            this.mysettings.TabIndex = 3;
            this.mysettings.SelectedIndexChanged += new System.EventHandler(this.mysettings_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "设置说明: ";
            // 
            // settingsinfo
            // 
            this.settingsinfo.Location = new System.Drawing.Point(126, 130);
            this.settingsinfo.Multiline = true;
            this.settingsinfo.Name = "settingsinfo";
            this.settingsinfo.ReadOnly = true;
            this.settingsinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.settingsinfo.Size = new System.Drawing.Size(346, 148);
            this.settingsinfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "说明：原作者GitHub搜Davidobot，本人只负责国内本地化。";
            // 
            // git_add
            // 
            this.git_add.Location = new System.Drawing.Point(129, 292);
            this.git_add.Name = "git_add";
            this.git_add.Size = new System.Drawing.Size(110, 29);
            this.git_add.TabIndex = 7;
            this.git_add.Text = "浏览开源代码";
            this.git_add.UseVisualStyleBackColor = true;
            this.git_add.Click += new System.EventHandler(this.git_add_Click);
            // 
            // xiyanblog
            // 
            this.xiyanblog.Location = new System.Drawing.Point(363, 292);
            this.xiyanblog.Name = "xiyanblog";
            this.xiyanblog.Size = new System.Drawing.Size(109, 29);
            this.xiyanblog.TabIndex = 8;
            this.xiyanblog.Text = "访问曦颜博客";
            this.xiyanblog.UseVisualStyleBackColor = true;
            this.xiyanblog.Click += new System.EventHandler(this.xiyanblog_Click);
            // 
            // SettingsGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.xiyanblog);
            this.Controls.Add(this.git_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.settingsinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mysettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置指南";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mysettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox settingsinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button git_add;
        private System.Windows.Forms.Button xiyanblog;
    }
}
