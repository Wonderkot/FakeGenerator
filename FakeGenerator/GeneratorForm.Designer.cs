using System.Windows.Forms;

namespace FakeGenerator
{
	partial class GeneratorForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gbCreateFile = new System.Windows.Forms.GroupBox();
			this.cbBase64 = new System.Windows.Forms.CheckBox();
			this.gbGenFile = new System.Windows.Forms.GroupBox();
			this.tbSize = new System.Windows.Forms.TextBox();
			this.gbEncodeFile = new System.Windows.Forms.GroupBox();
			this.gbOpenFile = new System.Windows.Forms.GroupBox();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.tbOpenFile = new System.Windows.Forms.TextBox();
			this.gbSaveFile = new System.Windows.Forms.GroupBox();
			this.btnSaveFile = new System.Windows.Forms.Button();
			this.tbSaveFilePath = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gbCreateFile.SuspendLayout();
			this.gbGenFile.SuspendLayout();
			this.gbEncodeFile.SuspendLayout();
			this.gbOpenFile.SuspendLayout();
			this.gbSaveFile.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(617, 113);
			this.panel1.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gbCreateFile);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gbEncodeFile);
			this.splitContainer1.Size = new System.Drawing.Size(617, 113);
			this.splitContainer1.SplitterDistance = 252;
			this.splitContainer1.TabIndex = 0;
			// 
			// gbCreateFile
			// 
			this.gbCreateFile.Controls.Add(this.cbBase64);
			this.gbCreateFile.Controls.Add(this.gbGenFile);
			this.gbCreateFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbCreateFile.Location = new System.Drawing.Point(0, 0);
			this.gbCreateFile.Name = "gbCreateFile";
			this.gbCreateFile.Size = new System.Drawing.Size(252, 113);
			this.gbCreateFile.TabIndex = 0;
			this.gbCreateFile.TabStop = false;
			this.gbCreateFile.Text = "Сгенерировать файл";
			// 
			// cbBase64
			// 
			this.cbBase64.AutoSize = true;
			this.cbBase64.Location = new System.Drawing.Point(6, 79);
			this.cbBase64.Name = "cbBase64";
			this.cbBase64.Padding = new System.Windows.Forms.Padding(3);
			this.cbBase64.Size = new System.Drawing.Size(67, 23);
			this.cbBase64.TabIndex = 1;
			this.cbBase64.Text = "base64";
			this.cbBase64.UseVisualStyleBackColor = true;
			// 
			// gbGenFile
			// 
			this.gbGenFile.Controls.Add(this.tbSize);
			this.gbGenFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbGenFile.Location = new System.Drawing.Point(3, 16);
			this.gbGenFile.Name = "gbGenFile";
			this.gbGenFile.Size = new System.Drawing.Size(246, 56);
			this.gbGenFile.TabIndex = 0;
			this.gbGenFile.TabStop = false;
			this.gbGenFile.Text = "Укажите необходимый размер файла (КБ)";
			// 
			// tbSize
			// 
			this.tbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSize.Location = new System.Drawing.Point(3, 28);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(237, 20);
			this.tbSize.TabIndex = 0;
			// 
			// gbEncodeFile
			// 
			this.gbEncodeFile.Controls.Add(this.gbOpenFile);
			this.gbEncodeFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbEncodeFile.Location = new System.Drawing.Point(0, 0);
			this.gbEncodeFile.Name = "gbEncodeFile";
			this.gbEncodeFile.Size = new System.Drawing.Size(361, 113);
			this.gbEncodeFile.TabIndex = 0;
			this.gbEncodeFile.TabStop = false;
			this.gbEncodeFile.Text = "Закодировать файл";
			// 
			// gbOpenFile
			// 
			this.gbOpenFile.Controls.Add(this.btnOpenFile);
			this.gbOpenFile.Controls.Add(this.tbOpenFile);
			this.gbOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbOpenFile.Location = new System.Drawing.Point(3, 16);
			this.gbOpenFile.Name = "gbOpenFile";
			this.gbOpenFile.Size = new System.Drawing.Size(355, 56);
			this.gbOpenFile.TabIndex = 1;
			this.gbOpenFile.TabStop = false;
			this.gbOpenFile.Text = "Выберите файл для кодирования";
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFile.Location = new System.Drawing.Point(314, 25);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(38, 23);
			this.btnOpenFile.TabIndex = 1;
			this.btnOpenFile.Text = "...";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// tbOpenFile
			// 
			this.tbOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOpenFile.Location = new System.Drawing.Point(3, 28);
			this.tbOpenFile.Name = "tbOpenFile";
			this.tbOpenFile.Size = new System.Drawing.Size(305, 20);
			this.tbOpenFile.TabIndex = 0;
			// 
			// gbSaveFile
			// 
			this.gbSaveFile.Controls.Add(this.btnSaveFile);
			this.gbSaveFile.Controls.Add(this.tbSaveFilePath);
			this.gbSaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbSaveFile.Location = new System.Drawing.Point(0, 0);
			this.gbSaveFile.Name = "gbSaveFile";
			this.gbSaveFile.Size = new System.Drawing.Size(617, 66);
			this.gbSaveFile.TabIndex = 1;
			this.gbSaveFile.TabStop = false;
			this.gbSaveFile.Text = "Сохранить файл";
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveFile.Location = new System.Drawing.Point(573, 16);
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Size = new System.Drawing.Size(38, 23);
			this.btnSaveFile.TabIndex = 0;
			this.btnSaveFile.Text = "...";
			this.btnSaveFile.UseVisualStyleBackColor = true;
			this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
			// 
			// tbSaveFilePath
			// 
			this.tbSaveFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSaveFilePath.Location = new System.Drawing.Point(4, 19);
			this.tbSaveFilePath.Name = "tbSaveFilePath";
			this.tbSaveFilePath.Size = new System.Drawing.Size(563, 20);
			this.tbSaveFilePath.TabIndex = 0;
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Location = new System.Drawing.Point(536, 6);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Поехали!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 244);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(617, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(169, 17);
			this.toolStripStatusLabel.Text = "Укажите путь для сохранения";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClear);
			this.panel2.Controls.Add(this.btnGo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 209);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(617, 35);
			this.panel2.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(455, 6);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Очистить";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.gbSaveFile);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 113);
			this.panel3.MinimumSize = new System.Drawing.Size(0, 60);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(617, 66);
			this.panel3.TabIndex = 5;
			// 
			// GeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 266);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GeneratorForm";
			this.Text = "Конвертер и генератор - человек и параход";
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gbCreateFile.ResumeLayout(false);
			this.gbCreateFile.PerformLayout();
			this.gbGenFile.ResumeLayout(false);
			this.gbGenFile.PerformLayout();
			this.gbEncodeFile.ResumeLayout(false);
			this.gbOpenFile.ResumeLayout(false);
			this.gbOpenFile.PerformLayout();
			this.gbSaveFile.ResumeLayout(false);
			this.gbSaveFile.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox gbCreateFile;
		private System.Windows.Forms.GroupBox gbEncodeFile;
		private System.Windows.Forms.GroupBox gbGenFile;
		private System.Windows.Forms.TextBox tbSize;
		private System.Windows.Forms.GroupBox gbSaveFile;
		private System.Windows.Forms.TextBox tbSaveFilePath;
		private System.Windows.Forms.CheckBox cbBase64;
		private System.Windows.Forms.Button btnSaveFile;
		private System.Windows.Forms.Button btnGo;
		private StatusStrip statusStrip1;
		private Panel panel2;
		private Panel panel3;
		private GroupBox gbOpenFile;
		private TextBox tbOpenFile;
		private ToolStripStatusLabel toolStripStatusLabel;
		private Button btnOpenFile;
		private Button btnClear;
	}

//	class GeneratorFormImpl : GeneratorForm
//	{
//	}
}

