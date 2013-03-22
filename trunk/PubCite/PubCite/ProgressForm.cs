using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PubCite
{
    public partial class ProgressForm : Form
    {
        
       public ProgressForm()
    {
        InitializeComponent();
        backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        startForm();
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        progressBar1.MarqueeAnimationSpeed = 0;
        progressBar1.Style = ProgressBarStyle.Blocks;
        progressBar1.Value = progressBar1.Minimum;
    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        DoSomething();
    }

    private void startForm()
    {
        progressBar1.Style = ProgressBarStyle.Marquee;
        progressBar1.MarqueeAnimationSpeed = 25;
        backgroundWorker.RunWorkerAsync();
    }

    private void DoSomething()
    {
        while (true) ;
    }

    }
}
