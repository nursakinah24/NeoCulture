using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCulture141
{
    //membuat kelas Sugar
    public class Sugar
    {
        //deklarasi variabel numeric sugarkg, hasil1
        public double sugarkg, hasil1;
        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void InputSugar()
        {
            //Display 'How many kilograms of sugar do you want to buy?'
            Console.WriteLine("How many kilograms of sugar do you want to buy?");
            //accept sugarkg
            sugarkg = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung 
        public double HitungSugar1()
        {
            hasil1 = sugarkg * 12000;
            return hasil1;
        }
        //membuat method berupa prosedur untuk menampilkan data
        public void tampilSugar()
        {
            //Display sugar + 'kg of sugar successfully added to the cart'
            Console.WriteLine(sugarkg + " kg of sugar successfully added to the cart");
        }
    }
    //membual kelas Rice
    public class Rice
    {
        //deklarasi numeric ricekg, hasil2
        public double ricekg, hasil2;
        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void InputRice()
        {
            //Display 'How many kilograms of rice do you want to buy?'
            Console.WriteLine("How many kilograms of rice do you want to buy?");
            //accept ricekg
            ricekg = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung 
        public double HitungRice1()
        {
            hasil2 = ricekg * 11500;
            return hasil2;
        }
        //membuat method berupa prosedur untuk menampilkan data
        public void tampilRice()
        {
            //Display ricekg + 'kg of rice successfully added to the cart'
            Console.WriteLine(ricekg + " kg of rice successfully added to the cart");
        }
    }
    //membuat kelas CookingOil
    public class CookingOil
    {
        //deklarasi numeric oilLtr, hasil3
        public double oilLtr, hasil3;
        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void InputOil()
        {
            //Display 'How many liters of cooking oil do you want to buy?'
            Console.WriteLine("How many liters of cooking oil do you want to buy?");
            //accept oilLtr
            oilLtr = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung 
        public double HitungOil1()
        {
            hasil3 = oilLtr * 14500;
            return hasil3;
        }
        //membuat method berupa prosedur untuk menampilkan data
        public void tampilOil()
        {
            //Display oilLtr + 'liter of cooking oil successfully added to the cart'
            Console.WriteLine(oilLtr + " liter of cooking oil successfully added to the cart");
        }
    }
    //membuat kelas Eggs
    public class Eggs
    {
        //deklarasi numeric eggkg, hasil4
        public double eggkg, hasil4;
        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void InputEgg()
        {
            //Display 'How many kilograms of eggs do you want to buy?'
            Console.WriteLine("How many kilograms of eggs do you want to buy?");
            //acceept eggkg
            eggkg = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung 
        public double HitungEgg1()
        {
            hasil4 = eggkg * 19500;
            return hasil4;
        }
        //membuat method berupa prosedur untuk menampilkan data
        public void tampilEgg()
        {
            //Display eggkg + 'kg of eggs successfully added to the cart'
            Console.WriteLine(eggkg + " kg of eggs successfully added to the cart");
        }
    }


    //Membuat kelas Program
    public class Program
    {
        //membuat method main
        public static void Main(string[] args)
        {
            //membuat instance untuk kelas Sugar, Rice, CookingOil, Eggs
            Sugar sg = new Sugar();
            Rice rc = new Rice();
            CookingOil co = new CookingOil();
            Eggs egg = new Eggs();

            //deklarasi variabel untuk ekspresi switch
            int pilih;

            //membuat tampilan Menu
            Console.WriteLine("Welcome to the Neo Culture 141 Grocery Application");
            Console.WriteLine("Please select the item from the purchase menu to buy");
            Console.WriteLine("=========================================================");

            //deklarasi variabel untuk if else
            bool exit = true;
            //melakukan perulangan do while pada menu
            do
            {
                //lanjutan membuat tampilan menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Sugar         Rp. 12.000/kg");
                Console.WriteLine("2. Rice          Rp. 11.500/kg");
                Console.WriteLine("3. Cooking Oil   Rp. 14.500/L");
                Console.WriteLine("4. Egg 1 Kg      Rp. 19.500/kg");
                Console.WriteLine("5. Finish/Exit");
                Console.Write("Choose (1/2/3/4/5) : ");
                //membaca input user dan dan mengubah tipenya menjadi Integer
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (pilih)
                {
                    case 1:
                        sg.InputSugar();
                        Console.WriteLine("");
                        sg.tampilSugar();
                        break;
                    case 2:
                        rc.InputRice();
                        Console.WriteLine("");
                        rc.tampilRice();
                        break;
                    case 3:
                        co.InputOil();
                        Console.WriteLine("");
                        co.tampilOil();
                        break;
                    case 4:
                        egg.InputEgg();
                        Console.WriteLine("");
                        egg.tampilEgg();
                        break;
                    case 5:
                        //if (gc.sugarkg > 0 atau gc.ricekg > 0 atau gc.oilLtr > 0 atau gc.eggkg > 0 )
                        if (sg.sugarkg > 0 || rc.ricekg > 0 || co.oilLtr > 0 || egg.eggkg > 0)
                        {
                            try
                            {
                                //deklarasi string untuk menyimpan path di drive C pada folder mydocument
                                string path = Environment.GetFolderPath
                                (Environment.SpecialFolder.MyDocuments);

                                //Lewatkan folder dan nama file yang digunakan untuk menyimpan data di drive C
                                StreamWriter sw = new StreamWriter(Path.Combine(path, $"coba.txt"));

                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("");
                                Console.WriteLine("Receipt:");
                                //menulis 'Receipt' ke dalam file
                                sw.WriteLine($"Receipt:");
                                Console.WriteLine(" " + sg.sugarkg + "  kg Sugar           = Rp.  " + (sg.HitungSugar1()).ToString("#,##0") + ",00");
                                //menulis gc.sugarkg + 'kg Sugar            = Rp.  ' + (gc.HitungSugar1()).ToString('#,##0')+',00' kedalam file
                                sw.WriteLine($" {sg.sugarkg} kg Sugar      = Rp. {sg.HitungSugar1().ToString("#,##0")},00");
                                Console.WriteLine(" " + rc.ricekg + "  kg Rice            = Rp.  " + (rc.HitungRice1()).ToString("#,##0") + ",00");
                                //menulis gc.ricekg + 'kg Rice            = Rp.  ' + (gc.HitungRice1()).ToString('#,##0')+',00' kedalam file
                                sw.WriteLine($" {rc.ricekg} kg Rice       = Rp. {rc.HitungRice1().ToString("#,##0")},00");
                                Console.WriteLine(" " + co.oilLtr + "  L Cooking Oil      = Rp.  " + (co.HitungOil1()).ToString("#,##0") + ",00");
                                //menulis gc.oilLtr + 'L Cooking Oil            = Rp.  ' + (gc.HitungOil1()).ToString('#,##0')+',00' kedalam file
                                sw.WriteLine($" {co.oilLtr} L Cooking Oil = Rp. {co.HitungOil1().ToString("#,##0")},00");
                                Console.WriteLine(" " + egg.eggkg + "  kg Eggs            = Rp.  " + (egg.HitungEgg1()).ToString("#,##0") + ",00");
                                //menulis gc.eggkg + 'kg Eggs            = Rp.  ' + (gc.HitungEgg1()).ToString('#,##0')+',00' kedalam file
                                sw.WriteLine($" {egg.eggkg} kg Eggs       = Rp. {egg.HitungEgg1().ToString("#,##0")},00");
                                Console.WriteLine("-------------------------------------------");
                                //menulis '-------------------------------------------' kedalam file
                                sw.WriteLine($"-------------------------------------------");

                                Console.WriteLine("                 TOTAL = Rp.  " + ((sg.HitungSugar1() + rc.HitungRice1() + co.HitungOil1() + egg.HitungEgg1()).ToString("#,##0") + ",00"));
                                //menulis '                 TOTAL = Rp.  {((gc.HitungSugar1() + gc.HitungRice1() + gc.HitungOil1() + gc.HitungEgg1()).ToString("#,##0"))},00' kedalam file
                                sw.WriteLine($"           TOTAL = Rp. {((sg.HitungSugar1() + rc.HitungRice1() + co.HitungOil1() + egg.HitungEgg1()).ToString("#,##0"))},00");
                                //Tutup file
                                sw.Close();

                                //Display 'Do you still want to shop?' + 'press 'yes' to continue shopping or press 'enter to exit''
                                Console.WriteLine("\nDo you still want to shop?" + "\npress 'yes' to continue shopping or press 'enter to exit'");
                                //membaca dan disimpan dalam variabel jawab
                                string jawab = Console.ReadLine();
                                //if (jawab = 'yes')
                                if (jawab == "yes")
                                {
                                    //Display '\n```````````````````````````````````'
                                    Console.WriteLine("\n```````````````````````````````````");
                                Main:
                                    break;
                                }
                                //else
                                else
                                {
                                    //Display '-------------------------------------------'
                                    Console.WriteLine("-------------------------------------------");
                                    //Display '\nExecuting finally block.'
                                    Console.WriteLine("\nExecuting finally block.");
                                    //Display 'receipt printed'
                                    Console.WriteLine("receipt printed");
                                    Console.ReadKey();
                                    exit = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception" + e.Message);
                            }
                        }
                        //else
                        else
                        {
                            exit = false;
                        }
                        break;
                    default:
                        //Display 'Option not available'
                        Console.WriteLine("Option not available");
                        break;
                }
            } while (exit);
        }
    }
}

