using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsole
{
    public class DuplicatedElements
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Distinct().Count() != nums.Length;
        }
    }
}
