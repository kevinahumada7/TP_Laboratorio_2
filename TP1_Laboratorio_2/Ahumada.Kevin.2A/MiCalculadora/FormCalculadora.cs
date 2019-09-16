using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.cbo_Operador.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_Operador.Items.Add("+");
            this.cbo_Operador.Items.Add("-");
            this.cbo_Operador.Items.Add("*");
            this.cbo_Operador.Items.Add("/");
            this.cbo_Operador.SelectedItem = "+";

            this.btn_ConvertBin.Enabled = false;
            this.btn_ConvertDec.Enabled = false;
        }

        private void Btn_Operar_Click(object sender, EventArgs e)
        {
            double result = Operar(txt_Operando1.Text, txt_Operando2.Text, cbo_Operador.Text);
            lbl_Result.Text = result.ToString();

            btn_ConvertBin.Enabled = true;
            btn_ConvertDec.Enabled = false;
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

            btn_ConvertBin.Enabled = false;
            btn_ConvertDec.Enabled = false;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ConvertBin_Click(object sender, EventArgs e)
        {
            btn_ConvertBin.Enabled = false;
            btn_ConvertDec.Enabled = true;
            this.lbl_Result.Text = Numero.DecimalBinario(lbl_Result.Text);
        }

        private void Btn_ConvertDec_Click(object sender, EventArgs e)
        {
            this.btn_ConvertDec.Enabled = false;
            this.btn_ConvertBin.Enabled = true;
            this.lbl_Result.Text = Numero.BinarioDecimal(lbl_Result.Text);
        }

        void Limpiar()
        {
            txt_Operando1.Text = "";
            txt_Operando2.Text = "";
            lbl_Result.Text = "";
            cbo_Operador.SelectedIndex = 0;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }
    }
}
