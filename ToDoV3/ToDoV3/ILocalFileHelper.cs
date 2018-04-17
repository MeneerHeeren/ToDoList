using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoV3.Data
{
    public interface ILocalFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
