namespace Baseline_Exersize;

public class Program
{
    //2
    public static List<int> doubleList(List<int> l)
    {
    List<int> doubleList=new List<int>();
    for (int i=0;i<doubleList.Count;i++,doubleList[i]=l[i]*2);
    return doubleList;
    }
    //3

    public static List<int> divideByThreeList(List<int> l){
     List<int> divideByThreeList=new List<int>();
     int k=0;
     for (int i=0;i<divideByThreeList.Count;i++)
     {
        if(l[i]%3==0){
          divideByThreeList[k++]=l[i];
        }
     }
     return divideByThreeList;
     }

//4
 public static void printRectangle(int width, int hight){
    if(width<=0||hight<=0)
    {
     Console.Write("error valid ");
    }
    string tav="*";

     for(int i=0;i < width ;i++){
        Console.Write(tav);
    }
        Console.WriteLine();
     for(int i=1;i<hight-1;i++){
        Console.Write(tav);
        for(int j=1;j < width-1;j++){
        Console.Write(" ");
        }
        Console.Write(tav);
        Console.WriteLine();
     }
        for(int i=0;i<width ;i++){
        Console.Write(tav);
    }
 }
    
    public static void Main(string[] args)
    {
        int primeNumber = 0;
         for(int y = 2 ; y < 14 ; y ++) {
            if(IsPrimeNumber(y) && y >=1) {
                primeNumber = y;
                break;
            }
        }
        
        Console.WriteLine($"{primeNumber} is a prime number.");
        printRectangle(3,4);
    }

    static bool IsPrimeNumber(int number)
    {
            for (int c = 2; c * c <= number; c++)
            {
                if (number % c == 0)
                {
                    return false;
                }
            }

            return true;
    }

}

