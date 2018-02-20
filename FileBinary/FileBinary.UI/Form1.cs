using FileBinary.BLL.Infrastructure;
using FileBinary.BLL.Interfaces;
using FileBinary.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBinary.UI
{
    public partial class Form1 : Form
    {
        IFileService fileService;
        public Form1()
        {
            InitializeComponent();

            fileService = new FileService();

            ComboBoxFiles.Items.AddRange(fileService.GetAllFiles().ToArray());
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "SELECT FOLDER";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileService.PackFile(fbd.SelectedPath);
                    ComboBoxFiles.Items.Clear();
                    ComboBoxFiles.Items.AddRange(fileService.GetAllFiles().ToArray());
                }
                catch (FileDetailsException ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
               
            }
        }

        private void ButtonInFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "In FOLDER";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileService.UnpackFile(ComboBoxFiles.SelectedItem.ToString(), fbd.SelectedPath);
                }
                catch (FileDetailsException ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

    
       
    }
}
