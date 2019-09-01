using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PerformensCheck
{
    public static class Process
    {
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public static void DoReferenceAssignment(int count)
        {
            ReferenceType arg;

            for(var i = 0; i<count; i++)
            {
                arg = new ReferenceType(1, 2, 3, 4);
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public static void DoValueAssignment(int count)
        {
            ValueType arg;

            for (var i = 0; i < count; i++)
            {
                arg = new ValueType(1, 2, 3, 4);
            }
        }
    }
}
