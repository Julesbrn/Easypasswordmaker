namespace EasyPasswordMaker2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.TextBox();
            this.wName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.lNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.wNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.numTip = new System.Windows.Forms.ToolTip(this.components);
            this.lenTip = new System.Windows.Forms.ToolTip(this.components);
            this.clipTip = new System.Windows.Forms.ToolTip(this.components);
            this.fnq = new System.Windows.Forms.Button();
            this.lnq = new System.Windows.Forms.Button();
            this.wnq = new System.Windows.Forms.Button();
            this.nq = new System.Windows.Forms.Button();
            this.lq = new System.Windows.Forms.Button();
            this.cq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // fName
            // 
            resources.ApplyResources(this.fName, "fName");
            this.fName.Name = "fName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // outbox
            // 
            resources.ApplyResources(this.outbox, "outbox");
            this.outbox.Name = "outbox";
            this.outbox.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lName
            // 
            resources.ApplyResources(this.lName, "lName");
            this.lName.Name = "lName";
            // 
            // wName
            // 
            resources.ApplyResources(this.wName, "wName");
            this.wName.Name = "wName";
            this.wName.TextChanged += new System.EventHandler(this.wName_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // num
            // 
            resources.ApplyResources(this.num, "num");
            this.num.Name = "num";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // passLength
            // 
            resources.ApplyResources(this.passLength, "passLength");
            this.passLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.passLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passLength.Name = "passLength";
            this.passLength.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // fNameTip
            // 
            this.fNameTip.AutomaticDelay = 100;
            this.fNameTip.AutoPopDelay = 10000;
            this.fNameTip.InitialDelay = 100;
            this.fNameTip.ReshowDelay = 0;
            // 
            // lNameTip
            // 
            this.lNameTip.AutomaticDelay = 100;
            this.lNameTip.AutoPopDelay = 10000;
            this.lNameTip.InitialDelay = 100;
            this.lNameTip.ReshowDelay = 0;
            // 
            // wNameTip
            // 
            this.wNameTip.AutomaticDelay = 100;
            this.wNameTip.AutoPopDelay = 10000;
            this.wNameTip.InitialDelay = 100;
            this.wNameTip.ReshowDelay = 0;
            // 
            // numTip
            // 
            this.numTip.AutomaticDelay = 100;
            this.numTip.AutoPopDelay = 10000;
            this.numTip.InitialDelay = 100;
            this.numTip.ReshowDelay = 20;
            // 
            // lenTip
            // 
            this.lenTip.AutomaticDelay = 100;
            this.lenTip.AutoPopDelay = 10000;
            this.lenTip.InitialDelay = 100;
            this.lenTip.ReshowDelay = 20;
            // 
            // clipTip
            // 
            this.clipTip.AutomaticDelay = 100;
            this.clipTip.AutoPopDelay = 10000;
            this.clipTip.InitialDelay = 100;
            this.clipTip.ReshowDelay = 20;
            // 
            // fnq
            // 
            resources.ApplyResources(this.fnq, "fnq");
            this.fnq.Name = "fnq";
            this.fnq.UseVisualStyleBackColor = true;
            this.fnq.Click += new System.EventHandler(this.fnq_Click);
            // 
            // lnq
            // 
            resources.ApplyResources(this.lnq, "lnq");
            this.lnq.Name = "lnq";
            this.lnq.UseVisualStyleBackColor = true;
            // 
            // wnq
            // 
            resources.ApplyResources(this.wnq, "wnq");
            this.wnq.Name = "wnq";
            this.wnq.UseVisualStyleBackColor = true;
            // 
            // nq
            // 
            resources.ApplyResources(this.nq, "nq");
            this.nq.Name = "nq";
            this.nq.UseVisualStyleBackColor = true;
            // 
            // lq
            // 
            resources.ApplyResources(this.lq, "lq");
            this.lq.Name = "lq";
            this.lq.UseVisualStyleBackColor = true;
            // 
            // cq
            // 
            resources.ApplyResources(this.cq, "cq");
            this.cq.Name = "cq";
            this.cq.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cq);
            this.Controls.Add(this.lq);
            this.Controls.Add(this.nq);
            this.Controls.Add(this.wnq);
            this.Controls.Add(this.lnq);
            this.Controls.Add(this.fnq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox wName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown passLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip fNameTip;
        private System.Windows.Forms.ToolTip lNameTip;
        private System.Windows.Forms.ToolTip wNameTip;
        private System.Windows.Forms.ToolTip numTip;
        private System.Windows.Forms.ToolTip lenTip;
        private System.Windows.Forms.ToolTip clipTip;
        private System.Windows.Forms.Button fnq;
        private System.Windows.Forms.Button lnq;
        private System.Windows.Forms.Button wnq;
        private System.Windows.Forms.Button nq;
        private System.Windows.Forms.Button lq;
        private System.Windows.Forms.Button cq;
    }
}

