using DesafioPOO.Models;

Iphone iphone = new Iphone(numero: "11 95636-5688", modelo: "Xr", imei: "11ADFR5", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sudoku");

Console.WriteLine("\n");

Nokia nokia = new Nokia(numero: "15 55555-7777", modelo: "12 PRO", imei: "15LDPO", memoria: 1000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");