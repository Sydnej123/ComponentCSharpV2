using System;
using System.Collections.Generic;
using System.Text;

namespace FormComponent
{
    public class FormComboBoxOption
    {
        private string _text ="";
        private string _value="";
        
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
