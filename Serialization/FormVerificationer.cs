using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using static System.Windows.Forms.Control;
namespace Serialization
{
    class FormVerificationer
    {
        private bool IsFormCorrect;
        private List<string> TroubledFields;
        public int ReturnResultOfConverting(string text)
        {
            return Convert.ToInt32(text);
        }
        public int ConvertIntValues(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
            }
            catch
            {
                SetValuesOfVerificator(textBox);
                return -10;
            }
                return Convert.ToInt32(textBox.Text);
        }

        public void SetValuesOfVerificator(TextBox textBox)
        {
            TroubledFields.Add(textBox.Tag.ToString());
            IsFormCorrect = false;
        }

        public float ConvertFloatValues(TextBox textBox)
        {
            try
            {
                float doubleValue = (float)Convert.ToDouble(textBox.Text);
            }
            catch
            {
                SetValuesOfVerificator(textBox);
                return (float)-10.00;
            }
            return (float)Convert.ToDouble(textBox.Text);
        }
        public DateTime ConvertPublishDate(DateTimePicker pickerOfDate)
        {
            return pickerOfDate.Value;
        }
        public FormVerificationer()
        {
            IsFormCorrect = true;
            TroubledFields = new List<string>();
        }
        public void OutputErrorMessage()
        {
            if (!IsFormCorrect){
                string errorMessage = "";
                foreach(string textBox in TroubledFields)
                {
                    errorMessage += "Ошибка в поле " + textBox + '\n';
                }
                MessageBox.Show(errorMessage);
            }
        } 
        
    }
}
