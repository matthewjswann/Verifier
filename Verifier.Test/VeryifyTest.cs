using System;
using Xunit;
using Verifier.Verification;

namespace Verifier.Test
{
   public class VerifyTest
   {
      // bool block

      [Fact]
      public void test_True_00_01()
      {
         Verify.True(AgnosticTestData.TRUE);
      }

      [Fact]
      public void test_True_99_01()
      {
         var exception = Record.Exception(() => Verify.True(AgnosticTestData.FALSE));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_False_00_01()
      {
         Verify.False(AgnosticTestData.FALSE);
      }

      [Fact]
      public void test_False_99_01()
      {
         var exception = Record.Exception(() => Verify.False(AgnosticTestData.TRUE));
         Assert.IsType<VerifyException>(exception);
      }

      // object block

      [Fact]
      public void test_Null_01_00_01()
      {
         Verify.Null(AgnosticTestData.NULL_OBJECT);
      }

      [Fact]
      public void test_Object_Null_99_01()
      {
         var exception = Record.Exception(() => Verify.Null(AgnosticTestData.OBJECT));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_Object_NotNull_00_01()
      {
         Verify.NotNull(AgnosticTestData.OBJECT);
      }

      [Fact]
      public void test_Object_NotNull_99_01()
      {
         var exception = Record.Exception(() => Verify.NotNull(AgnosticTestData.NULL_OBJECT));
         Assert.IsType<VerifyException>(exception);
      }

      // string block

      [Fact]
      public void test_String_Empty_00_01()
      {
         Verify.Empty(AgnosticTestData.EMPTY_STRING);
      }

      [Fact]
      public void test_String_Empty_99_01()
      {
         var exception = Record.Exception(() => Verify.Empty(AgnosticTestData.VALID_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotEmpty_00_01()
      {
         Verify.NotEmpty(AgnosticTestData.VALID_STRING);
      }

      [Fact]
      public void test_String_NotEmpty_99_01()
      {
         var exception = Record.Exception(() => Verify.NotEmpty(AgnosticTestData.EMPTY_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NullOrEmpty_00_01()
      {
         Verify.NullOrEmpty(AgnosticTestData.NULL_STRING);
      }

      [Fact]
      public void test_String_NullOrEmpty_00_02()
      {
         Verify.NullOrEmpty(AgnosticTestData.EMPTY_STRING);
      }

      [Fact]
      public void test_String_NullOrEmpty_99_01()
      {
         var exception = Record.Exception(() => Verify.NullOrEmpty(AgnosticTestData.VALID_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotNullOrEmpty_00_01()
      {
         Verify.NotNullOrEmpty(AgnosticTestData.VALID_STRING);
      }

      [Fact]
      public void test_String_NotNullOrEmpty_99_01()
      {
         var exception = Record.Exception(() => Verify.NotNullOrEmpty(AgnosticTestData.NULL_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotNullOrEmpty_99_02()
      {
         var exception = Record.Exception(() => Verify.NotNullOrEmpty(AgnosticTestData.EMPTY_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_EmptyOrWhiteSpace_00_01()
      {
         Verify.EmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING);
      }

      [Fact]
      public void test_String_EmptyOrWhiteSpace_00_02()
      {
         Verify.EmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE);
      }

      [Fact]
      public void test_String_EmptyOrWhiteSpace_99_01()
      {
         var exception = Record.Exception(() => Verify.EmptyOrWhiteSpace(AgnosticTestData.VALID_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotEmptyOrWhiteSpace_00_01()
      {
         Verify.NotEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING);
      }

      [Fact]
      public void test_String_NotEmptyOrWhiteSpace_99_01()
      {
         var exception = Record.Exception(() => Verify.NotEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotEmptyOrWhiteSpace_99_02()
      {
         var exception = Record.Exception(() => Verify.NotEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NullEmptyOrWhiteSpace_00_01()
      {
         Verify.NullEmptyOrWhiteSpace(AgnosticTestData.NULL_STRING);
      }

      [Fact]
      public void test_String_NullEmptyOrWhiteSpace_00_02()
      {
         Verify.NullEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING);
      }

      [Fact]
      public void test_String_NullEmptyOrWhiteSpace_00_03()
      {
         Verify.NullEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE);
      }

      [Fact]
      public void test_String_NullEmptyOrWhiteSpace_99_01()
      {
         var exception = Record.Exception(() => Verify.NullEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotNullEmptyOrWhiteSpace_00_01()
      {
         Verify.NotNullEmptyOrWhiteSpace(AgnosticTestData.VALID_STRING);
      }

      [Fact]
      public void test_String_NotNullEmptyOrWhiteSpace_99_01()
      {
         var exception = Record.Exception(() => Verify.NotNullEmptyOrWhiteSpace(AgnosticTestData.NULL_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotNullEmptyOrWhiteSpace_99_02()
      {
         var exception = Record.Exception(() => Verify.NotNullEmptyOrWhiteSpace(AgnosticTestData.EMPTY_STRING));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotNullEmptyOrWhiteSpace_99_03()
      {
         var exception = Record.Exception(() => Verify.NotNullEmptyOrWhiteSpace(AgnosticTestData.WHITE_SPACE));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_MeetingExactLength_00_01()
      {
         Verify.MeetingExactLength(AgnosticTestData.VALID_STRING, 6);
      }

      [Fact]
      public void test_String_MeetingExactLength_99_01()
      {
         var exception = Record.Exception(() => Verify.MeetingExactLength(AgnosticTestData.VALID_STRING, 0));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_NotMeetingExactLength_00_01()
      {
         Verify.NotMeetingExactLength(AgnosticTestData.VALID_STRING, 0);
      }

      [Fact]
      public void test_String_NotMeetingExactLength_99_01()
      {
         var exception = Record.Exception(() => Verify.NotMeetingExactLength(AgnosticTestData.VALID_STRING, 6));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_MeetingMinimumLength_00_01()
      {
         Verify.MeetingMinimumLength(AgnosticTestData.VALID_STRING, 6);
      }

      [Fact]
      public void test_String_MeetingMinimumLength_99_01()
      {
         var exception = Record.Exception(() => Verify.MeetingMinimumLength(AgnosticTestData.VALID_STRING, 7));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_MeetingMaximumLength_00_01()
      {
         Verify.MeetingMaximumLength(AgnosticTestData.VALID_STRING, 6);
      }

      [Fact]
      public void test_String_MeetingMaximumLength_99_01()
      {
         var exception = Record.Exception(() => Verify.MeetingMaximumLength(AgnosticTestData.VALID_STRING, 5));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_MeetingLengthRange_00_01()
      {
         Verify.MeetingLengthRange(AgnosticTestData.VALID_STRING, 5, 7);
      }

      [Fact]
      public void test_String_MeetingLengthRange_99_01()
      {
         var exception = Record.Exception(() => Verify.MeetingLengthRange(AgnosticTestData.VALID_STRING, 7, 8));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_MeetingLengthRange_99_02()
      {
         var exception = Record.Exception(() => Verify.MeetingLengthRange(AgnosticTestData.VALID_STRING, 4, 5));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_String_ValidEmail_00_01()
      {
         Verify.ValidEmail(AgnosticTestData.VALID_EMAIL);
      }

      [Fact]
      public void test_String_ValidEmail_99_01()
      {
         var exception = Record.Exception(() => Verify.ValidEmail(AgnosticTestData.WHITE_SPACE));
         Assert.IsType<VerifyException>(exception);
      }

      // list block

      [Fact]
      public void test_List_Empty_00_01()
      {
         Verify.Empty(AgnosticTestData.EMPTY_LIST);
      }

      [Fact]
      public void test_List_Empty_99_01()
      {
         var exception = Record.Exception(() => Verify.Empty(AgnosticTestData.NOT_EMPTY_LIST));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_List_NotEmpty_00_01()
      {
         Verify.NotEmpty(AgnosticTestData.NOT_EMPTY_LIST);
      }

      [Fact]
      public void test_List_NotEmpty_99_01()
      {
         var exception = Record.Exception(() => Verify.NotEmpty(AgnosticTestData.EMPTY_LIST));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_List_NullOrEmpty_00_01()
      {
         Verify.NullOrEmpty(AgnosticTestData.NULL_LIST);
      }

      [Fact]
      public void test_List_NullOrEmpty_00_02()
      {
         Verify.NullOrEmpty(AgnosticTestData.EMPTY_LIST);
      }

      [Fact]
      public void test_List_NullOrEmpty_99_01()
      {
         var exception = Record.Exception(() => Verify.NullOrEmpty(AgnosticTestData.NOT_EMPTY_LIST));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_List_NotNullOrEmpty_00_01()
      {
         Verify.NotNullOrEmpty(AgnosticTestData.NOT_EMPTY_LIST);
      }

      [Fact]
      public void test_List_NotNullOrEmpty_99_01()
      {
         var exception = Record.Exception(() => Verify.NotNullOrEmpty(AgnosticTestData.NULL_LIST));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_List_NotNullOrEmpty_99_02()
      {
         var exception = Record.Exception(() => Verify.NotNullOrEmpty(AgnosticTestData.EMPTY_LIST));
         Assert.IsType<VerifyException>(exception);
      }

      // number block

      [Fact]
      public void test_Number_Zero_00_01()
      {
         Verify.Zero(0.0F);
      }

      [Fact]
      public void test_Number_Zero_99_01()
      {
         var exception = Record.Exception(() => Verify.Zero(0.1F));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_Number_Positive_00_01()
      {
         Verify.Positive(0.1F);
      }

      [Fact]
      public void test_Number_Positive_99_01()
      {
         var exception = Record.Exception(() => Verify.Positive(0.0F));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_Number_Negative_00_01()
      {
         Verify.Negative(-0.1F);
      }

      [Fact]
      public void test_Number_Negative_99_01()
      {
         var exception = Record.Exception(() => Verify.Negative(0.0F));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_Number_WithinRange_00_01()
      {
         Verify.WithinRange(0.0F, -0.1F, 0.1F);
      }

      [Fact]
      public void test_Number_WithinRange_99_01()
      {
         var exception = Record.Exception(() => Verify.WithinRange(-0.1F, 0.0F, 0.1F));
         Assert.IsType<VerifyException>(exception);
      }

      [Fact]
      public void test_Number_WithinRange_99_02()
      {
         var exception = Record.Exception(() => Verify.WithinRange(0.1F, -0.1F, 0.0F));
         Assert.IsType<VerifyException>(exception);
      }
   }
}
