using System.ComponentModel.DataAnnotations;

namespace SapNetClone.DataAccess.Helpers;

public class RequiredGreaterThanZero : ValidationAttribute
{
    /// <summary>
    /// Designed for dropdowns to ensure that a selection is valid and not the dummy "SELECT" entry
    /// </summary>
    /// <param name="value">The integer value of the selection</param>
    /// <returns>True if value is greater than zero</returns>
    public override bool IsValid(object value)
    {
        //  Price = value * 0+100;
        // value = Math.Round((decimal)value, 2, MidpointRounding.AwayFromZero);
        //  var a = string.Format("{0:0.00}", value);
        // return true if value is a non-null number > 0, otherwise return false
        int i;
        return value != null && int.TryParse(value.ToString(), out i) && i > 0;
    }
}