using System;
using System.Collections.Generic;
using System.Text;

namespace FormComponent
{
    interface IFormInput
    {
        bool isValid();
        String getValue();
        String getName();


    }
}
