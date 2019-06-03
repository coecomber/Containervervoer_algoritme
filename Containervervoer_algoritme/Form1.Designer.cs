namespace Containervervoer_algoritme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_IsCooled = new System.Windows.Forms.CheckBox();
            this.checkBox_IsValuable = new System.Windows.Forms.CheckBox();
            this.btn_AddContainer = new System.Windows.Forms.Button();
            this.numericUpDown_Weight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SortContainers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_EditShip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_VerticalRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_HorizontalRows = new System.Windows.Forms.NumericUpDown();
            this.listBox_ContainersToDistribute = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_MaxWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VerticalRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HorizontalRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_IsCooled);
            this.groupBox1.Controls.Add(this.checkBox_IsValuable);
            this.groupBox1.Controls.Add(this.btn_AddContainer);
            this.groupBox1.Controls.Add(this.numericUpDown_Weight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Container toevoegen";
            // 
            // checkBox_IsCooled
            // 
            this.checkBox_IsCooled.AutoSize = true;
            this.checkBox_IsCooled.Location = new System.Drawing.Point(10, 88);
            this.checkBox_IsCooled.Name = "checkBox_IsCooled";
            this.checkBox_IsCooled.Size = new System.Drawing.Size(174, 17);
            this.checkBox_IsCooled.TabIndex = 8;
            this.checkBox_IsCooled.Text = "Moet gekoeld vervoerd worden";
            this.checkBox_IsCooled.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsValuable
            // 
            this.checkBox_IsValuable.AutoSize = true;
            this.checkBox_IsValuable.Location = new System.Drawing.Point(10, 65);
            this.checkBox_IsValuable.Name = "checkBox_IsValuable";
            this.checkBox_IsValuable.Size = new System.Drawing.Size(86, 17);
            this.checkBox_IsValuable.TabIndex = 7;
            this.checkBox_IsValuable.Text = "Is waardevol";
            this.checkBox_IsValuable.UseVisualStyleBackColor = true;
            // 
            // btn_AddContainer
            // 
            this.btn_AddContainer.Location = new System.Drawing.Point(108, 129);
            this.btn_AddContainer.Name = "btn_AddContainer";
            this.btn_AddContainer.Size = new System.Drawing.Size(75, 23);
            this.btn_AddContainer.TabIndex = 6;
            this.btn_AddContainer.Text = "Toevoegen";
            this.btn_AddContainer.UseVisualStyleBackColor = true;
            this.btn_AddContainer.Click += new System.EventHandler(this.Btn_AddContainer_Click);
            // 
            // numericUpDown_Weight
            // 
            this.numericUpDown_Weight.Location = new System.Drawing.Point(63, 30);
            this.numericUpDown_Weight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown_Weight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown_Weight.Name = "numericUpDown_Weight";
            this.numericUpDown_Weight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Weight.TabIndex = 3;
            this.numericUpDown_Weight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gewicht";
            // 
            // btn_SortContainers
            // 
            this.btn_SortContainers.Location = new System.Drawing.Point(108, 186);
            this.btn_SortContainers.Name = "btn_SortContainers";
            this.btn_SortContainers.Size = new System.Drawing.Size(258, 35);
            this.btn_SortContainers.TabIndex = 1;
            this.btn_SortContainers.Text = "Deel containers in";
            this.btn_SortContainers.UseVisualStyleBackColor = true;
            this.btn_SortContainers.Click += new System.EventHandler(this.Btn_SortContainers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_MaxWeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_EditShip);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_VerticalRows);
            this.groupBox2.Controls.Add(this.numericUpDown_HorizontalRows);
            this.groupBox2.Location = new System.Drawing.Point(221, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schip instellen";
            // 
            // btn_EditShip
            // 
            this.btn_EditShip.Location = new System.Drawing.Point(132, 129);
            this.btn_EditShip.Name = "btn_EditShip";
            this.btn_EditShip.Size = new System.Drawing.Size(103, 23);
            this.btn_EditShip.TabIndex = 4;
            this.btn_EditShip.Text = "Schip bijwerken";
            this.btn_EditShip.UseVisualStyleBackColor = true;
            this.btn_EditShip.Click += new System.EventHandler(this.Btn_EditShip_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Verticale rijen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horizontale rijen";
            // 
            // numericUpDown_VerticalRows
            // 
            this.numericUpDown_VerticalRows.Location = new System.Drawing.Point(115, 55);
            this.numericUpDown_VerticalRows.Name = "numericUpDown_VerticalRows";
            this.numericUpDown_VerticalRows.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_VerticalRows.TabIndex = 1;
            // 
            // numericUpDown_HorizontalRows
            // 
            this.numericUpDown_HorizontalRows.Location = new System.Drawing.Point(115, 29);
            this.numericUpDown_HorizontalRows.Name = "numericUpDown_HorizontalRows";
            this.numericUpDown_HorizontalRows.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_HorizontalRows.TabIndex = 0;
            // 
            // listBox_ContainersToDistribute
            // 
            this.listBox_ContainersToDistribute.FormattingEnabled = true;
            this.listBox_ContainersToDistribute.Location = new System.Drawing.Point(13, 277);
            this.listBox_ContainersToDistribute.Name = "listBox_ContainersToDistribute";
            this.listBox_ContainersToDistribute.Size = new System.Drawing.Size(466, 225);
            this.listBox_ContainersToDistribute.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Containers om op een schip te plaatsen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum gewicht";
            // 
            // numericUpDown_MaxWeight
            // 
            this.numericUpDown_MaxWeight.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_MaxWeight.Location = new System.Drawing.Point(115, 81);
            this.numericUpDown_MaxWeight.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDown_MaxWeight.Name = "numericUpDown_MaxWeight";
            this.numericUpDown_MaxWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_MaxWeight.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_ContainersToDistribute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_SortContainers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Containervervoer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VerticalRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HorizontalRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddContainer;
        private System.Windows.Forms.NumericUpDown numericUpDown_Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SortContainers;
        private System.Windows.Forms.CheckBox checkBox_IsCooled;
        private System.Windows.Forms.CheckBox checkBox_IsValuable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_EditShip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_VerticalRows;
        private System.Windows.Forms.NumericUpDown numericUpDown_HorizontalRows;
        private System.Windows.Forms.ListBox listBox_ContainersToDistribute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxWeight;
        private System.Windows.Forms.Label label5;
    }
}

