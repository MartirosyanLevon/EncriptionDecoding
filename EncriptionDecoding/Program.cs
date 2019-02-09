using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptionecoding
{
    class Program
    {
        static void Main(string[] args)
        {

            ushort secretkey = 0x0088;   // secret key (Length 16 bit)         
            char character = 'A';        // source character for encryption




            Console.WriteLine("source symbol {0},and code in the code table {1:x}", character, (byte)character);
            Console.WriteLine("Character size {0} = {1} bit", character, sizeof(char) * 8);

            //Character Encryption
            //Bin  1000 1000    Hex 88    Dec 136
            // Bin  0100 0001    Hex 41    Dec 65    'A'
            // Bin  1100 1001    Hex C9    Dec 201   'E'

            character = (char)(character ^ secretkey);
            Console.WriteLine("Character Encryption {0},and code in the code table {1:x}", character, (byte)character);

            //Character Decoding
            //Bin  1000 1000    Hex 88    Dec 136
            // Bin  1100 1001    Hex C9    Dec 201   'E'
            // Bin  0100 0001    Hex 41    Dec 65    'A'

            character = (char)(character ^ secretkey);
            Console.WriteLine("Character Decoding {0},and code in the code table {1:x}", character, (byte)character);



            Console.ReadKey();
        }
    }
}
