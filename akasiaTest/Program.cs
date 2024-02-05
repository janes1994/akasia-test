using System.Text;

class Program
{
    #region Jawaban 1
    public static int HitungKata(string contoh, string target)
    {
        var jmlTarget = new List<string>();

        foreach (char tar in target)
        {
            var tmp = new StringBuilder();
            foreach (char con in contoh)
            {
                if (tar == con)
                    tmp.Append(tar);
            }

            if (!string.IsNullOrEmpty(tmp.ToString()))
                jmlTarget.Add(tmp.ToString());
        }
        int min = jmlTarget.OrderBy(s => s.Length).FirstOrDefault().Length;
        return min;
    }
    #endregion

    #region Jawaban 2
    /*
        A.
        SELECT DISTINCT Tanggal, NIM, Nama
        FROM Kehadiran
        WHERE Tanggal IN('15 Juni 2020', '17 Juni 2020');
    
        B.
        SELECT NIM, Nama, COUNT(*) AS JumlahKehadiran
        FROM Kehadiran
        JOIN Mahasiswa ON Kehadiran.NIM = Mahasiswa.NIM
        WHERE Tanggal IN ('15 Juni 2020', '17 Juni 2020')
        GROUP BY Kehadiran.NIM, Mahasiswa.Nama;
    */
    #endregion

    #region Jawaban 3
    public static int PerkalianSederhana(int j, int k)
    {
        int hasil = 0;
        if (j > 0)
        {
            while (j > 0)
            {
                hasil += k;
                j--;
            }
        }
        else
        {
            while (j < 0)
            {
                hasil -= k;
                j++;
            }
        }
        return hasil;
    }
    #endregion

    #region Jawaban 4
    public static decimal HitungPendapatanMaksimum(int jumlahRuby, int jumlahTopaz, int jumlahPermata,
                                       decimal hargaRubyPerPasang, decimal hargaTopazPerPasang, decimal hargaPermataPerPasang)
    {
        decimal pendapatanMaksimum = 0;

        // Hitung pendapatan dari penjualan anting jenis Ruby
        decimal pendapatanRuby = (jumlahRuby / 2) * hargaRubyPerPasang;
        pendapatanMaksimum += pendapatanRuby;

        // Hitung pendapatan dari penjualan anting jenis Topaz
        decimal pendapatanTopaz = (jumlahTopaz / 2) * hargaTopazPerPasang;
        pendapatanMaksimum += pendapatanTopaz;

        // Hitung pendapatan dari penjualan anting jenis Permata
        decimal pendapatanPermata = (jumlahPermata / 2) * hargaPermataPerPasang;
        pendapatanMaksimum += pendapatanPermata;

        return pendapatanMaksimum;
    }
    #endregion

    #region Jawaban 5
    /*
        
        +-----------+               +-------------------+            +-------------------+
        |   Start   |               | Product Listing   |            | Product Auction   |
        +-----------+               +-------------------+            +-------------------+
              |                              |                                 |
              v                              v                                 v
        +------------------+    +--------------------------+     +--------------------------+
        | User creates     |    | User logs in             |     | Set auction parameters   |
        | an account       |    | to the system            |     | (time, initial price)    |
        +------------------+    +--------------------------+     +--------------------------+
              |                              |                                 |
              v                              v                                 v
        +------------------+    +--------------------------+     +--------------------------+
        | User logs in     |    | User inputs product info |     | Inform users about       |
        | to the account   |    | (name, description, etc.)|     | ongoing auction          |
        +------------------+    +--------------------------+     +--------------------------+
              |                              |                                 |
              v                              v                                 v
        +------------------+    +--------------------------+     +--------------------------+
        | User lists        |    | Product added to the    |     | Users place bids         |
        | a product         |    | system                  |     | on the product           |
        +------------------+    +--------------------------+     +--------------------------+
              |                              |                                 |
              v                              v                                 v
        +------------------+    +--------------------------+     +--------------------------+
        | Product listed   |    | Product information      |     | Evaluate bids,          |
        | successfully     |    | displayed to users       |     | update current bid,     |
        +------------------+    +--------------------------+     | notify users            |
                                                                 +--------------------------+
              |                                                             |
              v                                                             |
        +------------------+                                                |
        |   End            |                                                |
        +------------------+                                                |
                                                                            |
                                                                            v
                                                                    +------------------+
                                                                    |   End            |
                                                                    +------------------+


        Frontend:
        HTML, CSS, JavaScript, React

        Backend:
        .net core 6, Database SQL Server
 
    */
    #endregion

