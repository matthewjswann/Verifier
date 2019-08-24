using System;
using Xunit;
using Verifier.Verification;

namespace Verifier.Test
{
   public class InquiryTest
   {
      // bool block

      [Fact]
      public void test_bool_IsTrue_00_01()
      {
         Assert.True(Inquiry.IsTrue(AgnosticTestData.TRUE));
      }

      [Fact]
      public void test_bool_IsTrue_00_02()
      {
         Assert.False(Inquiry.IsTrue(AgnosticTestData.FALSE));
      }

      [Fact]
      public void test_bool_IsFalse_00_01()
      {
         Assert.True(Inquiry.IsFalse(AgnosticTestData.FALSE));
      }

      [Fact]
      public void test_bool_IsFalse_00_02()
      {
         Assert.False(Inquiry.IsFalse(AgnosticTestData.TRUE));
      }

      // object block

      [Fact]
      public void test_Object_IsNull_00_01()
      {
         Assert.True(Inquiry.IsNull(AgnosticTestData.NULL_OBJECT));
      }

      [Fact]
      public void test_obect_IsNull_00_02()
      {
         Assert.False(Inquiry.IsNull(AgnosticTestData.OBJECT));
      }

      [Fact]
      public void test_Object_IsNotNull_00_01()
      {
         Assert.True(Inquiry.IsNotNull(AgnosticTestData.OBJECT));
      }

      [Fact]
      public void test_Object_IsNotNull_00_02()
      {
         Assert.False(Inquiry.IsNotNull(AgnosticTestData.NULL_OBJECT));
      }

      // string block

