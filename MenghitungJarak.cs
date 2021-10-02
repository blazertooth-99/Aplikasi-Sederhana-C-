using System;

//Rumus Menghitung Kecepatan = Jarak : waktu
//Rmus Menghitung jarak yang ditempuh = Kecepatan * Waktu

	  
 public class Program {
	 
	 static void Menu() 
	 {
		 //Constructor
		 Kecepatan kecepatan = new Kecepatan ();
		 
		 
		 Console.WriteLine("Silahkan pilih menu : ");
         Console.WriteLine(" ");
         Console.WriteLine("1. Hitung Kecepatan Kendaraan");
		 Console.WriteLine("2. Hitung Jarak yang di tempuh");
		 
		 int menu = Convert.ToInt16(Console.ReadLine());
				// Decision Switch Case
                switch (menu)
                {
                    case 1:
                        kecepatan.KecepatanM();
                        break;
                    case 2:
                       kecepatan.JarakM();
						   break;
						
				}
	 }
 
	public static void Main (String [] args)
	{
		
		Console.WriteLine("Aplikasi Menghitung Kecepatan dan jarak tempuh  ");
		Console.WriteLine("------------------------------------------------");
		Console.WriteLine("  ");
		
		//Array
		 string[] nama = new string[1];
		
			//Loop For
            for (int x = 0; x<1;x++)
            {
                Console.Write("Masukan nama  anda : ");
                nama[x] = Console.ReadLine();
            }
		
            Console.WriteLine("Nama yang anda masukan adalah :");
            for (int a = 0;a<1;a++)
            {
                Console.Write(nama[a] + " ");
            }
            Console.ReadLine();
		
			
			Console.WriteLine("Masukan Umur :");
			int age = int. Parse (Console.ReadLine());
			Console.WriteLine("Apakah kamu punya sim (Yes/ No :");
			string sim = Console.ReadLine();
		
			bool isAdult = age >17; // Pernyataan 1
			bool isSyaratsim = sim== "Yes"; // Pernyataan 2
		
			// Menggunakan Operator Logika AND
			//Decision If else
			if (isAdult && isSyaratsim )
			{
				Console.WriteLine("Anda Boleh Berkendara dan mengecek jarak Tempuh dan Kecepatan Kendaraan Anda");
			}
			else 
			{
				Console.WriteLine("Maaf Anda tidak di izinkan berkendara");
			}
            
		Menu();
             int i = 1;
              while (i > 0)
			  {
				   Console.WriteLine(" ");
                    Console.WriteLine("Apakah Akan Kembali Ke Menu Utama (yes/no)");
                    string jwb = Console.ReadLine();
                    if (jwb.ToLower() == "yes")
                    {
					}
				  else {
					  return; 
				  }
			  }
			  }
		
	 
	}
		
	//abstract class
	abstract class Speedist
    {
		
		//acces modifier
        private double jarak, waktu, kec, hitung;

        //Set Enskapsulation Jarak
        public void setJarak(double j)
        {
            this.jarak = j;
        }
        
		//get  enkapsulation Jarak
        public double getJarak()
        {
            return jarak;
        }
		public void setWaktu(double w)
        {
            this.waktu = w;
        }
		public double getWaktu()
        {
            return waktu;
        }
		public void setKec (double k)
		{
			this.kec = k;
		}
		public double getKec()
        {
            return kec;
        }
		
        //Getter dan Setter
        public double Hitung
        {
            get { return hitung; }
            set { hitung = value; }
        }

        //Method
        public abstract double hitungKecepatan();
        public abstract double hitungJarak();
		
    }
	
	
	// Inheritance 
	 class Kecepatan : Speedist
    {
		// polymorphisme overriding  override (child) kecepatan
        public override double hitungKecepatan()
        {
       
		    Hitung = getJarak() / getWaktu();
            Console.WriteLine("Kecepatan kendaraan adalah  : "+Hitung+ "KM/jam" ); 
			
            return Hitung;
			
        }

        public override double hitungJarak()
        {
			
            Hitung = getKec () * getWaktu ();
            Console.WriteLine("jarak yang anda tempuh adalah : "+Hitung+"KM" );
            return Hitung;
        }
		//Polimerphime Overriding virtual (parent)/ Kecepatan
        public virtual void KecepatanM()
        {
            Console.WriteLine("Masukan Nilai jarak (km) : ");
            setJarak(Convert.ToDouble(Console.ReadLine()));
			Console.WriteLine("Masukan Nilai waktu (jam) : ");
            setWaktu(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
            hitungKecepatan();
            
        }
		public virtual void JarakM () {
		 	Console.WriteLine("Masukan Nilai Kecepatan (KM/Jam: ");
            setKec(Convert.ToDouble(Console.ReadLine()));
			Console.WriteLine("Masukan Waktu (jam): ");
            setWaktu(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
			hitungJarak();
		}
		
		
		}
		
		
			 