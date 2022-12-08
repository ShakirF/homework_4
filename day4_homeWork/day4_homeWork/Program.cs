// See https://aka.ms/new-console-template for more information
//1. İçində birdən çox elementi olan arrayı for, foreach, while, do-while istifadə etmədən ekrana yazdırın.


int[] arr = { 32,21,3,33,43,22};
Console.WriteLine(string.Join(" ",arr));

//2. Console-dan bir ədəd daxil olunur və array içində həmin ədədin olub olmamağını yoxlayırsız. Ekrana true false çıxarırsız. (Dövr istifadə etmədən!)

int[] arrNew = { 32, 23, 2, 3, 45, 1, 22, 56 };
int n = Convert.ToInt32(Console.ReadLine());
if (arrNew.Any(a => a == n))
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
