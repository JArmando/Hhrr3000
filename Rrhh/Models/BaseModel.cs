using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public abstract class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<ValidationResult> Errors = new List<ValidationResult>();

        public bool IsValid()
        {
            Validate();
            return !Errors.Any();
        }

        public IEnumerable<ValidationResult> Validate()
        {
            var errors = new List<ValidationResult>();
            var validationContext = new ValidationContext(this, null, null);
            var vResult = new List<ValidationResult>();
            Validator.TryValidateObject(this, validationContext, errors, true);
            Errors = Errors.Concat(errors);
            return vResult;
        }
    }
    public static class DbSetExtension
    {
        public static IQueryable<BaseModel> Active(this IQueryable<BaseModel> query)
        {
            return query.Where(x => x.IsActive);
        }
    }

}

    //public class ModelError
    //{
    //    public string PropertyName { get; }
    //    public string Message { get; }

    //    public ModelError(string propertyName, string message)
    //    {
    //        PropertyName = propertyName;
    //        Message = message;
    //    }
    //}



