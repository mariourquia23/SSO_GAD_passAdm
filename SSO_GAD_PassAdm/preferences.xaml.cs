using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;



namespace SSO_GAD_PassAdm
{
    /// <summary>
    /// Lógica de interacción para preferences.xaml
    /// </summary>
    public partial class preferences : Window
    {
        public preferences()
        {
            InitializeComponent();
            cargarConfiguraciones();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();

            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                gacmdtxtbox.Text = folderDlg.SelectedPath;
            }
          */
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            //dlg.InitialDirectory = "%programfiles(x86)%";
            dlg.DefaultExt = ".exe";
            dlg.Filter = "gacmd(.exe)|*.exe";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document

                string filename = dlg.FileName;

                gacmdtxtbox.Text = filename;
              
            }

           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.GACMD = gacmdtxtbox.Text;
            this.Close();
        }
        private void cargarConfiguraciones()
        {
            
            gacmdtxtbox.Text=Properties.Settings.Default.GACMD;
        }
        
    }
}
