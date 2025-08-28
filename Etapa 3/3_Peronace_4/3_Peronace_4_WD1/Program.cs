using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
        bool ok = Level1.ValidateAccessKey("WD-700000")
                  && !Level1.ValidateAccessKey("WD-123123")
                  && !Level1.ValidateAccessKey("WX-000007")
                  && !Level1.ValidateAccessKey("WD-00007");
        if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
        else Console.WriteLine("🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level1
{
    // Debe devolver true solo si:
    // - Empieza por "WD-"
    // - Luego hay exactamente 6 dígitos
    // - La suma de esos 6 dígitos es múltiplo de 7
    public static bool ValidateAccessKey(string key)
    {
        bool a = false;
        int b = 0,uno,dos,tres,cuatro,cinco,seis;
        if (key.StartsWith("WD-") && key.Length == 9)
        {
            if (char.IsDigit(key[3]) && char.IsDigit(key[4]) && char.IsDigit(key[5]) && char.IsDigit(key[6]) && char.IsDigit(key[7]) && char.IsDigit(key[8]))
            {
                uno = key[3] - '0';
                dos = key[4] - '0';
                tres = key[5] - '0';
                cuatro = key[6] - '0';
                cinco = key[7] - '0';
                seis = key[8] - '0';
                b = (uno + dos + tres + cuatro + cinco + seis) % 7;
                if(b == 0)
                {
                    a = true;
                }
            }
        }
        return a;
        // TODO: implementar
        // <- reemplazar por tu solución
    }
}