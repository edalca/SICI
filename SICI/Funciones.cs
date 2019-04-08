using MetroFramework.Controls;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System;
using System.Globalization;

namespace SICI
{
    class Funciones
    {
        public static bool esValido(Control control)
        {
            bool valido = true;

            foreach (Control c in control.Controls)
            {
                if(c.GetType()==typeof(GroupBox) || c.GetType() == typeof(Panel))
                {
                    if (esValido(c)==false)
                    {
                        valido = false;
                    }
                }else
                if(c.GetType()==typeof(MetroTextBox))
                {
                    MetroTextBox textBox = (MetroTextBox)c;
                    if (textBox.esValido()==false)
                    {
                        valido = false;
                    }
                }else
                if (c.GetType()==typeof(MetroComboBox))
                {
                    MetroComboBox comboBox = (MetroComboBox)c;
                    if(comboBox.esValido()==false)
                    {
                        valido = false;
                    }
                }else
                if (c.GetType() == typeof(MaskedTextBox))
                {
                    MaskedTextBox maskedTextBox = c as MaskedTextBox;
                    if (maskedTextBox.MaskFull == false)
                    {
                        valido = false;

                    }
                }
            }
            return valido;
        }

        public static void Limpiar(Control control)
        {
            
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(GroupBox) || c.GetType() == typeof(Panel))
                {
                    Limpiar(c);
                }
                else
                if (c.GetType() == typeof(MetroTextBox))
                {
                    MetroTextBox textBox = (MetroTextBox)c;
                    textBox.Clear();
                }
                else
                if (c.GetType() == typeof(MetroComboBox))
                {
                    MetroComboBox comboBox = (MetroComboBox)c;
                    comboBox.Text = null;
                }
                else
                if (c.GetType()== typeof(MetroButton))
                {
                    MetroButton button = c as MetroButton;
                    button.ButtonID = 0;
                }else
                if (c.GetType()==typeof(MaskedTextBox))
                {
                    MaskedTextBox maskedTextBox = c as MaskedTextBox;
                    maskedTextBox.Clear();
                }
            }
        }

        public static DialogResult Message(SqlException sqlex,Control control,string message, MessageBoxButtons boxButtons,MessageBoxIcon boxIcon,int height)
        {
            if (sqlex != null)
            {
                if( sqlex.Number==547)
                {
                    return MetroMessageBox.Show(control, "El registro no se puede eliminar", Application.ProductName, boxButtons, boxIcon, 100);
                }else
                if (sqlex.Number==2601)
                {
                    return MetroMessageBox.Show(control, "No se pueden guardar registros duplicados", Application.ProductName, boxButtons, boxIcon, 100);
                }
                else
                {
                    return DialogResult.Cancel;
                }
            }
            else
            {
               return MetroMessageBox.Show(control, message, Application.ProductName, boxButtons, boxIcon, height);
            }

        }

        public static string tittleCase(string Valor)
        {
           return  CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Valor.ToLower());
        }

        public static void CerrarTab(Form form)
        {
            TabPage tabPage = (TabPage)form.Parent;
            MetroTabControl tabControl =(MetroTabControl) tabPage.Parent;
            form.Close();
            tabControl.TabPages.Remove(tabPage);
            tabPage.Dispose();

        }

    }
}
