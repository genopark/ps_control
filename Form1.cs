﻿using ps_control.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ps_control
{
    public partial class Form1 : Form
    {
        #region globalvar

        // enter correct ip and port
        PSU m_ps1 = new PSU("PS1", "255.255.255.255", 5025);
        PSU m_ps2 = new PSU("PS2", "255.255.255.255", 5025);
        
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            connectInst();
            setupTimer();
        }

        public void setupTimer()
        {
            // setup timer (measurement/2ms)
            timer_instread = new System.Windows.Forms.Timer();
            timer_instread.Interval = 200;
            timer_instread.Tick += new EventHandler(timerInstreadTick);
            timer_instread.Enabled = true;
            timer_instread.Start();
        }

        public void connectInst()
        {
            m_ps1.connectInst();
            m_ps2.connectInst();
        }

        // update labels, current voltage and current
        public void timerInstreadTick(object sender, EventArgs e)
        {
            //PS1
            lbl_ps1volt.Text = m_ps1.getVolt() + " V";
            lbl_ps1curr.Text = m_ps1.getCurr() + " C";

            //PS2
            lbl_ps2volt.Text = m_ps2.getVolt() + " V";
            lbl_ps2curr.Text = m_ps2.getCurr() + " C";
        }

        #region button_clicks

        private void btn_ps1on_Click(object sender, EventArgs e)
        {
            m_ps1.setON();
        }

        private void btn_ps1off_Click(object sender, EventArgs e)
        {
            m_ps1.setOFF();
        }

        private void btn_ps1pcycle_Click(object sender, EventArgs e)
        {
            m_ps1.performPowerCycle();
        }

        private void btn_ps1setvolt_Click(object sender, EventArgs e)
        {
            m_ps1.setVolt(Convert.ToDouble(tb_ps1volt.Text));
        }

        private void btn_ps1setcurr_Click(object sender, EventArgs e)
        {
            m_ps1.setCurrLimit(Convert.ToDouble(tb_ps1curr.Text));
        }

        private void btn_ps2on_Click(object sender, EventArgs e)
        {
            m_ps2.setON();
        }

        private void btn_ps2off_Click(object sender, EventArgs e)
        {
            m_ps2.setOFF();
        }

        private void btn_ps2pcycle_Click(object sender, EventArgs e)
        {
            m_ps2.performPowerCycle();
        }

        private void btn_ps2setvolt_Click(object sender, EventArgs e)
        {
            m_ps2.setVolt(Convert.ToDouble(tb_ps2volt.Text));
        }

        private void btn_ps2setcurr_Click(object sender, EventArgs e)
        {
            m_ps2.setCurrLimit(Convert.ToDouble(tb_ps2curr.Text));
        }

        private void btn_ps1connect_Click(object sender, EventArgs e)
        {
            m_ps1.connectInst();
        }

        private void btn_ps2connect_Click(object sender, EventArgs e)
        {
            m_ps2.connectInst();
        }

        #endregion

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox != null && txtBox.SelectedText != string.Empty)
            {
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
                txtBox.SelectedText = string.Empty;
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox != null && txtBox.SelectedText != string.Empty)
            {
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
            }
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position, Clipboard.GetText());
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            //Open Help Form
            ps_control.about_form f2 = new ps_control.about_form();
            System.Windows.Forms.RichTextBox HelpTB = (System.Windows.Forms.RichTextBox)f2.Controls["HelpTextBox"];
            // Help Button
            HelpTB.AppendText("Built by Eugene Park"); HelpTB.AppendText(Environment.NewLine); HelpTB.ScrollToCaret();
            HelpTB.AppendText("Contact: genopark@gmail.com"); HelpTB.AppendText(Environment.NewLine); HelpTB.ScrollToCaret();
            HelpTB.AppendText("Control power supplies by entering correct ip and port numbers"); HelpTB.AppendText(Environment.NewLine); HelpTB.ScrollToCaret();
            HelpTB.AppendText("A work in progress. May need fine tuning to function properly."); HelpTB.AppendText(Environment.NewLine); HelpTB.ScrollToCaret();
            f2.ShowDialog();
        }
    }
}
