﻿using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        //The implementation of your tasks should look like this:
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length > 1 && s.StartsWith(c) && s.EndsWith(c));
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s.Length).OrderBy(s => s);
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(s => string.Join("", s.First(), s.Last()));

        }
            public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length == k && Char.IsDigit(s.Last())).OrderBy(s => s);
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.Where(i => i % 2 == 1).OrderBy(i => i).Select(i => i.ToString());
        }

        #endregion

        #region Middle

        public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }
        
        public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            //TODO :Delete line below and write your own solution
            throw new NotImplementedException();
        }

        public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList,
            IEnumerable<StorePrice> storePriceList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

    }
}
