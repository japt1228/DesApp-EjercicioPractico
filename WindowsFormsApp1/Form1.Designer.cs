namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Doc = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.supBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.persona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // Doc
            // 
            this.Doc.Location = new System.Drawing.Point(120, 50);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(249, 20);
            this.Doc.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(120, 87);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(249, 20);
            this.name.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 128);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // supBtn
            // 
            this.supBtn.Location = new System.Drawing.Point(137, 128);
            this.supBtn.Name = "supBtn";
            this.supBtn.Size = new System.Drawing.Size(100, 23);
            this.supBtn.TabIndex = 6;
            this.supBtn.Text = "Borrar";
            this.supBtn.UseVisualStyleBackColor = true;
            this.supBtn.Click += new System.EventHandler(this.supBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(264, 128);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(105, 23);
            this.updBtn.TabIndex = 7;
            this.updBtn.Text = "Limpiar";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.persona});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 175);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(354, 414);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Numero Documento";
            this.id.Width = 150;
            // 
            // persona
            // 
            this.persona.Text = "Nombre";
            this.persona.Width = 200;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(393, 615);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.supBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Doc;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button supBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader persona;
    }
}

