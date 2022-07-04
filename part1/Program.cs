
Console.WriteLine("является ли число палиндромом");
Console.WriteLine("_______________________________");
Console.Write("введите семизначное число ");
int list = Convert.ToInt32(Console.ReadLine());
string numbers = list.ToString();
compair(numbers);
void compair(string numbers){
int result;
int result1;  
int result3;
result = numbers[0].CompareTo(numbers[6]);
result1 = numbers[1].CompareTo(numbers[5]); 
result3 = numbers[2].CompareTo(numbers[4]); 

    if(result == 0 || result1 == 0 || result3 == 0){
        Console.Write("это число палиндром");
        }
    else{
        Console.Write("это число непалиндром");
    }
}







//int[] List2 ={};
// for (int i = 0; i < List2.Length; i++)
// {
//     List2[i] = List % 10;
// }
// Console.WriteLine(List2[]);

// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
//     Console.WriteLine(numbers[i]);
// }





// char[] ch = newList.ToCharArray();
;
// //int[] arrInt = new int[newList.Length];

// //Console.Write(string.Join("," , List1));
// //exam(newList);
// //void exam(string newList);
// if(ch[0] == 1)
// {
//     Console.Write("11");
// }

