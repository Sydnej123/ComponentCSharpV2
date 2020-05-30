using System;
using System.Collections.Generic;
using System.Text;

namespace FormComponent
{
    /// <summary>
    /// Options for FormComboBoxInput
    /// </summary>
    public class FormComboBoxOption
    {
        private string _text ="";
        private string _value="";
        
        /// <summary>
        /// Visible text for option
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        /// <summary>
        /// Value of option
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        /// <summary>
        /// Returns text to string
        /// </summary>
        /// <returns>String value of Text</returns>
        public override string ToString()
        {
            return this.Text;
        }
    }
}
