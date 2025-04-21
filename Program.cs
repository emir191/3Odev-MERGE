// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
Dosya dosya=new Dosya();
dosya.Awake();
dosya.HarfSayisi("kelime");
int harfAdeti=dosya.HarfSayisi("merhaba");
Console.WriteLine("TOPLAM HARF"+harfAdeti);