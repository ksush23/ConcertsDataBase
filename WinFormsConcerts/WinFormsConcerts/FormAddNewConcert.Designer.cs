namespace WinFormsConcerts
{
    partial class FormAddNewConcert
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
            this.comboBoxAddConcert = new System.Windows.Forms.ComboBox();
            this.buttonAddConcert = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsConcerts = new ConcertsData.DSConcerts();
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.notConcertsTableAdapter = new ConcertsData.DSConcertsTableAdapters.NotConcertsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAddConcert
            // 
            this.comboBoxAddConcert.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "Concert_ID", true));
            this.comboBoxAddConcert.DataSource = this.bindingSource;
            this.comboBoxAddConcert.DisplayMember = "Concert_TimeDate";
            this.comboBoxAddConcert.FormattingEnabled = true;
            this.comboBoxAddConcert.Location = new System.Drawing.Point(159, 137);
            this.comboBoxAddConcert.Name = "comboBoxAddConcert";
            this.comboBoxAddConcert.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAddConcert.TabIndex = 0;
            this.comboBoxAddConcert.ValueMember = "Concert_ID";
            // 
            // buttonAddConcert
            // 
            this.buttonAddConcert.Location = new System.Drawing.Point(459, 131);
            this.buttonAddConcert.Name = "buttonAddConcert";
            this.buttonAddConcert.Size = new System.Drawing.Size(108, 34);
            this.buttonAddConcert.TabIndex = 1;
            this.buttonAddConcert.Text = "Додати";
            this.buttonAddConcert.UseVisualStyleBackColor = true;
            this.buttonAddConcert.Click += new System.EventHandler(this.buttonAddConcert_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "NotConcerts";
            this.bindingSource.DataSource = this.dsConcerts;
            // 
            // dsConcerts
            // 
            this.dsConcerts.DataSetName = "DSConcerts";
            this.dsConcerts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concertsDataSet
            // 
            this.concertsDataSet.DataSetName = "ConcertsDataSet";
            this.concertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notConcertsTableAdapter
            // 
            this.notConcertsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddNewConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddConcert);
            this.Controls.Add(this.comboBoxAddConcert);
            this.Name = "FormAddNewConcert";
            this.Text = "FormAddNewConcert";
            this.Load += new System.EventHandler(this.FormAddNewConcert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAddConcert;
        private System.Windows.Forms.Button buttonAddConcert;
        private System.Windows.Forms.BindingSource bindingSource;
        private ConcertsData.DSConcerts dsConcerts;
        private ConcertsDataSet concertsDataSet;
        private ConcertsData.DSConcertsTableAdapters.NotConcertsTableAdapter notConcertsTableAdapter;
    }
}