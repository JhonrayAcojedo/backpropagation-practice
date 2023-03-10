using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backprop;

namespace acojedo_backpropagation_app_
{
    public partial class Form1 : Form
    {
        NeuralNet neuralNet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neuralNet = new NeuralNet(2, 10, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < Convert.ToInt32(textBox3.Text); x++)
            {
                neuralNet.setInputs(0, 1.0);
                neuralNet.setInputs(1, 1.0);
                neuralNet.setDesiredOutput(0, 1.0);
                neuralNet.learn();

                neuralNet.setInputs(0, 1.0);
                neuralNet.setInputs(1, 0.0);
                neuralNet.setDesiredOutput(0, 0.0);
                neuralNet.learn();

                neuralNet.setInputs(0, 0.0);
                neuralNet.setInputs(1, 1.0);
                neuralNet.setDesiredOutput(0, 0.0);
                neuralNet.learn();

                neuralNet.setInputs(0, 0.0);
                neuralNet.setInputs(1, 0.0);
                neuralNet.setDesiredOutput(0, 0.0);
                neuralNet.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            neuralNet.setInputs(0, Convert.ToDouble(textBox1.Text));
            neuralNet.setInputs(0, Convert.ToDouble(textBox2.Text));
            neuralNet.run();
            textBox4.Text = "" + neuralNet.getOuputData(0);
        }
    }
}
