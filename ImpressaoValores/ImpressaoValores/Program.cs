// See https://aka.ms/new-console-template for more information

//Primeiro
int aPrimeiro = 10;
int bPrimeiro = 20;
Console.WriteLine(bPrimeiro); //20
bPrimeiro = 5;
Console.WriteLine(aPrimeiro); // 10
Console.WriteLine(bPrimeiro); //5

Console.WriteLine("Fim do primeiro");

//Segundo
int aSegundo = 30;
int bSegundo = 20;
int cSegundo = aSegundo + bSegundo;
Console.WriteLine(cSegundo);//50

bSegundo = 10;
Console.WriteLine(bSegundo); //10
Console.WriteLine(cSegundo);//50

cSegundo = aSegundo + bSegundo; //Só muda pra 40 aqui
Console.WriteLine(aSegundo);//30
Console.WriteLine(bSegundo);//10
Console.WriteLine(cSegundo);//40

Console.WriteLine("Fim do segundo");

int aTerceiro = 10;
int bTerceiro = 20;
int cTerceiro = aTerceiro;
bTerceiro = cTerceiro;
aTerceiro = bTerceiro;
Console.WriteLine(aTerceiro);//10
Console.WriteLine(bTerceiro);//10
Console.WriteLine(cTerceiro);//10

Console.WriteLine("Fim do terceiro");

int aQuarto = 10;
int bQuarto = aQuarto + 1;
aQuarto = bQuarto + 1;
bQuarto = aQuarto + 1;
Console.WriteLine(aQuarto);//12
aQuarto = bQuarto + 1;
Console.WriteLine(aQuarto);//14
Console.WriteLine(bQuarto);//13

Console.WriteLine("Fim do quarto");

int aQuinto = 10;
int bQuinto = 5;
int cQuinto = aQuinto + bQuinto;
bQuinto = 20;
aQuinto = 10;
Console.WriteLine(aQuinto);//10
Console.WriteLine(bQuinto);//20
Console.WriteLine(cQuinto);//15

Console.WriteLine("Fim do quinto");

int x = 1;
int y = 2;
int z = y - x;
Console.WriteLine(z);//1

x = 5;
y = x + z;
Console.WriteLine(x);//5
Console.WriteLine(y);//6
Console.WriteLine(z);//1

Console.WriteLine("Fim do sexto");