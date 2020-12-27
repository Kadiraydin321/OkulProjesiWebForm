﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace OkulProjesiWebForm
{
    public class Functions
    {
        public static string uretici()
        {
            Random rastgele = new Random();
            String sb = "";
            for (int i = 0; i < 8; i++)
            {
                int ascii = rastgele.Next(32, 127);
                char karakter = Convert.ToChar(ascii);
                sb += karakter.ToString();
            }
            return sb;
        }

        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
    }
}