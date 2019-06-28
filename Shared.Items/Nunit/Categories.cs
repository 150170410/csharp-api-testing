using System;
using System.ComponentModel;

namespace Shared.Items.Nunit
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple=false)]
    public class HighPrioAttribute : CategoryAttribute 
    { }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple=false)]
    public class MediumPrioAttribute : CategoryAttribute 
    { }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple=false)]
    public class LowPrioAttribute : CategoryAttribute 
    { }
}
