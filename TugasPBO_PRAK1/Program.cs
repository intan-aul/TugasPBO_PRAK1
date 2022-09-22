using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO_PRAK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("______________________________________________________________________");
            Mobil mobil1 = new Agya("Michelin");
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();

            Console.WriteLine("______________________________________________________________________");
            Mobil mobil2 = new Avanza("Bridgestone");
            mobil2.NyalakanMesin();
            mobil2.MatikanMesin();
            ((Avanza)mobil2).NyalakanLampu();

            Console.WriteLine("______________________________________________________________________");
            Mobil civic1 = new Civic("Bridgestone");
            civic1.NyalakanMesin();
            civic1.MatikanMesin();
            ((Civic)civic1).VtecKickedIn();

            Console.WriteLine("______________________________________________________________________");
            Mobil honda1 = new Honda("Civic", "Bridgestone");
            honda1.NyalakanMesin();
            honda1.MatikanMesin();
            ((Honda)honda1).VtecKickedIn();
        }
    }
}

class Ban
{
    public string Merk;
    public Ban(string merk)
    {
        this.Merk = merk;
    }

}

class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
    }
}

class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone")
    {
    }
}

class Mobil
{
    public string Merk, Tipe, Ban;

    public Mobil(string merk, string tipe, string ban)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.Ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} menyala menggunakan ban {this.Ban}");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} mati menggunakan ban {this.Ban}");
    }
}

class Toyota : Mobil
{
    public Toyota(string tipe, string ban) : base("Toyota", tipe, ban)
    {
    }

    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.Merk} bertipe {this.Tipe} menyala");
    }

}

class Daihatsu : Mobil
{
    public Daihatsu(string tipe, string ban) : base("Daihatsu", tipe, ban)
    {
    }

}

class Honda : Mobil
{
    public Honda(string tipe, string ban) : base("Honda", tipe, ban)
    {
    }

    public void VtecKickedIn()
    {
        Console.WriteLine($"Ngeeeng Wooosh!");
    }
}

class Agya : Toyota
{
    public Agya(string ban) : base("Agya", ban)
    {
    }
}

class Innova : Toyota
{
    public Innova(string ban) : base("Innova", ban)
    {
    }
}

class Avanza : Toyota
{
    public Avanza(string ban) : base("Avanza", ban)
    {
    }
}

class Ayla : Daihatsu
{
    public Ayla(string ban) : base("Ayla", ban)
    {
    }
}

class Xenia : Daihatsu
{
    public Xenia(string ban) : base("Xenia", ban)
    {
    }
}

class Brio : Honda
{
    public Brio(string ban) : base("Brio", ban)
    {
    }
}

class Civic : Honda
{
    public Civic(string ban) : base("Civic", ban)
    {
    }
}
