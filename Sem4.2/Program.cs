﻿int [] getArray(int size){
    int [] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(7, 11444);
    }
    return result;
}

int [] array = getArray(8);
Console.WriteLine($"[{String.Join("`",array)}]");
