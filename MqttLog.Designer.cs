
namespace Camera_Test_Suite
{
    partial class MqttLog
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
            this.label7 = new System.Windows.Forms.Label();
            this.MqttLogText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "MQTT Log:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MqttLogText
            // 
            this.MqttLogText.Location = new System.Drawing.Point(12, 25);
            this.MqttLogText.Name = "MqttLogText";
            this.MqttLogText.ReadOnly = true;
            this.MqttLogText.Size = new System.Drawing.Size(343, 365);
            this.MqttLogText.TabIndex = 14;
            this.MqttLogText.Text = "";
            // 
            // MqttLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 402);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MqttLogText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MqttLog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MqttLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox MqttLogText;
    }
}