      [Fact]
      public void test_String_IsEmpty_00_01()
      {
         Assert.True(Inquiry.IsEmpty(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsEmpty_00_02()
      {
         Assert.False(Inquiry.IsEmpty(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsEmpty_00_03()
      {
         Assert.False(Inquiry.IsEmpty(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsNotEmpty_00_01()
      {
         Assert.False(Inquiry.IsNotEmpty(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsNotEmpty_00_02()
      {
         Assert.True(Inquiry.IsNotEmpty(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsNotEmpty_00_03()
      {
         Assert.True(Inquiry.IsNotEmpty(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsNullOrEmpty_00_01()
      {
         Assert.True(Inquiry.IsNullOrEmpty(AgnosticTestData.NULL_STRING));
      }

      [Fact]
      public void test_String_IsNullOrEmpty_00_02()
      {
         Assert.True(Inquiry.IsNullOrEmpty(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsNullOrEmpty_00_03()
      {
         Assert.False(Inquiry.IsNullOrEmpty(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsNullOrEmpty_00_04()
      {
         Assert.False(Inquiry.IsNullOrEmpty(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsNotNullOrEmpty_00_01()
      {
         Assert.False(Inquiry.IsNotNullOrEmpty(AgnosticTestData.NULL_STRING));
      }

      [Fact]
      public void test_String_IsNotNullOrEmpty_00_02()
      {
         Assert.False(Inquiry.IsNotNullOrEmpty(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsNotNullOrEmpty_00_03()
      {
         Assert.True(Inquiry.IsNotNullOrEmpty(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsNotNullOrEmpty_00_04()
      {
         Assert.True(Inquiry.IsNotNullOrEmpty(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsEmptyOrWhiteSpace_00_01()
      {
         Assert.True(Inquiry.IsEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsEmptyOrWhiteSpace_00_02()
      {
         Assert.True(Inquiry.IsEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsEmptyOrWhiteSpace_00_03()
      {
         Assert.False(Inquiry.IsEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsNotEmptyOrWhiteSpace_00_01()
      {
         Assert.False(Inquiry.IsNotEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsNotEmptyOrWhiteSpace_00_02()
      {
         Assert.False(Inquiry.IsNotEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsNotEmptyOrWhiteSpace_00_03()
      {
         Assert.True(Inquiry.IsNotEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsNullEmptyOrWhiteSpace_00_01()
      {
         Assert.True(Inquiry.IsNullEmptyOrWhiteSpace(AgnosticTestData.NULL_STRING));
      }

      [Fact]
      public void test_String_IsNullEmptyOrWhiteSpace_00_02()
      {
         Assert.True(Inquiry.IsNullEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsNullEmptyOrWhiteSpace_00_03()
      {
         Assert.True(Inquiry.IsNullEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsNullEmptyOrWhiteSpace_00_04()
      {
         Assert.False(Inquiry.IsNullEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsNotNullEmptyOrWhiteSpace_00_01()
      {
         Assert.False(Inquiry.IsNotNullEmptyOrWhiteSpace(AgnosticTestData.NULL_STRING));
      }

      [Fact]
      public void test_String_IsNotNullEmptyOrWhiteSpace_00_02()
      {
         Assert.False(Inquiry.IsNotNullEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING));
      }

      [Fact]
      public void test_String_IsNotNullEmptyOrWhiteSpace_00_03()
      {
         Assert.False(Inquiry.IsNotNullEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE));
      }

      [Fact]
      public void test_String_IsNotNullEmptyOrWhiteSpace_00_04()
      {
         Assert.True(Inquiry.IsNotNullEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING));
      }

      [Fact]
      public void test_String_IsMeetingExactLength_00_01()
      {
         Assert.True(Inquiry.IsMeetingExactLength(AgnosticTestData.VALID_STRING, 6));
      }

      [Fact]
      public void test_String_IsMeetingExactLength_00_02()
      {
         Assert.False(Inquiry.IsMeetingExactLength(AgnosticTestData.VALID_STRING, 0));
      }

      [Fact]
      public void test_String_IsNotMeetingExactLength_00_01()
      {
         Assert.True(Inquiry.IsNotMeetingExactLength(AgnosticTestData.VALID_STRING, 0));
      }

      [Fact]
      public void test_String_IsNotMeetingExactLength_00_02()
      {
         Assert.False(Inquiry.IsNotMeetingExactLength(AgnosticTestData.VALID_STRING, 6));
      }

      [Fact]
      public void test_String_IsMeetingMinimumLength_00_01()
      {
         Assert.True(Inquiry.IsMeetingMinimumLength(AgnosticTestData.VALID_STRING, 6));
      }

      [Fact]
      public void test_String_IsMeetingMinimumLength_00_02()
      {
         Assert.True(Inquiry.IsMeetingMinimumLength(AgnosticTestData.VALID_STRING, 5));
      }

      [Fact]
      public void test_String_IsMeetingMinimumLength_00_03()
      {
         Assert.False(Inquiry.IsMeetingMinimumLength(AgnosticTestData.VALID_STRING, 7));
      }

      [Fact]
      public void test_String_IsMeetingMaximumLength_00_01()
      {
         Assert.True(Inquiry.IsMeetingMaximumLength(AgnosticTestData.VALID_STRING, 6));
      }

      [Fact]
      public void test_String_IsMeetingMaximumLength_00_02()
      {
         Assert.True(Inquiry.IsMeetingMaximumLength(AgnosticTestData.VALID_STRING, 7));
      }

      [Fact]
      public void test_String_IsMeetingMaximumLength_00_03()
      {
         Assert.False(Inquiry.IsMeetingMaximumLength(AgnosticTestData.VALID_STRING, 5));
      }

      [Fact]
      public void test_String_IsMeetingLengthRange_00_01()
      {
         Assert.True(Inquiry.IsMeetingLengthRange(AgnosticTestData.VALID_STRING, 5, 7));
      }

      [Fact]
      public void test_String_IsMeetingLengthRange_00_02()
      {
         Assert.True(Inquiry.IsMeetingLengthRange(AgnosticTestData.VALID_STRING, 6, 7));
      }

      [Fact]
      public void test_String_IsMeetingLengthRange_00_03()
      {
         Assert.True(Inquiry.IsMeetingLengthRange(AgnosticTestData.VALID_STRING, 5, 6));
      }

      [Fact]
      public void test_String_IsMeetingLengthRange_00_04()
      {
         Assert.False(Inquiry.IsMeetingLengthRange(AgnosticTestData.VALID_STRING, 7, 8));
      }

      [Fact]
      public void test_String_IsMeetingLengthRange_00_05()
      {
         Assert.False(Inquiry.IsMeetingLengthRange(AgnosticTestData.VALID_STRING, 4, 5));
      }

      [Fact]
      public void test_String_IsValidEmail_00_01()
      {
         Assert.True(Inquiry.IsValidEmail(AgnosticTestData.VALID_EMAIL));
      }

      [Fact]
      public void test_String_IsValidEmail_00_02()
      {
         Assert.False(Inquiry.IsValidEmail(AgnosticTestData.WHITE_SPACE));
      }

      // list block

      [Fact]
      public void test_List_IsEmpty_00_01()
      {
         Assert.True(Inquiry.IsEmpty(AgnosticTestData.EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsEmpty_00_02()
      {
         Assert.False(Inquiry.IsEmpty(AgnosticTestData.NOT_EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsNotEmpty_00_01()
      {
         Assert.False(Inquiry.IsNotEmpty(AgnosticTestData.EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsNotEmpty_00_02()
      {
         Assert.True(Inquiry.IsNotEmpty(AgnosticTestData.NOT_EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsNullOrEmpty_00_01()
      {
         Assert.True(Inquiry.IsNullOrEmpty(AgnosticTestData.NULL_LIST));
      }

      [Fact]
      public void test_List_IsNullOrEmpty_00_02()
      {
         Assert.True(Inquiry.IsNullOrEmpty(AgnosticTestData.EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsNullOrEmpty_00_03()
      {
         Assert.False(Inquiry.IsNullOrEmpty(AgnosticTestData.NOT_EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsNotNullOrEmpty_00_01()
      {
         Assert.False(Inquiry.IsNotNullOrEmpty(AgnosticTestData.NULL_LIST));
      }

      [Fact]
      public void test_List_IsNotNullOrEmpty_00_02()
      {
         Assert.False(Inquiry.IsNotNullOrEmpty(AgnosticTestData.EMPTY_LIST));
      }

      [Fact]
      public void test_List_IsNotNullOrEmpty_00_03()
      {
         Assert.True(Inquiry.IsNotNullOrEmpty(AgnosticTestData.NOT_EMPTY_LIST));
      }

      // number block

      [Fact]
      public void test_Number_IsZero_00_01()
      {
         Assert.True(Inquiry.IsZero(0.0F));
      }

      [Fact]
      public void test_Number_IsZero_00_02()
      {
         Assert.False(Inquiry.IsZero(0.1F));
      }

      [Fact]
      public void test_Number_IsPositive_00_01()
      {
         Assert.True(Inquiry.IsPositive(0.1F));
      }

      [Fact]
      public void test_Number_IsPositive_00_02()
      {
         Assert.False(Inquiry.IsPositive(-0.1F));
      }

      [Fact]
      public void test_Number_IsPositive_00_03()
      {
         Assert.False(Inquiry.IsPositive(0.0F));
      }

      [Fact]
      public void test_Number_IsNegative_00_01()
      {
         Assert.True(Inquiry.IsNegative(-0.1F));
      }

      [Fact]
      public void test_Number_IsNegative_00_02()
      {
         Assert.False(Inquiry.IsNegative(0.1F));
      }

      [Fact]
      public void test_Number_IsNegative_00_03()
      {
         Assert.False(Inquiry.IsNegative(0.0F));
      }

      [Fact]
      public void test_Number_IsWithinRange_00_01()
      {
         Assert.True(Inquiry.IsWithinRange(0.0F, -0.1F, 0.1F));
      }

      [Fact]
      public void test_Number_IsWithinRange_00_02()
      {
         Assert.True(Inquiry.IsWithinRange(0.0F, 0.0F, 0.1F));
      }

      [Fact]
      public void test_Number_IsWithinRange_00_03()
      {
         Assert.True(Inquiry.IsWithinRange(0.0F, -0.1F, 0.0F));
      }

      [Fact]
      public void test_Number_IsWithinRange_00_04()
      {
         Assert.False(Inquiry.IsWithinRange(0.0F, 0.1F, 0.2F));
      }

      [Fact]
      public void test_Number_IsWithinRange_00_05()
      {
         Assert.False(Inquiry.IsWithinRange(0.0F, -0.2F, -0.1F));
      }
   }
}
