namespace Автоматизированная_Система_Стипендии
{
    partial class Отчет_Студенты
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Отчет_Студенты));
            this.СтудентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.АС_СтипендииDataSet = new Автоматизированная_Система_Стипендии.АС_СтипендииDataSet();
            this.button9 = new System.Windows.Forms.Button();
            this.СтудентыTableAdapter = new Автоматизированная_Система_Стипендии.АС_СтипендииDataSetTableAdapters.СтудентыTableAdapter();
            this.АС_СтипендииDataSet1 = new Автоматизированная_Система_Стипендии.АС_СтипендииDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.СтудентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.АС_СтипендииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.АС_СтипендииDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // СтудентыBindingSource
            // 
            this.СтудентыBindingSource.DataMember = "Студенты";
            this.СтудентыBindingSource.DataSource = this.АС_СтипендииDataSet;
            // 
            // АС_СтипендииDataSet
            // 
            this.АС_СтипендииDataSet.DataSetName = "АС_СтипендииDataSet";
            this.АС_СтипендииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Menu;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(623, 344);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 39);
            this.button9.TabIndex = 20;
            this.button9.Text = "Возврат";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // СтудентыTableAdapter
            // 
            this.СтудентыTableAdapter.ClearBeforeFill = true;
            // 
            // АС_СтипендииDataSet1
            // 
            this.АС_СтипендииDataSet1.DataSetName = "АС_СтипендииDataSet1";
            this.АС_СтипендииDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(710, 326);
            this.reportViewer1.TabIndex = 21;
            // 
            // Отчет_Студенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Автоматизированная_Система_Стипендии.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(734, 395);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Отчет_Студенты";
            this.Text = "Отчет Студенты";
            this.Load += new System.EventHandler(this.Отчет_Студенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СтудентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.АС_СтипендииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.АС_СтипендииDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource СтудентыBindingSource;
        private АС_СтипендииDataSet АС_СтипендииDataSet;
        private АС_СтипендииDataSetTableAdapters.СтудентыTableAdapter СтудентыTableAdapter;
        private АС_СтипендииDataSet1 АС_СтипендииDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}