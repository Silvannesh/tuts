using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file";
            ofd.Filter = "TXT|*.txt";
            ofd.DefaultExt = "txt";
            
            ofd.ShowDialog();

            if ( !string.IsNullOrEmpty( ofd.FileName ) )
            {
                try
                {
                    foreach ( string file in File.ReadAllLines( ofd.FileName ) )
                    {
                        rtb1.AppendText( file );
                    }
                }
                catch ( IOException ex )
                {
                    MessageBox.Show( ex.Message );
                    //+logger
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd= new SaveFileDialog();
            sfd.Title = "Save file";
            sfd.Filter = "TXT|*.txt";
            sfd.DefaultExt = "txt";

            sfd.ShowDialog();

            if ( !string.IsNullOrEmpty( sfd.FileName ) )
            {
                try
                {
                    File.WriteAllText( sfd.FileName, new TextRange( rtb1.Document.ContentStart, rtb1.Document.ContentEnd ).Text );
                }
                catch( IOException ex )
                {
                    MessageBox.Show( ex.Message );
                    //+logger
                }
            }

        }
    }
}
