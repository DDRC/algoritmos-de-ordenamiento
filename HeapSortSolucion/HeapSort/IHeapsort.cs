﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeapSort
{
    public interface IHeapsort
    {
        public void heapSort(int[] arr, int n);
        public void heapify(int[] arr, int n, int i);

    }
}
