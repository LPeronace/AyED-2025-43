using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        int m;
        string revez = "";
        char a, b;
        for(int i = 0;i< s.Length; i++)
        {
            a = s[i];
            m = a - '1';
            b = Convert.ToChar(m + 50);
            revez = revez + b.ToString();
        }
        // TODO: implementar
        // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
        return revez; // <- reemplazar por tu solución
    }
}