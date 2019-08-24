using System;
using System.Collections.Generic;
using System.Text;

namespace Verifier.Verification
{
   public class VerifyException : Exception
   {
      public VerifyException() 
         : base()
      {
      }

      public VerifyException(string message) 
         : base(message)
      {
      }

      public VerifyException(string message, Exception innerException)
         : base(message, innerException)
      {
      }

   }
}
