using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Exeptions
{
    public class ValidationExeption : Exception
    {
        public ValidationExeption() : this("Validation error occured")
        {

        }
        public ValidationExeption(String Message) : base(Message)
        {

        }
        public ValidationExeption(Exception ex) : this(ex.Message)
        {

        }
    }
}
