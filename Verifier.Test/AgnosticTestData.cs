using System;
using System.Collections.Generic;

namespace Verifier.Test
{
   public class AgnosticTestData
   {
      // bool block
      public static readonly bool FALSE = false;
      public static readonly bool TRUE = true;

      // object block
      public static readonly object NULL_OBJECT = null;
      public static readonly object OBJECT = new object();

      // string block
      public static readonly string EMPTY_STRING = string.Empty;
      public static readonly string VALID_STRING = "target";
      public static readonly string WHITE_SPACE = "   \n   \t   \r   ";
      public static readonly string NULL_STRING = null;
      public static readonly string VALID_EMAIL = "verifier@github.com";

      // list block
      public static readonly List<bool> NULL_LIST = null;
      public static readonly List<bool> EMPTY_LIST = new List<bool>();
      public static readonly List<bool> NOT_EMPTY_LIST = new List<bool>(new bool[] { TRUE, FALSE });

      // datetime block
      public static readonly DateTime TODAY = DateTime.Now;
      public static readonly DateTime YESTERDAY = TODAY.AddDays(-1);
      public static readonly DateTime TWO_DAYS_AGO = TODAY.AddDays(-2);
      public static readonly DateTime TOMORROW = TODAY.AddDays(1);
      public static readonly DateTime TWO_DAYS_FROM_NOW = TODAY.AddDays(2);

   }
}
