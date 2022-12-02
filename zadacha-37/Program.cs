int size = 5;
int[] arr = GetArray(size,-10,10);
Console.WriteLine($"[{String.Join(", ", arr)}]");


Console.WriteLine($"[{String.Join(", ", Proiz(arr,size))}]");


int[] GetArray(int size, int minV, int maxV){
    int[] mas = new int[size];
    for(int i=0;i<size;i++){
        mas[i] = new Random().Next(minV,maxV);
    }
    return mas;
}

int[] Proiz(int[] array,int size){
    int sz;
    if(size % 2 == 0){
        sz = size/2;
    }
    else{
        sz = (size/2)+1;
    }
    int[] masP = new int[sz];
    int left = 0 ;
    int right = size - 1;
    while(left<right){
        masP[left] = array[left]*array[right];
        left += 1;
        right -= 1;
    }
    if(size % 2 == 1){
        masP[sz-1] = array[size/2];
    }
    return masP;
}