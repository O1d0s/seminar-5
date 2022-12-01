int[] arr = GetArray(4,100,1000);
Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.WriteLine(Chet(arr));

int[] GetArray(int size, int minV, int maxV){
    int[] mas = new int[size];
    for(int i=0;i<size;i++){
        mas[i] = new Random().Next(minV,maxV);
    }
    return mas;
}

int Chet(int[] array){
    int count = 0;
    for(int i=0;i<array.Length;i++){
        if (array[i] % 2 == 0){
            count += 1;
        }
    }
    return count;
}
