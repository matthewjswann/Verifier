using System;
using System.Collections.Generic;

namespace Verifier.Verification
{
   public static class Verify
   {
      // bool block

      public static void True(bool target)
      {
         if (!Inquiry.IsTrue(target))
         {
            throw new VerifyException("Target value should be 'true'.");
         }
      }

      public static void False(bool target)
      {
         if (!Inquiry.IsFalse(target))
         {
            throw new VerifyException("Target value should be 'false'.");
         }
      }

      // object block

      public static void Null(Object target)
      {
         if (!Inquiry.IsNull(target))
         {
            throw new VerifyException("Target value should be null.");
         }
      }

      public static void NotNull(Object target)
      {
         if (!Inquiry.IsNotNull(target))
         {
            throw new VerifyException("Target value should not be null.");
         }
      }

      // string block

      public static void Empty(string target)
      {
         if (!Inquiry.IsEmpty(target))
         {
            throw new VerifyException("Target string should be empty.");
         }
      }

      public static void NotEmpty(string target)
      {
         if (!Inquiry.IsNotEmpty(target))
         {
            throw new VerifyException("Target string not should be empty.");
         }
      }

      public static void NullOrEmpty(string target)
      {
         if (!Inquiry.IsNullOrEmpty(target))
         {
            throw new VerifyException("Target string should be either null or empty.");
         }
      }

      public static void NotNullOrEmpty(string target)
      {
         if (!Inquiry.IsNotNullOrEmpty(target))
         {
            throw new VerifyException("Target string not should be either null or empty.");
         }
      }

      public static void EmptyOrWhiteSpace(string target)
      {
         if (!Inquiry.IsEmptyOrWhiteSpace(target))
         {
            throw new VerifyException("Target string should be either null or empty.");
         }
      }

      public static void NotEmptyOrWhiteSpace(string target)
      {
         if (!Inquiry.IsNotEmptyOrWhiteSpace(target))
         {
            throw new VerifyException("Target string should not be null or empty.");
         }
      }

      public static void NullEmptyOrWhiteSpace(string target)
      {
         if (!Inquiry.IsNullEmptyOrWhiteSpace(target))
         {
            throw new VerifyException("Target string should be either null, empty, or whitespace.");
         }
      }

      public static void NotNullEmptyOrWhiteSpace(string target)
      {
         if (!Inquiry.IsNotNullEmptyOrWhiteSpace(target))
         {
            throw new VerifyException("Target string should not be null, empty, or whitespace.");
         }
      }

      public static void MeetingExactLength(string target, int length)
      {
         if (!Inquiry.IsMeetingExactLength(target, length))
         {
            throw new VerifyException("Target string does not match desired length.");
         }
      }

      public static void NotMeetingExactLength(string target, int length)
      {
         if (!Inquiry.IsNotMeetingExactLength(target, length))
         {
            throw new VerifyException("Target string should not match undesired length.");
         }
      }

      public static void MeetingMinimumLength(string target, int length)
      {
         if (!Inquiry.IsMeetingMinimumLength(target, length))
         {
            throw new VerifyException("Target string does not meet minimum length requirements.");
         }
      }

      public static void MeetingMaximumLength(string target, int length)
      {
         if (!Inquiry.IsMeetingMaximumLength(target, length))
         {
            throw new VerifyException("Target string does not meet maximum length requirements.");
         }
      }

      public static void MeetingLengthRange(string target, int minLength, int maxLength)
      {
         if (!Inquiry.IsMeetingLengthRange(target, minLength, maxLength))
         {
            throw new VerifyException("Target string does not meet length range requirements.");
         }
      }

      public static void ValidEmail(string target)
      {
         if (!Inquiry.IsValidEmail(target))
         {
            throw new VerifyException("Target string is not a valid email address.");
         }
      }

      // list block

      public static void Empty<T>(List<T> target)
      {
         if (!Inquiry.IsEmpty(target))
         {
            throw new VerifyException("Target list should be empty.");
         }
      }

      public static void NotEmpty<T>(List<T> target)
      {
         if (!Inquiry.IsNotEmpty(target))
         {
            throw new VerifyException("Target list should not be empty.");
         }
      }

      public static void NullOrEmpty<T>(List<T> target)
      {
         if (!Inquiry.IsNullOrEmpty(target))
         {
            throw new VerifyException("Target list should be either null or empty.");
         }
      }

      public static void NotNullOrEmpty<T>(List<T> target)
      {
         if (!Inquiry.IsNotNullOrEmpty(target))
         {
            throw new VerifyException("Target list should not be null or empty.");
         }
      }

      // number block

      public static void Zero(double target)
      {
         if (!Inquiry.IsZero(target))
         {
            throw new VerifyException("Target value should be zero.");
         }
      }

      public static void Positive(double target)
      {
         if (!Inquiry.IsPositive(target))
         {
            throw new VerifyException("Target value should be positive.");
         }
      }

      public static void Negative(double target)
      {
         if (!Inquiry.IsNegative(target))
         {
            throw new VerifyException("Target value should be negative.");
         }
      }

      public static void WithinRange(double target, double floor, double ceiling)
      {
         if (!Inquiry.IsWithinRange(target, floor, ceiling))
         {
            throw new VerifyException("Target value does not fall within specified range.");
         }
      }
   }
}