    #region Jawaban 6
    /*
     
    [Start]
    |
    V
    [Input: Kendaraan datang ke SPBU]
    |
    V
    [Decision: Roda 2 atau Roda 4?]
    |
    |---[Roda 2]
    |   |
    |   V
    |   [Decision: Pilih jenis BBM]
    |   |
    |   |---[Pertalite]
    |   |   |
    |   |   V
    |   |   [Check antrian Pertalite 1]
    |   |   |
    |   |   V
    |   |   [Antrian Pertalite 1 tidak penuh]
    |   |       |
    |   |       V
    |   |       [Kendaraan masuk antrian Pertalite 1]
    |   |
    |   |---[Pertamax]
    |   |   |
    |   |   V
    |   |   [Check antrian Pertamax 1]
    |   |   |
    |   |   V
    |   |   [Antrian Pertamax 1 tidak penuh]
    |   |       |
    |   |       V
    |   |       [Kendaraan masuk antrian Pertamax 1]
    |   |
    |   |---[Pertamax Plus]
    |       |
    |       V
    |       [Check antrian Pertamax Plus]
    |       |
    |       V
    |       [Antrian Pertamax Plus tidak penuh]
    |           |
    |           V
    |           [Kendaraan masuk antrian Pertamax Plus]
    |
    |---[Roda 4]
        |
        V
        [Decision: Pilih jenis BBM]
        |
        |---[Pertalite]
        |   |
        |   V
        |   [Check antrian Pertalite 1]
        |   |
        |   V
        |   [Antrian Pertalite 1 tidak penuh]
        |       |
        |       V
        |       [Kendaraan masuk antrian Pertalite 1]
        |
        |---[Pertamax]
        |   |
        |   V
        |   [Check antrian Pertamax 1]
        |   |
        |   V
        |   [Antrian Pertamax 1 tidak penuh]
        |       |
        |       V
        |       [Kendaraan masuk antrian Pertamax 1]
        |
        |---[Pertamax Plus]
            |
            V
            [Check antrian Pertamax Plus]
            |
            V
            [Antrian Pertamax Plus tidak penuh]
                |
                V
                [Kendaraan masuk antrian Pertamax Plus]
    [End]

    */
    #endregion

    static void Main(string[] args)
    {
        #region Jawaban 1
        int jawaban1 = HitungKata("USOMAANAPAIUMASYDNIP", "SIAPA");
        Console.WriteLine("Jawaban 1: " + jawaban1);
        #endregion

        #region Jawaban 3
        int jawaban2 = PerkalianSederhana(-3, 2);
        Console.WriteLine("Jawaban 2: " + jawaban2);
        #endregion

        #region Jawaban 4
        int jumlahRuby = 5;
        int jumlahTopaz = 3;
        int jumlahPermata = 1;

        decimal hargaRubyPerPasang = 1000000;
        decimal hargaTopazPerPasang = 1250000;
        decimal hargaPermataPerPasang = 3000000;

        decimal jawaban4 = HitungPendapatanMaksimum(jumlahRuby, jumlahTopaz, jumlahPermata,
                                                          hargaRubyPerPasang, hargaTopazPerPasang, hargaPermataPerPasang);

        Console.WriteLine("Jawaban 4: " + jawaban4);
        #endregion
    }
}