using ps_control.source;
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
            m_ps1.setVoltage(Convert.ToDouble(tb_ps1volt.Text));
        }

        private void btn_ps1setcurr_Click(object sender, EventArgs e)
        {
            m_ps1.setCurrentLimit(Convert.ToDouble(tb_ps1curr.Text));
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
            m_ps2.setVoltage(Convert.ToDouble(tb_ps2volt.Text));
        }

        private void btn_ps2setcurr_Click(object sender, EventArgs e)
        {
            m_ps2.setCurrentLimit(Convert.ToDouble(tb_ps2curr.Text));
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

    }
}
