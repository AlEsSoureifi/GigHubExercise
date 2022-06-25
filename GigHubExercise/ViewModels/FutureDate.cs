using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GigHubExercise.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd MMM yyyy",
                DateTimeFormatInfo.InvariantInfo,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }

        //protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        //{
        //    try
        //    {
        //        DateTime dateTime;
        //        var isValid = DateTime.TryParseExact(Convert.ToString(value),
        //            "dd MMM yyyy",
        //            DateTimeFormatInfo.InvariantInfo,
        //            DateTimeStyles.None,
        //            out dateTime);
        //        if (dateTime < DateTime.Now)
        //        {
        //            return new ValidationResult("Date must be greater than today obviously!!!Wake up!!!");
        //        }
        //    }
        //    catch 
        //    {

        //        return new ValidationResult("Wrong date format.Try again (ex : 10 Nov 2000) ");
        //    }
        //    return ValidationResult.Success;                      
        //}
    }
}