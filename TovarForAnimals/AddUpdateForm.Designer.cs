
namespace TovarForAnimals
{
    partial class AddUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateForm));
            this.InsertImage = new System.Windows.Forms.Button();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelIsm = new System.Windows.Forms.Label();
            this.labelOstatok = new System.Windows.Forms.Label();
            this.TextBoxIsm = new System.Windows.Forms.TextBox();
            this.TextBoxOstatok = new System.Windows.Forms.TextBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertImage
            // 
            this.InsertImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.InsertImage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertImage.Location = new System.Drawing.Point(467, 285);
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(168, 42);
            this.InsertImage.TabIndex = 39;
            this.InsertImage.Text = "Выбрать картинку";
            this.InsertImage.UseVisualStyleBackColor = false;
            this.InsertImage.Click += new System.EventHandler(this.InsertImage_Click);
            // 
            // UserImage
            // 
            this.UserImage.Location = new System.Drawing.Point(490, 192);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(112, 87);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserImage.TabIndex = 38;
            this.UserImage.TabStop = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(72, 216);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(92, 23);
            this.labelCost.TabIndex = 36;
            this.labelCost.Text = "Стоимость";
            // 
            // labelIsm
            // 
            this.labelIsm.AutoSize = true;
            this.labelIsm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsm.Location = new System.Drawing.Point(2, 177);
            this.labelIsm.Name = "labelIsm";
            this.labelIsm.Size = new System.Drawing.Size(162, 23);
            this.labelIsm.TabIndex = 34;
            this.labelIsm.Text = "Единица измерения";
            // 
            // labelOstatok
            // 
            this.labelOstatok.AutoSize = true;
            this.labelOstatok.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOstatok.Location = new System.Drawing.Point(23, 133);
            this.labelOstatok.Name = "labelOstatok";
            this.labelOstatok.Size = new System.Drawing.Size(141, 23);
            this.labelOstatok.TabIndex = 33;
            this.labelOstatok.Text = "Кол-во на складе";
            // 
            // TextBoxIsm
            // 
            this.TextBoxIsm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxIsm.Location = new System.Drawing.Point(190, 170);
            this.TextBoxIsm.MaxLength = 50;
            this.TextBoxIsm.Name = "TextBoxIsm";
            this.TextBoxIsm.Size = new System.Drawing.Size(170, 30);
            this.TextBoxIsm.TabIndex = 32;
            // 
            // TextBoxOstatok
            // 
            this.TextBoxOstatok.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOstatok.Location = new System.Drawing.Point(190, 130);
            this.TextBoxOstatok.MaxLength = 50;
            this.TextBoxOstatok.Name = "TextBoxOstatok";
            this.TextBoxOstatok.Size = new System.Drawing.Size(170, 30);
            this.TextBoxOstatok.TabIndex = 30;
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCost.Location = new System.Drawing.Point(190, 213);
            this.TextBoxCost.MaxLength = 50;
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.Size = new System.Drawing.Size(170, 30);
            this.TextBoxCost.TabIndex = 29;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(76, 87);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(88, 23);
            this.labelType.TabIndex = 28;
            this.labelType.Text = "Категория";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.Location = new System.Drawing.Point(190, 48);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(170, 30);
            this.TextBoxName.TabIndex = 27;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(43, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 23);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Наименование";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxId.Location = new System.Drawing.Point(190, 9);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(170, 30);
            this.TextBoxId.TabIndex = 25;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelId.Location = new System.Drawing.Point(88, 16);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(76, 23);
            this.LabelId.TabIndex = 24;
            this.LabelId.Text = "Артикул";
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.AcceptButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(155, 342);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(205, 47);
            this.AcceptButton.TabIndex = 23;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(190, 84);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(170, 31);
            this.comboBoxType.TabIndex = 43;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(501, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(86, 23);
            this.labelInfo.TabIndex = 44;
            this.labelInfo.Text = "Описание";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(420, 41);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(256, 138);
            this.textBoxInfo.TabIndex = 45;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.Location = new System.Drawing.Point(67, 253);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(97, 23);
            this.labelPost.TabIndex = 49;
            this.labelPost.Text = "Поставщик";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPost.Location = new System.Drawing.Point(190, 253);
            this.textBoxPost.MaxLength = 50;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(170, 30);
            this.textBoxPost.TabIndex = 48;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(550, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 47);
            this.buttonExit.TabIndex = 50;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 422);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.InsertImage);
            this.Controls.Add(this.UserImage);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelIsm);
            this.Controls.Add(this.labelOstatok);
            this.Controls.Add(this.TextBoxIsm);
            this.Controls.Add(this.TextBoxOstatok);
            this.Controls.Add(this.TextBoxCost);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.AcceptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdateForm";
            this.Text = "Изменение данных";
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InsertImage;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelIsm;
        private System.Windows.Forms.Label labelOstatok;
        private System.Windows.Forms.TextBox TextBoxIsm;
        private System.Windows.Forms.TextBox TextBoxOstatok;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonExit;
    }
}