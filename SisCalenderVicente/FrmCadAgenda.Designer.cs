namespace PrototipoCalendario
{
    partial class FrmCadAgenda
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
            label1 = new Label();
            dateTimePickerSelecionado = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Data selecionada: ";
            // 
            // dateTimePickerSelecionado
            // 
            dateTimePickerSelecionado.Location = new Point(142, 25);
            dateTimePickerSelecionado.Name = "dateTimePickerSelecionado";
            dateTimePickerSelecionado.Size = new Size(200, 23);
            dateTimePickerSelecionado.TabIndex = 1;
            // 
            // FrmCadAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 325);
            Controls.Add(dateTimePickerSelecionado);
            Controls.Add(label1);
            Name = "FrmCadAgenda";
            Text = "FrmCadAgenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerSelecionado;
    }
}