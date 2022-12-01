int[] arr = GetArray(4,-10,50);
Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.WriteLine(NeChet(arr));

int[] GetArray(int size, int minV, int maxV){
    int[] mas = new int[size];
    for(int i=0;i<size;i++){
        mas[i] = new Random().Next(minV,maxV);
    }
    return mas;
}

int NeChet(int[] array){
    int sum = 0;
    for(int i=0;i<array.Length;i++){
        if (i % 2 == 1){
            sum += array[i];
        }
    }
    return sum;
}
