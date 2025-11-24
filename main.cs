using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

class Program
{
    public static void Main(string[] args)
    {
        string[] s3_facts = new string[] {
            "Scale storage resources to meet fluctuating needs with 99.999999999% (11 9s) of data durability.",
            "Store data across Amazon S3 storage classes to reduce costs without upfront investment or hardware refresh cycles.",
            "Protect your data with unmatched security, compliance, and audit capabilities.",
            "Easily manage data at any scale with robust access controls, flexible replication tools, and organization-wide visibility.",
            "Run big data analytics, artificial intelligence (AI), machine learning (ML), and high performance computing (HPC) applications.",
            "Meet Recovery Time Objectives (RTO), Recovery Point Objectives (RPO), and compliance requirements with S3's robust replication features."
        };

        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () =>
        {
            var rnd = new Random();
            int i = rnd.Next(0, s3_facts.Length);
            Console.WriteLine($"{i} - {s3_facts[i]}");
            return $"{DateTime.Now.TimeOfDay} - {s3_facts[i]}";
        });

        // Bind to all network interfaces on port 8002
        app.Urls.Add("http://0.0.0.0:8002");

        app.Run();
    }
}
