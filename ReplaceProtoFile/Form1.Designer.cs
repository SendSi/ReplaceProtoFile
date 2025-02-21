using System;
using System.Windows.Forms;

namespace ReplaceProtoFile
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtProtoPath = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnUnityReplaceFile = new System.Windows.Forms.Button();
            this.btnReplaceTxt = new System.Windows.Forms.Button();
            this.lblExcInfo = new System.Windows.Forms.Label();
            this.txtUnityProtoPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSVN = new System.Windows.Forms.Button();
            this.btnProtoc = new System.Windows.Forms.Button();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("宋体", 12F);
            this.btnReplace.Location = new System.Drawing.Point(467, 64);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(142, 40);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Packet替换Pb";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtProtoPath
            // 
            this.txtProtoPath.Location = new System.Drawing.Point(19, 110);
            this.txtProtoPath.Name = "txtProtoPath";
            this.txtProtoPath.Size = new System.Drawing.Size(442, 21);
            this.txtProtoPath.TabIndex = 1;
            this.txtProtoPath.Text = "D:\\WorkProject\\UnityClient\\Proto\\protofiles\\protofile\\client";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(19, 95);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(131, 12);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "前端Proto的client目录";
            // 
            // btnUnityReplaceFile
            // 
            this.btnUnityReplaceFile.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUnityReplaceFile.Location = new System.Drawing.Point(467, 168);
            this.btnUnityReplaceFile.Name = "btnUnityReplaceFile";
            this.btnUnityReplaceFile.Size = new System.Drawing.Size(142, 40);
            this.btnUnityReplaceFile.TabIndex = 5;
            this.btnUnityReplaceFile.Text = "生成到Unity项目中";
            this.btnUnityReplaceFile.UseVisualStyleBackColor = true;
            this.btnUnityReplaceFile.Click += new System.EventHandler(this.btnUnityReplaceFile_Click);
            // 
            // btnReplaceTxt
            // 
            this.btnReplaceTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.btnReplaceTxt.Location = new System.Drawing.Point(467, 220);
            this.btnReplaceTxt.Name = "btnReplaceTxt";
            this.btnReplaceTxt.Size = new System.Drawing.Size(142, 40);
            this.btnReplaceTxt.TabIndex = 6;
            this.btnReplaceTxt.Text = "Unity的get;set";
            this.btnReplaceTxt.UseVisualStyleBackColor = true;
            this.btnReplaceTxt.Click += new System.EventHandler(this.btnReplaceTxt_Click);
            // 
            // lblExcInfo
            // 
            this.lblExcInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExcInfo.AutoSize = true;
            this.lblExcInfo.Font = new System.Drawing.Font("宋体", 15F);
            this.lblExcInfo.ForeColor = System.Drawing.Color.Red;
            this.lblExcInfo.Location = new System.Drawing.Point(98, 235);
            this.lblExcInfo.Name = "lblExcInfo";
            this.lblExcInfo.Size = new System.Drawing.Size(89, 20);
            this.lblExcInfo.TabIndex = 7;
            this.lblExcInfo.Text = "执行结果";
            this.lblExcInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnityProtoPath
            // 
            this.txtUnityProtoPath.Location = new System.Drawing.Point(19, 185);
            this.txtUnityProtoPath.Name = "txtUnityProtoPath";
            this.txtUnityProtoPath.Size = new System.Drawing.Size(442, 21);
            this.txtUnityProtoPath.TabIndex = 8;
            this.txtUnityProtoPath.Text = "D:\\WorkProject\\UnityClient\\Unity\\Assets\\Hotfix\\CodeGen\\Proto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unity的Proto生成net目录";
            // 
            // btnSVN
            // 
            this.btnSVN.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSVN.Location = new System.Drawing.Point(467, 12);
            this.btnSVN.Name = "btnSVN";
            this.btnSVN.Size = new System.Drawing.Size(142, 40);
            this.btnSVN.TabIndex = 13;
            this.btnSVN.Text = "SVN更新替换";
            this.btnSVN.UseVisualStyleBackColor = true;
            this.btnSVN.Click += new System.EventHandler(this.btnSVN_Click);
            // 
            // btnProtoc
            // 
            this.btnProtoc.Font = new System.Drawing.Font("宋体", 12F);
            this.btnProtoc.Location = new System.Drawing.Point(467, 116);
            this.btnProtoc.Name = "btnProtoc";
            this.btnProtoc.Size = new System.Drawing.Size(142, 40);
            this.btnProtoc.TabIndex = 14;
            this.btnProtoc.Text = "执行Protoc工具";
            this.btnProtoc.UseVisualStyleBackColor = true;
            this.btnProtoc.Click += new System.EventHandler(this.btnProtoc_Click);
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(19, 35);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(442, 21);
            this.txtServerPath.TabIndex = 15;
            this.txtServerPath.Text = "D:\\WorkProject\\Common\\Common_Simulation\\Common\\NetProto\\Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "后端Proto的Source目录";
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("宋体", 8F);
            this.btnAll.Location = new System.Drawing.Point(21, 229);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(61, 31);
            this.btnAll.TabIndex = 17;
            this.btnAll.Text = "无聊的人";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 274);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerPath);
            this.Controls.Add(this.btnProtoc);
            this.Controls.Add(this.btnSVN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnityProtoPath);
            this.Controls.Add(this.lblExcInfo);
            this.Controls.Add(this.btnReplaceTxt);
            this.Controls.Add(this.btnUnityReplaceFile);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtProtoPath);
            this.Controls.Add(this.btnReplace);
            this.Name = "Form1";
            this.Text = "手搓的~上不了台面的~关于Proto的~别吐槽";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtProtoPath;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnUnityReplaceFile;
        private System.Windows.Forms.Button btnReplaceTxt;
        private System.Windows.Forms.Label lblExcInfo;
        private System.Windows.Forms.TextBox txtUnityProtoPath;
        private System.Windows.Forms.Label label3;
        private Button btnSVN;
        private Button btnProtoc;
        private TextBox txtServerPath;
        private Label label4;
        private Button btnAll;
    }
}