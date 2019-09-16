using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        private double ValidarNumero(string strNumero)
        {
            double numero;
            double result;

            if (double.TryParse(strNumero,out numero))
            {
                result = numero;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if(num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }
        }

        public static string BinarioDecimal(string binario)
        {
            char digit;
            int numero = 0;
            int index = binario.Length - 1;
            string strNumero = "0";

            for (int i = 0; i < binario.Length; i++)
            {
                digit = binario[index];
                index--;

                if (digit == '1')
                {
                    numero += (int)Math.Pow(2, i);
                    strNumero = numero.ToString();
                }
                else if (digit == '0')
                {
                    continue;
                }
                else
                {
                    strNumero = "Valor Invalido";
                    break;
                }
            }

            return strNumero;
        }
        

        public static string DecimalBinario(double numero)
        {
            string strBinario;

            if (numero >= 0)
            {
                strBinario = Convert.ToString(Convert.ToInt64(numero),2);
            }
            else
            {
                strBinario = "Valor Invalido";
            }

            return strBinario;
        }

        public static string DecimalBinario(string strNumero)
        {
            string strBinario;
            double numero;

            if(double.TryParse(strNumero, out numero))
            {
                strBinario = DecimalBinario(numero);
            }
            else
            {
                strBinario = "Valor Invalido";
            }

            return strBinario;
        }
    }
}
