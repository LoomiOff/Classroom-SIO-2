namespace Serialisation
{
    partial class MenuForm
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
            txtInput = new TextBox();
            btnSerialiseXML = new Button();
            btnSerialiseBin = new Button();
            btnSerialiseJSON = new Button();
            btnDeserialiseXML = new Button();
            btnDeserialiseBin = new Button();
            btnDeserialiseJSON = new Button();
            btnSerialiseSOAP = new Button();
            btnDeserialiseSOAP = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.Window;
            txtInput.Location = new Point(12, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(651, 274);
            txtInput.TabIndex = 0;
            // 
            // btnSerialiseXML
            // 
            btnSerialiseXML.Location = new Point(12, 313);
            btnSerialiseXML.Name = "btnSerialiseXML";
            btnSerialiseXML.Size = new Size(223, 60);
            btnSerialiseXML.TabIndex = 1;
            btnSerialiseXML.Text = "Serialise XML";
            btnSerialiseXML.UseVisualStyleBackColor = true;
            btnSerialiseXML.Click += btnSerialiseXML_Click;
            // 
            // btnSerialiseBin
            // 
            btnSerialiseBin.Location = new Point(12, 379);
            btnSerialiseBin.Name = "btnSerialiseBin";
            btnSerialiseBin.Size = new Size(223, 64);
            btnSerialiseBin.TabIndex = 2;
            btnSerialiseBin.Text = "Serialise Bin";
            btnSerialiseBin.UseVisualStyleBackColor = true;
            btnSerialiseBin.Click += btnSerialiseBin_Click;
            // 
            // btnSerialiseJSON
            // 
            btnSerialiseJSON.Location = new Point(12, 449);
            btnSerialiseJSON.Name = "btnSerialiseJSON";
            btnSerialiseJSON.Size = new Size(223, 60);
            btnSerialiseJSON.TabIndex = 3;
            btnSerialiseJSON.Text = "Serialise JSON";
            btnSerialiseJSON.UseVisualStyleBackColor = true;
            btnSerialiseJSON.Click += btnSerialiseJSON_Click;
            // 
            // btnDeserialiseXML
            // 
            btnDeserialiseXML.Location = new Point(440, 313);
            btnDeserialiseXML.Name = "btnDeserialiseXML";
            btnDeserialiseXML.Size = new Size(223, 60);
            btnDeserialiseXML.TabIndex = 4;
            btnDeserialiseXML.Text = "Deserialise XML";
            btnDeserialiseXML.UseVisualStyleBackColor = true;
            btnDeserialiseXML.Click += btnDeserialiseXML_Click;
            // 
            // btnDeserialiseBin
            // 
            btnDeserialiseBin.Location = new Point(440, 379);
            btnDeserialiseBin.Name = "btnDeserialiseBin";
            btnDeserialiseBin.Size = new Size(223, 64);
            btnDeserialiseBin.TabIndex = 5;
            btnDeserialiseBin.Text = "Deserialise Bin";
            btnDeserialiseBin.UseVisualStyleBackColor = true;
            btnDeserialiseBin.Click += btnDeserialiseBin_Click;
            // 
            // btnDeserialiseJSON
            // 
            btnDeserialiseJSON.Location = new Point(440, 449);
            btnDeserialiseJSON.Name = "btnDeserialiseJSON";
            btnDeserialiseJSON.Size = new Size(223, 60);
            btnDeserialiseJSON.TabIndex = 6;
            btnDeserialiseJSON.Text = "Deserialise JSON";
            btnDeserialiseJSON.UseVisualStyleBackColor = true;
            btnDeserialiseJSON.Click += btnDeserialiseJSON_Click;
            // 
            // btnSerialiseSOAP
            // 
            btnSerialiseSOAP.Location = new Point(12, 515);
            btnSerialiseSOAP.Name = "btnSerialiseSOAP";
            btnSerialiseSOAP.Size = new Size(223, 60);
            btnSerialiseSOAP.TabIndex = 7;
            btnSerialiseSOAP.Text = "Serialise SOAP";
            btnSerialiseSOAP.UseVisualStyleBackColor = true;
            btnSerialiseSOAP.Click += btnSerialiseSOAP_Click;
            // 
            // btnDeserialiseSOAP
            // 
            btnDeserialiseSOAP.Location = new Point(440, 515);
            btnDeserialiseSOAP.Name = "btnDeserialiseSOAP";
            btnDeserialiseSOAP.Size = new Size(223, 60);
            btnDeserialiseSOAP.TabIndex = 8;
            btnDeserialiseSOAP.Text = "Deserialise SOAP";
            btnDeserialiseSOAP.UseVisualStyleBackColor = true;
            btnDeserialiseSOAP.Click += btnDeserialiseSOAP_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(675, 591);
            Controls.Add(btnDeserialiseSOAP);
            Controls.Add(btnSerialiseSOAP);
            Controls.Add(btnDeserialiseJSON);
            Controls.Add(btnDeserialiseBin);
            Controls.Add(btnDeserialiseXML);
            Controls.Add(btnSerialiseJSON);
            Controls.Add(btnSerialiseBin);
            Controls.Add(btnSerialiseXML);
            Controls.Add(txtInput);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnSerialiseXML;
        private Button btnSerialiseBin;
        private Button btnSerialiseJSON;
        private Button btnDeserialiseXML;
        private Button btnDeserialiseBin;
        private Button btnDeserialiseJSON;
        private Button btnSerialiseSOAP;
        private Button btnDeserialiseSOAP;
    }
}
