using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTaskMaster.Model;

namespace MyTaskMaster
{
    public partial class Form1 : Form
    {
        private tmDBContext tmContext;
        public Form1()
        {

            InitializeComponent();

            tmContext = new tmDBContext();

            var statuses = tmContext.Statuses.ToList();

            foreach(Status s in statuses)
            {
                cboStatus.Items.Add(s);
            }
        }
    }
}
