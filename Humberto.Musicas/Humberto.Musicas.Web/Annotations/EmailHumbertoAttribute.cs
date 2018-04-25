using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Humberto.Musicas.Web.Annotations
{
    public class EmailHumbertoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@treinaweb.com.br");
        }
    }
}