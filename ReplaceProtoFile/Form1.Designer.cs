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
            this.txtOriOutPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSVN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("宋体", 12F);
            this.btnReplace.Location = new System.Drawing.Point(564, 50);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(142, 40);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "替换";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtProtoPath
            // 
            this.txtProtoPath.Location = new System.Drawing.Point(137, 59);
            this.txtProtoPath.Name = "txtProtoPath";
            this.txtProtoPath.Size = new System.Drawing.Size(408, 21);
            this.txtProtoPath.TabIndex = 1;
            this.txtProtoPath.Text = "D:\\WorkProject\\UnityClient\\Proto\\protofiles\\protofile\\client";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(10, 64);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(119, 12);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "目录下的*.proto文件";
            // 
            // btnUnityReplaceFile
            // 
            this.btnUnityReplaceFile.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUnityReplaceFile.Location = new System.Drawing.Point(564, 155);
            this.btnUnityReplaceFile.Name = "btnUnityReplaceFile";
            this.btnUnityReplaceFile.Size = new System.Drawing.Size(142, 40);
            this.btnUnityReplaceFile.TabIndex = 5;
            this.btnUnityReplaceFile.Text = "Unity替换文件";
            this.btnUnityReplaceFile.UseVisualStyleBackColor = true;
            this.btnUnityReplaceFile.Click += new System.EventHandler(this.btnUnityReplaceFile_Click);
            // 
            // btnReplaceTxt
            // 
            this.btnReplaceTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.btnReplaceTxt.Location = new System.Drawing.Point(564, 215);
            this.btnReplaceTxt.Name = "btnReplaceTxt";
            this.btnReplaceTxt.Size = new System.Drawing.Size(142, 40);
            this.btnReplaceTxt.TabIndex = 6;
            this.btnReplaceTxt.Text = "文字替换";
            this.btnReplaceTxt.UseVisualStyleBackColor = true;
            this.btnReplaceTxt.Click += new System.EventHandler(this.btnReplaceTxt_Click);
            // 
            // lblExcInfo
            // 
            this.lblExcInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExcInfo.AutoSize = true;
            this.lblExcInfo.Font = new System.Drawing.Font("宋体", 15F);
            this.lblExcInfo.ForeColor = System.Drawing.Color.Red;
            this.lblExcInfo.Location = new System.Drawing.Point(288, 263);
            this.lblExcInfo.Name = "lblExcInfo";
            this.lblExcInfo.Size = new System.Drawing.Size(49, 20);
            this.lblExcInfo.TabIndex = 7;
            this.lblExcInfo.Text = "信息";
            this.lblExcInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnityProtoPath
            // 
            this.txtUnityProtoPath.Location = new System.Drawing.Point(137, 168);
            this.txtUnityProtoPath.Name = "txtUnityProtoPath";
            this.txtUnityProtoPath.Size = new System.Drawing.Size(408, 21);
            this.txtUnityProtoPath.TabIndex = 8;
            this.txtUnityProtoPath.Text = "D:\\WorkProject\\UnityClient\\Unity\\Assets\\Hotfix\\CodeGen\\Proto";
            // 
            // txtOriOutPath
            // 
            this.txtOriOutPath.Location = new System.Drawing.Point(137, 215);
            this.txtOriOutPath.Name = "txtOriOutPath";
            this.txtOriOutPath.Size = new System.Drawing.Size(408, 21);
            this.txtOriOutPath.TabIndex = 9;
            this.txtOriOutPath.Text = "D:\\WorkProject\\UnityClient\\Proto\\out\\cs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "bat生成的输出目录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unity的Proto生成目录";
            // 
            // btnSVN
            // 
            this.btnSVN.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSVN.Location = new System.Drawing.Point(564, 4);
            this.btnSVN.Name = "btnSVN";
            this.btnSVN.Size = new System.Drawing.Size(142, 40);
            this.btnSVN.TabIndex = 13;
            this.btnSVN.Text = "SVN更新替换";
            this.btnSVN.UseVisualStyleBackColor = true;
            this.btnSVN.Click += new System.EventHandler(this.btnSVN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(564, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Protoc工具";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(137, 17);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(408, 21);
            this.txtServerPath.TabIndex = 15;
            this.txtServerPath.Text = "D:\\WorkProject\\Common\\Common_Simulation\\Common\\NetProto\\Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "后端目录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSVN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOriOutPath);
            this.Controls.Add(this.txtUnityProtoPath);
            this.Controls.Add(this.lblExcInfo);
            this.Controls.Add(this.btnReplaceTxt);
            this.Controls.Add(this.btnUnityReplaceFile);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtProtoPath);
            this.Controls.Add(this.btnReplace);
            this.Name = "Form1";
            this.Text = "手搓的~上不了台面的~关于Proto的";
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
        private System.Windows.Forms.TextBox txtOriOutPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Button btnSVN;
        private Button button1;
        private TextBox txtServerPath;
        private Label label4;
    }
}