using System;
using System.Collections.Generic;
/// <summary>
///  Class OBJ
/// </summary>
class Obj
{
    /// <summary>
    /// Return True or False
    /// </summary>
    /// <param name="obj">parameter</param>
    /// <returns>returns true if is object otherwise returns false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj == null)
            return false;
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        else
            return false;
    }
}