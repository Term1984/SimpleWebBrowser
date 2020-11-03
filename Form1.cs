using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

// Namespace
namespace SimpleWebBrowser
{
    // Class
    public partial class Form1 : Form
    {
        // Main Windows Form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Core navigation function
        private void NavigateToPage() 
        {
            AddressBar.Enabled = false;
            NavButton.Enabled = false;
            WebContainer.Load(AddressBar.Text);
            WebContainer.SetZoomLevel(-6.0);
        }

        // Browser back button
        private void BackButton_Click(object sender, EventArgs e)
        {
            WebContainer.Back();
        }

        // Browser forward button
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            WebContainer.Forward();
        }
        
        // Browser navigation button
        private void NavButton_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        // Loading state changed
        private void WebContainer_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            WebContainer.SetZoomLevel(-1.0);
            AddressBar.Enabled = true;
            NavButton.Enabled = true;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String AppInfo = "Simple Web Browser v1.0.0-alpha1";
            MessageBox.Show(AppInfo);
        }
    }
}
