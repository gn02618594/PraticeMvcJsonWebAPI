﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiServices.Helpers
{
    public class Utility
    {
        //產生整數陣列，依傳入參數 num 決定產生多少個陣列元素
        public int[] getNumbers(int num) {

            Random rdn = new Random(Guid.NewGuid().GetHashCode());
            int[] Nums = new int[num];
            for (int i = 0; i < num; i++) {
                Nums[i] = rdn.Next(1, 500);
            }
            return Nums;
        }
    }
}