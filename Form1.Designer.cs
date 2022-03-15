namespace IceCreamShop
{
    partial class frmIceCreamShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbIceCreamChoice = new System.Windows.Forms.GroupBox();
            this.rbBananaSplit = new System.Windows.Forms.RadioButton();
            this.rbSundae = new System.Windows.Forms.RadioButton();
            this.rbCone = new System.Windows.Forms.RadioButton();
            this.lblBananaSplit = new System.Windows.Forms.Label();
            this.lblSundae = new System.Windows.Forms.Label();
            this.lblCone = new System.Windows.Forms.Label();
            this.pbBananaSplit = new System.Windows.Forms.PictureBox();
            this.pbSundae = new System.Windows.Forms.PictureBox();
            this.pbCone = new System.Windows.Forms.PictureBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.lblSyrup = new System.Windows.Forms.Label();
            this.lblSprinkles = new System.Windows.Forms.Label();
            this.lblFlake = new System.Windows.Forms.Label();
            this.cbSyrup = new System.Windows.Forms.CheckBox();
            this.cbSprinkles = new System.Windows.Forms.CheckBox();
            this.cbFlake = new System.Windows.Forms.CheckBox();
            this.gbIceCreamFlavour = new System.Windows.Forms.GroupBox();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.rbVanilla = new System.Windows.Forms.RadioButton();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbIceCreamChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBananaSplit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSundae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCone)).BeginInit();
            this.gbToppings.SuspendLayout();
            this.gbIceCreamFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(71, 47);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(319, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Please Place Your Order";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gbIceCreamChoice
            // 
            this.gbIceCreamChoice.Controls.Add(this.rbBananaSplit);
            this.gbIceCreamChoice.Controls.Add(this.rbSundae);
            this.gbIceCreamChoice.Controls.Add(this.rbCone);
            this.gbIceCreamChoice.Controls.Add(this.lblBananaSplit);
            this.gbIceCreamChoice.Controls.Add(this.lblSundae);
            this.gbIceCreamChoice.Controls.Add(this.lblCone);
            this.gbIceCreamChoice.Controls.Add(this.pbBananaSplit);
            this.gbIceCreamChoice.Controls.Add(this.pbSundae);
            this.gbIceCreamChoice.Controls.Add(this.pbCone);
            this.gbIceCreamChoice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIceCreamChoice.Location = new System.Drawing.Point(12, 104);
            this.gbIceCreamChoice.Name = "gbIceCreamChoice";
            this.gbIceCreamChoice.Size = new System.Drawing.Size(437, 234);
            this.gbIceCreamChoice.TabIndex = 2;
            this.gbIceCreamChoice.TabStop = false;
            this.gbIceCreamChoice.Text = "Ice Cream Choice";
            // 
            // rbBananaSplit
            // 
            this.rbBananaSplit.AutoSize = true;
            this.rbBananaSplit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBananaSplit.Location = new System.Drawing.Point(319, 182);
            this.rbBananaSplit.Name = "rbBananaSplit";
            this.rbBananaSplit.Size = new System.Drawing.Size(109, 24);
            this.rbBananaSplit.TabIndex = 8;
            this.rbBananaSplit.TabStop = true;
            this.rbBananaSplit.Text = "BananaSplit";
            this.rbBananaSplit.UseVisualStyleBackColor = true;
            this.rbBananaSplit.Click += new System.EventHandler(this.pbBananaSplit_Click_1);
            // 
            // rbSundae
            // 
            this.rbSundae.AutoSize = true;
            this.rbSundae.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSundae.Location = new System.Drawing.Point(167, 182);
            this.rbSundae.Name = "rbSundae";
            this.rbSundae.Size = new System.Drawing.Size(79, 24);
            this.rbSundae.TabIndex = 7;
            this.rbSundae.TabStop = true;
            this.rbSundae.Text = "Sundae";
            this.rbSundae.UseVisualStyleBackColor = true;
            this.rbSundae.Click += new System.EventHandler(this.pbSundae_Click_1);
            // 
            // rbCone
            // 
            this.rbCone.AutoSize = true;
            this.rbCone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCone.Location = new System.Drawing.Point(21, 182);
            this.rbCone.Name = "rbCone";
            this.rbCone.Size = new System.Drawing.Size(64, 24);
            this.rbCone.TabIndex = 6;
            this.rbCone.TabStop = true;
            this.rbCone.Text = "Cone";
            this.rbCone.UseVisualStyleBackColor = true;
            this.rbCone.Click += new System.EventHandler(this.pbCone_Click_1);
            // 
            // lblBananaSplit
            // 
            this.lblBananaSplit.AutoSize = true;
            this.lblBananaSplit.Location = new System.Drawing.Point(338, 45);
            this.lblBananaSplit.Name = "lblBananaSplit";
            this.lblBananaSplit.Size = new System.Drawing.Size(57, 25);
            this.lblBananaSplit.TabIndex = 5;
            this.lblBananaSplit.Text = "€2.50";
            // 
            // lblSundae
            // 
            this.lblSundae.AutoSize = true;
            this.lblSundae.Location = new System.Drawing.Point(188, 45);
            this.lblSundae.Name = "lblSundae";
            this.lblSundae.Size = new System.Drawing.Size(57, 25);
            this.lblSundae.TabIndex = 4;
            this.lblSundae.Text = "€1.90";
            // 
            // lblCone
            // 
            this.lblCone.AutoSize = true;
            this.lblCone.Location = new System.Drawing.Point(38, 45);
            this.lblCone.Name = "lblCone";
            this.lblCone.Size = new System.Drawing.Size(57, 25);
            this.lblCone.TabIndex = 3;
            this.lblCone.Text = "€1.50";
            // 
            // pbBananaSplit
            // 
            this.pbBananaSplit.Location = new System.Drawing.Point(319, 73);
            this.pbBananaSplit.Name = "pbBananaSplit";
            this.pbBananaSplit.Size = new System.Drawing.Size(98, 94);
            this.pbBananaSplit.TabIndex = 2;
            this.pbBananaSplit.TabStop = false;
            this.pbBananaSplit.Click += new System.EventHandler(this.pbBananaSplit_Click_1);
            // 
            // pbSundae
            // 
            this.pbSundae.Location = new System.Drawing.Point(167, 73);
            this.pbSundae.Name = "pbSundae";
            this.pbSundae.Size = new System.Drawing.Size(98, 94);
            this.pbSundae.TabIndex = 1;
            this.pbSundae.TabStop = false;
            this.pbSundae.Click += new System.EventHandler(this.pbSundae_Click_1);
            // 
            // pbCone
            // 
            this.pbCone.Location = new System.Drawing.Point(21, 73);
            this.pbCone.Name = "pbCone";
            this.pbCone.Size = new System.Drawing.Size(98, 94);
            this.pbCone.TabIndex = 0;
            this.pbCone.TabStop = false;
            this.pbCone.Click += new System.EventHandler(this.pbCone_Click_1);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.lblSyrup);
            this.gbToppings.Controls.Add(this.lblSprinkles);
            this.gbToppings.Controls.Add(this.lblFlake);
            this.gbToppings.Controls.Add(this.cbSyrup);
            this.gbToppings.Controls.Add(this.cbSprinkles);
            this.gbToppings.Controls.Add(this.cbFlake);
            this.gbToppings.Location = new System.Drawing.Point(12, 373);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(222, 154);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // lblSyrup
            // 
            this.lblSyrup.AutoSize = true;
            this.lblSyrup.Location = new System.Drawing.Point(139, 107);
            this.lblSyrup.Name = "lblSyrup";
            this.lblSyrup.Size = new System.Drawing.Size(44, 20);
            this.lblSyrup.TabIndex = 5;
            this.lblSyrup.Text = "€0.20";
            // 
            // lblSprinkles
            // 
            this.lblSprinkles.AutoSize = true;
            this.lblSprinkles.Location = new System.Drawing.Point(139, 70);
            this.lblSprinkles.Name = "lblSprinkles";
            this.lblSprinkles.Size = new System.Drawing.Size(44, 20);
            this.lblSprinkles.TabIndex = 4;
            this.lblSprinkles.Text = "€0.20";
            // 
            // lblFlake
            // 
            this.lblFlake.AutoSize = true;
            this.lblFlake.Location = new System.Drawing.Point(139, 33);
            this.lblFlake.Name = "lblFlake";
            this.lblFlake.Size = new System.Drawing.Size(44, 20);
            this.lblFlake.TabIndex = 3;
            this.lblFlake.Text = "€0.20";
            // 
            // cbSyrup
            // 
            this.cbSyrup.AutoSize = true;
            this.cbSyrup.Location = new System.Drawing.Point(11, 108);
            this.cbSyrup.Name = "cbSyrup";
            this.cbSyrup.Size = new System.Drawing.Size(68, 24);
            this.cbSyrup.TabIndex = 2;
            this.cbSyrup.Text = "Syrup";
            this.cbSyrup.UseVisualStyleBackColor = true;
            this.cbSyrup.Click += new System.EventHandler(this.ToppingCheckChanged);
            // 
            // cbSprinkles
            // 
            this.cbSprinkles.AutoSize = true;
            this.cbSprinkles.Location = new System.Drawing.Point(11, 69);
            this.cbSprinkles.Name = "cbSprinkles";
            this.cbSprinkles.Size = new System.Drawing.Size(90, 24);
            this.cbSprinkles.TabIndex = 1;
            this.cbSprinkles.Text = "Sprinkles";
            this.cbSprinkles.UseVisualStyleBackColor = true;
            this.cbSprinkles.Click += new System.EventHandler(this.ToppingCheckChanged);
            // 
            // cbFlake
            // 
            this.cbFlake.AutoSize = true;
            this.cbFlake.Location = new System.Drawing.Point(11, 29);
            this.cbFlake.Name = "cbFlake";
            this.cbFlake.Size = new System.Drawing.Size(65, 24);
            this.cbFlake.TabIndex = 0;
            this.cbFlake.Text = "Flake";
            this.cbFlake.UseVisualStyleBackColor = true;
            this.cbFlake.Click += new System.EventHandler(this.ToppingCheckChanged);
            // 
            // gbIceCreamFlavour
            // 
            this.gbIceCreamFlavour.Controls.Add(this.rbStrawberry);
            this.gbIceCreamFlavour.Controls.Add(this.rbVanilla);
            this.gbIceCreamFlavour.Controls.Add(this.rbChocolate);
            this.gbIceCreamFlavour.Location = new System.Drawing.Point(240, 373);
            this.gbIceCreamFlavour.Name = "gbIceCreamFlavour";
            this.gbIceCreamFlavour.Size = new System.Drawing.Size(209, 154);
            this.gbIceCreamFlavour.TabIndex = 4;
            this.gbIceCreamFlavour.TabStop = false;
            this.gbIceCreamFlavour.Text = "Ice Cream Flavour";
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Location = new System.Drawing.Point(38, 107);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(101, 24);
            this.rbStrawberry.TabIndex = 2;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            // 
            // rbVanilla
            // 
            this.rbVanilla.AutoSize = true;
            this.rbVanilla.Location = new System.Drawing.Point(38, 68);
            this.rbVanilla.Name = "rbVanilla";
            this.rbVanilla.Size = new System.Drawing.Size(74, 24);
            this.rbVanilla.TabIndex = 1;
            this.rbVanilla.TabStop = true;
            this.rbVanilla.Text = "Vanilla";
            this.rbVanilla.UseVisualStyleBackColor = true;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(38, 29);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(97, 24);
            this.rbChocolate.TabIndex = 0;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(23, 555);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(110, 555);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "€xxx.xx";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Gold;
            this.btnOrder.Location = new System.Drawing.Point(240, 551);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(92, 51);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(359, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 51);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmIceCreamShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(461, 614);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbIceCreamFlavour);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbIceCreamChoice);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIceCreamShop";
            this.Text = "Ice Cream Shop";
            this.Load += new System.EventHandler(this.frmIceCreamShop_Load);
            this.Click += new System.EventHandler(this.frmIceCreamShop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbIceCreamChoice.ResumeLayout(false);
            this.gbIceCreamChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBananaSplit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSundae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCone)).EndInit();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbIceCreamFlavour.ResumeLayout(false);
            this.gbIceCreamFlavour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeading;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox gbIceCreamChoice;
        private RadioButton rbBananaSplit;
        private RadioButton rbSundae;
        private RadioButton rbCone;
        private Label lblBananaSplit;
        private Label lblSundae;
        private Label lblCone;
        private PictureBox pbBananaSplit;
        private PictureBox pbSundae;
        private PictureBox pbCone;
        private GroupBox gbToppings;
        private Label lblSyrup;
        private Label lblSprinkles;
        private Label lblFlake;
        private CheckBox cbSyrup;
        private CheckBox cbSprinkles;
        private CheckBox cbFlake;
        private GroupBox gbIceCreamFlavour;
        private RadioButton rbStrawberry;
        private RadioButton rbVanilla;
        private RadioButton rbChocolate;
        private Label lblTotal;
        private Label lblPrice;
        private Button btnOrder;
        private Button btnExit;
    }
}