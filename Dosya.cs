public class Dosya{




public int KareAl(int sayi){
   int  sonuc=sayi*sayi;
   return sonuc;

}
public int HarfSayisi(string kelime){
    int sayi=0;
    char [] hecelenmis=kelime.ToCharArray();
    foreach(var hece in hecelenmis){
        Console.WriteLine(hece);
        sayi++;

    }
    return sayi;
}
public void Awake(){
    int goster=KareAl(5);
     Console.WriteLine(goster);
}
}