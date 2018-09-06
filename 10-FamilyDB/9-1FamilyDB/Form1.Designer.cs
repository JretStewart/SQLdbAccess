namespace _9_1FamilyDB
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
            this.components = new System.ComponentModel.Container();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnClose = new System.Windows.Forms.Button();
            this.lblExc = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInstruct = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnLoad
            // 
            this.bttnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLoad.Location = new System.Drawing.Point(62, 173);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(175, 46);
            this.bttnLoad.TabIndex = 1;
            this.bttnLoad.Text = "Load Data";
            this.bttnLoad.UseVisualStyleBackColor = true;
            this.bttnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.Location = new System.Drawing.Point(62, 624);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(175, 46);
            this.bttnClear.TabIndex = 3;
            this.bttnClear.Text = "Clear List";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnClose
            // 
            this.bttnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClose.Location = new System.Drawing.Point(508, 624);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(194, 46);
            this.bttnClose.TabIndex = 4;
            this.bttnClose.Text = "Close Connection";
            this.bttnClose.UseVisualStyleBackColor = true;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // lblExc
            // 
            this.lblExc.AutoSize = true;
            this.lblExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExc.Location = new System.Drawing.Point(58, 700);
            this.lblExc.Name = "lblExc";
            this.lblExc.Size = new System.Drawing.Size(0, 25);
            this.lblExc.TabIndex = 5;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(523, 184);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(179, 25);
            this.lblCon.TabIndex = 6;
            this.lblCon.Text = "Connection Closed";
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.Location = new System.Drawing.Point(63, 46);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(229, 35);
            this.tbServer.TabIndex = 7;
            this.tbServer.Text = "stusql.otc.edu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruct.Location = new System.Drawing.Point(60, 13);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(205, 25);
            this.lblInstruct.TabIndex = 8;
            this.lblInstruct.Text = "Enter Server Address:";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(62, 123);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(229, 35);
            this.tbUser.TabIndex = 9;
            this.tbUser.Text = "js0170337";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(60, 95);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(159, 25);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Enter Username:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(340, 639);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 20);
            this.lblTimer.TabIndex = 11;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(63, 272);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 28;
            this.dgView.Size = new System.Drawing.Size(642, 323);
            this.dgView.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.bttnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 740);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblExc);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnLoad);
            this.Name = "Form1";
            this.Text = "Database Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Label lblExc;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridView dgView;
    }
}

