using Verifier.Verification;

namespace Verifier
{
   class Program
   {
      static void Main(string[] args)
      {
         DebugSandbox();
      }

      public static void DebugSandbox()
      {
         var myBool = Inquiry.IsNull(null);
         Verify.NotNull("string");
      }
   }
}
