﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.Desktop.GUI.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private  static HomeUserControl? _instance;
        public static HomeUserControl Instance => _instance ?? new HomeUserControl();
        public HomeUserControl()
        {
            InitializeComponent();
        }
    }
}
