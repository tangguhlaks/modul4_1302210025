// See https://aka.ms/new-console-template for more information
using modul4_1302210025;


KodeBuah kb = new KodeBuah();
Console.WriteLine("Kode Buah " + KodeBuah.buah.jagung + " adalah " + kb.getKodeBuah(KodeBuah.buah.jagung));


Console.WriteLine();
PosisiKarakterGame p = new PosisiKarakterGame(); 
Console.WriteLine("Pilih Tombol");
Console.WriteLine("1. tombolW");
Console.WriteLine("2. tombolS");
Console.WriteLine("3. tombolx");
var myt = Console.ReadLine();
while (myt != "0") { 
    if(myt == "1")
    {
        p.setMyTriger(triger.tombolW);
    }
    else if(myt == "2")
    {
        p.setMyTriger(triger.tombolS);
    }
    else
    {
        p.setMyTriger(triger.tombolX);
    }
    myt = Console.ReadLine();
}

