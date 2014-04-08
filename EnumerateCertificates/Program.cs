using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateCertificates
{
    class Program
    {
        static void Main(string[] args)
        {
            X509Store store = new X509Store("My");

            store.Open(OpenFlags.ReadOnly);

            foreach (X509Certificate2 mCert in store.Certificates)
            {
                Console.WriteLine( mCert.Thumbprint );
            }

            Console.ReadLine();
        }
    }
}
