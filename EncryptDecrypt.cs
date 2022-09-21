using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt
{
    internal class EncryptDecrypt
    {
        public static string Encrypt(string missatgeString, int clau, char[] code)
        {
            char[] missatgeEncriptat = { 'R', 'e', 's', 'u', 'l', 't' };

            if (missatgeString != null && clau != 0) 
            {
                missatgeString.ToLower();
                char[] missatge = missatgeString.ToCharArray();
                int x = 0;
                missatgeEncriptat = new char[missatge.Length];

                if (clau < 0)
                    clau *= -1;

                for (int i = 0; i < code.Length; i++)
                {

                    if (missatge[x] == code[i])
                    {
                        while ((i + clau) > code.Length)
                            i -= code.Length;

                        missatgeEncriptat[x] = code[(i + clau)];
                        x++;
                        i = 0;

                        if (missatge.Length == x)
                            i = code.Length;

                        if (i == code.Length - 1)
                            i = 0;
                    }

                }
            }

            return new string (missatgeEncriptat);

        }
        public static string Decrypt(string missatgeString, int clau, char[] code)
        {

            char[] missatgeEncriptat = { 'R', 'e', 's', 'u', 'l', 't' };

            if (missatgeString != null && clau != 0) 
            {
                missatgeString.ToLower();
                char[] missatge = missatgeString.ToCharArray();

                int x = 0;
                missatgeEncriptat = new char[missatge.Length];

                if (clau < 0)
                    clau *= -1;

                for (int i = 0; i < code.Length; i++)
                {

                    if (missatge[x] == code[i])
                    {
                        while ((i - clau) < 0)
                            i += code.Length;

                        missatgeEncriptat[x] = code[(i - clau)];

                        x++;

                        i = 0;

                        if (missatge.Length == x)
                            i = code.Length;

                        if (i == code.Length - 1)
                            i = 0;
                    }

                }
            }

            return new string (missatgeEncriptat);

        }
    }
}
