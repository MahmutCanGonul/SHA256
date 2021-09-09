using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;


public class Sha256{

     public static int Index { get; set; }  
    public static DateTime TimeStamp { get; set; }  
    public static string PreviousHash { get; set; }  
    public static string Hash { get; set; }  
    public static string Data { get; set; }  
    public static Random random = new Random();
    public static int maxIterations=0;
    public static List<string> takeHash = new List<string>();

     public Sha256(DateTime timeStamp, string previousHash, string data){

        Index = 0;  
        TimeStamp = timeStamp;  
        PreviousHash = previousHash;  
        Data = data;  
        Hash = CalculateHash();  
     }


   public static void Main(string[] args){
          
          while(maxIterations != 10){

              maxIterations++;
              takeHash.Add(Sha256.CalculateHash());
          }
          
          for(int i=0; i<takeHash.Count;i++){

             Console.WriteLine(takeHash[i]);

          }
          
          //Console.WriteLine(Sha256.CalculateHash());


   }

   public static string CalculateHash()  
    {  
        SHA256 sha256 = SHA256.Create();  
         int a = random.Next(1000);
         int b = random.Next(1000);
         int sum = a * b;
        
        Sha256.Data = sum.ToString();
        Sha256.PreviousHash = "Mahmut Can Gönül";
        
        
        byte[] inputBytes = Encoding.ASCII.GetBytes($"{Sha256.TimeStamp}-{Sha256.PreviousHash ?? ""}-{Sha256.Data}");  
        byte[] outputBytes = sha256.ComputeHash(inputBytes);  
  
        return Convert.ToBase64String(outputBytes);  
    }  

}