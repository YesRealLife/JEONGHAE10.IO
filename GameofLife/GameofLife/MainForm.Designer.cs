﻿namespace GameofLife
{
    partial class MainForm
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
            this.textBox_FlyNum = new System.Windows.Forms.TextBox();
            this.textBox_MajesticNum = new System.Windows.Forms.TextBox();
            this.textBox_DeadlyNum = new System.Windows.Forms.TextBox();
            this.label_FlyNum = new System.Windows.Forms.Label();
            this.label_MajesticNum = new System.Windows.Forms.Label();
            this.label_DeadlyNums = new System.Windows.Forms.Label();
            this.textBox_Rows = new System.Windows.Forms.TextBox();
            this.textBox_Columns = new System.Windows.Forms.TextBox();
            this.label_Cols = new System.Windows.Forms.Label();
            this.label_Rows = new System.Windows.Forms.Label();
            this.button_Next = new System.Windows.Forms.Button();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.button_ContinueFromManualSelect = new System.Windows.Forms.Button();
            this.groupBox_manualSelect = new System.Windows.Forms.GroupBox();
            this.radioButton_ManualDeadly = new System.Windows.Forms.RadioButton();
            this.radioButton_ManualFly = new System.Windows.Forms.RadioButton();
            this.radioButton_ManualMimic = new System.Windows.Forms.RadioButton();
            this.button_ManualLoad = new System.Windows.Forms.Button();
            this.radioButton_Manual = new System.Windows.Forms.RadioButton();
            this.radioButton_Auto = new System.Windows.Forms.RadioButton();
            this.label_genCount = new System.Windows.Forms.Label();
            this.label_generationNum = new System.Windows.Forms.Label();
            this.textBox_generationNum = new System.Windows.Forms.TextBox();
            this.button_Restart = new System.Windows.Forms.Button();
            this.label_DeadlyCount = new System.Windows.Forms.Label();
            this.label_MajesticCount = new System.Windows.Forms.Label();
            this.label_FlyCount = new System.Windows.Forms.Label();
            this.timer_Game = new System.Windows.Forms.Timer(this.components);
            this.button_AutoLoad = new System.Windows.Forms.Button();
            this.groupBox_Control.SuspendLayout();
            this.groupBox_manualSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FlyNum
            // 
            this.textBox_FlyNum.Location = new System.Drawing.Point(77, 14);
            this.textBox_FlyNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FlyNum.Name = "textBox_FlyNum";
            this.textBox_FlyNum.Size = new System.Drawing.Size(28, 22);
            this.textBox_FlyNum.TabIndex = 53;
            // 
            // textBox_MajesticNum
            // 
            this.textBox_MajesticNum.Location = new System.Drawing.Point(77, 43);
            this.textBox_MajesticNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MajesticNum.Name = "textBox_MajesticNum";
            this.textBox_MajesticNum.Size = new System.Drawing.Size(28, 22);
            this.textBox_MajesticNum.TabIndex = 54;
            // 
            // textBox_DeadlyNum
            // 
            this.textBox_DeadlyNum.Location = new System.Drawing.Point(77, 74);
            this.textBox_DeadlyNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DeadlyNum.Name = "textBox_DeadlyNum";
            this.textBox_DeadlyNum.Size = new System.Drawing.Size(28, 22);
            this.textBox_DeadlyNum.TabIndex = 55;
            // 
            // label_FlyNum
            // 
            this.label_FlyNum.AutoSize = true;
            this.label_FlyNum.Location = new System.Drawing.Point(32, 18);
            this.label_FlyNum.Name = "label_FlyNum";
            this.label_FlyNum.Size = new System.Drawing.Size(38, 17);
            this.label_FlyNum.TabIndex = 56;
            this.label_FlyNum.Text = "Fly #";
            this.label_FlyNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_MajesticNum
            // 
            this.label_MajesticNum.AutoSize = true;
            this.label_MajesticNum.Location = new System.Drawing.Point(-1, 48);
            this.label_MajesticNum.Name = "label_MajesticNum";
            this.label_MajesticNum.Size = new System.Drawing.Size(71, 17);
            this.label_MajesticNum.TabIndex = 57;
            this.label_MajesticNum.Text = "Majestic #";
            // 
            // label_DeadlyNums
            // 
            this.label_DeadlyNums.AutoSize = true;
            this.label_DeadlyNums.Location = new System.Drawing.Point(5, 78);
            this.label_DeadlyNums.Name = "label_DeadlyNums";
            this.label_DeadlyNums.Size = new System.Drawing.Size(64, 17);
            this.label_DeadlyNums.TabIndex = 58;
            this.label_DeadlyNums.Text = "Deadly #";
            // 
            // textBox_Rows
            // 
            this.textBox_Rows.Location = new System.Drawing.Point(220, 15);
            this.textBox_Rows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Rows.Name = "textBox_Rows";
            this.textBox_Rows.Size = new System.Drawing.Size(31, 22);
            this.textBox_Rows.TabIndex = 59;
            // 
            // textBox_Columns
            // 
            this.textBox_Columns.Location = new System.Drawing.Point(220, 46);
            this.textBox_Columns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Columns.Name = "textBox_Columns";
            this.textBox_Columns.Size = new System.Drawing.Size(31, 22);
            this.textBox_Columns.TabIndex = 60;
            // 
            // label_Cols
            // 
            this.label_Cols.AutoSize = true;
            this.label_Cols.Location = new System.Drawing.Point(167, 18);
            this.label_Cols.Name = "label_Cols";
            this.label_Cols.Size = new System.Drawing.Size(47, 17);
            this.label_Cols.TabIndex = 61;
            this.label_Cols.Text = "Row #";
            this.label_Cols.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Rows
            // 
            this.label_Rows.AutoSize = true;
            this.label_Rows.Location = new System.Drawing.Point(167, 48);
            this.label_Rows.Name = "label_Rows";
            this.label_Rows.Size = new System.Drawing.Size(40, 17);
            this.label_Rows.TabIndex = 62;
            this.label_Rows.Text = "Col #";
            this.label_Rows.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(328, 12);
            this.button_Next.Margin = new System.Windows