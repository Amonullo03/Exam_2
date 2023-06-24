System.Console.Write("From = ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("To = ");
int y = Convert.ToInt32(Console.ReadLine());
int mult = 1; 
for (int i=1; i<=10; i++){
mult=x*i;
System.Console.WriteLine($"{x} * {i} = {mult}");
}
System.Console.WriteLine();
int mult1 = 1; 
for (int i=1; i<=10; i++){
mult1=y*i;
System.Console.WriteLine($"{y} * {i} = {mult1}");
}
