using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace FormComponent
{
    interface IFormInput
    {
        bool isValid();
        String getValue();
        String getName();

        void clearField();

        void setFieldHorizontalPosition(int horizontalPosition);
        void setErrorPosition(Point point);

        void setErrorSize(Size size);

        void setInputSize(Size size);

    }
}
