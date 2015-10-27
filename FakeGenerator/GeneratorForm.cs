using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FakeGenerator
{
	//-----------------------------------------------------------------------------------------------------
	public partial class GeneratorForm : Form
	{
		//-----------------------------------------------------------------------------------------------------
		public GeneratorForm()
		{
			InitializeComponent();
			tbSaveFilePath.Text = Path.Combine(Path.GetTempFileName());
		}

		//-----------------------------------------------------------------------------------------------------
		/// <summary>
		/// Handles the Click event of the btnGo control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnGo_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSaveFilePath.Text.Trim()))
			{
				MessageBox.Show(@"Не указан путь для сохранения!", @"СЛЫШЬ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			toolStripStatusLabel.Text = string.Empty;
			var savePath = tbSaveFilePath.Text;

			Int64 size = 0;
			if (!string.IsNullOrWhiteSpace(tbSize.Text.Trim()))
			{
				if (!Regex.IsMatch(tbSize.Text, "[ ^ 0-9]"))
				{
					MessageBox.Show(@"В поле размера файла были введены некорректные символы!", string.Empty, MessageBoxButtons.OK,
						MessageBoxIcon.Stop);
					return;
				}
				size = Convert.ToInt64(tbSize.Text);
			}

			var openFile = tbOpenFile.Text;
			if (!string.IsNullOrWhiteSpace(tbSize.Text) && !string.IsNullOrWhiteSpace(openFile))
			{
				var resut = MessageBox.Show(
					@"Заполнены поля с размером и выбранным файлом. Нажмите Да, если Вы хотите сгенерировать файл с заданным размером. Нажмите Нет, если Вы хотите закодировать файл.",
					string.Empty, MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question);
				switch (resut)
				{
					case DialogResult.Yes:
						GenerateFile(savePath, size);
						break;
					case DialogResult.No:
						break;
					default:
						return;
				}
			}
			else
			{
				//если указан размер
				if (!string.IsNullOrWhiteSpace(tbSize.Text))
				{
					//					if (!Regex.IsMatch(tbSize.Text, "[ ^ 0-9]"))
					//					{
					//						MessageBox.Show(@"В поле размера файла были введены некорректные символы!", string.Empty, MessageBoxButtons.OK,
					//							MessageBoxIcon.Stop);
					//						return;
					//					}
					(new Thread(delegate() { GenerateFile(savePath, size); })).Start();
				}
				if (string.IsNullOrWhiteSpace(openFile)) return;
				if (!File.Exists(openFile))
				{
					toolStripStatusLabel.Text = @"Указанный файл не существует!";
				}
				else
				{
					toolStripStatusLabel.Text = @"Считывается содержимое файла.";
					(new Thread(delegate() { EncodeFile(openFile, savePath); })).Start();

				}
			}
		}

		//-----------------------------------------------------------------------------------------------------
		/// <summary>
		/// Encodes the file.
		/// </summary>
		/// <param name="openFile">The open file.</param>
		/// <param name="savePath">The save path.</param>
		private void EncodeFile(string openFile, string savePath)
		{
			if (openFile == null) throw new ArgumentNullException("openFile");
			if (savePath == null) throw new ArgumentNullException("savePath");
			try
			{
				var bytes = File.ReadAllBytes(openFile);
				var base64String = Convert.ToBase64String(bytes);
				using (var fs = new FileStream(savePath, FileMode.Create))
				{
					var buf = Encoding.UTF8.GetBytes(base64String);
					fs.Write(buf, 0, buf.Length);
					fs.Flush();
					fs.Close();
					fs.Dispose();
				}
				toolStripStatusLabel.Text = @"Файл успешно сохранён";
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//-----------------------------------------------------------------------------------------------------
		/// <summary>
		/// Generates the file.
		/// </summary>
		/// <param name="savePath">The save path.</param>
		/// <param name="size"></param>
		private void GenerateFile(string savePath, long size)
		{
			try
			{
				if (savePath == null) throw new ArgumentNullException("savePath");
				if (File.Exists(savePath))
				{
					File.Delete(savePath);
				}
				//				var random = new Random();
				var length = size * 1024;
				toolStripStatusLabel.Text = @"Создание файла.";
				//				const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
				var bytes = new string('a', (int)length);
				toolStripStatusLabel.Text = @"Создание файла..";
				toolStripStatusLabel.Text = @"Создание файла";
				if (cbBase64.Checked)
				{
					using (var ms = new FileStream(savePath, FileMode.Create))
					using (var cs = new CryptoStream(ms, new ToBase64Transform(), CryptoStreamMode.Write))
					using (var tr = new StreamWriter(cs))
					{
						tr.Write(bytes);
						tr.Flush();
					}
				}
				else
				{
					using (var ms = new FileStream(savePath, FileMode.Create))
					using (var tr = new StreamWriter(ms))
					{
						tr.Write(bytes);
						tr.Flush();
					}
				}
				toolStripStatusLabel.Text = @"Файл успешно создан";
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnClear_Click(object sender, EventArgs e)
		{
			tbOpenFile.Clear();
			tbSaveFilePath.Clear();
			tbSize.Clear();
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			tbOpenFile.Text = openFileDialog.FileName;
		}

		private void btnSaveFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog fileDialog = new SaveFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				tbSaveFilePath.Text = fileDialog.FileName;
			}
		}
	}
}


