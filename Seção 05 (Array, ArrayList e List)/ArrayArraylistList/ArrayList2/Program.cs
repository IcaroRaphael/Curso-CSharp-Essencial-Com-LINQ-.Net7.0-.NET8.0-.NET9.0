﻿using System.Collections;

// var lista = new ArrayList() { "Maria", 5, true, " ", null };
// lista.Add(3.5);
// lista.Insert(2, "Paulo");

var lista = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista.AddRange(array1);

lista.InsertRange(2, array1);

Console.ReadKey();
