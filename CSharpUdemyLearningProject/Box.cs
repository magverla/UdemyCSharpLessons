using System;

public class Box
{
    public int Länge { get; set; }
    public int Höhe { get; set; }
    public int Breite { get; set; }
    public Box(int länge = 0, int höhe=0, int breite=0)
	{
        this.Länge = länge;
        this.Höhe = höhe;
        this.Breite = breite;
	}

    public int Volumen()
    {
        return this.Höhe * this.Länge * this.Breite;
    }

    public void TellMeAboutTheBox()
    {
        string q = "quadratisch";
        string r = "rechteckig";
        Console.WriteLine($"Das Volumen der Box ist {this.Volumen()}");
        Console.WriteLine($"Die Box hat eine {((this.Länge == this.Breite) ? "quadratisch" : "rechteckig")}e grundfläche");
    }
    
}
