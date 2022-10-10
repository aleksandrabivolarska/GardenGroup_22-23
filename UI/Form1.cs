using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using MongoDB.Driver;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {
            MongoHelper mongodb = MongoHelper.getInstance();
            var dbs = mongodb.getAllDbs();
            dbs.ForEach(d => listBox1.Items.Add(d));
        }
    }
}
