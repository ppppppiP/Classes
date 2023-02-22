using Classes;

Schools[] scool = new Schools[3];


for(int i = 0; i < scool.Length; i++)
{
	string name = Console.ReadLine();
	string directorName = Console.ReadLine();
	long phoneNumber = Convert.ToInt64(Console.ReadLine());
	scool[i] = new Schools(name, directorName, phoneNumber);
}
Console.WriteLine();
for(int i = 0;i < scool.Length; i++)
{
	Console.WriteLine(scool[i]);
}
