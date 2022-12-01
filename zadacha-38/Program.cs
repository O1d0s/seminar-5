int[] arr = GetArray(5,-10,10);
Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.WriteLine(MaxMin(arr));

int[] GetArray(int size, int minV, int maxV){
    int[] mas = new int[size];
    for(int i=0;i<size;i++){
        mas[i] = new Random().Next(minV,maxV);
    }
    return mas;
}

int MaxMin(int[] arr){
    int max = arr[0],
    min = arr[0],
    raz = 0;
    
    for(int i=1;i<arr.Length;i++){
        if(arr[i]>max){
            max = arr[i];
        }
        if(arr[i]<min){
            min = arr[i];
        }
    }
    if(min>0){
        raz = Math.Abs(max-min);
    }
    else{
        raz = Math.Abs(max+min);
    }
    return raz;
}
