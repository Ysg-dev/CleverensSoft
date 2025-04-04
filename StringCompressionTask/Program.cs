using StringCompressionTask;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("������� �������� ������ (����. aaabbcccdde):");
        string input = Console.ReadLine();

        // ������ ������
        string compressed = StringCompressor.Compress(input);
        Console.WriteLine("������ ������: " + compressed);

        // ������������ ������ ������ ��� �������� ������������
        string decompressed = StringCompressor.Decompress(compressed);
        Console.WriteLine("������������������� ������: " + decompressed);

        Console.WriteLine("������� ����� ������� ��� ������...");
        Console.ReadKey();
    }
}