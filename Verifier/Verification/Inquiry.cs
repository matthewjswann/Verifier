using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Verifier.Verification
{
   public class Inquiry
   {
      // bool block

      public static bool IsTrue(bool target)
      {
         return true == target;
      }

      public static bool IsFalse(bool target)
      {
         return false == target;
      }

      // object block

      public static bool IsNull(Object target)
      {
         return null == target;
      }

      public static bool IsNotNull(Object target)
      {
         return null != target;
      }

      // string block

      public static bool IsEmpty(string target)
      {
         return string.Equals(target, string.Empty);
      }
      
      public static bool IsNotEmpty(string target)
      {
         return !(string.Equals(target, string.Empty));
      }

      public static bool IsNullOrEmpty(string target)
      {
         return null == target || string.Equals(target, string.Empty);
      }

      public static bool IsNotNullOrEmpty(string target)
      {
         return !(null == target || string.Equals(target, string.Empty));
      }

      public static bool IsEmptyOrWhiteSpace(string target)
      {
         return string.Equals(target.Trim(), string.Empty);
      }

      public static bool IsNotEmptyOrWhiteSpace(string target)
      {
         return !(string.Equals(target.Trim(), string.Empty));
      }

      public static bool IsNullEmptyOrWhiteSpace(string target)
      {
         return null == target || string.Equals(target.Trim(), string.Empty);
      }

      public static bool IsNotNullEmptyOrWhiteSpace(string target)
      {
         return !(null == target || string.Equals(target.Trim(), string.Empty));
      }

      public static bool IsMeetingExactLength(string target, int length)
      {
         return target.Length == length;
      }

      public static bool IsNotMeetingExactLength(string target, int length)
      {
         return !(target.Length == length);
      }

      public static bool IsMeetingMinimumLength(string target, int minLength)
      {
         return target.Length >= minLength;
      }

      public static bool IsMeetingMaximumLength(string target, int maxLength)
      {
         return target.Length <= maxLength;
      }

      public static bool IsMeetingLengthRange(string target, int minLength, int maxLength)
      {
         return target.Length >= minLength && target.Length <= maxLength;
      }

      public static bool IsValidEmail(string target)
      {
         try
         {
            new MailAddress(target);
            return true;
         }
         catch (FormatException)
         {
            return false;
         }
      }

      // list block

      public static bool IsEmpty<T>(List<T> target)
      {
         return !(target.Any());
      }
      
      public static bool IsNotEmpty<T>(List<T> target)
      {
         return target.Any();
      } 

      public static bool IsNullOrEmpty<T>(List<T> target)
      {
         return null == target || !target.Any();
      }

      public static bool IsNotNullOrEmpty<T>(List<T> target)
      {
         return !(null == target || !target.Any());
      }

      // number block

      public static bool IsZero(double target)
      {
         return target == 0;
      }

      public static bool IsPositive(double target)
      {
         return target > 0;
      }

      public static bool IsNegative(double target)
      {
         return target < 0;
      }

      public static bool IsWithinRange(double target, double floor, double ceiling)
      {
         return target >= floor && target <= ceiling;
      }

      // Date/Datetime
      // date match, date after, on or after, before, on or before, between
      // datetime after, on or after, before, on or before, between

      //public static bool IsOnSameDay()
      //{

      //}

      //public 

      //public static bool IsOnOrBefore(DateTime target, DateTime sentileDate)
      //{
      //   return null;
      //}
   }
}
