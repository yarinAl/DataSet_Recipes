
namespace targil_3__DataSet
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
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMeat = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbVegan = new System.Windows.Forms.RadioButton();
            this.rbVegetarian = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.ChooseRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(28, 154);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 62;
            this.dgvRecipes.Size = new System.Drawing.Size(528, 375);
            this.dgvRecipes.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(768, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "קטגוריה:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "עוגות",
            "עוגיות",
            "סלטים",
            "מאפים",
            "תבשילים",
            "פשטידות",
            "עוף",
            "דגים",
            "דיאטטים",
            "פיצה",
            "תוספות",
            "אורז",
            "ירקות",
            "לחמים",
            "קינוחים",
            "פסטה",
            "ללא גלוטן",
            "ראשונות",
            "ילדים",
            "בשר",
            "משקאות",
            "מרקים",
            "ארוחות בוקר"});
            this.cbCategory.Location = new System.Drawing.Point(578, 225);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCategory.Size = new System.Drawing.Size(180, 28);
            this.cbCategory.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMeat);
            this.groupBox1.Controls.Add(this.rbRegular);
            this.groupBox1.Controls.Add(this.rbVegan);
            this.groupBox1.Controls.Add(this.rbVegetarian);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(892, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 194);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "סוג מתכון:";
            // 
            // rbMeat
            // 
            this.rbMeat.AutoSize = true;
            this.rbMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeat.Location = new System.Drawing.Point(214, 78);
            this.rbMeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMeat.Name = "rbMeat";
            this.rbMeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbMeat.Size = new System.Drawing.Size(72, 26);
            this.rbMeat.TabIndex = 16;
            this.rbMeat.TabStop = true;
            this.rbMeat.Text = "בשרי";
            this.rbMeat.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegular.Location = new System.Drawing.Point(220, 40);
            this.rbRegular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbRegular.Size = new System.Drawing.Size(67, 26);
            this.rbRegular.TabIndex = 13;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "רגיל";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // rbVegan
            // 
            this.rbVegan.AutoSize = true;
            this.rbVegan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVegan.Location = new System.Drawing.Point(202, 155);
            this.rbVegan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbVegan.Name = "rbVegan";
            this.rbVegan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbVegan.Size = new System.Drawing.Size(87, 26);
            this.rbVegan.TabIndex = 15;
            this.rbVegan.TabStop = true;
            this.rbVegan.Text = "טבעוני";
            this.rbVegan.UseVisualStyleBackColor = true;
            // 
            // rbVegetarian
            // 
            this.rbVegetarian.AutoSize = true;
            this.rbVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVegetarian.Location = new System.Drawing.Point(202, 117);
            this.rbVegetarian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbVegetarian.Name = "rbVegetarian";
            this.rbVegetarian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbVegetarian.Size = new System.Drawing.Size(87, 26);
            this.rbVegetarian.TabIndex = 14;
            this.rbVegetarian.TabStop = true;
            this.rbVegetarian.Text = "צמחוני";
            this.rbVegetarian.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(578, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(207, 51);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "מחק מתכון";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(814, 446);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(207, 51);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "עדכן מתכון";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1042, 446);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.Size = new System.Drawing.Size(207, 51);
            this.btnInsert.TabIndex = 36;
            this.btnInsert.Text = "הוסף מתכון";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "זמן ההכנה המשוער:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(986, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "שם מתכון:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(984, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "מס\' מתכון:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(688, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(205, 36);
            this.txtName.TabIndex = 45;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(688, 24);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(205, 36);
            this.txtID.TabIndex = 44;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(688, 147);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTime.Size = new System.Drawing.Size(205, 36);
            this.txtTime.TabIndex = 43;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(127, 107);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnShow.Size = new System.Drawing.Size(318, 51);
            this.btnShow.TabIndex = 49;
            this.btnShow.Text = "צפייה בטבלת המתכונים";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ChooseRecipe
            // 
            this.ChooseRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChooseRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseRecipe.Location = new System.Drawing.Point(186, 59);
            this.ChooseRecipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseRecipe.Name = "ChooseRecipe";
            this.ChooseRecipe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChooseRecipe.Size = new System.Drawing.Size(207, 51);
            this.ChooseRecipe.TabIndex = 50;
            this.ChooseRecipe.Text = "בחר מתכון";
            this.ChooseRecipe.UseVisualStyleBackColor = false;
            this.ChooseRecipe.Click += new System.EventHandler(this.ChooseRecipe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 644);
            this.Controls.Add(this.ChooseRecipe);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMeat;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.RadioButton rbVegan;
        private System.Windows.Forms.RadioButton rbVegetarian;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button ChooseRecipe;
    }
}

