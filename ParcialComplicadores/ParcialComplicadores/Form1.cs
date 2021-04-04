using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialComplicadores
{
    public partial class Form1 : Form
    {

        private String CaracterActual;
        private String CaracterAnterior="";
        private String LineaResultado = "";
        const String ESPACIO= " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void ConvertirAMorse() {
            String cadenaAValidar = txtLatino.Text.Trim();
            Char[] caractereresAValidar =cadenaAValidar.ToCharArray();
            for (int i = 0; caractereresAValidar.Length > i; i++)
            {
                if (i == 0)
                {
                    CaracterActual = caractereresAValidar[i].ToString().ToLower();
                }
                else if (i > 0) {
                    CaracterActual = caractereresAValidar[i].ToString().ToLower();
                    CaracterAnterior = caractereresAValidar[i-1].ToString().ToLower();
                }
                switch (CaracterActual)
                {
                    case "a":
                        LineaResultado += ".-"+ESPACIO;
                        break;
                    case "b":
                        LineaResultado += "-..." + ESPACIO;
                        break;
                    case "c":
                        LineaResultado += "-.-." + ESPACIO;
                        break;
                    case "d":
                        LineaResultado += "-.." + ESPACIO;
                        break;
                    case "e":
                        LineaResultado += "." + ESPACIO;
                        break;
                    case "f":
                        LineaResultado += "..-." + ESPACIO;
                        break;
                    case "g":
                        LineaResultado += "--." + ESPACIO;
                        break;
                    case "h":
                        LineaResultado += "...." + ESPACIO;
                        break;
                    case "i":
                        LineaResultado += ".." + ESPACIO;
                        break;
                    case "j":
                        LineaResultado += ".---" + ESPACIO;
                        break;
                    case "k":
                        LineaResultado += "-.-" + ESPACIO;
                        break;
                    case "l":
                        LineaResultado += ".-.." + ESPACIO;
                        break;
                    case "m":
                        LineaResultado += "--" + ESPACIO;
                        break;
                    case "n":
                        LineaResultado += "-." + ESPACIO;
                        break;
                    case "ñ":
                        LineaResultado += "#" + ESPACIO;
                        break;
                    case "o":
                        LineaResultado += "---" + ESPACIO;
                        break;
                    case "p":
                        LineaResultado += ".--." + ESPACIO;
                        break;
                    case "q":
                        LineaResultado += "--.-" + ESPACIO;
                        break;
                    case "r":
                        LineaResultado += ".-." + ESPACIO;
                        break;
                    case "s":
                        LineaResultado += "..." + ESPACIO;
                        break;
                    case "t":
                        LineaResultado += "-" + ESPACIO;
                        break;
                    case "u":
                        LineaResultado += "..-" + ESPACIO;
                        break;
                    case "v":
                        LineaResultado += "...-" + ESPACIO;
                        break;
                    case "w":
                        LineaResultado += ".--" + ESPACIO;
                        break;
                    case "x":
                        LineaResultado += "-..-" + ESPACIO;
                        break;
                    case "y":
                        LineaResultado += "-.--" + ESPACIO;
                        break;
                    case "z":
                        LineaResultado += "--.." + ESPACIO;
                        break;
                    case "1":
                        LineaResultado += ".----" + ESPACIO;
                        break;
                    case "2":
                        LineaResultado += "..---" + ESPACIO;
                        break;
                    case "3":
                        LineaResultado += "...--" + ESPACIO;
                        break;
                    case "4":
                        LineaResultado += "....-" + ESPACIO;
                        break;
                    case "5":
                        LineaResultado += "....." + ESPACIO;
                        break;
                    case "6":
                        LineaResultado += "-...." + ESPACIO;
                        break;
                    case "7":
                        LineaResultado += "--..." + ESPACIO;
                        break;
                    case "8":
                        LineaResultado += "---.." + ESPACIO;
                        break;
                    case "9":
                        LineaResultado += "----." + ESPACIO;
                        break;
                    case "0":
                        LineaResultado += "-----" + ESPACIO;
                        break;
                    case " ":
                        if (CaracterAnterior != " "){
                            LineaResultado += "/" + ESPACIO;
                        }
                        break;
                    case ".":
                        LineaResultado += ".-.-.-" + ESPACIO;
                        break;
                    case ",":
                        LineaResultado += "--..--" + ESPACIO;
                        break;
                    case "?":
                        LineaResultado += "..--.." + ESPACIO;
                        break;
                    case "'":
                        LineaResultado += ".----." + ESPACIO;
                        break;
                    case "!":
                        LineaResultado += "	-.-.--" + ESPACIO;
                        break;
                    case "/":
                        LineaResultado += "-..-." + ESPACIO;
                        break;
                    case "(":
                        LineaResultado += "	-.--." + ESPACIO;
                        break;
                    case ")":
                        LineaResultado += "-.--.-" + ESPACIO;
                        break;
                    case "&":
                        LineaResultado += ".-..." + ESPACIO;
                        break;
                    case ":":
                        LineaResultado += "---..." + ESPACIO;
                        break;
                    case ";":
                        LineaResultado += "-.-.-." + ESPACIO;
                        break;
                    case "=":
                        LineaResultado += "-...-" + ESPACIO;
                        break;
                    case "+":
                        LineaResultado += ".-.-." + ESPACIO;
                        break;
                    case "-":
                        LineaResultado += "-....-" + ESPACIO;
                        break;
                    case "_":
                        LineaResultado += "..--.-" + ESPACIO;
                        break;
                    case "'u0022'"://Comillas dobles
                        LineaResultado += ".-..-." + ESPACIO;
                        break;
                    case "$":
                        LineaResultado += "...-..-" + ESPACIO;
                        break;
                    case "@":
                        LineaResultado += ".--.-." + ESPACIO;
                        break;
                    case "¿":
                        LineaResultado += "..-.-" + ESPACIO;
                        break;
                    case "¡":
                        LineaResultado += "--...-" + ESPACIO;
                        break;
                    case "\r":
                        break;
                    case "\n":
                        break;
                    default:
                        LineaResultado += "#" + ESPACIO;
                        break;

                }
            }
            txtMorse.Text = LineaResultado.ToUpper();
            
        }


        private void ConvertirALatino()
        {
            String cadenaAValidar = txtMorse.Text.Trim();
            String[] caractereresAValidar = cadenaAValidar.Split(' ');
            for (int i = 0; caractereresAValidar.Length > i; i++)
            {
                if (i == 0)
                {
                    CaracterActual = caractereresAValidar[i].ToString().ToLower();
                }
                else if (i > 0)
                {
                    CaracterActual = caractereresAValidar[i].ToString().ToLower();
                    CaracterAnterior = caractereresAValidar[i - 1].ToString().ToLower();
                }
                if (CaracterActual == "") {
                    CaracterActual = " ";
                }
                switch (CaracterActual)
                {
                    case ".-":
                        LineaResultado += "a";
                        break;
                    case "-...":
                        LineaResultado += "b";
                        break;
                    case "-.-.":
                        LineaResultado += "c";
                        break;
                    case "-..":
                        LineaResultado += "d";
                        break;
                    case ".":
                        LineaResultado += "e";
                        break;
                    case "..-.":
                        LineaResultado += "f";
                        break;
                    case "--.":
                        LineaResultado += "g";
                        break;
                    case "....":
                        LineaResultado += "h";
                        break;
                    case "..":
                        LineaResultado += "i";
                        break;
                    case ".---":
                        LineaResultado += "j";
                        break;
                    case "-.-":
                        LineaResultado += "k";
                        break;
                    case ".-..":
                        LineaResultado += "l";
                        break;
                    case "--":
                        LineaResultado += "m";
                        break;
                    case "-.":
                        LineaResultado += "n";
                        break;
                    case "---":
                        LineaResultado += "o";
                        break;
                    case ".--.":
                        LineaResultado += "p";
                        break;
                    case "--.-":
                        LineaResultado += "q";
                        break;
                    case ".-.":
                        LineaResultado += "r";
                        break;
                    case "...":
                        LineaResultado += "s";
                        break;
                    case "-":
                        LineaResultado += "t";
                        break;
                    case "..-":
                        LineaResultado += "u";
                        break;
                    case "...-":
                        LineaResultado += "v";
                        break;
                    case ".--":
                        LineaResultado += "w";
                        break;
                    case "-..-":
                        LineaResultado += "x";
                        break;
                    case "-.--":
                        LineaResultado += "y";
                        break;
                    case "--..":
                        LineaResultado += "z";
                        break;
                    case ".----":
                        LineaResultado += "1";
                        break;
                    case "..---":
                        LineaResultado += "2";
                        break;
                    case "...--":
                        LineaResultado += "3";
                        break;
                    case "....-":
                        LineaResultado += "4";
                        break;
                    case ".....":
                        LineaResultado += "5";
                        break;
                    case "-....":
                        LineaResultado += "6";
                        break;
                    case "--...":
                        LineaResultado += "7";
                        break;
                    case "---..":
                        LineaResultado += "8";
                        break;
                    case "----.":
                        LineaResultado += "9";
                        break;
                    case "-----":
                        LineaResultado += "0";
                        break;
                    case " ":
                        
                        break;
                    case ".-.-.-":
                        LineaResultado += ".";
                        break;
                    case "--..--":
                        LineaResultado += ",";
                        break;
                    case "..--..":
                        LineaResultado += "?";
                        break;
                    case ".----.":
                        LineaResultado += "'";
                        break;
                    case "-.-.--":
                        LineaResultado += "!";
                        break;
                    case "-..-.":
                        LineaResultado += "/";
                        break;
                    case "-.--.":
                        LineaResultado += "(";
                        break;
                    case "-.--.-":
                        LineaResultado += ")";
                        break;
                    case ".-...":
                        LineaResultado += "&";
                        break;
                    case "---...":
                        LineaResultado += ":";
                        break;
                    case "-.-.-.":
                        LineaResultado += ";";
                        break;
                    case "-...-":
                        LineaResultado += "=";
                        break;
                    case ".-.-.":
                        LineaResultado += "+";
                        break;
                    case "-....-":
                        LineaResultado += "-";
                        break;
                    case "..--.-":
                        LineaResultado += "_";
                        break;
                    case ".-..-."://Comillas dobles revisar
                        LineaResultado += "'u0022'";
                        break;
                    case "...-..-":
                        LineaResultado += "$";
                        break;
                    case ".--.-.":
                        LineaResultado += "@";
                        break;
                    case "..-.-":
                        LineaResultado += "¿";
                        break;
                    case "--...-":
                        LineaResultado += "¡";
                        break;
                    case "/":
                        LineaResultado += " ";
                        break;
                    case "\r":
                        break;
                    case "\n":
                        break;
                    default:
                        LineaResultado += "#" + ESPACIO;
                        break;

                }
            }
            txtLatino.Text = LineaResultado.ToUpper();

        }


        private void chkLatinoAMorse_CheckedChanged(object sender, EventArgs e)
        {

            if (chkLatinoAMorse.Enabled)
            {
                txtLatino.Enabled = true;
                txtMorse.Enabled = false;
                chkMorseALatino.Checked = false;
                btnConvAMorse.Enabled = true;
                btnConvertirALatino.Enabled = false;
            }
            else {
                chkLatinoAMorse.Checked = true;
                txtLatino.Enabled = false;
                chkMorseALatino.Checked = false;
            }
        }

        private void chkMorseALatino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMorseALatino.Enabled)
            {
                txtLatino.Enabled = false;
                txtMorse.Enabled = true;
                chkLatinoAMorse.Checked = false;
                btnConvAMorse.Enabled = false;
                btnConvertirALatino.Enabled = true;
            }
            else
            {
                txtLatino.Enabled = false;
                txtMorse.Enabled = true;
                chkMorseALatino.Checked = false;
            }
        }

        private void btnConvAMorse_Click(object sender, EventArgs e)
        {
            limpiarResultado();
            ConvertirAMorse();
        }

        private void btnConvertirALatino_Click(object sender, EventArgs e)
        {
            limpiarResultado();
            ConvertirALatino();
        }

        private void limpiarResultado() {
            LineaResultado = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtLatino.Clear();
                    txtMorse.Clear();
                    string[] lines = System.IO.File.ReadAllLines(@openFileDialog1.FileName);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (txtLatino.Enabled) {
                            txtLatino.Text += (lines[i]);
                        }
                        else
                        {
                            txtMorse.Text += (lines[i]);
                        }
                    }
                    if (txtLatino.Enabled)
                    {
                        limpiarResultado();
                        ConvertirAMorse();
                    }
                    else
                    {
                        limpiarResultado();
                        ConvertirALatino();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Farid el mejor " + exception);
            }
        }
    }
}
