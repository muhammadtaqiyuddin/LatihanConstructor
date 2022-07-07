using LatihanConstructor;

public class Program
{
    static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa("4328", "Taqi");
        CetakHasil(mhs1);

        Console.WriteLine();

        Mahasiswa mhs2 = new Mahasiswa("12345", "Paijo");
        CetakHasil(mhs2);

        Console.ReadKey();
    }
    static void CetakHasil(Mahasiswa mhs)
    {
        Console.WriteLine("Nim: {0}", mhs.Nim);
        Console.WriteLine("Nama: {0}", mhs.Nama);
    }
}