// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


var wc = new System.Net.WebClient();

wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
wc.DownloadStringCompleted += Wc_DownloadStringCompleted;

void Wc_DownloadStringCompleted(object sender, System.Net.DownloadStringCompletedEventArgs e)
{
    Console.WriteLine(e.ToString());
}

void Wc_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
{
    Console.WriteLine(e.ProgressPercentage.ToString());
}



//wc.DownloadFile(@"", );
var uri = new Uri("http://11.8.2.18:82/amanadb/amanadb_backup_2025_07_01_000003_9380797.bak");

wc.DownloadFile(uri, @"c:\temp\amanadb_backup_2025_07_01_000003_9380797.bak");





