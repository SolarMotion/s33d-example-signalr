using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApi.Helpers
{
    public static class CommonExtension
    {
        #region DB Exception

        /// <summary>
        ///     A DbEntityValidationException extension method that formates validation errors to string.
        /// </summary>
        public static string DbEntityValidationExceptionToString(this DbEntityValidationException e)
        {
            var validationErrors = e.DbEntityValidationResultToString();
            var exceptionMessage = string.Format("{0}{1}Validation errors:{1}{2}", e, Environment.NewLine, validationErrors);
            return exceptionMessage;
        }

        /// <summary>
        ///     A DbEntityValidationException extension method that aggregate database entity validation results to string.
        /// </summary>
        public static string DbEntityValidationResultToString(this DbEntityValidationException e)
        {
            return e.EntityValidationErrors
                    .Select(dbEntityValidationResult => dbEntityValidationResult.DbValidationErrorsToString(dbEntityValidationResult.ValidationErrors))
                    .Aggregate(string.Empty, (current, next) => string.Format("{0}{1}{2}", current, Environment.NewLine, next));
        }

        /// <summary>
        ///     A DbEntityValidationResult extension method that to strings database validation errors.
        /// </summary>
        public static string DbValidationErrorsToString(this DbEntityValidationResult dbEntityValidationResult, IEnumerable<DbValidationError> dbValidationErrors)
        {
            var entityName = string.Format("[{0}]", dbEntityValidationResult.Entry.Entity.GetType().Name);
            const string indentation = "\t - ";
            var aggregatedValidationErrorMessages = dbValidationErrors.Select(error => string.Format("[{0} - {1}]", error.PropertyName, error.ErrorMessage))
                                                   .Aggregate(string.Empty, (current, validationErrorMessage) => current + (Environment.NewLine + indentation + validationErrorMessage));
            return string.Format("{0}{1}", entityName, aggregatedValidationErrorMessages);
        }

        #endregion

        #region Formatting

        public static string ToJson(this object @object)
        {
            return JsonConvert.SerializeObject(@object);
        }

        public static string GetTime()
        {
            return DateTime.Now.ToString("HHmmss");
        }

        public static string GetEnumDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }

            return GenericEnum.ToString();
        }

        #endregion
    }
}