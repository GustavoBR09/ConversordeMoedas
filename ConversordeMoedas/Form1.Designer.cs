namespace ConversordeMoedas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxPrincipal = new ComboBox();
            textBoxResultado = new TextBox();
            comboBoxResultado = new ComboBox();
            buttonConverter = new Button();
            textBoxPrincipal = new TextBox();
            label1 = new Label();
            de = new Label();
            para = new Label();
            valor = new Label();
            convertido = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxPrincipal
            // 
            resources.ApplyResources(comboBoxPrincipal, "comboBoxPrincipal");
            comboBoxPrincipal.FormattingEnabled = true;
            comboBoxPrincipal.Name = "comboBoxPrincipal";
            // 
            // textBoxResultado
            // 
            resources.ApplyResources(textBoxResultado, "textBoxResultado");
            textBoxResultado.Name = "textBoxResultado";
            // 
            // comboBoxResultado
            // 
            resources.ApplyResources(comboBoxResultado, "comboBoxResultado");
            comboBoxResultado.FormattingEnabled = true;
            comboBoxResultado.Name = "comboBoxResultado";
            // 
            // buttonConverter
            // 
            resources.ApplyResources(buttonConverter, "buttonConverter");
            buttonConverter.Name = "buttonConverter";
            buttonConverter.UseVisualStyleBackColor = true;
            buttonConverter.Click += buttonConverter_Click;
            // 
            // textBoxPrincipal
            // 
            resources.ApplyResources(textBoxPrincipal, "textBoxPrincipal");
            textBoxPrincipal.Name = "textBoxPrincipal";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // de
            // 
            resources.ApplyResources(de, "de");
            de.Name = "de";
            // 
            // para
            // 
            resources.ApplyResources(para, "para");
            para.Name = "para";
            // 
            // valor
            // 
            resources.ApplyResources(valor, "valor");
            valor.Name = "valor";
            // 
            // convertido
            // 
            resources.ApplyResources(convertido, "convertido");
            convertido.Name = "convertido";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(buttonConverter);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(convertido);
            Controls.Add(valor);
            Controls.Add(para);
            Controls.Add(de);
            Controls.Add(label1);
            Controls.Add(textBoxPrincipal);
            Controls.Add(comboBoxResultado);
            Controls.Add(textBoxResultado);
            Controls.Add(comboBoxPrincipal);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPrincipal;
        private TextBox textBoxResultado;
        private ComboBox comboBoxResultado;
        private Button buttonConverter;
        private TextBox textBoxPrincipal;
        private Label label1;
        private Label de;
        private Label para;
        private Label valor;
        private Label convertido;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
    }
}
