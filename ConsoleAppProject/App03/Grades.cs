using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public enum Grades
    {
        [Description("No grade has been given.")]
        [Display(Name = "No Grade has been awarded.")]
        NULL,
        [Description("Fail.")]
        [Display(Name = "Not Passed.")]
        F,
        [Description("Third Class")]
        [Display(Name = "Third Class")]
        D,
        [Description("Lower Second")]
        [Display(Name = "Lower Second")]
        C,
        [Description("Upper Second")]
        [Display(Name = "Upper Second")]
        B,
        [Description("First Class")]
        [Display(Name = "First Class")]
        A
    }



}
