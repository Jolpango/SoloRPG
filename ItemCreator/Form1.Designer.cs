namespace ItemCreator
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDamage = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.richTextBoxXmlCode = new System.Windows.Forms.RichTextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxPath2 = new System.Windows.Forms.TextBox();
            this.textBoxArmour = new System.Windows.Forms.TextBox();
            this.textBoxInformation2 = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonGenerateArmour = new System.Windows.Forms.Button();
            this.textBoxPrice2 = new System.Windows.Forms.TextBox();
            this.comboBoxRarity = new System.Windows.Forms.ComboBox();
            this.comboBoxRarity2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxDamage
            // 
            this.textBoxDamage.Location = new System.Drawing.Point(13, 59);
            this.textBoxDamage.Name = "textBoxDamage";
            this.textBoxDamage.Size = new System.Drawing.Size(100, 20);
            this.textBoxDamage.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(13, 85);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(11, 187);
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.Size = new System.Drawing.Size(367, 20);
            this.textBoxInformation.TabIndex = 4;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(119, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(85, 169);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Weapon Creator\r\n\r\nName\r\n\r\nDamage\r\n\r\nPrice\r\n\r\nImage Path\r\n\r\nRarity\r\n\r\nInformation";
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // richTextBoxXmlCode
            // 
            this.richTextBoxXmlCode.Enabled = false;
            this.richTextBoxXmlCode.Location = new System.Drawing.Point(11, 213);
            this.richTextBoxXmlCode.Name = "richTextBoxXmlCode";
            this.richTextBoxXmlCode.Size = new System.Drawing.Size(367, 96);
            this.richTextBoxXmlCode.TabIndex = 6;
            this.richTextBoxXmlCode.Text = "";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(11, 315);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(13, 112);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(100, 20);
            this.textBoxPath.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 195);
            this.label1.TabIndex = 9;
            this.label1.Text = "Armour Creator\r\n\r\nType\r\n\r\nName\r\n\r\nPath\r\n\r\nArmourValue\r\n\r\nPrice\r\n\r\nRarity\r\n\r\nInfor" +
    "mation\r\n";
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(12, 401);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 20);
            this.textBoxName2.TabIndex = 10;
            // 
            // textBoxPath2
            // 
            this.textBoxPath2.Location = new System.Drawing.Point(12, 427);
            this.textBoxPath2.Name = "textBoxPath2";
            this.textBoxPath2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPath2.TabIndex = 11;
            // 
            // textBoxArmour
            // 
            this.textBoxArmour.Location = new System.Drawing.Point(13, 453);
            this.textBoxArmour.Name = "textBoxArmour";
            this.textBoxArmour.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmour.TabIndex = 12;
            // 
            // textBoxInformation2
            // 
            this.textBoxInformation2.Location = new System.Drawing.Point(10, 551);
            this.textBoxInformation2.Name = "textBoxInformation2";
            this.textBoxInformation2.Size = new System.Drawing.Size(368, 20);
            this.textBoxInformation2.TabIndex = 13;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxType.Items.AddRange(new object[] {
            "Head",
            "Chest",
            "Offhand",
            "Feet"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 374);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(101, 21);
            this.comboBoxType.TabIndex = 15;
            // 
            // buttonGenerateArmour
            // 
            this.buttonGenerateArmour.Location = new System.Drawing.Point(11, 577);
            this.buttonGenerateArmour.Name = "buttonGenerateArmour";
            this.buttonGenerateArmour.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateArmour.TabIndex = 16;
            this.buttonGenerateArmour.Text = "Generate";
            this.buttonGenerateArmour.UseVisualStyleBackColor = true;
            this.buttonGenerateArmour.Click += new System.EventHandler(this.buttonGenerateArmour_Click);
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.Location = new System.Drawing.Point(13, 480);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice2.TabIndex = 17;
            // 
            // comboBoxRarity
            // 
            this.comboBoxRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRarity.FormattingEnabled = true;
            this.comboBoxRarity.Items.AddRange(new object[] {
            "Common",
            "Rare",
            "Epic",
            "Legendary"});
            this.comboBoxRarity.Location = new System.Drawing.Point(13, 138);
            this.comboBoxRarity.Name = "comboBoxRarity";
            this.comboBoxRarity.Size = new System.Drawing.Size(99, 21);
            this.comboBoxRarity.TabIndex = 18;
            // 
            // comboBoxRarity2
            // 
            this.comboBoxRarity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRarity2.FormattingEnabled = true;
            this.comboBoxRarity2.Items.AddRange(new object[] {
            "Common",
            "Rare",
            "Epic",
            "Legendary"});
            this.comboBoxRarity2.Location = new System.Drawing.Point(11, 506);
            this.comboBoxRarity2.Name = "comboBoxRarity2";
            this.comboBoxRarity2.Size = new System.Drawing.Size(99, 21);
            this.comboBoxRarity2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 612);
            this.Controls.Add(this.comboBoxRarity2);
            this.Controls.Add(this.comboBoxRarity);
            this.Controls.Add(this.textBoxPrice2);
            this.Controls.Add(this.buttonGenerateArmour);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxInformation2);
            this.Controls.Add(this.textBoxArmour);
            this.Controls.Add(this.textBoxPath2);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.richTextBoxXmlCode);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDamage);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "ItemCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDamage;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RichTextBox richTextBoxXmlCode;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxPath2;
        private System.Windows.Forms.TextBox textBoxArmour;
        private System.Windows.Forms.TextBox textBoxInformation2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonGenerateArmour;
        private System.Windows.Forms.TextBox textBoxPrice2;
        private System.Windows.Forms.ComboBox comboBoxRarity;
        private System.Windows.Forms.ComboBox comboBoxRarity2;
    }
}

