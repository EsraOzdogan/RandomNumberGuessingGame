// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Net


[<EntryPoint>]
 let main argv =
    let mutable tahmin=0
    let mutable isim=""
    let mutable hamlesayisi=0
    let mutable hamlesayisidosya=""
    let mutable maxsayidosya=""
    printfn"1'le kaç aralığında sayı oluşturulsun?"
    let mutable maxsayi=(Console.ReadLine())|> int
    let tahminEdilen=(new System.Random()).Next(1,maxsayi)
    
    printfn "Lütfen isminizi giriniz."
    isim<-(Console.ReadLine())
    printfn "Lütfen tahmininizi giriniz."
    while (tahminEdilen<>tahmin) do
        hamlesayisi<-hamlesayisi+1;
        tahmin <- Console.ReadLine() |> int
        if tahmin>maxsayi || tahmin<1 then printfn "Lütfen belirlenen aralıkta sayı giriniz"
        elif tahmin<maxsayi then
            if tahmin>tahminEdilen then printfn"Bilemediniz!!Lütfen daha küçük bir sayı giriniz."
            elif tahmin<tahminEdilen then printfn"Bilemediniz!!Lütfen daha büyük bir sayı giriniz."
        
        
    hamlesayisidosya<-hamlesayisi|>string
    maxsayidosya<-maxsayidosya|>string
    File.AppendAllText("../../../../ConsoleApp4/oyunculistesi.txt",
     ("\n"+isim+","+"1-"+ maxsayidosya+"aralığındaki sayı"+hamlesayisidosya+" hamlede bildi."))
    Console.WriteLine("Tebrikler!!! {0} hamlede bildiniz!! ",hamlesayisi )
    
    Console.ReadKey()|> ignore
    0 // return an integer exit code


    


