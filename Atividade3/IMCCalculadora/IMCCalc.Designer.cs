namespace WindowsFormsApp1
{
    partial class IMCCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox DesingBox1;
            System.Windows.Forms.PictureBox DesingTxt2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMCCalc));
            this.BtnCalc = new System.Windows.Forms.Button();
            this.TxtTitulo = new System.Windows.Forms.Label();
            this.MskTxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtAlt = new System.Windows.Forms.MaskedTextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblAlt = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblClass = new System.Windows.Forms.Label();
            this.TxtIMCResult = new System.Windows.Forms.Label();
            this.TxtClassInf = new System.Windows.Forms.Label();
            DesingBox1 = new System.Windows.Forms.PictureBox();
            DesingTxt2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(DesingBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(DesingTxt2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalc
            // 
            this.BtnCalc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnCalc.AutoSize = true;
            this.BtnCalc.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnCalc.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCalc.Location = new System.Drawing.Point(448, 222);
            this.BtnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCalc.Size = new System.Drawing.Size(139, 48);
            this.BtnCalc.TabIndex = 3;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTitulo.AutoSize = true;
            this.TxtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTitulo.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxtTitulo.Location = new System.Drawing.Point(359, 9);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtTitulo.Size = new System.Drawing.Size(323, 53);
            this.TxtTitulo.TabIndex = 6;
            this.TxtTitulo.Text = "Calculadora de IMC ";
            this.TxtTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxtTitulo.UseCompatibleTextRendering = true;
            // 
            // MskTxtPeso
            // 
            this.MskTxtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MskTxtPeso.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtPeso.ForeColor = System.Drawing.Color.Black;
            this.MskTxtPeso.Location = new System.Drawing.Point(740, 139);
            this.MskTxtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.MskTxtPeso.Mask = "999.99";
            this.MskTxtPeso.Name = "MskTxtPeso";
            this.MskTxtPeso.Size = new System.Drawing.Size(193, 33);
            this.MskTxtPeso.TabIndex = 2;
            this.MskTxtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MskTxtAlt
            // 
            this.MskTxtAlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MskTxtAlt.BeepOnError = true;
            this.MskTxtAlt.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtAlt.ForeColor = System.Drawing.Color.Black;
            this.MskTxtAlt.Location = new System.Drawing.Point(273, 142);
            this.MskTxtAlt.Margin = new System.Windows.Forms.Padding(4);
            this.MskTxtAlt.Mask = "9.99";
            this.MskTxtAlt.Name = "MskTxtAlt";
            this.MskTxtAlt.Size = new System.Drawing.Size(166, 33);
            this.MskTxtAlt.TabIndex = 1;
            this.MskTxtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResultado
            // 
            this.LblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblResultado.BackColor = System.Drawing.Color.LightSlateGray;
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultado.Enabled = false;
            this.LblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultado.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblResultado.Location = new System.Drawing.Point(448, 329);
            this.LblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(144, 30);
            this.LblResultado.TabIndex = 10;
            this.LblResultado.Text = "Resultado";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAlt
            // 
            this.LblAlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAlt.Enabled = false;
            this.LblAlt.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlt.ForeColor = System.Drawing.Color.Black;
            this.LblAlt.Location = new System.Drawing.Point(156, 142);
            this.LblAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAlt.Name = "LblAlt";
            this.LblAlt.Size = new System.Drawing.Size(93, 33);
            this.LblAlt.TabIndex = 11;
            this.LblAlt.Text = "Altura";
            this.LblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPeso
            // 
            this.LblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPeso.Enabled = false;
            this.LblPeso.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.ForeColor = System.Drawing.Color.Black;
            this.LblPeso.Location = new System.Drawing.Point(583, 139);
            this.LblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(122, 33);
            this.LblPeso.TabIndex = 12;
            this.LblPeso.Text = "Peso (Kg)";
            this.LblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResult.Enabled = false;
            this.LblResult.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.ForeColor = System.Drawing.Color.Black;
            this.LblResult.Location = new System.Drawing.Point(273, 455);
            this.LblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(148, 44);
            this.LblResult.TabIndex = 14;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblClass
            // 
            this.LblClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblClass.Enabled = false;
            this.LblClass.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClass.ForeColor = System.Drawing.Color.Black;
            this.LblClass.Location = new System.Drawing.Point(674, 457);
            this.LblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(259, 44);
            this.LblClass.TabIndex = 15;
            this.LblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtIMCResult
            // 
            this.TxtIMCResult.Enabled = false;
            this.TxtIMCResult.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIMCResult.ForeColor = System.Drawing.Color.Black;
            this.TxtIMCResult.Location = new System.Drawing.Point(119, 457);
            this.TxtIMCResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtIMCResult.Name = "TxtIMCResult";
            this.TxtIMCResult.Size = new System.Drawing.Size(148, 42);
            this.TxtIMCResult.TabIndex = 16;
            this.TxtIMCResult.Text = "O seu IMC é:";
            this.TxtIMCResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtIMCResult.UseWaitCursor = true;
            // 
            // TxtClassInf
            // 
            this.TxtClassInf.Enabled = false;
            this.TxtClassInf.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClassInf.ForeColor = System.Drawing.Color.Black;
            this.TxtClassInf.Location = new System.Drawing.Point(458, 456);
            this.TxtClassInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtClassInf.Name = "TxtClassInf";
            this.TxtClassInf.Size = new System.Drawing.Size(208, 44);
            this.TxtClassInf.TabIndex = 17;
            this.TxtClassInf.Text = "Sua Classificação é:";
            this.TxtClassInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtClassInf.UseWaitCursor = true;
            // 
            // DesingBox1
            // 
            DesingBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            DesingBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DesingBox1.Enabled = false;
            DesingBox1.Location = new System.Drawing.Point(106, 123);
            DesingBox1.Name = "DesingBox1";
            DesingBox1.Size = new System.Drawing.Size(859, 65);
            DesingBox1.TabIndex = 18;
            DesingBox1.TabStop = false;
            // 
            // DesingTxt2
            // 
            DesingTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            DesingTxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DesingTxt2.Enabled = false;
            DesingTxt2.Location = new System.Drawing.Point(106, 445);
            DesingTxt2.Name = "DesingTxt2";
            DesingTxt2.Size = new System.Drawing.Size(859, 65);
            DesingTxt2.TabIndex = 19;
            DesingTxt2.TabStop = false;
            // 
            // IMCCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.TxtClassInf);
            this.Controls.Add(this.TxtIMCResult);
            this.Controls.Add(this.LblClass);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblAlt);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.MskTxtAlt);
            this.Controls.Add(this.MskTxtPeso);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(DesingBox1);
            this.Controls.Add(DesingTxt2);
            this.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IMCCalc";
            this.Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)(DesingBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(DesingTxt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TxtTitulo;
        private System.Windows.Forms.MaskedTextBox MskTxtPeso;
        private System.Windows.Forms.MaskedTextBox MskTxtAlt;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblAlt;
        private System.Windows.Forms.Label LblPeso;
        public System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblClass;
        private System.Windows.Forms.Label TxtIMCResult;
        private System.Windows.Forms.Label TxtClassInf;
    }
}

